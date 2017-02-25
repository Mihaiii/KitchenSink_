// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "UrlPage.json"
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
using __UrlPage1__ = global::KitchenSink.UrlPage.JsonByExample;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __UrLabel__ = global::KitchenSink.UrlPage.Input.Label;
using __UrUrl__ = global::KitchenSink.UrlPage.Input.Url;
using __UrHtml__ = global::KitchenSink.UrlPage.Input.Html;
using __UrlPage2__ = global::KitchenSink.UrlPage.Input;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __TString__ = global::Starcounter.Templates.TString;
using __UrSchema__ = global::KitchenSink.UrlPage.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __UrlPage__ = global::KitchenSink.UrlPage;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class UrlPage_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class UrlPage : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __UrSchema__ DefaultTemplate = new __UrSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public UrlPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public UrlPage(__UrSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __UrSchema__ Template { get { return (__UrSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__UrlPage__);
                ClassName = "UrlPage";
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/KitchenSink/UrlPage.html";
                Html.SetCustomAccessors((_p_) => { return ((__UrlPage__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__UrlPage__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Url = Add<__TString__>("Url");
                Url.DefaultValue = "";
                Url.SetCustomAccessors((_p_) => { return ((__UrlPage__)_p_).__bf__Url__; }, (_p_, _v_) => { ((__UrlPage__)_p_).__bf__Url__ = (System.String)_v_; }, false);
                Label = Add<__TString__>("Label");
                Label.DefaultValue = "";
                Label.SetCustomAccessors((_p_) => { return ((__UrlPage__)_p_).__bf__Label__; }, (_p_, _v_) => { ((__UrlPage__)_p_).__bf__Label__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __UrlPage__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Url;
            public __TString__ Label;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "UrlPage.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "UrlPage.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Url__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Url {
    #line 4 "UrlPage.json"
        get {
        #line hidden
            return Template.Url.Getter(this); }
        #line 4 "UrlPage.json"
        set {
        #line hidden
            Template.Url.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Label__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Label {
    #line 6 "UrlPage.json"
        get {
        #line hidden
            return Template.Label.Getter(this); }
        #line 6 "UrlPage.json"
        set {
        #line hidden
            Template.Label.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__UrlPage__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Url : Input<__UrlPage__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Label : Input<__UrlPage__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
