// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "RedirectPage.json"
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
using __ReHtml__ = global::KitchenSink.RedirectPage.Input.Html;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __ReRedirect__ = global::KitchenSink.RedirectPage.Input.RedirectUrl;
using __ReGoToDocs__ = global::KitchenSink.RedirectPage.Input.GoToDocs;
using __ReMorphUrl__ = global::KitchenSink.RedirectPage.Input.MorphUrl;
using __ReGoToHome__ = global::KitchenSink.RedirectPage.Input.GoToHomePartial;
using __ReYourFavo__ = global::KitchenSink.RedirectPage.Input.YourFavoriteFood;
using __ReChooseFo__ = global::KitchenSink.RedirectPage.Input.ChooseFood;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __Redirect1__ = global::KitchenSink.RedirectPage.JsonByExample;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __ReSchema__ = global::KitchenSink.RedirectPage.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Redirect__ = global::KitchenSink.RedirectPage;
using __Redirect2__ = global::KitchenSink.RedirectPage.Input;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class RedirectPage_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class RedirectPage : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __ReSchema__ DefaultTemplate = new __ReSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public RedirectPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public RedirectPage(__ReSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __ReSchema__ Template { get { return (__ReSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Redirect__);
                ClassName = "RedirectPage";
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/KitchenSink/RedirectPage.html";
                Html.SetCustomAccessors((_p_) => { return ((__Redirect__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Redirect__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                ChooseFood = Add<__TString__>("ChooseFood$");
                ChooseFood.DefaultValue = "";
                ChooseFood.Editable = true;
                ChooseFood.SetCustomAccessors((_p_) => { return ((__Redirect__)_p_).__bf__ChooseFood__; }, (_p_, _v_) => { ((__Redirect__)_p_).__bf__ChooseFood__ = (System.String)_v_; }, false);
                ChooseFood.AddHandler((Json pup, Property<String> prop, String value) => { return (new Input.ChooseFood() { App = (RedirectPage)pup, Template = (TString)prop, Value = value }); }, (Json pup, Starcounter.Input<String> input) => { ((RedirectPage)pup).Handle((Input.ChooseFood)input); });
                YourFavoriteFood = Add<__TString__>("YourFavoriteFood");
                YourFavoriteFood.DefaultValue = "Select your favorite food";
                YourFavoriteFood.SetCustomAccessors((_p_) => { return ((__Redirect__)_p_).__bf__YourFavoriteFood__; }, (_p_, _v_) => { ((__Redirect__)_p_).__bf__YourFavoriteFood__ = (System.String)_v_; }, false);
                GoToHomePartial = Add<__TLong__>("GoToHomePartial$");
                GoToHomePartial.DefaultValue = 0L;
                GoToHomePartial.Editable = true;
                GoToHomePartial.SetCustomAccessors((_p_) => { return ((__Redirect__)_p_).__bf__GoToHomePartial__; }, (_p_, _v_) => { ((__Redirect__)_p_).__bf__GoToHomePartial__ = (System.Int64)_v_; }, false);
                GoToHomePartial.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.GoToHomePartial() { App = (RedirectPage)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((RedirectPage)pup).Handle((Input.GoToHomePartial)input); });
                MorphUrl = Add<__TString__>("MorphUrl$");
                MorphUrl.DefaultValue = "";
                MorphUrl.Editable = true;
                MorphUrl.SetCustomAccessors((_p_) => { return ((__Redirect__)_p_).__bf__MorphUrl__; }, (_p_, _v_) => { ((__Redirect__)_p_).__bf__MorphUrl__ = (System.String)_v_; }, false);
                GoToDocs = Add<__TLong__>("GoToDocs$");
                GoToDocs.DefaultValue = 0L;
                GoToDocs.Editable = true;
                GoToDocs.SetCustomAccessors((_p_) => { return ((__Redirect__)_p_).__bf__GoToDocs__; }, (_p_, _v_) => { ((__Redirect__)_p_).__bf__GoToDocs__ = (System.Int64)_v_; }, false);
                GoToDocs.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.GoToDocs() { App = (RedirectPage)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((RedirectPage)pup).Handle((Input.GoToDocs)input); });
                RedirectUrl = Add<__TString__>("RedirectUrl$");
                RedirectUrl.DefaultValue = "";
                RedirectUrl.Editable = true;
                RedirectUrl.SetCustomAccessors((_p_) => { return ((__Redirect__)_p_).__bf__RedirectUrl__; }, (_p_, _v_) => { ((__Redirect__)_p_).__bf__RedirectUrl__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Redirect__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ ChooseFood;
            public __TString__ YourFavoriteFood;
            public __TLong__ GoToHomePartial;
            public __TString__ MorphUrl;
            public __TLong__ GoToDocs;
            public __TString__ RedirectUrl;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "RedirectPage.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "RedirectPage.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__ChooseFood__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String ChooseFood {
    #line 4 "RedirectPage.json"
        get {
        #line hidden
            return Template.ChooseFood.Getter(this); }
        #line 4 "RedirectPage.json"
        set {
        #line hidden
            Template.ChooseFood.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__YourFavoriteFood__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String YourFavoriteFood {
    #line 5 "RedirectPage.json"
        get {
        #line hidden
            return Template.YourFavoriteFood.Getter(this); }
        #line 5 "RedirectPage.json"
        set {
        #line hidden
            Template.YourFavoriteFood.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__GoToHomePartial__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 GoToHomePartial {
    #line 6 "RedirectPage.json"
        get {
        #line hidden
            return Template.GoToHomePartial.Getter(this); }
        #line 6 "RedirectPage.json"
        set {
        #line hidden
            Template.GoToHomePartial.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__MorphUrl__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String MorphUrl {
    #line 7 "RedirectPage.json"
        get {
        #line hidden
            return Template.MorphUrl.Getter(this); }
        #line 7 "RedirectPage.json"
        set {
        #line hidden
            Template.MorphUrl.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__GoToDocs__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 GoToDocs {
    #line 9 "RedirectPage.json"
        get {
        #line hidden
            return Template.GoToDocs.Getter(this); }
        #line 9 "RedirectPage.json"
        set {
        #line hidden
            Template.GoToDocs.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__RedirectUrl__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String RedirectUrl {
    #line 11 "RedirectPage.json"
        get {
        #line hidden
            return Template.RedirectUrl.Getter(this); }
        #line 11 "RedirectPage.json"
        set {
        #line hidden
            Template.RedirectUrl.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Redirect__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class ChooseFood : Input<__Redirect__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class YourFavoriteFood : Input<__Redirect__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class GoToHomePartial : Input<__Redirect__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class MorphUrl : Input<__Redirect__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class GoToDocs : Input<__Redirect__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class RedirectUrl : Input<__Redirect__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
