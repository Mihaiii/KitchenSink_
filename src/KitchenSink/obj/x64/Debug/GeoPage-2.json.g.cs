// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "GeoPage.json"
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
using __GeoPage1__ = global::KitchenSink.GeoPage.JsonByExample;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __GeHtml__ = global::KitchenSink.GeoPage.Input.Html;
using __GeoPage2__ = global::KitchenSink.GeoPage.Input;
using __GeReset__ = global::KitchenSink.GeoPagePosition.Input.Reset;
using __GeLongitud__ = global::KitchenSink.GeoPagePosition.Input.Longitude;
using __GeLatitude__ = global::KitchenSink.GeoPagePosition.Input.Latitude;
using __GeoPageP2__ = global::KitchenSink.GeoPagePosition.Input;
using __GeoPageP1__ = global::KitchenSink.GeoPagePosition.JsonByExample;
using __GeoPageP__ = global::KitchenSink.GeoPagePosition;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TDouble__ = global::Starcounter.Templates.TDouble;
using __GeSchema1__ = global::KitchenSink.GeoPagePosition.JsonByExample.Schema;
using __TString__ = global::Starcounter.Templates.TString;
using __GeSchema__ = global::KitchenSink.GeoPage.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __GeoPage__ = global::KitchenSink.GeoPage;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class GeoPage_json : s::TemplateAttribute {
    
    #line hidden
    public class Position : s::TemplateAttribute {
    }
    #line default
}
#line default

#line hidden
public partial class GeoPagePosition : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __GeSchema1__ DefaultTemplate = new __GeSchema1__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public GeoPagePosition() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public GeoPagePosition(__GeSchema1__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __GeSchema1__ Template { get { return (__GeSchema1__)base.Template; } set { base.Template = value; } }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new GeoCoordinates Data { get { return (GeoCoordinates)base.Data; } set { base.Data = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__GeoPageP__);
                ClassName = "GeoPagePosition";
                Properties.ClearExposed();
                Latitude = Add<__TDouble__>("Latitude$");
                Latitude.DefaultValue = 0d;
                Latitude.Editable = true;
                Latitude.SetCustomAccessors((_p_) => { return ((__GeoPageP__)_p_).__bf__Latitude__; }, (_p_, _v_) => { ((__GeoPageP__)_p_).__bf__Latitude__ = (System.Double)_v_; }, false);
                Latitude.AddHandler((Json pup, Property<Double> prop, Double value) => { return (new Input.Latitude() { App = (GeoPagePosition)pup, Template = (TDouble)prop, Value = value }); }, (Json pup, Starcounter.Input<Double> input) => { ((GeoPagePosition)pup).Handle((Input.Latitude)input); });
                Longitude = Add<__TDouble__>("Longitude$");
                Longitude.DefaultValue = 0d;
                Longitude.Editable = true;
                Longitude.SetCustomAccessors((_p_) => { return ((__GeoPageP__)_p_).__bf__Longitude__; }, (_p_, _v_) => { ((__GeoPageP__)_p_).__bf__Longitude__ = (System.Double)_v_; }, false);
                Longitude.AddHandler((Json pup, Property<Double> prop, Double value) => { return (new Input.Longitude() { App = (GeoPagePosition)pup, Template = (TDouble)prop, Value = value }); }, (Json pup, Starcounter.Input<Double> input) => { ((GeoPagePosition)pup).Handle((Input.Longitude)input); });
                Reset = Add<__TLong__>("Reset$");
                Reset.DefaultValue = 0L;
                Reset.Editable = true;
                Reset.SetCustomAccessors((_p_) => { return ((__GeoPageP__)_p_).__bf__Reset__; }, (_p_, _v_) => { ((__GeoPageP__)_p_).__bf__Reset__ = (System.Int64)_v_; }, false);
                Reset.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.Reset() { App = (GeoPagePosition)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((GeoPagePosition)pup).Handle((Input.Reset)input); });
            }
            public override object CreateInstance(s.Json parent) { return new __GeoPageP__(this) { Parent = parent }; }
            public __TDouble__ Latitude;
            public __TDouble__ Longitude;
            public __TLong__ Reset;
        }
        #line default
    }
    #line default
    #line hidden
    private System.Double __bf__Latitude__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Double Latitude {
    #line 5 "GeoPage.json"
        get {
        #line hidden
            return Template.Latitude.Getter(this); }
        #line 5 "GeoPage.json"
        set {
        #line hidden
            Template.Latitude.Setter(this, value); } }
        #line default
    #line hidden
    private System.Double __bf__Longitude__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Double Longitude {
    #line 6 "GeoPage.json"
        get {
        #line hidden
            return Template.Longitude.Getter(this); }
        #line 6 "GeoPage.json"
        set {
        #line hidden
            Template.Longitude.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Reset__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Reset {
    #line 8 "GeoPage.json"
        get {
        #line hidden
            return Template.Reset.Getter(this); }
        #line 8 "GeoPage.json"
        set {
        #line hidden
            Template.Reset.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Latitude : Input<__GeoPageP__, __TDouble__, Double> {
        }
        #line default
        
        #line hidden
        public class Longitude : Input<__GeoPageP__, __TDouble__, Double> {
        }
        #line default
        
        #line hidden
        public class Reset : Input<__GeoPageP__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default

#line hidden
public partial class GeoPage : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __GeSchema__ DefaultTemplate = new __GeSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public GeoPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public GeoPage(__GeSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __GeSchema__ Template { get { return (__GeSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__GeoPage__);
                ClassName = "GeoPage";
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/KitchenSink/GeoPage.html";
                Html.SetCustomAccessors((_p_) => { return ((__GeoPage__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__GeoPage__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Position = Add<__GeSchema1__>("Position");
                Position.SetCustomAccessors((_p_) => { return ((__GeoPage__)_p_).__bf__Position__; }, (_p_, _v_) => { ((__GeoPage__)_p_).__bf__Position__ = (__GeoPageP__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __GeoPage__(this) { Parent = parent }; }
            public __TString__ Html;
            public __GeSchema1__ Position;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "GeoPage.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "GeoPage.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private __GeoPageP__ __bf__Position__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __GeoPageP__ Position {
    #line 9 "GeoPage.json"
        get {
        #line hidden
            return (__GeoPageP__)Template.Position.Getter(this); }
        #line 9 "GeoPage.json"
        set {
        #line hidden
            Template.Position.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__GeoPage__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
