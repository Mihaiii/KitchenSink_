// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "TablePage.json"
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
using __TPeName__ = global::KitchenSink.TablePage.PetsElementJson.Input.Name;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __TaAddPet__ = global::KitchenSink.TablePage.Input.AddPet;
using __TaHtml__ = global::KitchenSink.TablePage.Input.Html;
using __TablePag2__ = global::KitchenSink.TablePage.Input;
using __Arr__ = global::Starcounter.Arr<global::KitchenSink.TablePage.PetsElementJson>;
using __TablePag1__ = global::KitchenSink.TablePage.JsonByExample;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TArray__ = global::Starcounter.Templates.TArray<global::KitchenSink.TablePage.PetsElementJson>;
using __TPeKind__ = global::KitchenSink.TablePage.PetsElementJson.Input.Kind;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __TaPetsElem2__ = global::KitchenSink.TablePage.PetsElementJson.Input;
using __TaPetsElem1__ = global::KitchenSink.TablePage.PetsElementJson.JsonByExample;
using __TPeSchema__ = global::KitchenSink.TablePage.PetsElementJson.JsonByExample.Schema;
using __TaPetsElem__ = global::KitchenSink.TablePage.PetsElementJson;
using __TString__ = global::Starcounter.Templates.TString;
using __TaSchema__ = global::KitchenSink.TablePage.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __TablePag__ = global::KitchenSink.TablePage;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class TablePage_json : s::TemplateAttribute {
    
    #line hidden
    public class Pets : s::TemplateAttribute {
    }
    #line default
}
#line default

#line hidden
public partial class TablePage : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __TaSchema__ DefaultTemplate = new __TaSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public TablePage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public TablePage(__TaSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __TaSchema__ Template { get { return (__TaSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__TablePag__);
                ClassName = "TablePage";
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/KitchenSink/TablePage.html";
                Html.SetCustomAccessors((_p_) => { return ((__TablePag__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__TablePag__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Pets = Add<__TArray__>("Pets");
                Pets.SetCustomGetElementType((arr) => { return __TaPetsElem__.DefaultTemplate;});
                Pets.SetCustomAccessors((_p_) => { return ((__TablePag__)_p_).__bf__Pets__; }, (_p_, _v_) => { ((__TablePag__)_p_).__bf__Pets__ = (__Arr__)_v_; }, false);
                AddPet = Add<__TLong__>("AddPet$");
                AddPet.DefaultValue = 0L;
                AddPet.Editable = true;
                AddPet.SetCustomAccessors((_p_) => { return ((__TablePag__)_p_).__bf__AddPet__; }, (_p_, _v_) => { ((__TablePag__)_p_).__bf__AddPet__ = (System.Int64)_v_; }, false);
                AddPet.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.AddPet() { App = (TablePage)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((TablePage)pup).Handle((Input.AddPet)input); });
            }
            public override object CreateInstance(s.Json parent) { return new __TablePag__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TArray__ Pets;
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
    #line 2 "TablePage.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "TablePage.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__Pets__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ Pets {
    #line 9 "TablePage.json"
        get {
        #line hidden
            return Template.Pets.Getter(this); }
        #line 9 "TablePage.json"
        set {
        #line hidden
            Template.Pets.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__AddPet__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 AddPet {
    #line 12 "TablePage.json"
        get {
        #line hidden
            return Template.AddPet.Getter(this); }
        #line 12 "TablePage.json"
        set {
        #line hidden
            Template.AddPet.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class PetsElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __TPeSchema__ DefaultTemplate = new __TPeSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public PetsElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public PetsElementJson(__TPeSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __TPeSchema__ Template { get { return (__TPeSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__TaPetsElem__);
                    ClassName = "PetsElementJson";
                    Properties.ClearExposed();
                    Name = Add<__TString__>("Name");
                    Name.DefaultValue = "";
                    Name.SetCustomAccessors((_p_) => { return ((__TaPetsElem__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__TaPetsElem__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                    Kind = Add<__TString__>("Kind");
                    Kind.DefaultValue = "";
                    Kind.SetCustomAccessors((_p_) => { return ((__TaPetsElem__)_p_).__bf__Kind__; }, (_p_, _v_) => { ((__TaPetsElem__)_p_).__bf__Kind__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __TaPetsElem__(this) { Parent = parent }; }
                public __TString__ Name;
                public __TString__ Kind;
            }
            #line default
        }
        #line default
        #line hidden
        private System.String __bf__Name__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Name {
        #line 6 "TablePage.json"
            get {
            #line hidden
                return Template.Name.Getter(this); }
            #line 6 "TablePage.json"
            set {
            #line hidden
                Template.Name.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__Kind__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Kind {
        #line 8 "TablePage.json"
            get {
            #line hidden
                return Template.Kind.Getter(this); }
            #line 8 "TablePage.json"
            set {
            #line hidden
                Template.Kind.Setter(this, value); } }
            #line default
        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Name : Input<__TaPetsElem__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Kind : Input<__TaPetsElem__, __TString__, string> {
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
        public class Html : Input<__TablePag__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class AddPet : Input<__TablePag__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
