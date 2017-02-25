// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "NestedPartial.json"
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
using __NestedPa1__ = global::KitchenSink.NestedPartial.JsonByExample;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __NeAddChild__ = global::KitchenSink.NestedPartial.Input.AddChild;
using __NeName__ = global::KitchenSink.NestedPartial.Input.Name;
using __NeHtml__ = global::KitchenSink.NestedPartial.Input.Html;
using __NestedPa2__ = global::KitchenSink.NestedPartial.Input;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __TString__ = global::Starcounter.Templates.TString;
using __NeSchema__ = global::KitchenSink.NestedPartial.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __NestedPa__ = global::KitchenSink.NestedPartial;
using __TLong__ = global::Starcounter.Templates.TLong;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class NestedPartial_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class NestedPartial : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __NeSchema__ DefaultTemplate = new __NeSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public NestedPartial() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public NestedPartial(__NeSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __NeSchema__ Template { get { return (__NeSchema__)base.Template; } set { base.Template = value; } }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new AnyData Data { get { return (AnyData)base.Data; } set { base.Data = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__NestedPa__);
                ClassName = "NestedPartial";
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/KitchenSink/NestedPartial.html";
                Html.SetCustomAccessors((_p_) => { return ((__NestedPa__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__NestedPa__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Name = Add<__TString__>("Name");
                Name.DefaultValue = "";
                Name.SetCustomAccessors((_p_) => { return ((__NestedPa__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__NestedPa__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                ChildPartial = Add<__TObject__>("ChildPartial");
                ChildPartial.SetCustomAccessors((_p_) => { return ((__NestedPa__)_p_).__bf__ChildPartial__; }, (_p_, _v_) => { ((__NestedPa__)_p_).__bf__ChildPartial__ = (__Json__)_v_; }, false);
                AddChild = Add<__TLong__>("AddChild$");
                AddChild.DefaultValue = 0L;
                AddChild.Editable = true;
                AddChild.SetCustomAccessors((_p_) => { return ((__NestedPa__)_p_).__bf__AddChild__; }, (_p_, _v_) => { ((__NestedPa__)_p_).__bf__AddChild__ = (System.Int64)_v_; }, false);
                AddChild.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.AddChild() { App = (NestedPartial)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((NestedPartial)pup).Handle((Input.AddChild)input); });
            }
            public override object CreateInstance(s.Json parent) { return new __NestedPa__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Name;
            public __TObject__ ChildPartial;
            public __TLong__ AddChild;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "NestedPartial.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "NestedPartial.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Name__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
    #line 3 "NestedPartial.json"
        get {
        #line hidden
            return Template.Name.Getter(this); }
        #line 3 "NestedPartial.json"
        set {
        #line hidden
            Template.Name.Setter(this, value); } }
        #line default
    #line hidden
    private __Json__ __bf__ChildPartial__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Json__ ChildPartial {
    #line 4 "NestedPartial.json"
        get {
        #line hidden
            return (__Json__)Template.ChildPartial.Getter(this); }
        #line 4 "NestedPartial.json"
        set {
        #line hidden
            Template.ChildPartial.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__AddChild__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 AddChild {
    #line 6 "NestedPartial.json"
        get {
        #line hidden
            return Template.AddChild.Getter(this); }
        #line 6 "NestedPartial.json"
        set {
        #line hidden
            Template.AddChild.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__NestedPa__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Name : Input<__NestedPa__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class AddChild : Input<__NestedPa__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
