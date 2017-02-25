// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "SortableList.json"
// Version: 2
// DO NOT MODIFY DIRECTLY - CHANGES WILL BE OVERWRITTEN

using System;
using System.Collections;
using System.Collections.Generic;
using Starcounter.Advanced;
using Starcounter;
using Starcounter.Internal;
using Starcounter.Templates;
#pragma warning disable 0108
#pragma warning disable 1591

namespace KitchenSink {
using __SSoorderNr__ = global::KitchenSink.SortableList.SortableListPersons.Input.orderNr;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __SomoveTo__ = global::KitchenSink.SortableList.Input.moveTo;
using __SoHtml__ = global::KitchenSink.SortableList.Input.Html;
using __Sortable2__ = global::KitchenSink.SortableList.Input;
using __Arr__ = global::Starcounter.Arr<global::KitchenSink.SortableList.SortableListPersons>;
using __Sortable1__ = global::KitchenSink.SortableList.JsonByExample;
using __TArray__ = global::Starcounter.Templates.TArray<global::KitchenSink.SortableList.SortableListPersons>;
using __SSomoveDown__ = global::KitchenSink.SortableList.SortableListPersons.Input.moveDown;
using __SSomoveUp__ = global::KitchenSink.SortableList.SortableListPersons.Input.moveUp;
using __SSoisLast__ = global::KitchenSink.SortableList.SortableListPersons.Input.isLast;
using __SSoisFirst__ = global::KitchenSink.SortableList.SortableListPersons.Input.isFirst;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __SoSortable2__ = global::KitchenSink.SortableList.SortableListPersons.Input;
using __SoSortable1__ = global::KitchenSink.SortableList.SortableListPersons.JsonByExample;
using __TBool__ = global::Starcounter.Templates.TBool;
using __TLong__ = global::Starcounter.Templates.TLong;
using __SSoSchema__ = global::KitchenSink.SortableList.SortableListPersons.JsonByExample.Schema;
using __SoSortable__ = global::KitchenSink.SortableList.SortableListPersons;
using __TString__ = global::Starcounter.Templates.TString;
using __SoSchema__ = global::KitchenSink.SortableList.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Sortable__ = global::KitchenSink.SortableList;
using __SSoName__ = global::KitchenSink.SortableList.SortableListPersons.Input.Name;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class SortableList_json : s::TemplateAttribute {
    
    #line hidden
    public class Persons : s::TemplateAttribute {
    }
    #line default
}
#line default

#line hidden
public partial class SortableList : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __SoSchema__ DefaultTemplate = new __SoSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public SortableList() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public SortableList(__SoSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __SoSchema__ Template { get { return (__SoSchema__)base.Template; } set { base.Template = value; } }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new Person Data { get { return (Person)base.Data; } set { base.Data = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Sortable__);
                ClassName = "SortableList";
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/KitchenSink/SortableList.html";
                Html.SetCustomAccessors((_p_) => { return ((__Sortable__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Sortable__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Persons = Add<__TArray__>("Persons");
                Persons.SetCustomGetElementType((arr) => { return __SoSortable__.DefaultTemplate;});
                Persons.SetCustomAccessors((_p_) => { return ((__Sortable__)_p_).__bf__Persons__; }, (_p_, _v_) => { ((__Sortable__)_p_).__bf__Persons__ = (__Arr__)_v_; }, false);
                moveTo = Add<__TString__>("moveTo$");
                moveTo.DefaultValue = "";
                moveTo.Editable = true;
                moveTo.SetCustomAccessors((_p_) => { return ((__Sortable__)_p_).__bf__moveTo__; }, (_p_, _v_) => { ((__Sortable__)_p_).__bf__moveTo__ = (System.String)_v_; }, false);
                moveTo.AddHandler((Json pup, Property<String> prop, String value) => { return (new Input.moveTo() { App = (SortableList)pup, Template = (TString)prop, Value = value }); }, (Json pup, Starcounter.Input<String> input) => { ((SortableList)pup).Handle((Input.moveTo)input); });
            }
            public override object CreateInstance(s.Json parent) { return new __Sortable__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TArray__ Persons;
            public __TString__ moveTo;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "SortableList.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "SortableList.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__Persons__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ Persons {
    #line 13 "SortableList.json"
        get {
        #line hidden
            return Template.Persons.Getter(this); }
        #line 13 "SortableList.json"
        set {
        #line hidden
            Template.Persons.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__moveTo__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String moveTo {
    #line 15 "SortableList.json"
        get {
        #line hidden
            return Template.moveTo.Getter(this); }
        #line 15 "SortableList.json"
        set {
        #line hidden
            Template.moveTo.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Sortable__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class moveTo : Input<__Sortable__, __TString__, string> {
        }
        #line default
    }
    #line default
    
    #line hidden
    public partial class SortableListPersons : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __SSoSchema__ DefaultTemplate = new __SSoSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public SortableListPersons() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public SortableListPersons(__SSoSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __SSoSchema__ Template { get { return (__SSoSchema__)base.Template; } set { base.Template = value; } }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new Person Data { get { return (Person)base.Data; } set { base.Data = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class JsonByExample {
            
            #line hidden
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__SoSortable__);
                    ClassName = "SortableListPersons";
                    Properties.ClearExposed();
                    Name = Add<__TString__>("Name");
                    Name.DefaultValue = "";
                    Name.SetCustomAccessors((_p_) => { return ((__SoSortable__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__SoSortable__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                    orderNr = Add<__TLong__>("orderNr$");
                    orderNr.DefaultValue = 1L;
                    orderNr.Editable = true;
                    orderNr.SetCustomAccessors((_p_) => { return ((__SoSortable__)_p_).__bf__orderNr__; }, (_p_, _v_) => { ((__SoSortable__)_p_).__bf__orderNr__ = (System.Int64)_v_; }, false);
                    isFirst = Add<__TBool__>("isFirst$");
                    isFirst.DefaultValue = false;
                    isFirst.Editable = true;
                    isFirst.SetCustomAccessors((_p_) => { return ((__SoSortable__)_p_).__bf__isFirst__; }, (_p_, _v_) => { ((__SoSortable__)_p_).__bf__isFirst__ = (System.Boolean)_v_; }, false);
                    isLast = Add<__TBool__>("isLast$");
                    isLast.DefaultValue = false;
                    isLast.Editable = true;
                    isLast.SetCustomAccessors((_p_) => { return ((__SoSortable__)_p_).__bf__isLast__; }, (_p_, _v_) => { ((__SoSortable__)_p_).__bf__isLast__ = (System.Boolean)_v_; }, false);
                    moveUp = Add<__TLong__>("moveUp$");
                    moveUp.DefaultValue = 0L;
                    moveUp.Editable = true;
                    moveUp.SetCustomAccessors((_p_) => { return ((__SoSortable__)_p_).__bf__moveUp__; }, (_p_, _v_) => { ((__SoSortable__)_p_).__bf__moveUp__ = (System.Int64)_v_; }, false);
                    moveUp.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.moveUp() { App = (SortableListPersons)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((SortableListPersons)pup).Handle((Input.moveUp)input); });
                    moveDown = Add<__TLong__>("moveDown$");
                    moveDown.DefaultValue = 0L;
                    moveDown.Editable = true;
                    moveDown.SetCustomAccessors((_p_) => { return ((__SoSortable__)_p_).__bf__moveDown__; }, (_p_, _v_) => { ((__SoSortable__)_p_).__bf__moveDown__ = (System.Int64)_v_; }, false);
                    moveDown.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.moveDown() { App = (SortableListPersons)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((SortableListPersons)pup).Handle((Input.moveDown)input); });
                }
                public override object CreateInstance(s.Json parent) { return new __SoSortable__(this) { Parent = parent }; }
                public __TString__ Name;
                public __TLong__ orderNr;
                public __TBool__ isFirst;
                public __TBool__ isLast;
                public __TLong__ moveUp;
                public __TLong__ moveDown;
            }
            #line default
        }
        #line default
        #line hidden
        private System.String __bf__Name__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Name {
        #line 6 "SortableList.json"
            get {
            #line hidden
                return Template.Name.Getter(this); }
            #line 6 "SortableList.json"
            set {
            #line hidden
                Template.Name.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__orderNr__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 orderNr {
        #line 7 "SortableList.json"
            get {
            #line hidden
                return Template.orderNr.Getter(this); }
            #line 7 "SortableList.json"
            set {
            #line hidden
                Template.orderNr.Setter(this, value); } }
            #line default
        #line hidden
        private System.Boolean __bf__isFirst__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Boolean isFirst {
        #line 123 "JOCKE4"
            get {
            #line hidden
                return Template.isFirst.Getter(this); }
            #line 123 "JOCKE4"
            set {
            #line hidden
                Template.isFirst.Setter(this, value); } }
            #line default
        #line hidden
        private System.Boolean __bf__isLast__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Boolean isLast {
        #line 123 "JOCKE4"
            get {
            #line hidden
                return Template.isLast.Getter(this); }
            #line 123 "JOCKE4"
            set {
            #line hidden
                Template.isLast.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__moveUp__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 moveUp {
        #line 10 "SortableList.json"
            get {
            #line hidden
                return Template.moveUp.Getter(this); }
            #line 10 "SortableList.json"
            set {
            #line hidden
                Template.moveUp.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__moveDown__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 moveDown {
        #line 12 "SortableList.json"
            get {
            #line hidden
                return Template.moveDown.Getter(this); }
            #line 12 "SortableList.json"
            set {
            #line hidden
                Template.moveDown.Setter(this, value); } }
            #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class Input {
            
            #line hidden
            public class Name : Input<__SoSortable__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class orderNr : Input<__SoSortable__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class isFirst : Input<__SoSortable__, __TBool__, bool> {
            }
            #line default
            
            #line hidden
            public class isLast : Input<__SoSortable__, __TBool__, bool> {
            }
            #line default
            
            #line hidden
            public class moveUp : Input<__SoSortable__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class moveDown : Input<__SoSortable__, __TLong__, long> {
            }
            #line default
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
