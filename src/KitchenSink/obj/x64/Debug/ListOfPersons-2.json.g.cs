// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "ListOfPersons.json"
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

using __LPeName__ = global::ListOfPersons.PersonsElementJson.Input.Name;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __LiAddPet__ = global::ListOfPersons.Input.AddPet;
using __LiHtml__ = global::ListOfPersons.Input.Html;
using __ListOfPe2__ = global::ListOfPersons.Input;
using __Arr__ = global::Starcounter.Arr<global::ListOfPersons.PersonsElementJson>;
using __ListOfPe1__ = global::ListOfPersons.JsonByExample;
using __TArray__ = global::Starcounter.Templates.TArray<global::ListOfPersons.PersonsElementJson>;
using __LPeindex__ = global::ListOfPersons.PersonsElementJson.Input.index;
using __LPeorderNr__ = global::ListOfPersons.PersonsElementJson.Input.orderNr;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __LiPersonsE1__ = global::ListOfPersons.PersonsElementJson.JsonByExample;
using __TLong__ = global::Starcounter.Templates.TLong;
using __LPeSchema__ = global::ListOfPersons.PersonsElementJson.JsonByExample.Schema;
using __LiPersonsE__ = global::ListOfPersons.PersonsElementJson;
using __TString__ = global::Starcounter.Templates.TString;
using __LiSchema__ = global::ListOfPersons.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __ListOfPe__ = global::ListOfPersons;
using __LiPersonsE2__ = global::ListOfPersons.PersonsElementJson.Input;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class ListOfPersons_json : s::TemplateAttribute {
    
    #line hidden
    public class Persons : s::TemplateAttribute {
    }
    #line default
}
#line default

#line hidden
public partial class ListOfPersons : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __LiSchema__ DefaultTemplate = new __LiSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ListOfPersons() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ListOfPersons(__LiSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __LiSchema__ Template { get { return (__LiSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__ListOfPe__);
                ClassName = "ListOfPersons";
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/KitchenSink/SortableList.html";
                Html.SetCustomAccessors((_p_) => { return ((__ListOfPe__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__ListOfPe__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Persons = Add<__TArray__>("Persons");
                Persons.SetCustomGetElementType((arr) => { return __LiPersonsE__.DefaultTemplate;});
                Persons.SetCustomAccessors((_p_) => { return ((__ListOfPe__)_p_).__bf__Persons__; }, (_p_, _v_) => { ((__ListOfPe__)_p_).__bf__Persons__ = (__Arr__)_v_; }, false);
                AddPet = Add<__TLong__>("AddPet$");
                AddPet.DefaultValue = 0L;
                AddPet.Editable = true;
                AddPet.SetCustomAccessors((_p_) => { return ((__ListOfPe__)_p_).__bf__AddPet__; }, (_p_, _v_) => { ((__ListOfPe__)_p_).__bf__AddPet__ = (System.Int64)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __ListOfPe__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TArray__ Persons;
            public __TLong__ AddPet;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "ListOfPersons.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "ListOfPersons.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__Persons__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ Persons {
    #line 10 "ListOfPersons.json"
        get {
        #line hidden
            return Template.Persons.Getter(this); }
        #line 10 "ListOfPersons.json"
        set {
        #line hidden
            Template.Persons.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__AddPet__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 AddPet {
    #line 13 "ListOfPersons.json"
        get {
        #line hidden
            return Template.AddPet.Getter(this); }
        #line 13 "ListOfPersons.json"
        set {
        #line hidden
            Template.AddPet.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class PersonsElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __LPeSchema__ DefaultTemplate = new __LPeSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public PersonsElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public PersonsElementJson(__LPeSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __LPeSchema__ Template { get { return (__LPeSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__LiPersonsE__);
                    ClassName = "PersonsElementJson";
                    Properties.ClearExposed();
                    Name = Add<__TString__>("Name");
                    Name.DefaultValue = "";
                    Name.SetCustomAccessors((_p_) => { return ((__LiPersonsE__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__LiPersonsE__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                    orderNr = Add<__TLong__>("orderNr");
                    orderNr.DefaultValue = 0L;
                    orderNr.SetCustomAccessors((_p_) => { return ((__LiPersonsE__)_p_).__bf__orderNr__; }, (_p_, _v_) => { ((__LiPersonsE__)_p_).__bf__orderNr__ = (System.Int64)_v_; }, false);
                    index = Add<__TLong__>("index");
                    index.DefaultValue = 0L;
                    index.SetCustomAccessors((_p_) => { return ((__LiPersonsE__)_p_).__bf__index__; }, (_p_, _v_) => { ((__LiPersonsE__)_p_).__bf__index__ = (System.Int64)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __LiPersonsE__(this) { Parent = parent }; }
                public __TString__ Name;
                public __TLong__ orderNr;
                public __TLong__ index;
            }
            #line default
        }
        #line default
        #line hidden
        private System.String __bf__Name__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Name {
        #line 6 "ListOfPersons.json"
            get {
            #line hidden
                return Template.Name.Getter(this); }
            #line 6 "ListOfPersons.json"
            set {
            #line hidden
                Template.Name.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__orderNr__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 orderNr {
        #line 7 "ListOfPersons.json"
            get {
            #line hidden
                return Template.orderNr.Getter(this); }
            #line 7 "ListOfPersons.json"
            set {
            #line hidden
                Template.orderNr.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__index__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 index {
        #line 9 "ListOfPersons.json"
            get {
            #line hidden
                return Template.index.Getter(this); }
            #line 9 "ListOfPersons.json"
            set {
            #line hidden
                Template.index.Setter(this, value); } }
            #line default
        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Name : Input<__LiPersonsE__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class orderNr : Input<__LiPersonsE__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class index : Input<__LiPersonsE__, __TLong__, long> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__ListOfPe__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class AddPet : Input<__ListOfPe__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
#pragma warning restore 1591
#pragma warning restore 0108
