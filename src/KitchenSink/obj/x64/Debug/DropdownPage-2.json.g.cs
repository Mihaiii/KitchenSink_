// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "DropdownPage.json"
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
using __DPrName__ = global::KitchenSink.DropdownPage.ProductsElementJson.Input.Name;
using __Dropdown1__ = global::KitchenSink.DropdownPage.JsonByExample;
using __Arr__ = global::Starcounter.Arr<global::KitchenSink.DropdownPage.PetsElementJson>;
using __Arr1__ = global::Starcounter.Arr<global::KitchenSink.DropdownPage.ProductsElementJson>;
using __DrSelected__ = global::KitchenSink.DropdownPage.SelectedProductJson;
using __DrSelected1__ = global::KitchenSink.DropdownPage.SelectedProductJson.JsonByExample;
using __DrSelected2__ = global::KitchenSink.DropdownPage.SelectedProductJson.Input;
using __DSeKey__ = global::KitchenSink.DropdownPage.SelectedProductJson.Input.Key;
using __DSeSchema__ = global::KitchenSink.DropdownPage.SelectedProductJson.JsonByExample.Schema;
using __DSeName__ = global::KitchenSink.DropdownPage.SelectedProductJson.Input.Name;
using __DrHtml__ = global::KitchenSink.DropdownPage.Input.Html;
using __DrSelected3__ = global::KitchenSink.DropdownPage.Input.SelectedPet;
using __DrPetReact__ = global::KitchenSink.DropdownPage.Input.PetReaction;
using __DrSelected4__ = global::KitchenSink.DropdownPage.Input.SelectedProductKey;
using s = Starcounter;
using st = Starcounter.Templates;
using _ScTemplate_ = Starcounter.Templates.Template;
using __Dropdown2__ = global::KitchenSink.DropdownPage.Input;
using __TArray1__ = global::Starcounter.Templates.TArray<global::KitchenSink.DropdownPage.ProductsElementJson>;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __DPrKey__ = global::KitchenSink.DropdownPage.ProductsElementJson.Input.Key;
using __Dropdown__ = global::KitchenSink.DropdownPage;
using __Json__ = global::Starcounter.Json;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __DrSchema__ = global::KitchenSink.DropdownPage.JsonByExample.Schema;
using __TString__ = global::Starcounter.Templates.TString;
using __DrPetsElem__ = global::KitchenSink.DropdownPage.PetsElementJson;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using __DPeSchema__ = global::KitchenSink.DropdownPage.PetsElementJson.JsonByExample.Schema;
using __DrPetsElem2__ = global::KitchenSink.DropdownPage.PetsElementJson.Input;
using __DPeLabel__ = global::KitchenSink.DropdownPage.PetsElementJson.Input.Label;
using __TArray__ = global::Starcounter.Templates.TArray<global::KitchenSink.DropdownPage.PetsElementJson>;
using __DrProducts__ = global::KitchenSink.DropdownPage.ProductsElementJson;
using __DPrSchema__ = global::KitchenSink.DropdownPage.ProductsElementJson.JsonByExample.Schema;
using __DrProducts1__ = global::KitchenSink.DropdownPage.ProductsElementJson.JsonByExample;
using __DrProducts2__ = global::KitchenSink.DropdownPage.ProductsElementJson.Input;
using __DrPetsElem1__ = global::KitchenSink.DropdownPage.PetsElementJson.JsonByExample;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class DropdownPage_json : s::TemplateAttribute {
    
    #line hidden
    public class Pets : s::TemplateAttribute {
    }
    #line default
    
    #line hidden
    public class Products : s::TemplateAttribute {
    }
    #line default
    
    #line hidden
    public class SelectedProduct : s::TemplateAttribute {
    }
    #line default
}
#line default

#line hidden
public partial class DropdownPage : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __DrSchema__ DefaultTemplate = new __DrSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public DropdownPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public DropdownPage(__DrSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __DrSchema__ Template { get { return (__DrSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Dropdown__);
                ClassName = "DropdownPage";
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/KitchenSink/DropdownPage.html";
                Html.SetCustomAccessors((_p_) => { return ((__Dropdown__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Dropdown__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Pets = Add<__TArray__>("Pets");
                Pets.SetCustomGetElementType((arr) => { return __DrPetsElem__.DefaultTemplate;});
                Pets.SetCustomAccessors((_p_) => { return ((__Dropdown__)_p_).__bf__Pets__; }, (_p_, _v_) => { ((__Dropdown__)_p_).__bf__Pets__ = (__Arr__)_v_; }, false);
                SelectedPet = Add<__TString__>("SelectedPet$");
                SelectedPet.DefaultValue = "";
                SelectedPet.Editable = true;
                SelectedPet.SetCustomAccessors((_p_) => { return ((__Dropdown__)_p_).__bf__SelectedPet__; }, (_p_, _v_) => { ((__Dropdown__)_p_).__bf__SelectedPet__ = (System.String)_v_; }, false);
                PetReaction = Add<__TString__>("PetReaction", bind:"CalculatedPetReaction");
                PetReaction.DefaultValue = "";
                PetReaction.SetCustomAccessors((_p_) => { return ((__Dropdown__)_p_).__bf__PetReaction__; }, (_p_, _v_) => { ((__Dropdown__)_p_).__bf__PetReaction__ = (System.String)_v_; }, false);
                Products = Add<__TArray1__>("Products");
                Products.SetCustomGetElementType((arr) => { return __DrProducts__.DefaultTemplate;});
                Products.SetCustomAccessors((_p_) => { return ((__Dropdown__)_p_).__bf__Products__; }, (_p_, _v_) => { ((__Dropdown__)_p_).__bf__Products__ = (__Arr1__)_v_; }, false);
                SelectedProduct = Add<__DSeSchema__>("SelectedProduct");
                SelectedProduct.SetCustomAccessors((_p_) => { return ((__Dropdown__)_p_).__bf__SelectedProduct__; }, (_p_, _v_) => { ((__Dropdown__)_p_).__bf__SelectedProduct__ = (__DrSelected__)_v_; }, false);
                SelectedProductKey = Add<__TString__>("SelectedProductKey$");
                SelectedProductKey.DefaultValue = "";
                SelectedProductKey.Editable = true;
                SelectedProductKey.SetCustomAccessors((_p_) => { return ((__Dropdown__)_p_).__bf__SelectedProductKey__; }, (_p_, _v_) => { ((__Dropdown__)_p_).__bf__SelectedProductKey__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Dropdown__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TArray__ Pets;
            public __TString__ SelectedPet;
            public __TString__ PetReaction;
            public __TArray1__ Products;
            public __DSeSchema__ SelectedProduct;
            public __TString__ SelectedProductKey;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "DropdownPage.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "DropdownPage.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__Pets__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ Pets {
    #line 6 "DropdownPage.json"
        get {
        #line hidden
            return Template.Pets.Getter(this); }
        #line 6 "DropdownPage.json"
        set {
        #line hidden
            Template.Pets.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__SelectedPet__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String SelectedPet {
    #line 7 "DropdownPage.json"
        get {
        #line hidden
            return Template.SelectedPet.Getter(this); }
        #line 7 "DropdownPage.json"
        set {
        #line hidden
            Template.SelectedPet.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__PetReaction__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String PetReaction {
    #line 9 "DropdownPage.json"
        get {
        #line hidden
            return Template.PetReaction.Getter(this); }
        #line 9 "DropdownPage.json"
        set {
        #line hidden
            Template.PetReaction.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr1__ __bf__Products__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr1__ Products {
    #line 17 "DropdownPage.json"
        get {
        #line hidden
            return Template.Products.Getter(this); }
        #line 17 "DropdownPage.json"
        set {
        #line hidden
            Template.Products.Setter(this, value); } }
        #line default
    #line hidden
    private __DrSelected__ __bf__SelectedProduct__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __DrSelected__ SelectedProduct {
    #line 21 "DropdownPage.json"
        get {
        #line hidden
            return (__DrSelected__)Template.SelectedProduct.Getter(this); }
        #line 21 "DropdownPage.json"
        set {
        #line hidden
            Template.SelectedProduct.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__SelectedProductKey__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String SelectedProductKey {
    #line 23 "DropdownPage.json"
        get {
        #line hidden
            return Template.SelectedProductKey.Getter(this); }
        #line 23 "DropdownPage.json"
        set {
        #line hidden
            Template.SelectedProductKey.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class PetsElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __DPeSchema__ DefaultTemplate = new __DPeSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public PetsElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public PetsElementJson(__DPeSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __DPeSchema__ Template { get { return (__DPeSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__DrPetsElem__);
                    ClassName = "PetsElementJson";
                    Properties.ClearExposed();
                    Label = Add<__TString__>("Label");
                    Label.DefaultValue = "";
                    Label.SetCustomAccessors((_p_) => { return ((__DrPetsElem__)_p_).__bf__Label__; }, (_p_, _v_) => { ((__DrPetsElem__)_p_).__bf__Label__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __DrPetsElem__(this) { Parent = parent }; }
                public __TString__ Label;
            }
            #line default
        }
        #line default
        #line hidden
        private System.String __bf__Label__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Label {
        #line 5 "DropdownPage.json"
            get {
            #line hidden
                return Template.Label.Getter(this); }
            #line 5 "DropdownPage.json"
            set {
            #line hidden
                Template.Label.Setter(this, value); } }
            #line default
        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Label : Input<__DrPetsElem__, __TString__, string> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class ProductsElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __DPrSchema__ DefaultTemplate = new __DPrSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public ProductsElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public ProductsElementJson(__DPrSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __DPrSchema__ Template { get { return (__DPrSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__DrProducts__);
                    ClassName = "ProductsElementJson";
                    Properties.ClearExposed();
                    Key = Add<__TString__>("Key");
                    Key.DefaultValue = "";
                    Key.SetCustomAccessors((_p_) => { return ((__DrProducts__)_p_).__bf__Key__; }, (_p_, _v_) => { ((__DrProducts__)_p_).__bf__Key__ = (System.String)_v_; }, false);
                    Name = Add<__TString__>("Name");
                    Name.DefaultValue = "";
                    Name.SetCustomAccessors((_p_) => { return ((__DrProducts__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__DrProducts__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __DrProducts__(this) { Parent = parent }; }
                public __TString__ Key;
                public __TString__ Name;
            }
            #line default
        }
        #line default
        #line hidden
        private System.String __bf__Key__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Key {
        #line 14 "DropdownPage.json"
            get {
            #line hidden
                return Template.Key.Getter(this); }
            #line 14 "DropdownPage.json"
            set {
            #line hidden
                Template.Key.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__Name__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Name {
        #line 16 "DropdownPage.json"
            get {
            #line hidden
                return Template.Name.Getter(this); }
            #line 16 "DropdownPage.json"
            set {
            #line hidden
                Template.Name.Setter(this, value); } }
            #line default
        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Key : Input<__DrProducts__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Name : Input<__DrProducts__, __TString__, string> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class SelectedProductJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __DSeSchema__ DefaultTemplate = new __DSeSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public SelectedProductJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public SelectedProductJson(__DSeSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __DSeSchema__ Template { get { return (__DSeSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__DrSelected__);
                    ClassName = "SelectedProductJson";
                    Properties.ClearExposed();
                    Key = Add<__TString__>("Key");
                    Key.DefaultValue = "";
                    Key.SetCustomAccessors((_p_) => { return ((__DrSelected__)_p_).__bf__Key__; }, (_p_, _v_) => { ((__DrSelected__)_p_).__bf__Key__ = (System.String)_v_; }, false);
                    Name = Add<__TString__>("Name");
                    Name.DefaultValue = "";
                    Name.SetCustomAccessors((_p_) => { return ((__DrSelected__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__DrSelected__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __DrSelected__(this) { Parent = parent }; }
                public __TString__ Key;
                public __TString__ Name;
            }
            #line default
        }
        #line default
        #line hidden
        private System.String __bf__Key__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Key {
        #line 19 "DropdownPage.json"
            get {
            #line hidden
                return Template.Key.Getter(this); }
            #line 19 "DropdownPage.json"
            set {
            #line hidden
                Template.Key.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__Name__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Name {
        #line 21 "DropdownPage.json"
            get {
            #line hidden
                return Template.Name.Getter(this); }
            #line 21 "DropdownPage.json"
            set {
            #line hidden
                Template.Name.Setter(this, value); } }
            #line default
        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Key : Input<__DrSelected__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Name : Input<__DrSelected__, __TString__, string> {
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
        public class Html : Input<__Dropdown__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SelectedPet : Input<__Dropdown__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class PetReaction : Input<__Dropdown__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SelectedProductKey : Input<__Dropdown__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
