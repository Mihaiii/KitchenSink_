// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "TextPage.json"
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
using __TextPage2__ = global::KitchenSink.TextPage.Input;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __TeNameLive1__ = global::KitchenSink.TextPage.Input.NameLiveReaction;
using __TeNameReac__ = global::KitchenSink.TextPage.Input.NameReaction;
using __TeNameLive__ = global::KitchenSink.TextPage.Input.NameLive;
using __TeName__ = global::KitchenSink.TextPage.Input.Name;
using __TeHtml__ = global::KitchenSink.TextPage.Input.Html;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __TextPage1__ = global::KitchenSink.TextPage.JsonByExample;
using __TString__ = global::Starcounter.Templates.TString;
using __TeSchema__ = global::KitchenSink.TextPage.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __TextPage__ = global::KitchenSink.TextPage;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class TextPage_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class TextPage : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __TeSchema__ DefaultTemplate = new __TeSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public TextPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public TextPage(__TeSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __TeSchema__ Template { get { return (__TeSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__TextPage__);
                ClassName = "TextPage";
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/KitchenSink/TextPage.html";
                Html.SetCustomAccessors((_p_) => { return ((__TextPage__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__TextPage__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Name = Add<__TString__>("Name$");
                Name.DefaultValue = "";
                Name.Editable = true;
                Name.SetCustomAccessors((_p_) => { return ((__TextPage__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__TextPage__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                NameLive = Add<__TString__>("NameLive$");
                NameLive.DefaultValue = "";
                NameLive.Editable = true;
                NameLive.SetCustomAccessors((_p_) => { return ((__TextPage__)_p_).__bf__NameLive__; }, (_p_, _v_) => { ((__TextPage__)_p_).__bf__NameLive__ = (System.String)_v_; }, false);
                NameReaction = Add<__TString__>("NameReaction", bind:"CalculatedNameReaction");
                NameReaction.DefaultValue = "";
                NameReaction.SetCustomAccessors((_p_) => { return ((__TextPage__)_p_).__bf__NameReaction__; }, (_p_, _v_) => { ((__TextPage__)_p_).__bf__NameReaction__ = (System.String)_v_; }, false);
                NameLiveReaction = Add<__TString__>("NameLiveReaction", bind:"CalculatedNameLiveReaction");
                NameLiveReaction.DefaultValue = "";
                NameLiveReaction.SetCustomAccessors((_p_) => { return ((__TextPage__)_p_).__bf__NameLiveReaction__; }, (_p_, _v_) => { ((__TextPage__)_p_).__bf__NameLiveReaction__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __TextPage__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Name;
            public __TString__ NameLive;
            public __TString__ NameReaction;
            public __TString__ NameLiveReaction;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "TextPage.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "TextPage.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Name__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
    #line 4 "TextPage.json"
        get {
        #line hidden
            return Template.Name.Getter(this); }
        #line 4 "TextPage.json"
        set {
        #line hidden
            Template.Name.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__NameLive__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NameLive {
    #line 5 "TextPage.json"
        get {
        #line hidden
            return Template.NameLive.Getter(this); }
        #line 5 "TextPage.json"
        set {
        #line hidden
            Template.NameLive.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__NameReaction__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NameReaction {
    #line 7 "TextPage.json"
        get {
        #line hidden
            return Template.NameReaction.Getter(this); }
        #line 7 "TextPage.json"
        set {
        #line hidden
            Template.NameReaction.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__NameLiveReaction__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NameLiveReaction {
    #line 9 "TextPage.json"
        get {
        #line hidden
            return Template.NameLiveReaction.Getter(this); }
        #line 9 "TextPage.json"
        set {
        #line hidden
            Template.NameLiveReaction.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__TextPage__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Name : Input<__TextPage__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class NameLive : Input<__TextPage__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class NameReaction : Input<__TextPage__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class NameLiveReaction : Input<__TextPage__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
