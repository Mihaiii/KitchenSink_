// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "IntegerPage.json"
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
using __IntegerP1__ = global::KitchenSink.IntegerPage.JsonByExample;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __InAgeReact__ = global::KitchenSink.IntegerPage.Input.AgeReaction;
using __InAge__ = global::KitchenSink.IntegerPage.Input.Age;
using __InHtml__ = global::KitchenSink.IntegerPage.Input.Html;
using __IntegerP2__ = global::KitchenSink.IntegerPage.Input;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __TString__ = global::Starcounter.Templates.TString;
using __InSchema__ = global::KitchenSink.IntegerPage.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __IntegerP__ = global::KitchenSink.IntegerPage;
using __TLong__ = global::Starcounter.Templates.TLong;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class IntegerPage_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class IntegerPage : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __InSchema__ DefaultTemplate = new __InSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public IntegerPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public IntegerPage(__InSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __InSchema__ Template { get { return (__InSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__IntegerP__);
                ClassName = "IntegerPage";
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/KitchenSink/IntegerPage.html";
                Html.SetCustomAccessors((_p_) => { return ((__IntegerP__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__IntegerP__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Age = Add<__TLong__>("Age$");
                Age.DefaultValue = 0L;
                Age.Editable = true;
                Age.SetCustomAccessors((_p_) => { return ((__IntegerP__)_p_).__bf__Age__; }, (_p_, _v_) => { ((__IntegerP__)_p_).__bf__Age__ = (System.Int64)_v_; }, false);
                AgeReaction = Add<__TString__>("AgeReaction", bind:"CalculatedAgeReaction");
                AgeReaction.DefaultValue = "";
                AgeReaction.SetCustomAccessors((_p_) => { return ((__IntegerP__)_p_).__bf__AgeReaction__; }, (_p_, _v_) => { ((__IntegerP__)_p_).__bf__AgeReaction__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __IntegerP__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TLong__ Age;
            public __TString__ AgeReaction;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "IntegerPage.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "IntegerPage.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Age__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Age {
    #line 4 "IntegerPage.json"
        get {
        #line hidden
            return Template.Age.Getter(this); }
        #line 4 "IntegerPage.json"
        set {
        #line hidden
            Template.Age.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__AgeReaction__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String AgeReaction {
    #line 6 "IntegerPage.json"
        get {
        #line hidden
            return Template.AgeReaction.Getter(this); }
        #line 6 "IntegerPage.json"
        set {
        #line hidden
            Template.AgeReaction.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__IntegerP__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Age : Input<__IntegerP__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class AgeReaction : Input<__IntegerP__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
