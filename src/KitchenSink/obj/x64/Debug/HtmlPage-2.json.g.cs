// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "HtmlPage.json"
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
using __HtmlPage1__ = global::KitchenSink.HtmlPage.JsonByExample;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __HtBio__ = global::KitchenSink.HtmlPage.Input.Bio;
using __HtHtml__ = global::KitchenSink.HtmlPage.Input.Html;
using __HtmlPage2__ = global::KitchenSink.HtmlPage.Input;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __HtSchema__ = global::KitchenSink.HtmlPage.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __HtmlPage__ = global::KitchenSink.HtmlPage;
using __TString__ = global::Starcounter.Templates.TString;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class HtmlPage_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class HtmlPage : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __HtSchema__ DefaultTemplate = new __HtSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public HtmlPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public HtmlPage(__HtSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __HtSchema__ Template { get { return (__HtSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__HtmlPage__);
                ClassName = "HtmlPage";
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/KitchenSink/HtmlPage.html";
                Html.SetCustomAccessors((_p_) => { return ((__HtmlPage__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__HtmlPage__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Bio = Add<__TString__>("Bio");
                Bio.DefaultValue = "";
                Bio.SetCustomAccessors((_p_) => { return ((__HtmlPage__)_p_).__bf__Bio__; }, (_p_, _v_) => { ((__HtmlPage__)_p_).__bf__Bio__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __HtmlPage__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Bio;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "HtmlPage.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "HtmlPage.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Bio__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Bio {
    #line 5 "HtmlPage.json"
        get {
        #line hidden
            return Template.Bio.Getter(this); }
        #line 5 "HtmlPage.json"
        set {
        #line hidden
            Template.Bio.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__HtmlPage__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Bio : Input<__HtmlPage__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
