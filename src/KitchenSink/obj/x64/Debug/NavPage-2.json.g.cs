// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "NavPage.json"
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
using __NaNavLinks2__ = global::KitchenSink.NavPage.NavLinksElementJson.Input;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __NaHtml__ = global::KitchenSink.NavPage.Input.Html;
using __NavPage2__ = global::KitchenSink.NavPage.Input;
using __Arr__ = global::Starcounter.Arr<global::KitchenSink.NavPage.NavLinksElementJson>;
using __NavPage1__ = global::KitchenSink.NavPage.JsonByExample;
using __TArray__ = global::Starcounter.Templates.TArray<global::KitchenSink.NavPage.NavLinksElementJson>;
using __NNaUrl__ = global::KitchenSink.NavPage.NavLinksElementJson.Input.Url;
using __NNaLabel__ = global::KitchenSink.NavPage.NavLinksElementJson.Input.Label;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __NaNavLinks1__ = global::KitchenSink.NavPage.NavLinksElementJson.JsonByExample;
using __NNaSchema__ = global::KitchenSink.NavPage.NavLinksElementJson.JsonByExample.Schema;
using __NaNavLinks__ = global::KitchenSink.NavPage.NavLinksElementJson;
using __TString__ = global::Starcounter.Templates.TString;
using __NaSchema__ = global::KitchenSink.NavPage.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __NavPage__ = global::KitchenSink.NavPage;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class NavPage_json : s::TemplateAttribute {
    
    #line hidden
    public class NavLinks : s::TemplateAttribute {
    }
    #line default
}
#line default

#line hidden
public partial class NavPage : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __NaSchema__ DefaultTemplate = new __NaSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public NavPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public NavPage(__NaSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __NaSchema__ Template { get { return (__NaSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__NavPage__);
                ClassName = "NavPage";
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/KitchenSink/NavPage.html";
                Html.SetCustomAccessors((_p_) => { return ((__NavPage__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__NavPage__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                NavLinks = Add<__TArray__>("NavLinks");
                NavLinks.SetCustomGetElementType((arr) => { return __NaNavLinks__.DefaultTemplate;});
                NavLinks.SetCustomAccessors((_p_) => { return ((__NavPage__)_p_).__bf__NavLinks__; }, (_p_, _v_) => { ((__NavPage__)_p_).__bf__NavLinks__ = (__Arr__)_v_; }, false);
                CurrentPage = Add<__TObject__>("CurrentPage");
                CurrentPage.SetCustomAccessors((_p_) => { return ((__NavPage__)_p_).__bf__CurrentPage__; }, (_p_, _v_) => { ((__NavPage__)_p_).__bf__CurrentPage__ = (__Json__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __NavPage__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TArray__ NavLinks;
            public __TObject__ CurrentPage;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "NavPage.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "NavPage.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__NavLinks__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ NavLinks {
    #line 9 "NavPage.json"
        get {
        #line hidden
            return Template.NavLinks.Getter(this); }
        #line 9 "NavPage.json"
        set {
        #line hidden
            Template.NavLinks.Setter(this, value); } }
        #line default
    #line hidden
    private __Json__ __bf__CurrentPage__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Json__ CurrentPage {
    #line 11 "NavPage.json"
        get {
        #line hidden
            return (__Json__)Template.CurrentPage.Getter(this); }
        #line 11 "NavPage.json"
        set {
        #line hidden
            Template.CurrentPage.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class NavLinksElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __NNaSchema__ DefaultTemplate = new __NNaSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public NavLinksElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public NavLinksElementJson(__NNaSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __NNaSchema__ Template { get { return (__NNaSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__NaNavLinks__);
                    ClassName = "NavLinksElementJson";
                    Properties.ClearExposed();
                    Label = Add<__TString__>("Label");
                    Label.DefaultValue = "";
                    Label.SetCustomAccessors((_p_) => { return ((__NaNavLinks__)_p_).__bf__Label__; }, (_p_, _v_) => { ((__NaNavLinks__)_p_).__bf__Label__ = (System.String)_v_; }, false);
                    Url = Add<__TString__>("Url");
                    Url.DefaultValue = "";
                    Url.SetCustomAccessors((_p_) => { return ((__NaNavLinks__)_p_).__bf__Url__; }, (_p_, _v_) => { ((__NaNavLinks__)_p_).__bf__Url__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __NaNavLinks__(this) { Parent = parent }; }
                public __TString__ Label;
                public __TString__ Url;
            }
            #line default
        }
        #line default
        #line hidden
        private System.String __bf__Label__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Label {
        #line 6 "NavPage.json"
            get {
            #line hidden
                return Template.Label.Getter(this); }
            #line 6 "NavPage.json"
            set {
            #line hidden
                Template.Label.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__Url__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Url {
        #line 8 "NavPage.json"
            get {
            #line hidden
                return Template.Url.Getter(this); }
            #line 8 "NavPage.json"
            set {
            #line hidden
                Template.Url.Setter(this, value); } }
            #line default
        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Label : Input<__NaNavLinks__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Url : Input<__NaNavLinks__, __TString__, string> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__NavPage__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
