// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "TextareaPage.json"
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
using __Textarea1__ = global::KitchenSink.TextareaPage.JsonByExample;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __TeBioReact__ = global::KitchenSink.TextareaPage.Input.BioReaction;
using __TeBio__ = global::KitchenSink.TextareaPage.Input.Bio;
using __TeHtml__ = global::KitchenSink.TextareaPage.Input.Html;
using __Textarea2__ = global::KitchenSink.TextareaPage.Input;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __TString__ = global::Starcounter.Templates.TString;
using __TeSchema__ = global::KitchenSink.TextareaPage.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Textarea__ = global::KitchenSink.TextareaPage;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class TextareaPage_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class TextareaPage : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __TeSchema__ DefaultTemplate = new __TeSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public TextareaPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public TextareaPage(__TeSchema__ template) { Template = template; }
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
                InstanceType = typeof(__Textarea__);
                ClassName = "TextareaPage";
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/KitchenSink/TextareaPage.html";
                Html.SetCustomAccessors((_p_) => { return ((__Textarea__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Textarea__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Bio = Add<__TString__>("Bio$");
                Bio.DefaultValue = "";
                Bio.Editable = true;
                Bio.SetCustomAccessors((_p_) => { return ((__Textarea__)_p_).__bf__Bio__; }, (_p_, _v_) => { ((__Textarea__)_p_).__bf__Bio__ = (System.String)_v_; }, false);
                BioReaction = Add<__TString__>("BioReaction", bind:"CalculatedBioReaction");
                BioReaction.DefaultValue = "";
                BioReaction.SetCustomAccessors((_p_) => { return ((__Textarea__)_p_).__bf__BioReaction__; }, (_p_, _v_) => { ((__Textarea__)_p_).__bf__BioReaction__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Textarea__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Bio;
            public __TString__ BioReaction;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "TextareaPage.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "TextareaPage.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Bio__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Bio {
    #line 4 "TextareaPage.json"
        get {
        #line hidden
            return Template.Bio.Getter(this); }
        #line 4 "TextareaPage.json"
        set {
        #line hidden
            Template.Bio.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__BioReaction__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String BioReaction {
    #line 6 "TextareaPage.json"
        get {
        #line hidden
            return Template.BioReaction.Getter(this); }
        #line 6 "TextareaPage.json"
        set {
        #line hidden
            Template.BioReaction.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Textarea__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Bio : Input<__Textarea__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class BioReaction : Input<__Textarea__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
