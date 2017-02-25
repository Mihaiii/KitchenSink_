// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "ValidationPage.json"
// Version: 2
// DO NOT MODIFY DIRECTLY - CHANGES WILL BE OVERWRITTEN

using System;
using System.Collections;
using System.Collections.Generic;
using Starcounter.Advanced;
using Starcounter;
using Starcounter.Internal;
using Starcounter.Templates;
using FluentValidation;
#pragma warning disable 0108
#pragma warning disable 1591

namespace KitchenSink {
using __Validati2__ = global::KitchenSink.ValidationPage.Input;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __VaErrorLas__ = global::KitchenSink.ValidationPage.Input.ErrorLastName;
using __VaLastName__ = global::KitchenSink.ValidationPage.Input.LastName;
using __VaErrorNam__ = global::KitchenSink.ValidationPage.Input.ErrorName;
using __VaName__ = global::KitchenSink.ValidationPage.Input.Name;
using __VaValidate__ = global::KitchenSink.ValidationPage.Input.Validate;
using __VaHtml__ = global::KitchenSink.ValidationPage.Input.Html;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __Validati1__ = global::KitchenSink.ValidationPage.JsonByExample;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __VaSchema__ = global::KitchenSink.ValidationPage.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Validati__ = global::KitchenSink.ValidationPage;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class ValidationPage_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class ValidationPage : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __VaSchema__ DefaultTemplate = new __VaSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ValidationPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ValidationPage(__VaSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __VaSchema__ Template { get { return (__VaSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Validati__);
                ClassName = "ValidationPage";
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/KitchenSink/ValidationPage.html";
                Html.SetCustomAccessors((_p_) => { return ((__Validati__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Validati__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Validate = Add<__TLong__>("Validate$");
                Validate.DefaultValue = 0L;
                Validate.Editable = true;
                Validate.SetCustomAccessors((_p_) => { return ((__Validati__)_p_).__bf__Validate__; }, (_p_, _v_) => { ((__Validati__)_p_).__bf__Validate__ = (System.Int64)_v_; }, false);
                Validate.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.Validate() { App = (ValidationPage)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((ValidationPage)pup).Handle((Input.Validate)input); });
                Name = Add<__TString__>("Name$");
                Name.DefaultValue = "";
                Name.Editable = true;
                Name.SetCustomAccessors((_p_) => { return ((__Validati__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__Validati__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                ErrorName = Add<__TString__>("ErrorName$");
                ErrorName.DefaultValue = "";
                ErrorName.Editable = true;
                ErrorName.SetCustomAccessors((_p_) => { return ((__Validati__)_p_).__bf__ErrorName__; }, (_p_, _v_) => { ((__Validati__)_p_).__bf__ErrorName__ = (System.String)_v_; }, false);
                LastName = Add<__TString__>("LastName$");
                LastName.DefaultValue = "";
                LastName.Editable = true;
                LastName.SetCustomAccessors((_p_) => { return ((__Validati__)_p_).__bf__LastName__; }, (_p_, _v_) => { ((__Validati__)_p_).__bf__LastName__ = (System.String)_v_; }, false);
                ErrorLastName = Add<__TString__>("ErrorLastName$");
                ErrorLastName.DefaultValue = "";
                ErrorLastName.Editable = true;
                ErrorLastName.SetCustomAccessors((_p_) => { return ((__Validati__)_p_).__bf__ErrorLastName__; }, (_p_, _v_) => { ((__Validati__)_p_).__bf__ErrorLastName__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Validati__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TLong__ Validate;
            public __TString__ Name;
            public __TString__ ErrorName;
            public __TString__ LastName;
            public __TString__ ErrorLastName;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "ValidationPage.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "ValidationPage.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Validate__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Validate {
    #line 3 "ValidationPage.json"
        get {
        #line hidden
            return Template.Validate.Getter(this); }
        #line 3 "ValidationPage.json"
        set {
        #line hidden
            Template.Validate.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Name__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
    #line 4 "ValidationPage.json"
        get {
        #line hidden
            return Template.Name.Getter(this); }
        #line 4 "ValidationPage.json"
        set {
        #line hidden
            Template.Name.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__ErrorName__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String ErrorName {
    #line 5 "ValidationPage.json"
        get {
        #line hidden
            return Template.ErrorName.Getter(this); }
        #line 5 "ValidationPage.json"
        set {
        #line hidden
            Template.ErrorName.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__LastName__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String LastName {
    #line 6 "ValidationPage.json"
        get {
        #line hidden
            return Template.LastName.Getter(this); }
        #line 6 "ValidationPage.json"
        set {
        #line hidden
            Template.LastName.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__ErrorLastName__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String ErrorLastName {
    #line 8 "ValidationPage.json"
        get {
        #line hidden
            return Template.ErrorLastName.Getter(this); }
        #line 8 "ValidationPage.json"
        set {
        #line hidden
            Template.ErrorLastName.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Validati__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Validate : Input<__Validati__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class Name : Input<__Validati__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class ErrorName : Input<__Validati__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class LastName : Input<__Validati__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class ErrorLastName : Input<__Validati__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
