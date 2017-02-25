// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "ToggleButtonPage.json"
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
using __ToggleBu1__ = global::KitchenSink.ToggleButtonPage.JsonByExample;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __ToAcceptTe1__ = global::KitchenSink.ToggleButtonPage.Input.AcceptTermsAndConditionsReaction;
using __ToAcceptTe__ = global::KitchenSink.ToggleButtonPage.Input.AcceptTermsAndConditions;
using __ToHtml__ = global::KitchenSink.ToggleButtonPage.Input.Html;
using __ToggleBu2__ = global::KitchenSink.ToggleButtonPage.Input;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __TString__ = global::Starcounter.Templates.TString;
using __ToSchema__ = global::KitchenSink.ToggleButtonPage.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __ToggleBu__ = global::KitchenSink.ToggleButtonPage;
using __TBool__ = global::Starcounter.Templates.TBool;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class ToggleButtonPage_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class ToggleButtonPage : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __ToSchema__ DefaultTemplate = new __ToSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ToggleButtonPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ToggleButtonPage(__ToSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __ToSchema__ Template { get { return (__ToSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__ToggleBu__);
                ClassName = "ToggleButtonPage";
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/KitchenSink/ToggleButtonPage.html";
                Html.SetCustomAccessors((_p_) => { return ((__ToggleBu__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__ToggleBu__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                AcceptTermsAndConditions = Add<__TBool__>("AcceptTermsAndConditions$");
                AcceptTermsAndConditions.DefaultValue = true;
                AcceptTermsAndConditions.Editable = true;
                AcceptTermsAndConditions.SetCustomAccessors((_p_) => { return ((__ToggleBu__)_p_).__bf__AcceptTermsAndConditions__; }, (_p_, _v_) => { ((__ToggleBu__)_p_).__bf__AcceptTermsAndConditions__ = (System.Boolean)_v_; }, false);
                AcceptTermsAndConditionsReaction = Add<__TString__>("AcceptTermsAndConditionsReaction", bind:"CalculatedAcceptTermsAndConditionsReaction");
                AcceptTermsAndConditionsReaction.DefaultValue = "";
                AcceptTermsAndConditionsReaction.SetCustomAccessors((_p_) => { return ((__ToggleBu__)_p_).__bf__AcceptTermsAndConditionsReaction__; }, (_p_, _v_) => { ((__ToggleBu__)_p_).__bf__AcceptTermsAndConditionsReaction__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __ToggleBu__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TBool__ AcceptTermsAndConditions;
            public __TString__ AcceptTermsAndConditionsReaction;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "ToggleButtonPage.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "ToggleButtonPage.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.Boolean __bf__AcceptTermsAndConditions__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Boolean AcceptTermsAndConditions {
    #line 123 "JOCKE3"
        get {
        #line hidden
            return Template.AcceptTermsAndConditions.Getter(this); }
        #line 123 "JOCKE3"
        set {
        #line hidden
            Template.AcceptTermsAndConditions.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__AcceptTermsAndConditionsReaction__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String AcceptTermsAndConditionsReaction {
    #line 6 "ToggleButtonPage.json"
        get {
        #line hidden
            return Template.AcceptTermsAndConditionsReaction.Getter(this); }
        #line 6 "ToggleButtonPage.json"
        set {
        #line hidden
            Template.AcceptTermsAndConditionsReaction.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__ToggleBu__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class AcceptTermsAndConditions : Input<__ToggleBu__, __TBool__, bool> {
        }
        #line default
        
        #line hidden
        public class AcceptTermsAndConditionsReaction : Input<__ToggleBu__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
