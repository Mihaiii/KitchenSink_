// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "MultiselectPage.json"
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
using __MuCountrie2__ = global::KitchenSink.MultiselectPage.CountriesElementJson.Input;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __MuFavorite__ = global::KitchenSink.MultiselectPage.Input.FavoriteCountry;
using __MuHtml__ = global::KitchenSink.MultiselectPage.Input.Html;
using __Multisel2__ = global::KitchenSink.MultiselectPage.Input;
using __Arr__ = global::Starcounter.Arr<global::KitchenSink.MultiselectPage.CountriesElementJson>;
using __Multisel1__ = global::KitchenSink.MultiselectPage.JsonByExample;
using __TArray__ = global::Starcounter.Templates.TArray<global::KitchenSink.MultiselectPage.CountriesElementJson>;
using __MCoSelected__ = global::KitchenSink.MultiselectPage.CountriesElementJson.Input.Selected;
using __MCoName__ = global::KitchenSink.MultiselectPage.CountriesElementJson.Input.Name;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __MuCountrie1__ = global::KitchenSink.MultiselectPage.CountriesElementJson.JsonByExample;
using __TBool__ = global::Starcounter.Templates.TBool;
using __MCoSchema__ = global::KitchenSink.MultiselectPage.CountriesElementJson.JsonByExample.Schema;
using __MuCountrie__ = global::KitchenSink.MultiselectPage.CountriesElementJson;
using __TString__ = global::Starcounter.Templates.TString;
using __MuSchema__ = global::KitchenSink.MultiselectPage.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Multisel__ = global::KitchenSink.MultiselectPage;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class MultiselectPage_json : s::TemplateAttribute {
    
    #line hidden
    public class Countries : s::TemplateAttribute {
    }
    #line default
}
#line default

#line hidden
public partial class MultiselectPage : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __MuSchema__ DefaultTemplate = new __MuSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public MultiselectPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public MultiselectPage(__MuSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __MuSchema__ Template { get { return (__MuSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Multisel__);
                ClassName = "MultiselectPage";
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/KitchenSink/MultiselectPage.html";
                Html.SetCustomAccessors((_p_) => { return ((__Multisel__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Multisel__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Countries = Add<__TArray__>("Countries");
                Countries.SetCustomGetElementType((arr) => { return __MuCountrie__.DefaultTemplate;});
                Countries.SetCustomAccessors((_p_) => { return ((__Multisel__)_p_).__bf__Countries__; }, (_p_, _v_) => { ((__Multisel__)_p_).__bf__Countries__ = (__Arr__)_v_; }, false);
                FavoriteCountry = Add<__TString__>("FavoriteCountry$");
                FavoriteCountry.DefaultValue = "";
                FavoriteCountry.Editable = true;
                FavoriteCountry.SetCustomAccessors((_p_) => { return ((__Multisel__)_p_).__bf__FavoriteCountry__; }, (_p_, _v_) => { ((__Multisel__)_p_).__bf__FavoriteCountry__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Multisel__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TArray__ Countries;
            public __TString__ FavoriteCountry;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "MultiselectPage.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "MultiselectPage.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__Countries__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ Countries {
    #line 8 "MultiselectPage.json"
        get {
        #line hidden
            return Template.Countries.Getter(this); }
        #line 8 "MultiselectPage.json"
        set {
        #line hidden
            Template.Countries.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__FavoriteCountry__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String FavoriteCountry {
    #line 10 "MultiselectPage.json"
        get {
        #line hidden
            return Template.FavoriteCountry.Getter(this); }
        #line 10 "MultiselectPage.json"
        set {
        #line hidden
            Template.FavoriteCountry.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class CountriesElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __MCoSchema__ DefaultTemplate = new __MCoSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public CountriesElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public CountriesElementJson(__MCoSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __MCoSchema__ Template { get { return (__MCoSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__MuCountrie__);
                    ClassName = "CountriesElementJson";
                    Properties.ClearExposed();
                    Name = Add<__TString__>("Name");
                    Name.DefaultValue = "";
                    Name.SetCustomAccessors((_p_) => { return ((__MuCountrie__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__MuCountrie__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                    Selected = Add<__TBool__>("Selected$");
                    Selected.DefaultValue = false;
                    Selected.Editable = true;
                    Selected.SetCustomAccessors((_p_) => { return ((__MuCountrie__)_p_).__bf__Selected__; }, (_p_, _v_) => { ((__MuCountrie__)_p_).__bf__Selected__ = (System.Boolean)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __MuCountrie__(this) { Parent = parent }; }
                public __TString__ Name;
                public __TBool__ Selected;
            }
            #line default
        }
        #line default
        #line hidden
        private System.String __bf__Name__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Name {
        #line 5 "MultiselectPage.json"
            get {
            #line hidden
                return Template.Name.Getter(this); }
            #line 5 "MultiselectPage.json"
            set {
            #line hidden
                Template.Name.Setter(this, value); } }
            #line default
        #line hidden
        private System.Boolean __bf__Selected__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Boolean Selected {
        #line 123 "JOCKE4"
            get {
            #line hidden
                return Template.Selected.Getter(this); }
            #line 123 "JOCKE4"
            set {
            #line hidden
                Template.Selected.Setter(this, value); } }
            #line default
        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Name : Input<__MuCountrie__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Selected : Input<__MuCountrie__, __TBool__, bool> {
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
        public class Html : Input<__Multisel__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class FavoriteCountry : Input<__Multisel__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
