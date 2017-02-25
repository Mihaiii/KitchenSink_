// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "DecimalPage.json"
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
using __DecimalP1__ = global::KitchenSink.DecimalPage.JsonByExample;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __DePriceRea__ = global::KitchenSink.DecimalPage.Input.PriceReaction;
using __DePrice__ = global::KitchenSink.DecimalPage.Input.Price;
using __DeHtml__ = global::KitchenSink.DecimalPage.Input.Html;
using __DecimalP2__ = global::KitchenSink.DecimalPage.Input;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __TString__ = global::Starcounter.Templates.TString;
using __DeSchema__ = global::KitchenSink.DecimalPage.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __DecimalP__ = global::KitchenSink.DecimalPage;
using __TDecimal__ = global::Starcounter.Templates.TDecimal;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class DecimalPage_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class DecimalPage : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __DeSchema__ DefaultTemplate = new __DeSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public DecimalPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public DecimalPage(__DeSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __DeSchema__ Template { get { return (__DeSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__DecimalP__);
                ClassName = "DecimalPage";
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/KitchenSink/DecimalPage.html";
                Html.SetCustomAccessors((_p_) => { return ((__DecimalP__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__DecimalP__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Price = Add<__TDecimal__>("Price$");
                Price.DefaultValue = 0.0m;
                Price.Editable = true;
                Price.SetCustomAccessors((_p_) => { return ((__DecimalP__)_p_).__bf__Price__; }, (_p_, _v_) => { ((__DecimalP__)_p_).__bf__Price__ = (System.Decimal)_v_; }, false);
                PriceReaction = Add<__TString__>("PriceReaction", bind:"CalculatedPriceReaction");
                PriceReaction.DefaultValue = "";
                PriceReaction.SetCustomAccessors((_p_) => { return ((__DecimalP__)_p_).__bf__PriceReaction__; }, (_p_, _v_) => { ((__DecimalP__)_p_).__bf__PriceReaction__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __DecimalP__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TDecimal__ Price;
            public __TString__ PriceReaction;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "DecimalPage.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "DecimalPage.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.Decimal __bf__Price__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Decimal Price {
    #line 4 "DecimalPage.json"
        get {
        #line hidden
            return Template.Price.Getter(this); }
        #line 4 "DecimalPage.json"
        set {
        #line hidden
            Template.Price.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__PriceReaction__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String PriceReaction {
    #line 6 "DecimalPage.json"
        get {
        #line hidden
            return Template.PriceReaction.Getter(this); }
        #line 6 "DecimalPage.json"
        set {
        #line hidden
            Template.PriceReaction.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__DecimalP__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Price : Input<__DecimalP__, __TDecimal__, Decimal> {
        }
        #line default
        
        #line hidden
        public class PriceReaction : Input<__DecimalP__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
