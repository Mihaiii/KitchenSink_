// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "AutocompletePage.json"
// Version: 2
// DO NOT MODIFY DIRECTLY - CHANGES WILL BE OVERWRITTEN

using System;
using System.Collections;
using System.Collections.Generic;
using Starcounter.Advanced;
using Starcounter;
using Starcounter.Internal;
using Starcounter.Templates;
using System.Linq;
#pragma warning disable 0108
#pragma warning disable 1591

namespace KitchenSink {
using __AuFoundPro2__ = global::KitchenSink.AutocompletePage.FoundProductsItem.Input;
using __AFoSelect1__ = global::KitchenSink.AutocompletePage.FoundProductsItem.Input.Select;
using __TArray1__ = global::Starcounter.Templates.TArray<global::KitchenSink.AutocompletePage.FoundProductsItem>;
using __Autocomp1__ = global::KitchenSink.AutocompletePage.JsonByExample;
using __Arr__ = global::Starcounter.Arr<global::KitchenSink.AutocompletePage.FoundPlacesItem>;
using __Arr1__ = global::Starcounter.Arr<global::KitchenSink.AutocompletePage.FoundProductsItem>;
using __Autocomp2__ = global::KitchenSink.AutocompletePage.Input;
using __AuHtml__ = global::KitchenSink.AutocompletePage.Input.Html;
using __AFoPrice__ = global::KitchenSink.AutocompletePage.FoundProductsItem.Input.Price;
using __AuPlacesSe__ = global::KitchenSink.AutocompletePage.Input.PlacesSearch;
using __AuClearPla__ = global::KitchenSink.AutocompletePage.Input.ClearPlaces;
using __AuProducts__ = global::KitchenSink.AutocompletePage.Input.ProductsSearch;
using __AuProducts1__ = global::KitchenSink.AutocompletePage.Input.ProductsText;
using __AuClearPro__ = global::KitchenSink.AutocompletePage.Input.ClearProducts;
using s = Starcounter;
using st = Starcounter.Templates;
using _ScTemplate_ = Starcounter.Templates.Template;
using __AuPlacesTe__ = global::KitchenSink.AutocompletePage.Input.PlacesText;
using __AFoName1__ = global::KitchenSink.AutocompletePage.FoundProductsItem.Input.Name;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __AuFoundPro1__ = global::KitchenSink.AutocompletePage.FoundProductsItem.JsonByExample;
using __Autocomp__ = global::KitchenSink.AutocompletePage;
using __AuSchema__ = global::KitchenSink.AutocompletePage.JsonByExample.Schema;
using __TString__ = global::Starcounter.Templates.TString;
using __TLong__ = global::Starcounter.Templates.TLong;
using __AuFoundPla__ = global::KitchenSink.AutocompletePage.FoundPlacesItem;
using __Json__ = global::Starcounter.Json;
using __TObject__ = global::Starcounter.Templates.TObject;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __AuFoundPla1__ = global::KitchenSink.AutocompletePage.FoundPlacesItem.JsonByExample;
using __AuFoundPla2__ = global::KitchenSink.AutocompletePage.FoundPlacesItem.Input;
using __AFoName__ = global::KitchenSink.AutocompletePage.FoundPlacesItem.Input.Name;
using __AFoSelect__ = global::KitchenSink.AutocompletePage.FoundPlacesItem.Input.Select;
using __TArray__ = global::Starcounter.Templates.TArray<global::KitchenSink.AutocompletePage.FoundPlacesItem>;
using __AuFoundPro__ = global::KitchenSink.AutocompletePage.FoundProductsItem;
using __AFoSchema1__ = global::KitchenSink.AutocompletePage.FoundProductsItem.JsonByExample.Schema;
using __AFoSchema__ = global::KitchenSink.AutocompletePage.FoundPlacesItem.JsonByExample.Schema;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class AutocompletePage_json : s::TemplateAttribute {
    
    #line hidden
    public class FoundPlaces : s::TemplateAttribute {
    }
    #line default
    
    #line hidden
    public class FoundProducts : s::TemplateAttribute {
    }
    #line default
}
#line default

#line hidden
public partial class AutocompletePage : Partial {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __AuSchema__ DefaultTemplate = new __AuSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public AutocompletePage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public AutocompletePage(__AuSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __AuSchema__ Template { get { return (__AuSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : Partial.JsonByExample.Schema {
            public Schema()
                : base() {
                InstanceType = typeof(__Autocomp__);
                ClassName = "AutocompletePage";
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/KitchenSink/AutocompletePage.html";
                Html.SetCustomAccessors((_p_) => { return ((__Autocomp__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Autocomp__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                PlacesSearch = Add<__TString__>("PlacesSearch$");
                PlacesSearch.DefaultValue = "";
                PlacesSearch.Editable = true;
                PlacesSearch.SetCustomAccessors((_p_) => { return ((__Autocomp__)_p_).__bf__PlacesSearch__; }, (_p_, _v_) => { ((__Autocomp__)_p_).__bf__PlacesSearch__ = (System.String)_v_; }, false);
                PlacesSearch.AddHandler((Json pup, Property<String> prop, String value) => { return (new Input.PlacesSearch() { App = (AutocompletePage)pup, Template = (TString)prop, Value = value }); }, (Json pup, Starcounter.Input<String> input) => { ((AutocompletePage)pup).Handle((Input.PlacesSearch)input); });
                PlacesText = Add<__TString__>("PlacesText");
                PlacesText.DefaultValue = "";
                PlacesText.SetCustomAccessors((_p_) => { return ((__Autocomp__)_p_).__bf__PlacesText__; }, (_p_, _v_) => { ((__Autocomp__)_p_).__bf__PlacesText__ = (System.String)_v_; }, false);
                ClearPlaces = Add<__TLong__>("ClearPlaces$");
                ClearPlaces.DefaultValue = 0L;
                ClearPlaces.Editable = true;
                ClearPlaces.SetCustomAccessors((_p_) => { return ((__Autocomp__)_p_).__bf__ClearPlaces__; }, (_p_, _v_) => { ((__Autocomp__)_p_).__bf__ClearPlaces__ = (System.Int64)_v_; }, false);
                ClearPlaces.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.ClearPlaces() { App = (AutocompletePage)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((AutocompletePage)pup).Handle((Input.ClearPlaces)input); });
                FoundPlaces = Add<__TArray__>("FoundPlaces");
                FoundPlaces.SetCustomGetElementType((arr) => { return __AuFoundPla__.DefaultTemplate;});
                FoundPlaces.SetCustomAccessors((_p_) => { return ((__Autocomp__)_p_).__bf__FoundPlaces__; }, (_p_, _v_) => { ((__Autocomp__)_p_).__bf__FoundPlaces__ = (__Arr__)_v_; }, false);
                ProductsSearch = Add<__TString__>("ProductsSearch$");
                ProductsSearch.DefaultValue = "";
                ProductsSearch.Editable = true;
                ProductsSearch.SetCustomAccessors((_p_) => { return ((__Autocomp__)_p_).__bf__ProductsSearch__; }, (_p_, _v_) => { ((__Autocomp__)_p_).__bf__ProductsSearch__ = (System.String)_v_; }, false);
                ProductsSearch.AddHandler((Json pup, Property<String> prop, String value) => { return (new Input.ProductsSearch() { App = (AutocompletePage)pup, Template = (TString)prop, Value = value }); }, (Json pup, Starcounter.Input<String> input) => { ((AutocompletePage)pup).Handle((Input.ProductsSearch)input); });
                ProductsText = Add<__TString__>("ProductsText");
                ProductsText.DefaultValue = "";
                ProductsText.SetCustomAccessors((_p_) => { return ((__Autocomp__)_p_).__bf__ProductsText__; }, (_p_, _v_) => { ((__Autocomp__)_p_).__bf__ProductsText__ = (System.String)_v_; }, false);
                ClearProducts = Add<__TLong__>("ClearProducts$");
                ClearProducts.DefaultValue = 0L;
                ClearProducts.Editable = true;
                ClearProducts.SetCustomAccessors((_p_) => { return ((__Autocomp__)_p_).__bf__ClearProducts__; }, (_p_, _v_) => { ((__Autocomp__)_p_).__bf__ClearProducts__ = (System.Int64)_v_; }, false);
                ClearProducts.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.ClearProducts() { App = (AutocompletePage)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((AutocompletePage)pup).Handle((Input.ClearProducts)input); });
                FoundProducts = Add<__TArray1__>("FoundProducts");
                FoundProducts.SetCustomGetElementType((arr) => { return __AuFoundPro__.DefaultTemplate;});
                FoundProducts.SetCustomAccessors((_p_) => { return ((__Autocomp__)_p_).__bf__FoundProducts__; }, (_p_, _v_) => { ((__Autocomp__)_p_).__bf__FoundProducts__ = (__Arr1__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Autocomp__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ PlacesSearch;
            public __TString__ PlacesText;
            public __TLong__ ClearPlaces;
            public __TArray__ FoundPlaces;
            public __TString__ ProductsSearch;
            public __TString__ ProductsText;
            public __TLong__ ClearProducts;
            public __TArray1__ FoundProducts;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "AutocompletePage.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "AutocompletePage.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__PlacesSearch__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String PlacesSearch {
    #line 4 "AutocompletePage.json"
        get {
        #line hidden
            return Template.PlacesSearch.Getter(this); }
        #line 4 "AutocompletePage.json"
        set {
        #line hidden
            Template.PlacesSearch.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__PlacesText__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String PlacesText {
    #line 5 "AutocompletePage.json"
        get {
        #line hidden
            return Template.PlacesText.Getter(this); }
        #line 5 "AutocompletePage.json"
        set {
        #line hidden
            Template.PlacesText.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__ClearPlaces__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 ClearPlaces {
    #line 6 "AutocompletePage.json"
        get {
        #line hidden
            return Template.ClearPlaces.Getter(this); }
        #line 6 "AutocompletePage.json"
        set {
        #line hidden
            Template.ClearPlaces.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__FoundPlaces__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ FoundPlaces {
    #line 12 "AutocompletePage.json"
        get {
        #line hidden
            return Template.FoundPlaces.Getter(this); }
        #line 12 "AutocompletePage.json"
        set {
        #line hidden
            Template.FoundPlaces.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__ProductsSearch__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String ProductsSearch {
    #line 13 "AutocompletePage.json"
        get {
        #line hidden
            return Template.ProductsSearch.Getter(this); }
        #line 13 "AutocompletePage.json"
        set {
        #line hidden
            Template.ProductsSearch.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__ProductsText__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String ProductsText {
    #line 14 "AutocompletePage.json"
        get {
        #line hidden
            return Template.ProductsText.Getter(this); }
        #line 14 "AutocompletePage.json"
        set {
        #line hidden
            Template.ProductsText.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__ClearProducts__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 ClearProducts {
    #line 15 "AutocompletePage.json"
        get {
        #line hidden
            return Template.ClearProducts.Getter(this); }
        #line 15 "AutocompletePage.json"
        set {
        #line hidden
            Template.ClearProducts.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr1__ __bf__FoundProducts__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr1__ FoundProducts {
    #line 23 "AutocompletePage.json"
        get {
        #line hidden
            return Template.FoundProducts.Getter(this); }
        #line 23 "AutocompletePage.json"
        set {
        #line hidden
            Template.FoundProducts.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Autocomp__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class PlacesSearch : Input<__Autocomp__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class PlacesText : Input<__Autocomp__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class ClearPlaces : Input<__Autocomp__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class ProductsSearch : Input<__Autocomp__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class ProductsText : Input<__Autocomp__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class ClearProducts : Input<__Autocomp__, __TLong__, long> {
        }
        #line default
    }
    #line default
    
    #line hidden
    public partial class FoundProductsItem : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __AFoSchema1__ DefaultTemplate = new __AFoSchema1__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public FoundProductsItem() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public FoundProductsItem(__AFoSchema1__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __AFoSchema1__ Template { get { return (__AFoSchema1__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class JsonByExample {
            
            #line hidden
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__AuFoundPro__);
                    ClassName = "FoundProductsItem";
                    Properties.ClearExposed();
                    Name = Add<__TString__>("Name");
                    Name.DefaultValue = "";
                    Name.SetCustomAccessors((_p_) => { return ((__AuFoundPro__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__AuFoundPro__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                    Price = Add<__TLong__>("Price");
                    Price.DefaultValue = 0L;
                    Price.SetCustomAccessors((_p_) => { return ((__AuFoundPro__)_p_).__bf__Price__; }, (_p_, _v_) => { ((__AuFoundPro__)_p_).__bf__Price__ = (System.Int64)_v_; }, false);
                    Select = Add<__TLong__>("Select$");
                    Select.DefaultValue = 0L;
                    Select.Editable = true;
                    Select.SetCustomAccessors((_p_) => { return ((__AuFoundPro__)_p_).__bf__Select__; }, (_p_, _v_) => { ((__AuFoundPro__)_p_).__bf__Select__ = (System.Int64)_v_; }, false);
                    Select.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.Select() { App = (FoundProductsItem)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((FoundProductsItem)pup).Handle((Input.Select)input); });
                }
                public override object CreateInstance(s.Json parent) { return new __AuFoundPro__(this) { Parent = parent }; }
                public __TString__ Name;
                public __TLong__ Price;
                public __TLong__ Select;
            }
            #line default
        }
        #line default
        #line hidden
        private System.String __bf__Name__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Name {
        #line 18 "AutocompletePage.json"
            get {
            #line hidden
                return Template.Name.Getter(this); }
            #line 18 "AutocompletePage.json"
            set {
            #line hidden
                Template.Name.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__Price__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 Price {
        #line 19 "AutocompletePage.json"
            get {
            #line hidden
                return Template.Price.Getter(this); }
            #line 19 "AutocompletePage.json"
            set {
            #line hidden
                Template.Price.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__Select__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 Select {
        #line 21 "AutocompletePage.json"
            get {
            #line hidden
                return Template.Select.Getter(this); }
            #line 21 "AutocompletePage.json"
            set {
            #line hidden
                Template.Select.Setter(this, value); } }
            #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class Input {
            
            #line hidden
            public class Name : Input<__AuFoundPro__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class Price : Input<__AuFoundPro__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class Select : Input<__AuFoundPro__, __TLong__, long> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    public partial class FoundPlacesItem : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __AFoSchema__ DefaultTemplate = new __AFoSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public FoundPlacesItem() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public FoundPlacesItem(__AFoSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __AFoSchema__ Template { get { return (__AFoSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class JsonByExample {
            
            #line hidden
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__AuFoundPla__);
                    ClassName = "FoundPlacesItem";
                    Properties.ClearExposed();
                    Name = Add<__TString__>("Name");
                    Name.DefaultValue = "";
                    Name.SetCustomAccessors((_p_) => { return ((__AuFoundPla__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__AuFoundPla__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                    Select = Add<__TLong__>("Select$");
                    Select.DefaultValue = 0L;
                    Select.Editable = true;
                    Select.SetCustomAccessors((_p_) => { return ((__AuFoundPla__)_p_).__bf__Select__; }, (_p_, _v_) => { ((__AuFoundPla__)_p_).__bf__Select__ = (System.Int64)_v_; }, false);
                    Select.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.Select() { App = (FoundPlacesItem)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((FoundPlacesItem)pup).Handle((Input.Select)input); });
                }
                public override object CreateInstance(s.Json parent) { return new __AuFoundPla__(this) { Parent = parent }; }
                public __TString__ Name;
                public __TLong__ Select;
            }
            #line default
        }
        #line default
        #line hidden
        private System.String __bf__Name__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Name {
        #line 9 "AutocompletePage.json"
            get {
            #line hidden
                return Template.Name.Getter(this); }
            #line 9 "AutocompletePage.json"
            set {
            #line hidden
                Template.Name.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__Select__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 Select {
        #line 11 "AutocompletePage.json"
            get {
            #line hidden
                return Template.Select.Getter(this); }
            #line 11 "AutocompletePage.json"
            set {
            #line hidden
                Template.Select.Setter(this, value); } }
            #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class Input {
            
            #line hidden
            public class Name : Input<__AuFoundPla__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class Select : Input<__AuFoundPla__, __TLong__, long> {
            }
            #line default
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
