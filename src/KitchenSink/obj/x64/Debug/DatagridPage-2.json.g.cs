// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "DatagridPage.json"
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
using __DaName__ = global::KitchenSink.DatagridPagePetsElementJson.Input.Name;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __DaAddPet__ = global::KitchenSink.DatagridPage.Input.AddPet;
using __DaHtml__ = global::KitchenSink.DatagridPage.Input.Html;
using __Datagrid5__ = global::KitchenSink.DatagridPage.Input;
using __Arr__ = global::Starcounter.Arr<global::KitchenSink.DatagridPagePetsElementJson>;
using __Datagrid4__ = global::KitchenSink.DatagridPage.JsonByExample;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TArray__ = global::Starcounter.Templates.TArray<global::KitchenSink.DatagridPagePetsElementJson>;
using __DaSound__ = global::KitchenSink.DatagridPagePetsElementJson.Input.Sound;
using __DaKind__ = global::KitchenSink.DatagridPagePetsElementJson.Input.Kind;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __Datagrid3__ = global::KitchenSink.DatagridPagePetsElementJson.Input;
using __Datagrid2__ = global::KitchenSink.DatagridPagePetsElementJson.JsonByExample;
using __DaSchema1__ = global::KitchenSink.DatagridPagePetsElementJson.JsonByExample.Schema;
using __Datagrid1__ = global::KitchenSink.DatagridPagePetsElementJson;
using __TString__ = global::Starcounter.Templates.TString;
using __DaSchema__ = global::KitchenSink.DatagridPage.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Datagrid__ = global::KitchenSink.DatagridPage;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class DatagridPage_json : s::TemplateAttribute {
    
    #line hidden
    public class Pets : s::TemplateAttribute {
    }
    #line default
}
#line default

#line hidden
public partial class DatagridPagePetsElementJson : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __DaSchema1__ DefaultTemplate = new __DaSchema1__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public DatagridPagePetsElementJson() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public DatagridPagePetsElementJson(__DaSchema1__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __DaSchema1__ Template { get { return (__DaSchema1__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Datagrid1__);
                ClassName = "DatagridPagePetsElementJson";
                Properties.ClearExposed();
                Name = Add<__TString__>("Name$");
                Name.DefaultValue = "";
                Name.Editable = true;
                Name.SetCustomAccessors((_p_) => { return ((__Datagrid1__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__Datagrid1__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                Kind = Add<__TString__>("Kind$");
                Kind.DefaultValue = "";
                Kind.Editable = true;
                Kind.SetCustomAccessors((_p_) => { return ((__Datagrid1__)_p_).__bf__Kind__; }, (_p_, _v_) => { ((__Datagrid1__)_p_).__bf__Kind__ = (System.String)_v_; }, false);
                Sound = Add<__TString__>("Sound", bind:"CalculatedSound");
                Sound.DefaultValue = "";
                Sound.SetCustomAccessors((_p_) => { return ((__Datagrid1__)_p_).__bf__Sound__; }, (_p_, _v_) => { ((__Datagrid1__)_p_).__bf__Sound__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Datagrid1__(this) { Parent = parent }; }
            public __TString__ Name;
            public __TString__ Kind;
            public __TString__ Sound;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Name__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
    #line 6 "DatagridPage.json"
        get {
        #line hidden
            return Template.Name.Getter(this); }
        #line 6 "DatagridPage.json"
        set {
        #line hidden
            Template.Name.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Kind__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Kind {
    #line 7 "DatagridPage.json"
        get {
        #line hidden
            return Template.Kind.Getter(this); }
        #line 7 "DatagridPage.json"
        set {
        #line hidden
            Template.Kind.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Sound__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Sound {
    #line 8 "DatagridPage.json"
        get {
        #line hidden
            return Template.Sound.Getter(this); }
        #line 8 "DatagridPage.json"
        set {
        #line hidden
            Template.Sound.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Name : Input<__Datagrid1__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Kind : Input<__Datagrid1__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Sound : Input<__Datagrid1__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default

#line hidden
public partial class DatagridPage : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __DaSchema__ DefaultTemplate = new __DaSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public DatagridPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public DatagridPage(__DaSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __DaSchema__ Template { get { return (__DaSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Datagrid__);
                ClassName = "DatagridPage";
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/KitchenSink/DatagridPage.html";
                Html.SetCustomAccessors((_p_) => { return ((__Datagrid__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Datagrid__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Pets = Add<__TArray__>("Pets");
                Pets.SetCustomGetElementType((arr) => { return __Datagrid1__.DefaultTemplate;});
                Pets.SetCustomAccessors((_p_) => { return ((__Datagrid__)_p_).__bf__Pets__; }, (_p_, _v_) => { ((__Datagrid__)_p_).__bf__Pets__ = (__Arr__)_v_; }, false);
                AddPet = Add<__TLong__>("AddPet$");
                AddPet.DefaultValue = 0L;
                AddPet.Editable = true;
                AddPet.SetCustomAccessors((_p_) => { return ((__Datagrid__)_p_).__bf__AddPet__; }, (_p_, _v_) => { ((__Datagrid__)_p_).__bf__AddPet__ = (System.Int64)_v_; }, false);
                AddPet.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.AddPet() { App = (DatagridPage)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((DatagridPage)pup).Handle((Input.AddPet)input); });
            }
            public override object CreateInstance(s.Json parent) { return new __Datagrid__(this) { Parent = parent }; }
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
    #line 2 "DatagridPage.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "DatagridPage.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__Pets__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ Pets {
    #line 11 "DatagridPage.json"
        get {
        #line hidden
            return Template.Pets.Getter(this); }
        #line 11 "DatagridPage.json"
        set {
        #line hidden
            Template.Pets.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__AddPet__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 AddPet {
    #line 14 "DatagridPage.json"
        get {
        #line hidden
            return Template.AddPet.Getter(this); }
        #line 14 "DatagridPage.json"
        set {
        #line hidden
            Template.AddPet.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Datagrid__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class AddPet : Input<__Datagrid__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
