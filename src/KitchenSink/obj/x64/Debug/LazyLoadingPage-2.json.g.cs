// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "LazyLoadingPage.json"
// Version: 2
// DO NOT MODIFY DIRECTLY - CHANGES WILL BE OVERWRITTEN

using System;
using System.Collections;
using System.Collections.Generic;
using Starcounter.Advanced;
using Starcounter;
using Starcounter.Internal;
using Starcounter.Templates;
using System.Threading;
#pragma warning disable 0108
#pragma warning disable 1591

namespace KitchenSink {
using __LLaIsHovere__ = global::KitchenSink.LazyLoadingPage.LazyLoadingPagePeople.Input.IsHovered;
using __TArray__ = global::Starcounter.Templates.TArray<global::KitchenSink.LazyLoadingPage.LazyLoadingPagePeople>;
using __LDiSchema__ = global::KitchenSink.LazyLoadingPage.DisplayedDataJson.JsonByExample.Schema;
using __LazyLoad1__ = global::KitchenSink.LazyLoadingPage.JsonByExample;
using __Arr__ = global::Starcounter.Arr<global::KitchenSink.LazyLoadingPage.LazyLoadingPagePeople>;
using __LaDisplaye__ = global::KitchenSink.LazyLoadingPage.DisplayedDataJson;
using __LaDisplaye1__ = global::KitchenSink.LazyLoadingPage.DisplayedDataJson.JsonByExample;
using __LaDisplaye2__ = global::KitchenSink.LazyLoadingPage.DisplayedDataJson.Input;
using __LDiDataCont__ = global::KitchenSink.LazyLoadingPage.DisplayedDataJson.Input.DataContent;
using __LazyLoad2__ = global::KitchenSink.LazyLoadingPage.Input;
using __LaHtml__ = global::KitchenSink.LazyLoadingPage.Input.Html;
using __LaSelected__ = global::KitchenSink.LazyLoadingPage.Input.SelectedPersonsName;
using __LaDisplayH__ = global::KitchenSink.LazyLoadingPage.Input.DisplayHoverBox;
using s = Starcounter;
using st = Starcounter.Templates;
using _ScTemplate_ = Starcounter.Templates.Template;
using __LLaDataToSh__ = global::KitchenSink.LazyLoadingPage.LazyLoadingPagePeople.Input.DataToShow;
using __LLaDataIsLo__ = global::KitchenSink.LazyLoadingPage.LazyLoadingPagePeople.Input.DataIsLoaded;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __LLaFavorite__ = global::KitchenSink.LazyLoadingPage.LazyLoadingPagePeople.Input.FavoriteGame;
using __LazyLoad__ = global::KitchenSink.LazyLoadingPage;
using __Json__ = global::Starcounter.Json;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __LaSchema__ = global::KitchenSink.LazyLoadingPage.JsonByExample.Schema;
using __TString__ = global::Starcounter.Templates.TString;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using __LaLazyLoad__ = global::KitchenSink.LazyLoadingPage.LazyLoadingPagePeople;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TBool__ = global::Starcounter.Templates.TBool;
using __LaLazyLoad1__ = global::KitchenSink.LazyLoadingPage.LazyLoadingPagePeople.JsonByExample;
using __LaLazyLoad2__ = global::KitchenSink.LazyLoadingPage.LazyLoadingPagePeople.Input;
using __LLaOrder__ = global::KitchenSink.LazyLoadingPage.LazyLoadingPagePeople.Input.Order;
using __LLaFirstNam__ = global::KitchenSink.LazyLoadingPage.LazyLoadingPagePeople.Input.FirstName;
using __LLaLastName__ = global::KitchenSink.LazyLoadingPage.LazyLoadingPagePeople.Input.LastName;
using __LLaSchema__ = global::KitchenSink.LazyLoadingPage.LazyLoadingPagePeople.JsonByExample.Schema;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class LazyLoadingPage_json : s::TemplateAttribute {
    
    #line hidden
    public class People : s::TemplateAttribute {
    }
    #line default
    
    #line hidden
    public class DisplayedData : s::TemplateAttribute {
    }
    #line default
}
#line default

#line hidden
public partial class LazyLoadingPage : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __LaSchema__ DefaultTemplate = new __LaSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public LazyLoadingPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public LazyLoadingPage(__LaSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __LaSchema__ Template { get { return (__LaSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__LazyLoad__);
                ClassName = "LazyLoadingPage";
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/Kitchensink/LazyLoadingPage.html";
                Html.SetCustomAccessors((_p_) => { return ((__LazyLoad__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__LazyLoad__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                People = Add<__TArray__>("People");
                People.SetCustomGetElementType((arr) => { return __LaLazyLoad__.DefaultTemplate;});
                People.SetCustomAccessors((_p_) => { return ((__LazyLoad__)_p_).__bf__People__; }, (_p_, _v_) => { ((__LazyLoad__)_p_).__bf__People__ = (__Arr__)_v_; }, false);
                SelectedPersonsName = Add<__TString__>("SelectedPersonsName$");
                SelectedPersonsName.DefaultValue = "";
                SelectedPersonsName.Editable = true;
                SelectedPersonsName.SetCustomAccessors((_p_) => { return ((__LazyLoad__)_p_).__bf__SelectedPersonsName__; }, (_p_, _v_) => { ((__LazyLoad__)_p_).__bf__SelectedPersonsName__ = (System.String)_v_; }, false);
                DisplayHoverBox = Add<__TBool__>("DisplayHoverBox$");
                DisplayHoverBox.DefaultValue = false;
                DisplayHoverBox.Editable = true;
                DisplayHoverBox.SetCustomAccessors((_p_) => { return ((__LazyLoad__)_p_).__bf__DisplayHoverBox__; }, (_p_, _v_) => { ((__LazyLoad__)_p_).__bf__DisplayHoverBox__ = (System.Boolean)_v_; }, false);
                DisplayedData = Add<__LDiSchema__>("DisplayedData");
                DisplayedData.SetCustomAccessors((_p_) => { return ((__LazyLoad__)_p_).__bf__DisplayedData__; }, (_p_, _v_) => { ((__LazyLoad__)_p_).__bf__DisplayedData__ = (__LaDisplaye__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __LazyLoad__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TArray__ People;
            public __TString__ SelectedPersonsName;
            public __TBool__ DisplayHoverBox;
            public __LDiSchema__ DisplayedData;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "LazyLoadingPage.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "LazyLoadingPage.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__People__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ People {
    #line 13 "LazyLoadingPage.json"
        get {
        #line hidden
            return Template.People.Getter(this); }
        #line 13 "LazyLoadingPage.json"
        set {
        #line hidden
            Template.People.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__SelectedPersonsName__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String SelectedPersonsName {
    #line 14 "LazyLoadingPage.json"
        get {
        #line hidden
            return Template.SelectedPersonsName.Getter(this); }
        #line 14 "LazyLoadingPage.json"
        set {
        #line hidden
            Template.SelectedPersonsName.Setter(this, value); } }
        #line default
    #line hidden
    private System.Boolean __bf__DisplayHoverBox__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Boolean DisplayHoverBox {
    #line 123 "JOCKE4"
        get {
        #line hidden
            return Template.DisplayHoverBox.Getter(this); }
        #line 123 "JOCKE4"
        set {
        #line hidden
            Template.DisplayHoverBox.Setter(this, value); } }
        #line default
    #line hidden
    private __LaDisplaye__ __bf__DisplayedData__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __LaDisplaye__ DisplayedData {
    #line 20 "LazyLoadingPage.json"
        get {
        #line hidden
            return (__LaDisplaye__)Template.DisplayedData.Getter(this); }
        #line 20 "LazyLoadingPage.json"
        set {
        #line hidden
            Template.DisplayedData.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class DisplayedDataJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __LDiSchema__ DefaultTemplate = new __LDiSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public DisplayedDataJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public DisplayedDataJson(__LDiSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __LDiSchema__ Template { get { return (__LDiSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__LaDisplaye__);
                    ClassName = "DisplayedDataJson";
                    Properties.ClearExposed();
                    DataContent = Add<__TString__>("DataContent$");
                    DataContent.DefaultValue = "";
                    DataContent.Editable = true;
                    DataContent.SetCustomAccessors((_p_) => { return ((__LaDisplaye__)_p_).__bf__DataContent__; }, (_p_, _v_) => { ((__LaDisplaye__)_p_).__bf__DataContent__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __LaDisplaye__(this) { Parent = parent }; }
                public __TString__ DataContent;
            }
            #line default
        }
        #line default
        #line hidden
        private System.String __bf__DataContent__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String DataContent {
        #line 19 "LazyLoadingPage.json"
            get {
            #line hidden
                return Template.DataContent.Getter(this); }
            #line 19 "LazyLoadingPage.json"
            set {
            #line hidden
                Template.DataContent.Setter(this, value); } }
            #line default
        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class DataContent : Input<__LaDisplaye__, __TString__, string> {
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
        public class Html : Input<__LazyLoad__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SelectedPersonsName : Input<__LazyLoad__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class DisplayHoverBox : Input<__LazyLoad__, __TBool__, bool> {
        }
        #line default
    }
    #line default
    
    #line hidden
    public partial class LazyLoadingPagePeople : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __LLaSchema__ DefaultTemplate = new __LLaSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public LazyLoadingPagePeople() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public LazyLoadingPagePeople(__LLaSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __LLaSchema__ Template { get { return (__LLaSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class JsonByExample {
            
            #line hidden
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__LaLazyLoad__);
                    ClassName = "LazyLoadingPagePeople";
                    Properties.ClearExposed();
                    Order = Add<__TLong__>("Order");
                    Order.DefaultValue = 0L;
                    Order.SetCustomAccessors((_p_) => { return ((__LaLazyLoad__)_p_).__bf__Order__; }, (_p_, _v_) => { ((__LaLazyLoad__)_p_).__bf__Order__ = (System.Int64)_v_; }, false);
                    FirstName = Add<__TString__>("FirstName");
                    FirstName.DefaultValue = "";
                    FirstName.SetCustomAccessors((_p_) => { return ((__LaLazyLoad__)_p_).__bf__FirstName__; }, (_p_, _v_) => { ((__LaLazyLoad__)_p_).__bf__FirstName__ = (System.String)_v_; }, false);
                    LastName = Add<__TString__>("LastName");
                    LastName.DefaultValue = "";
                    LastName.SetCustomAccessors((_p_) => { return ((__LaLazyLoad__)_p_).__bf__LastName__; }, (_p_, _v_) => { ((__LaLazyLoad__)_p_).__bf__LastName__ = (System.String)_v_; }, false);
                    FavoriteGame = Add<__TString__>("FavoriteGame");
                    FavoriteGame.DefaultValue = "";
                    FavoriteGame.SetCustomAccessors((_p_) => { return ((__LaLazyLoad__)_p_).__bf__FavoriteGame__; }, (_p_, _v_) => { ((__LaLazyLoad__)_p_).__bf__FavoriteGame__ = (System.String)_v_; }, false);
                    IsHovered = Add<__TLong__>("IsHovered$");
                    IsHovered.DefaultValue = 0L;
                    IsHovered.Editable = true;
                    IsHovered.SetCustomAccessors((_p_) => { return ((__LaLazyLoad__)_p_).__bf__IsHovered__; }, (_p_, _v_) => { ((__LaLazyLoad__)_p_).__bf__IsHovered__ = (System.Int64)_v_; }, false);
                    IsHovered.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.IsHovered() { App = (LazyLoadingPagePeople)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((LazyLoadingPagePeople)pup).Handle((Input.IsHovered)input); });
                    DataIsLoaded = Add<__TBool__>("DataIsLoaded");
                    DataIsLoaded.DefaultValue = false;
                    DataIsLoaded.SetCustomAccessors((_p_) => { return ((__LaLazyLoad__)_p_).__bf__DataIsLoaded__; }, (_p_, _v_) => { ((__LaLazyLoad__)_p_).__bf__DataIsLoaded__ = (System.Boolean)_v_; }, false);
                    DataToShow = Add<__TString__>("DataToShow");
                    DataToShow.DefaultValue = "";
                    DataToShow.SetCustomAccessors((_p_) => { return ((__LaLazyLoad__)_p_).__bf__DataToShow__; }, (_p_, _v_) => { ((__LaLazyLoad__)_p_).__bf__DataToShow__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __LaLazyLoad__(this) { Parent = parent }; }
                public __TLong__ Order;
                public __TString__ FirstName;
                public __TString__ LastName;
                public __TString__ FavoriteGame;
                public __TLong__ IsHovered;
                public __TBool__ DataIsLoaded;
                public __TString__ DataToShow;
            }
            #line default
        }
        #line default
        #line hidden
        private System.Int64 __bf__Order__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 Order {
        #line 5 "LazyLoadingPage.json"
            get {
            #line hidden
                return Template.Order.Getter(this); }
            #line 5 "LazyLoadingPage.json"
            set {
            #line hidden
                Template.Order.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__FirstName__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String FirstName {
        #line 6 "LazyLoadingPage.json"
            get {
            #line hidden
                return Template.FirstName.Getter(this); }
            #line 6 "LazyLoadingPage.json"
            set {
            #line hidden
                Template.FirstName.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__LastName__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String LastName {
        #line 7 "LazyLoadingPage.json"
            get {
            #line hidden
                return Template.LastName.Getter(this); }
            #line 7 "LazyLoadingPage.json"
            set {
            #line hidden
                Template.LastName.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__FavoriteGame__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String FavoriteGame {
        #line 8 "LazyLoadingPage.json"
            get {
            #line hidden
                return Template.FavoriteGame.Getter(this); }
            #line 8 "LazyLoadingPage.json"
            set {
            #line hidden
                Template.FavoriteGame.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__IsHovered__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 IsHovered {
        #line 9 "LazyLoadingPage.json"
            get {
            #line hidden
                return Template.IsHovered.Getter(this); }
            #line 9 "LazyLoadingPage.json"
            set {
            #line hidden
                Template.IsHovered.Setter(this, value); } }
            #line default
        #line hidden
        private System.Boolean __bf__DataIsLoaded__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Boolean DataIsLoaded {
        #line 123 "JOCKE4"
            get {
            #line hidden
                return Template.DataIsLoaded.Getter(this); }
            #line 123 "JOCKE4"
            set {
            #line hidden
                Template.DataIsLoaded.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__DataToShow__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String DataToShow {
        #line 12 "LazyLoadingPage.json"
            get {
            #line hidden
                return Template.DataToShow.Getter(this); }
            #line 12 "LazyLoadingPage.json"
            set {
            #line hidden
                Template.DataToShow.Setter(this, value); } }
            #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class Input {
            
            #line hidden
            public class Order : Input<__LaLazyLoad__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class FirstName : Input<__LaLazyLoad__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class LastName : Input<__LaLazyLoad__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class FavoriteGame : Input<__LaLazyLoad__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class IsHovered : Input<__LaLazyLoad__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class DataIsLoaded : Input<__LaLazyLoad__, __TBool__, bool> {
            }
            #line default
            
            #line hidden
            public class DataToShow : Input<__LaLazyLoad__, __TString__, string> {
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
