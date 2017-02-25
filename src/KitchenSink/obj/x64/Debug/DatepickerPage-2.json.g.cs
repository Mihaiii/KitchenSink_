// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "DatepickerPage.json"
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
using __Datepick2__ = global::KitchenSink.DatepickerPage.Input;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __DaYear__ = global::KitchenSink.DatepickerPage.Input.Year;
using __DaDay__ = global::KitchenSink.DatepickerPage.Input.Day;
using __DaMonth__ = global::KitchenSink.DatepickerPage.Input.Month;
using __DaValue__ = global::KitchenSink.DatepickerPage.Input.Value;
using __DaHtml__ = global::KitchenSink.DatepickerPage.Input.Html;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __Datepick1__ = global::KitchenSink.DatepickerPage.JsonByExample;
using __TString__ = global::Starcounter.Templates.TString;
using __DaSchema__ = global::KitchenSink.DatepickerPage.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Datepick__ = global::KitchenSink.DatepickerPage;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class DatepickerPage_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class DatepickerPage : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __DaSchema__ DefaultTemplate = new __DaSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public DatepickerPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public DatepickerPage(__DaSchema__ template) { Template = template; }
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
                InstanceType = typeof(__Datepick__);
                ClassName = "DatepickerPage";
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/KitchenSink/DatepickerPage.html";
                Html.SetCustomAccessors((_p_) => { return ((__Datepick__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Datepick__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Value = Add<__TString__>("Value$");
                Value.DefaultValue = "";
                Value.Editable = true;
                Value.SetCustomAccessors((_p_) => { return ((__Datepick__)_p_).__bf__Value__; }, (_p_, _v_) => { ((__Datepick__)_p_).__bf__Value__ = (System.String)_v_; }, false);
                Value.AddHandler((Json pup, Property<String> prop, String value) => { return (new Input.Value() { App = (DatepickerPage)pup, Template = (TString)prop, Value = value }); }, (Json pup, Starcounter.Input<String> input) => { ((DatepickerPage)pup).Handle((Input.Value)input); });
                Month = Add<__TString__>("Month");
                Month.DefaultValue = "";
                Month.SetCustomAccessors((_p_) => { return ((__Datepick__)_p_).__bf__Month__; }, (_p_, _v_) => { ((__Datepick__)_p_).__bf__Month__ = (System.String)_v_; }, false);
                Day = Add<__TString__>("Day");
                Day.DefaultValue = "";
                Day.SetCustomAccessors((_p_) => { return ((__Datepick__)_p_).__bf__Day__; }, (_p_, _v_) => { ((__Datepick__)_p_).__bf__Day__ = (System.String)_v_; }, false);
                Year = Add<__TString__>("Year");
                Year.DefaultValue = "";
                Year.SetCustomAccessors((_p_) => { return ((__Datepick__)_p_).__bf__Year__; }, (_p_, _v_) => { ((__Datepick__)_p_).__bf__Year__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Datepick__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Value;
            public __TString__ Month;
            public __TString__ Day;
            public __TString__ Year;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "DatepickerPage.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "DatepickerPage.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Value__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Value {
    #line 3 "DatepickerPage.json"
        get {
        #line hidden
            return Template.Value.Getter(this); }
        #line 3 "DatepickerPage.json"
        set {
        #line hidden
            Template.Value.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Month__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Month {
    #line 4 "DatepickerPage.json"
        get {
        #line hidden
            return Template.Month.Getter(this); }
        #line 4 "DatepickerPage.json"
        set {
        #line hidden
            Template.Month.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Day__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Day {
    #line 5 "DatepickerPage.json"
        get {
        #line hidden
            return Template.Day.Getter(this); }
        #line 5 "DatepickerPage.json"
        set {
        #line hidden
            Template.Day.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Year__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Year {
    #line 7 "DatepickerPage.json"
        get {
        #line hidden
            return Template.Year.Getter(this); }
        #line 7 "DatepickerPage.json"
        set {
        #line hidden
            Template.Year.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Datepick__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Value : Input<__Datepick__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Month : Input<__Datepick__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Day : Input<__Datepick__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Year : Input<__Datepick__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
