// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "RadiolistPage.json"
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
using __MenuOpti2__ = global::KitchenSink.MenuOptionsElement.Input;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __RaSelected1__ = global::KitchenSink.RadiolistPage.Input.SelectedItemLabel;
using __RaSelected__ = global::KitchenSink.RadiolistPage.Input.SelectedItemIndex;
using __RaHtml__ = global::KitchenSink.RadiolistPage.Input.Html;
using __Radiolis2__ = global::KitchenSink.RadiolistPage.Input;
using __Arr__ = global::Starcounter.Arr<global::KitchenSink.MenuOptionsElement>;
using __Radiolis1__ = global::KitchenSink.RadiolistPage.JsonByExample;
using __TArray__ = global::Starcounter.Templates.TArray<global::KitchenSink.MenuOptionsElement>;
using __MeChoose__ = global::KitchenSink.MenuOptionsElement.Input.Choose;
using __MeLabel__ = global::KitchenSink.MenuOptionsElement.Input.Label;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __MenuOpti1__ = global::KitchenSink.MenuOptionsElement.JsonByExample;
using __TLong__ = global::Starcounter.Templates.TLong;
using __MeSchema__ = global::KitchenSink.MenuOptionsElement.JsonByExample.Schema;
using __MenuOpti__ = global::KitchenSink.MenuOptionsElement;
using __TString__ = global::Starcounter.Templates.TString;
using __RaSchema__ = global::KitchenSink.RadiolistPage.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Radiolis__ = global::KitchenSink.RadiolistPage;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class RadiolistPage_json : s::TemplateAttribute {
    
    #line hidden
    public class MenuOptions : s::TemplateAttribute {
    }
    #line default
}
#line default

#line hidden
public partial class MenuOptionsElement : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __MeSchema__ DefaultTemplate = new __MeSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public MenuOptionsElement() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public MenuOptionsElement(__MeSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __MeSchema__ Template { get { return (__MeSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__MenuOpti__);
                ClassName = "MenuOptionsElement";
                Properties.ClearExposed();
                Label = Add<__TString__>("Label");
                Label.DefaultValue = "";
                Label.SetCustomAccessors((_p_) => { return ((__MenuOpti__)_p_).__bf__Label__; }, (_p_, _v_) => { ((__MenuOpti__)_p_).__bf__Label__ = (System.String)_v_; }, false);
                Choose = Add<__TLong__>("Choose$");
                Choose.DefaultValue = 0L;
                Choose.Editable = true;
                Choose.SetCustomAccessors((_p_) => { return ((__MenuOpti__)_p_).__bf__Choose__; }, (_p_, _v_) => { ((__MenuOpti__)_p_).__bf__Choose__ = (System.Int64)_v_; }, false);
                Choose.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.Choose() { App = (MenuOptionsElement)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((MenuOptionsElement)pup).Handle((Input.Choose)input); });
            }
            public override object CreateInstance(s.Json parent) { return new __MenuOpti__(this) { Parent = parent }; }
            public __TString__ Label;
            public __TLong__ Choose;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Label__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Label {
    #line 6 "RadiolistPage.json"
        get {
        #line hidden
            return Template.Label.Getter(this); }
        #line 6 "RadiolistPage.json"
        set {
        #line hidden
            Template.Label.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Choose__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Choose {
    #line 8 "RadiolistPage.json"
        get {
        #line hidden
            return Template.Choose.Getter(this); }
        #line 8 "RadiolistPage.json"
        set {
        #line hidden
            Template.Choose.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Label : Input<__MenuOpti__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Choose : Input<__MenuOpti__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default

#line hidden
public partial class RadiolistPage : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __RaSchema__ DefaultTemplate = new __RaSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public RadiolistPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public RadiolistPage(__RaSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __RaSchema__ Template { get { return (__RaSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Radiolis__);
                ClassName = "RadiolistPage";
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/KitchenSink/RadiolistPage.html";
                Html.SetCustomAccessors((_p_) => { return ((__Radiolis__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Radiolis__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                MenuOptions = Add<__TArray__>("MenuOptions");
                MenuOptions.SetCustomGetElementType((arr) => { return __MenuOpti__.DefaultTemplate;});
                MenuOptions.SetCustomAccessors((_p_) => { return ((__Radiolis__)_p_).__bf__MenuOptions__; }, (_p_, _v_) => { ((__Radiolis__)_p_).__bf__MenuOptions__ = (__Arr__)_v_; }, false);
                SelectedItemIndex = Add<__TLong__>("SelectedItemIndex$");
                SelectedItemIndex.DefaultValue = 0L;
                SelectedItemIndex.Editable = true;
                SelectedItemIndex.SetCustomAccessors((_p_) => { return ((__Radiolis__)_p_).__bf__SelectedItemIndex__; }, (_p_, _v_) => { ((__Radiolis__)_p_).__bf__SelectedItemIndex__ = (System.Int64)_v_; }, false);
                SelectedItemIndex.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SelectedItemIndex() { App = (RadiolistPage)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((RadiolistPage)pup).Handle((Input.SelectedItemIndex)input); });
                SelectedItemLabel = Add<__TString__>("SelectedItemLabel");
                SelectedItemLabel.DefaultValue = "";
                SelectedItemLabel.SetCustomAccessors((_p_) => { return ((__Radiolis__)_p_).__bf__SelectedItemLabel__; }, (_p_, _v_) => { ((__Radiolis__)_p_).__bf__SelectedItemLabel__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Radiolis__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TArray__ MenuOptions;
            public __TLong__ SelectedItemIndex;
            public __TString__ SelectedItemLabel;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "RadiolistPage.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "RadiolistPage.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__MenuOptions__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ MenuOptions {
    #line 9 "RadiolistPage.json"
        get {
        #line hidden
            return Template.MenuOptions.Getter(this); }
        #line 9 "RadiolistPage.json"
        set {
        #line hidden
            Template.MenuOptions.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SelectedItemIndex__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SelectedItemIndex {
    #line 10 "RadiolistPage.json"
        get {
        #line hidden
            return Template.SelectedItemIndex.Getter(this); }
        #line 10 "RadiolistPage.json"
        set {
        #line hidden
            Template.SelectedItemIndex.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__SelectedItemLabel__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String SelectedItemLabel {
    #line 12 "RadiolistPage.json"
        get {
        #line hidden
            return Template.SelectedItemLabel.Getter(this); }
        #line 12 "RadiolistPage.json"
        set {
        #line hidden
            Template.SelectedItemLabel.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Radiolis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SelectedItemIndex : Input<__Radiolis__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class SelectedItemLabel : Input<__Radiolis__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
