// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "CookiePage.json"
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
using __CookiePa1__ = global::KitchenSink.CookiePage.JsonByExample;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __CoRequestC__ = global::KitchenSink.CookiePage.Input.RequestCookie;
using __CoHtml__ = global::KitchenSink.CookiePage.Input.Html;
using __CookiePa2__ = global::KitchenSink.CookiePage.Input;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __CoSchema__ = global::KitchenSink.CookiePage.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __CookiePa__ = global::KitchenSink.CookiePage;
using __TString__ = global::Starcounter.Templates.TString;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class CookiePage_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class CookiePage : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __CoSchema__ DefaultTemplate = new __CoSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CookiePage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CookiePage(__CoSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __CoSchema__ Template { get { return (__CoSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__CookiePa__);
                ClassName = "CookiePage";
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/KitchenSink/CookiePage.html";
                Html.SetCustomAccessors((_p_) => { return ((__CookiePa__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__CookiePa__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                RequestCookie = Add<__TString__>("RequestCookie");
                RequestCookie.DefaultValue = "The cookie is not set, reload the page to set value";
                RequestCookie.SetCustomAccessors((_p_) => { return ((__CookiePa__)_p_).__bf__RequestCookie__; }, (_p_, _v_) => { ((__CookiePa__)_p_).__bf__RequestCookie__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __CookiePa__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ RequestCookie;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "CookiePage.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "CookiePage.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__RequestCookie__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String RequestCookie {
    #line 4 "CookiePage.json"
        get {
        #line hidden
            return Template.RequestCookie.Getter(this); }
        #line 4 "CookiePage.json"
        set {
        #line hidden
            Template.RequestCookie.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__CookiePa__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class RequestCookie : Input<__CookiePa__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
