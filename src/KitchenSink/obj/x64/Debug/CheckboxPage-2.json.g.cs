// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "CheckboxPage.json"
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
using __Checkbox1__ = global::KitchenSink.CheckboxPage.JsonByExample;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __ChDrivingL1__ = global::KitchenSink.CheckboxPage.Input.DrivingLicenseReaction;
using __ChDrivingL__ = global::KitchenSink.CheckboxPage.Input.DrivingLicense;
using __ChHtml__ = global::KitchenSink.CheckboxPage.Input.Html;
using __Checkbox2__ = global::KitchenSink.CheckboxPage.Input;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __TString__ = global::Starcounter.Templates.TString;
using __ChSchema__ = global::KitchenSink.CheckboxPage.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Checkbox__ = global::KitchenSink.CheckboxPage;
using __TBool__ = global::Starcounter.Templates.TBool;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class CheckboxPage_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class CheckboxPage : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __ChSchema__ DefaultTemplate = new __ChSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CheckboxPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CheckboxPage(__ChSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __ChSchema__ Template { get { return (__ChSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Checkbox__);
                ClassName = "CheckboxPage";
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/KitchenSink/CheckboxPage.html";
                Html.SetCustomAccessors((_p_) => { return ((__Checkbox__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Checkbox__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                DrivingLicense = Add<__TBool__>("DrivingLicense$");
                DrivingLicense.DefaultValue = true;
                DrivingLicense.Editable = true;
                DrivingLicense.SetCustomAccessors((_p_) => { return ((__Checkbox__)_p_).__bf__DrivingLicense__; }, (_p_, _v_) => { ((__Checkbox__)_p_).__bf__DrivingLicense__ = (System.Boolean)_v_; }, false);
                DrivingLicenseReaction = Add<__TString__>("DrivingLicenseReaction", bind:"CalculatedDrivingLicenseReaction");
                DrivingLicenseReaction.DefaultValue = "";
                DrivingLicenseReaction.SetCustomAccessors((_p_) => { return ((__Checkbox__)_p_).__bf__DrivingLicenseReaction__; }, (_p_, _v_) => { ((__Checkbox__)_p_).__bf__DrivingLicenseReaction__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Checkbox__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TBool__ DrivingLicense;
            public __TString__ DrivingLicenseReaction;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "CheckboxPage.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "CheckboxPage.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.Boolean __bf__DrivingLicense__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Boolean DrivingLicense {
    #line 123 "JOCKE3"
        get {
        #line hidden
            return Template.DrivingLicense.Getter(this); }
        #line 123 "JOCKE3"
        set {
        #line hidden
            Template.DrivingLicense.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__DrivingLicenseReaction__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String DrivingLicenseReaction {
    #line 6 "CheckboxPage.json"
        get {
        #line hidden
            return Template.DrivingLicenseReaction.Getter(this); }
        #line 6 "CheckboxPage.json"
        set {
        #line hidden
            Template.DrivingLicenseReaction.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Checkbox__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class DrivingLicense : Input<__Checkbox__, __TBool__, bool> {
        }
        #line default
        
        #line hidden
        public class DrivingLicenseReaction : Input<__Checkbox__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
