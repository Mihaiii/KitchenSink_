using Starcounter;
using System;

namespace KitchenSink
{
    [Database]
    public class Person
    {
        public string Name;
        public int orderNr;
    }

    partial class SortableList : Json, IBound<Person>
    {

        protected override void OnData()
        {
            base.OnData();
            LoadData();
        }
        
        void Handle(Input.moveTo action)
        {
            string input = action.Value;
            int moveFrom = Convert.ToInt32(input.Split(' ')[0]);
            int moveTo = Convert.ToInt32(input.Split(' ')[1]);

            Db.Transact(() =>
            {
                Persons[moveFrom - 1].Data.orderNr = moveTo;
                Persons[moveTo - 1].Data.orderNr = moveFrom;
            });
            LoadData();
        }

        [SortableList_json.Persons]
        partial class SortableListPersons : Json, IBound<Person>
        {
            public void Handle(Input.moveUp action)
            {
                SortableList sl = (SortableList)Parent.Parent;
                sl.MoveOnePerson(Data.orderNr - 1);
                sl.LoadData();
            }

            public void Handle(Input.moveDown action)
            {
                SortableList sl = (SortableList)Parent.Parent;
                sl.MoveOnePerson(Data.orderNr);
                sl.LoadData();
            }
        }

        public void LoadData() {
            this.Persons = Db.SQL("SELECT p from KitchenSink.Person p ORDER BY p.orderNr");
            Persons[0].isFirst = true;
            Persons[Persons.Count - 1].isLast = true;
        }

        public void MoveOnePerson(int orderNr)
        {
            Db.Transact(() =>
            {
                Persons[orderNr].Data.orderNr--;
                Persons[orderNr - 1].Data.orderNr++;
            });
        }
    }
}