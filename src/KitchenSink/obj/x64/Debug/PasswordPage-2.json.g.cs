// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "PasswordPage.json"
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
using __Password1__ = global::KitchenSink.PasswordPage.JsonByExample;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __PaPassword1__ = global::KitchenSink.PasswordPage.Input.PasswordReaction;
using __PaPassword__ = global::KitchenSink.PasswordPage.Input.Password;
using __PaHtml__ = global::KitchenSink.PasswordPage.Input.Html;
using __Password2__ = global::KitchenSink.PasswordPage.Input;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __TString__ = global::Starcounter.Templates.TString;
using __PaSchema__ = global::KitchenSink.PasswordPage.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Password__ = global::KitchenSink.PasswordPage;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class PasswordPage_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class PasswordPage : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __PaSchema__ DefaultTemplate = new __PaSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public PasswordPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public PasswordPage(__PaSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __PaSchema__ Template { get { return (__PaSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Password__);
                ClassName = "PasswordPage";
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/KitchenSink/PasswordPage.html";
                Html.SetCustomAccessors((_p_) => { return ((__Password__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Password__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Password = Add<__TString__>("Password$");
                Password.DefaultValue = "";
                Password.Editable = true;
                Password.SetCustomAccessors((_p_) => { return ((__Password__)_p_).__bf__Password__; }, (_p_, _v_) => { ((__Password__)_p_).__bf__Password__ = (System.String)_v_; }, false);
                PasswordReaction = Add<__TString__>("PasswordReaction", bind:"CalculatedPasswordReaction");
                PasswordReaction.DefaultValue = "";
                PasswordReaction.SetCustomAccessors((_p_) => { return ((__Password__)_p_).__bf__PasswordReaction__; }, (_p_, _v_) => { ((__Password__)_p_).__bf__PasswordReaction__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Password__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Password;
            public __TString__ PasswordReaction;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "PasswordPage.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "PasswordPage.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Password__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Password {
    #line 4 "PasswordPage.json"
        get {
        #line hidden
            return Template.Password.Getter(this); }
        #line 4 "PasswordPage.json"
        set {
        #line hidden
            Template.Password.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__PasswordReaction__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String PasswordReaction {
    #line 6 "PasswordPage.json"
        get {
        #line hidden
            return Template.PasswordReaction.Getter(this); }
        #line 6 "PasswordPage.json"
        set {
        #line hidden
            Template.PasswordReaction.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Password__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Password : Input<__Password__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class PasswordReaction : Input<__Password__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
