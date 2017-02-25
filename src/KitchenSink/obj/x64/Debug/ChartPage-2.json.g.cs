// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "ChartPage.json"
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
using __CTeSchema__ = global::KitchenSink.ChartPage.TemperaturesElementJson.JsonByExample.Schema;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __ChHtml__ = global::KitchenSink.ChartPage.Input.Html;
using __ChartPag2__ = global::KitchenSink.ChartPage.Input;
using __Arr1__ = global::Starcounter.Arr<global::KitchenSink.ChartPage.TemperaturesElementJson>;
using __Arr__ = global::Starcounter.Arr<global::KitchenSink.ChartPage.LabelsElementJson>;
using __ChartPag1__ = global::KitchenSink.ChartPage.JsonByExample;
using __TArray1__ = global::Starcounter.Templates.TArray<global::KitchenSink.ChartPage.TemperaturesElementJson>;
using __CTeIntegerV__ = global::KitchenSink.ChartPage.TemperaturesElementJson.Input.IntegerValue;
using __ChTemperat2__ = global::KitchenSink.ChartPage.TemperaturesElementJson.Input;
using __ChTemperat1__ = global::KitchenSink.ChartPage.TemperaturesElementJson.JsonByExample;
using __TLong__ = global::Starcounter.Templates.TLong;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __TArray__ = global::Starcounter.Templates.TArray<global::KitchenSink.ChartPage.LabelsElementJson>;
using __CLaStringVa__ = global::KitchenSink.ChartPage.LabelsElementJson.Input.StringValue;
using __ChLabelsEl2__ = global::KitchenSink.ChartPage.LabelsElementJson.Input;
using __ChLabelsEl1__ = global::KitchenSink.ChartPage.LabelsElementJson.JsonByExample;
using __CLaSchema__ = global::KitchenSink.ChartPage.LabelsElementJson.JsonByExample.Schema;
using __ChLabelsEl__ = global::KitchenSink.ChartPage.LabelsElementJson;
using __TString__ = global::Starcounter.Templates.TString;
using __ChSchema__ = global::KitchenSink.ChartPage.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __ChartPag__ = global::KitchenSink.ChartPage;
using __ChTemperat__ = global::KitchenSink.ChartPage.TemperaturesElementJson;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class ChartPage_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class ChartPage : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __ChSchema__ DefaultTemplate = new __ChSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ChartPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ChartPage(__ChSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __ChSchema__ Template { get { return (__ChSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__ChartPag__);
                ClassName = "ChartPage";
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/KitchenSink/ChartPage.html";
                Html.SetCustomAccessors((_p_) => { return ((__ChartPag__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__ChartPag__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Labels = Add<__TArray__>("Labels");
                Labels.SetCustomGetElementType((arr) => { return __ChLabelsEl__.DefaultTemplate;});
                Labels.SetCustomAccessors((_p_) => { return ((__ChartPag__)_p_).__bf__Labels__; }, (_p_, _v_) => { ((__ChartPag__)_p_).__bf__Labels__ = (__Arr__)_v_; }, false);
                Temperatures = Add<__TArray1__>("Temperatures");
                Temperatures.SetCustomGetElementType((arr) => { return __ChTemperat__.DefaultTemplate;});
                Temperatures.SetCustomAccessors((_p_) => { return ((__ChartPag__)_p_).__bf__Temperatures__; }, (_p_, _v_) => { ((__ChartPag__)_p_).__bf__Temperatures__ = (__Arr1__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __ChartPag__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TArray__ Labels;
            public __TArray1__ Temperatures;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "ChartPage.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "ChartPage.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__Labels__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ Labels {
    #line 4 "ChartPage.json"
        get {
        #line hidden
            return Template.Labels.Getter(this); }
        #line 4 "ChartPage.json"
        set {
        #line hidden
            Template.Labels.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr1__ __bf__Temperatures__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr1__ Temperatures {
    #line 6 "ChartPage.json"
        get {
        #line hidden
            return Template.Temperatures.Getter(this); }
        #line 6 "ChartPage.json"
        set {
        #line hidden
            Template.Temperatures.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class LabelsElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __CLaSchema__ DefaultTemplate = new __CLaSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public LabelsElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public LabelsElementJson(__CLaSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __CLaSchema__ Template { get { return (__CLaSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TString__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__ChLabelsEl__);
                    ClassName = "LabelsElementJson";
                    this.DefaultValue = "1";
                    this.SetCustomAccessors((_p_) => { return ((__ChLabelsEl__)_p_).__bf__StringValue__; }, (_p_, _v_) => { ((__ChLabelsEl__)_p_).__bf__StringValue__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __ChLabelsEl__(this) { Parent = parent }; }
                public __CLaSchema__ StringValue;
            }
            #line default
        }
        #line default
        #line hidden
        private System.String __bf__StringValue__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String StringValue {
        #line 4 "ChartPage.json"
            get {
            #line hidden
                return Template.Getter(this); }
            #line 4 "ChartPage.json"
            set {
            #line hidden
                Template.Setter(this, value); } }
            #line default
        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class StringValue : Input<__ChLabelsEl__, __TString__, System.String> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class TemperaturesElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __CTeSchema__ DefaultTemplate = new __CTeSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public TemperaturesElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public TemperaturesElementJson(__CTeSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __CTeSchema__ Template { get { return (__CTeSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TLong__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__ChTemperat__);
                    ClassName = "TemperaturesElementJson";
                    this.DefaultValue = 13L;
                    this.SetCustomAccessors((_p_) => { return ((__ChTemperat__)_p_).__bf__IntegerValue__; }, (_p_, _v_) => { ((__ChTemperat__)_p_).__bf__IntegerValue__ = (System.Int64)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __ChTemperat__(this) { Parent = parent }; }
                public __CTeSchema__ IntegerValue;
            }
            #line default
        }
        #line default
        #line hidden
        private System.Int64 __bf__IntegerValue__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 IntegerValue {
        #line 5 "ChartPage.json"
            get {
            #line hidden
                return Template.Getter(this); }
            #line 5 "ChartPage.json"
            set {
            #line hidden
                Template.Setter(this, value); } }
            #line default
        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class IntegerValue : Input<__ChTemperat__, __TLong__, System.Int64> {
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
        public class Html : Input<__ChartPag__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
