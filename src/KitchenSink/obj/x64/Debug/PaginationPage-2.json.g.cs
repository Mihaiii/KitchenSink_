// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "PaginationPage.json"
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
using __PaPagesEle2__ = global::KitchenSink.PaginationPage.PagesElementJson.Input;
using __PPaActive__ = global::KitchenSink.PaginationPage.PagesElementJson.Input.Active;
using __TArray2__ = global::Starcounter.Templates.TArray<global::KitchenSink.PaginationPage.PagesElementJson>;
using __Paginati1__ = global::KitchenSink.PaginationPage.JsonByExample;
using __Arr__ = global::Starcounter.Arr<global::KitchenSink.PaginationPage.LibraryElementJson>;
using __Arr1__ = global::Starcounter.Arr<global::KitchenSink.PaginationPage.PageEntriesElementJson>;
using __Arr2__ = global::Starcounter.Arr<global::KitchenSink.PaginationPage.PagesElementJson>;
using __Paginati2__ = global::KitchenSink.PaginationPage.Input;
using __PaHtml__ = global::KitchenSink.PaginationPage.Input.Html;
using __PaChangePa__ = global::KitchenSink.PaginationPage.Input.ChangePage;
using __PaNextPage__ = global::KitchenSink.PaginationPage.Input.NextPage;
using __PaPrevious__ = global::KitchenSink.PaginationPage.Input.PreviousPage;
using __PaLastPage__ = global::KitchenSink.PaginationPage.Input.LastPage;
using __PaFirstPag__ = global::KitchenSink.PaginationPage.Input.FirstPage;
using __PaEntriesP__ = global::KitchenSink.PaginationPage.Input.EntriesPerPage;
using __PaTotalEnt__ = global::KitchenSink.PaginationPage.Input.TotalEntries;
using __PaTotalPag__ = global::KitchenSink.PaginationPage.Input.TotalPages;
using __PaCurrentP__ = global::KitchenSink.PaginationPage.Input.CurrentPage;
using __PaCurrentO__ = global::KitchenSink.PaginationPage.Input.CurrentOffset;
using __PaDisableF__ = global::KitchenSink.PaginationPage.Input.DisableFirst;
using __PaDisableL__ = global::KitchenSink.PaginationPage.Input.DisableLast;
using s = Starcounter;
using st = Starcounter.Templates;
using _ScTemplate_ = Starcounter.Templates.Template;
using __PPaPageNumb__ = global::KitchenSink.PaginationPage.PagesElementJson.Input.PageNumber;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __TBool__ = global::Starcounter.Templates.TBool;
using __Paginati__ = global::KitchenSink.PaginationPage;
using __Json__ = global::Starcounter.Json;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __PaSchema__ = global::KitchenSink.PaginationPage.JsonByExample.Schema;
using __TString__ = global::Starcounter.Templates.TString;
using __TLong__ = global::Starcounter.Templates.TLong;
using __PaLibraryE__ = global::KitchenSink.PaginationPage.LibraryElementJson;
using __PLiSchema__ = global::KitchenSink.PaginationPage.LibraryElementJson.JsonByExample.Schema;
using __PaLibraryE1__ = global::KitchenSink.PaginationPage.LibraryElementJson.JsonByExample;
using __PaPagesEle1__ = global::KitchenSink.PaginationPage.PagesElementJson.JsonByExample;
using __PaLibraryE2__ = global::KitchenSink.PaginationPage.LibraryElementJson.Input;
using __PLiTitle__ = global::KitchenSink.PaginationPage.LibraryElementJson.Input.Title;
using __TArray__ = global::Starcounter.Templates.TArray<global::KitchenSink.PaginationPage.LibraryElementJson>;
using __PaPageEntr__ = global::KitchenSink.PaginationPage.PageEntriesElementJson;
using __PPaSchema__ = global::KitchenSink.PaginationPage.PageEntriesElementJson.JsonByExample.Schema;
using __PaPageEntr1__ = global::KitchenSink.PaginationPage.PageEntriesElementJson.JsonByExample;
using __PaPageEntr2__ = global::KitchenSink.PaginationPage.PageEntriesElementJson.Input;
using __PPaAmount__ = global::KitchenSink.PaginationPage.PageEntriesElementJson.Input.Amount;
using __TArray1__ = global::Starcounter.Templates.TArray<global::KitchenSink.PaginationPage.PageEntriesElementJson>;
using __PaPagesEle__ = global::KitchenSink.PaginationPage.PagesElementJson;
using __PPaSchema1__ = global::KitchenSink.PaginationPage.PagesElementJson.JsonByExample.Schema;
using __PLiAuthor__ = global::KitchenSink.PaginationPage.LibraryElementJson.Input.Author;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class PaginationPage_json : s::TemplateAttribute {
    
    #line hidden
    public class Library : s::TemplateAttribute {
    }
    #line default
    
    #line hidden
    public class PageEntries : s::TemplateAttribute {
    }
    #line default
    
    #line hidden
    public class Pages : s::TemplateAttribute {
    }
    #line default
}
#line default

#line hidden
public partial class PaginationPage : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __PaSchema__ DefaultTemplate = new __PaSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public PaginationPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public PaginationPage(__PaSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __PaSchema__ Template { get { return (__PaSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Paginati__);
                ClassName = "PaginationPage";
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/KitchenSink/PaginationPage.html";
                Html.SetCustomAccessors((_p_) => { return ((__Paginati__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Paginati__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                ChangePage = Add<__TLong__>("ChangePage$");
                ChangePage.DefaultValue = 0L;
                ChangePage.Editable = true;
                ChangePage.SetCustomAccessors((_p_) => { return ((__Paginati__)_p_).__bf__ChangePage__; }, (_p_, _v_) => { ((__Paginati__)_p_).__bf__ChangePage__ = (System.Int64)_v_; }, false);
                ChangePage.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.ChangePage() { App = (PaginationPage)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((PaginationPage)pup).Handle((Input.ChangePage)input); });
                NextPage = Add<__TLong__>("NextPage$");
                NextPage.DefaultValue = 0L;
                NextPage.Editable = true;
                NextPage.SetCustomAccessors((_p_) => { return ((__Paginati__)_p_).__bf__NextPage__; }, (_p_, _v_) => { ((__Paginati__)_p_).__bf__NextPage__ = (System.Int64)_v_; }, false);
                NextPage.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.NextPage() { App = (PaginationPage)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((PaginationPage)pup).Handle((Input.NextPage)input); });
                PreviousPage = Add<__TLong__>("PreviousPage$");
                PreviousPage.DefaultValue = 0L;
                PreviousPage.Editable = true;
                PreviousPage.SetCustomAccessors((_p_) => { return ((__Paginati__)_p_).__bf__PreviousPage__; }, (_p_, _v_) => { ((__Paginati__)_p_).__bf__PreviousPage__ = (System.Int64)_v_; }, false);
                PreviousPage.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.PreviousPage() { App = (PaginationPage)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((PaginationPage)pup).Handle((Input.PreviousPage)input); });
                LastPage = Add<__TLong__>("LastPage$");
                LastPage.DefaultValue = 0L;
                LastPage.Editable = true;
                LastPage.SetCustomAccessors((_p_) => { return ((__Paginati__)_p_).__bf__LastPage__; }, (_p_, _v_) => { ((__Paginati__)_p_).__bf__LastPage__ = (System.Int64)_v_; }, false);
                LastPage.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.LastPage() { App = (PaginationPage)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((PaginationPage)pup).Handle((Input.LastPage)input); });
                FirstPage = Add<__TLong__>("FirstPage$");
                FirstPage.DefaultValue = 0L;
                FirstPage.Editable = true;
                FirstPage.SetCustomAccessors((_p_) => { return ((__Paginati__)_p_).__bf__FirstPage__; }, (_p_, _v_) => { ((__Paginati__)_p_).__bf__FirstPage__ = (System.Int64)_v_; }, false);
                FirstPage.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.FirstPage() { App = (PaginationPage)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((PaginationPage)pup).Handle((Input.FirstPage)input); });
                Library = Add<__TArray__>("Library");
                Library.SetCustomGetElementType((arr) => { return __PaLibraryE__.DefaultTemplate;});
                Library.SetCustomAccessors((_p_) => { return ((__Paginati__)_p_).__bf__Library__; }, (_p_, _v_) => { ((__Paginati__)_p_).__bf__Library__ = (__Arr__)_v_; }, false);
                EntriesPerPage = Add<__TLong__>("EntriesPerPage$");
                EntriesPerPage.DefaultValue = 5L;
                EntriesPerPage.Editable = true;
                EntriesPerPage.SetCustomAccessors((_p_) => { return ((__Paginati__)_p_).__bf__EntriesPerPage__; }, (_p_, _v_) => { ((__Paginati__)_p_).__bf__EntriesPerPage__ = (System.Int64)_v_; }, false);
                EntriesPerPage.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.EntriesPerPage() { App = (PaginationPage)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((PaginationPage)pup).Handle((Input.EntriesPerPage)input); });
                PageEntries = Add<__TArray1__>("PageEntries");
                PageEntries.SetCustomGetElementType((arr) => { return __PaPageEntr__.DefaultTemplate;});
                PageEntries.SetCustomAccessors((_p_) => { return ((__Paginati__)_p_).__bf__PageEntries__; }, (_p_, _v_) => { ((__Paginati__)_p_).__bf__PageEntries__ = (__Arr1__)_v_; }, false);
                Pages = Add<__TArray2__>("Pages");
                Pages.SetCustomGetElementType((arr) => { return __PaPagesEle__.DefaultTemplate;});
                Pages.SetCustomAccessors((_p_) => { return ((__Paginati__)_p_).__bf__Pages__; }, (_p_, _v_) => { ((__Paginati__)_p_).__bf__Pages__ = (__Arr2__)_v_; }, false);
                TotalEntries = Add<__TLong__>("TotalEntries");
                TotalEntries.DefaultValue = 0L;
                TotalEntries.SetCustomAccessors((_p_) => { return ((__Paginati__)_p_).__bf__TotalEntries__; }, (_p_, _v_) => { ((__Paginati__)_p_).__bf__TotalEntries__ = (System.Int64)_v_; }, false);
                TotalPages = Add<__TLong__>("TotalPages");
                TotalPages.DefaultValue = 0L;
                TotalPages.SetCustomAccessors((_p_) => { return ((__Paginati__)_p_).__bf__TotalPages__; }, (_p_, _v_) => { ((__Paginati__)_p_).__bf__TotalPages__ = (System.Int64)_v_; }, false);
                CurrentPage = Add<__TLong__>("CurrentPage");
                CurrentPage.DefaultValue = 1L;
                CurrentPage.SetCustomAccessors((_p_) => { return ((__Paginati__)_p_).__bf__CurrentPage__; }, (_p_, _v_) => { ((__Paginati__)_p_).__bf__CurrentPage__ = (System.Int64)_v_; }, false);
                CurrentOffset = Add<__TLong__>("CurrentOffset");
                CurrentOffset.DefaultValue = 0L;
                CurrentOffset.SetCustomAccessors((_p_) => { return ((__Paginati__)_p_).__bf__CurrentOffset__; }, (_p_, _v_) => { ((__Paginati__)_p_).__bf__CurrentOffset__ = (System.Int64)_v_; }, false);
                DisableFirst = Add<__TBool__>("DisableFirst");
                DisableFirst.DefaultValue = true;
                DisableFirst.SetCustomAccessors((_p_) => { return ((__Paginati__)_p_).__bf__DisableFirst__; }, (_p_, _v_) => { ((__Paginati__)_p_).__bf__DisableFirst__ = (System.Boolean)_v_; }, false);
                DisableLast = Add<__TBool__>("DisableLast");
                DisableLast.DefaultValue = false;
                DisableLast.SetCustomAccessors((_p_) => { return ((__Paginati__)_p_).__bf__DisableLast__; }, (_p_, _v_) => { ((__Paginati__)_p_).__bf__DisableLast__ = (System.Boolean)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Paginati__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TLong__ ChangePage;
            public __TLong__ NextPage;
            public __TLong__ PreviousPage;
            public __TLong__ LastPage;
            public __TLong__ FirstPage;
            public __TArray__ Library;
            public __TLong__ EntriesPerPage;
            public __TArray1__ PageEntries;
            public __TArray2__ Pages;
            public __TLong__ TotalEntries;
            public __TLong__ TotalPages;
            public __TLong__ CurrentPage;
            public __TLong__ CurrentOffset;
            public __TBool__ DisableFirst;
            public __TBool__ DisableLast;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "PaginationPage.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "PaginationPage.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__ChangePage__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 ChangePage {
    #line 3 "PaginationPage.json"
        get {
        #line hidden
            return Template.ChangePage.Getter(this); }
        #line 3 "PaginationPage.json"
        set {
        #line hidden
            Template.ChangePage.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__NextPage__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 NextPage {
    #line 4 "PaginationPage.json"
        get {
        #line hidden
            return Template.NextPage.Getter(this); }
        #line 4 "PaginationPage.json"
        set {
        #line hidden
            Template.NextPage.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__PreviousPage__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 PreviousPage {
    #line 5 "PaginationPage.json"
        get {
        #line hidden
            return Template.PreviousPage.Getter(this); }
        #line 5 "PaginationPage.json"
        set {
        #line hidden
            Template.PreviousPage.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__LastPage__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 LastPage {
    #line 6 "PaginationPage.json"
        get {
        #line hidden
            return Template.LastPage.Getter(this); }
        #line 6 "PaginationPage.json"
        set {
        #line hidden
            Template.LastPage.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__FirstPage__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 FirstPage {
    #line 7 "PaginationPage.json"
        get {
        #line hidden
            return Template.FirstPage.Getter(this); }
        #line 7 "PaginationPage.json"
        set {
        #line hidden
            Template.FirstPage.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__Library__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ Library {
    #line 13 "PaginationPage.json"
        get {
        #line hidden
            return Template.Library.Getter(this); }
        #line 13 "PaginationPage.json"
        set {
        #line hidden
            Template.Library.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__EntriesPerPage__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 EntriesPerPage {
    #line 15 "PaginationPage.json"
        get {
        #line hidden
            return Template.EntriesPerPage.Getter(this); }
        #line 15 "PaginationPage.json"
        set {
        #line hidden
            Template.EntriesPerPage.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr1__ __bf__PageEntries__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr1__ PageEntries {
    #line 20 "PaginationPage.json"
        get {
        #line hidden
            return Template.PageEntries.Getter(this); }
        #line 20 "PaginationPage.json"
        set {
        #line hidden
            Template.PageEntries.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr2__ __bf__Pages__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr2__ Pages {
    #line 27 "PaginationPage.json"
        get {
        #line hidden
            return Template.Pages.Getter(this); }
        #line 27 "PaginationPage.json"
        set {
        #line hidden
            Template.Pages.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__TotalEntries__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 TotalEntries {
    #line 29 "PaginationPage.json"
        get {
        #line hidden
            return Template.TotalEntries.Getter(this); }
        #line 29 "PaginationPage.json"
        set {
        #line hidden
            Template.TotalEntries.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__TotalPages__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 TotalPages {
    #line 30 "PaginationPage.json"
        get {
        #line hidden
            return Template.TotalPages.Getter(this); }
        #line 30 "PaginationPage.json"
        set {
        #line hidden
            Template.TotalPages.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__CurrentPage__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 CurrentPage {
    #line 31 "PaginationPage.json"
        get {
        #line hidden
            return Template.CurrentPage.Getter(this); }
        #line 31 "PaginationPage.json"
        set {
        #line hidden
            Template.CurrentPage.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__CurrentOffset__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 CurrentOffset {
    #line 32 "PaginationPage.json"
        get {
        #line hidden
            return Template.CurrentOffset.Getter(this); }
        #line 32 "PaginationPage.json"
        set {
        #line hidden
            Template.CurrentOffset.Setter(this, value); } }
        #line default
    #line hidden
    private System.Boolean __bf__DisableFirst__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Boolean DisableFirst {
    #line 123 "JOCKE3"
        get {
        #line hidden
            return Template.DisableFirst.Getter(this); }
        #line 123 "JOCKE3"
        set {
        #line hidden
            Template.DisableFirst.Setter(this, value); } }
        #line default
    #line hidden
    private System.Boolean __bf__DisableLast__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Boolean DisableLast {
    #line 123 "JOCKE4"
        get {
        #line hidden
            return Template.DisableLast.Getter(this); }
        #line 123 "JOCKE4"
        set {
        #line hidden
            Template.DisableLast.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class LibraryElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __PLiSchema__ DefaultTemplate = new __PLiSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public LibraryElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public LibraryElementJson(__PLiSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __PLiSchema__ Template { get { return (__PLiSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__PaLibraryE__);
                    ClassName = "LibraryElementJson";
                    Properties.ClearExposed();
                    Author = Add<__TString__>("Author");
                    Author.DefaultValue = "";
                    Author.SetCustomAccessors((_p_) => { return ((__PaLibraryE__)_p_).__bf__Author__; }, (_p_, _v_) => { ((__PaLibraryE__)_p_).__bf__Author__ = (System.String)_v_; }, false);
                    Title = Add<__TString__>("Title");
                    Title.DefaultValue = "";
                    Title.SetCustomAccessors((_p_) => { return ((__PaLibraryE__)_p_).__bf__Title__; }, (_p_, _v_) => { ((__PaLibraryE__)_p_).__bf__Title__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __PaLibraryE__(this) { Parent = parent }; }
                public __TString__ Author;
                public __TString__ Title;
            }
            #line default
        }
        #line default
        #line hidden
        private System.String __bf__Author__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Author {
        #line 10 "PaginationPage.json"
            get {
            #line hidden
                return Template.Author.Getter(this); }
            #line 10 "PaginationPage.json"
            set {
            #line hidden
                Template.Author.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__Title__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Title {
        #line 12 "PaginationPage.json"
            get {
            #line hidden
                return Template.Title.Getter(this); }
            #line 12 "PaginationPage.json"
            set {
            #line hidden
                Template.Title.Setter(this, value); } }
            #line default
        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Author : Input<__PaLibraryE__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Title : Input<__PaLibraryE__, __TString__, string> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class PageEntriesElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __PPaSchema__ DefaultTemplate = new __PPaSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public PageEntriesElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public PageEntriesElementJson(__PPaSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __PPaSchema__ Template { get { return (__PPaSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__PaPageEntr__);
                    ClassName = "PageEntriesElementJson";
                    Properties.ClearExposed();
                    Amount = Add<__TLong__>("Amount");
                    Amount.DefaultValue = 0L;
                    Amount.SetCustomAccessors((_p_) => { return ((__PaPageEntr__)_p_).__bf__Amount__; }, (_p_, _v_) => { ((__PaPageEntr__)_p_).__bf__Amount__ = (System.Int64)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __PaPageEntr__(this) { Parent = parent }; }
                public __TLong__ Amount;
            }
            #line default
        }
        #line default
        #line hidden
        private System.Int64 __bf__Amount__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 Amount {
        #line 19 "PaginationPage.json"
            get {
            #line hidden
                return Template.Amount.Getter(this); }
            #line 19 "PaginationPage.json"
            set {
            #line hidden
                Template.Amount.Setter(this, value); } }
            #line default
        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Amount : Input<__PaPageEntr__, __TLong__, long> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class PagesElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __PPaSchema1__ DefaultTemplate = new __PPaSchema1__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public PagesElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public PagesElementJson(__PPaSchema1__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __PPaSchema1__ Template { get { return (__PPaSchema1__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__PaPagesEle__);
                    ClassName = "PagesElementJson";
                    Properties.ClearExposed();
                    PageNumber = Add<__TLong__>("PageNumber");
                    PageNumber.DefaultValue = 0L;
                    PageNumber.SetCustomAccessors((_p_) => { return ((__PaPagesEle__)_p_).__bf__PageNumber__; }, (_p_, _v_) => { ((__PaPagesEle__)_p_).__bf__PageNumber__ = (System.Int64)_v_; }, false);
                    Active = Add<__TBool__>("Active");
                    Active.DefaultValue = false;
                    Active.SetCustomAccessors((_p_) => { return ((__PaPagesEle__)_p_).__bf__Active__; }, (_p_, _v_) => { ((__PaPagesEle__)_p_).__bf__Active__ = (System.Boolean)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __PaPagesEle__(this) { Parent = parent }; }
                public __TLong__ PageNumber;
                public __TBool__ Active;
            }
            #line default
        }
        #line default
        #line hidden
        private System.Int64 __bf__PageNumber__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 PageNumber {
        #line 24 "PaginationPage.json"
            get {
            #line hidden
                return Template.PageNumber.Getter(this); }
            #line 24 "PaginationPage.json"
            set {
            #line hidden
                Template.PageNumber.Setter(this, value); } }
            #line default
        #line hidden
        private System.Boolean __bf__Active__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Boolean Active {
        #line 123 "JOCKE4"
            get {
            #line hidden
                return Template.Active.Getter(this); }
            #line 123 "JOCKE4"
            set {
            #line hidden
                Template.Active.Setter(this, value); } }
            #line default
        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class PageNumber : Input<__PaPagesEle__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Active : Input<__PaPagesEle__, __TBool__, bool> {
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
        public class Html : Input<__Paginati__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class ChangePage : Input<__Paginati__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class NextPage : Input<__Paginati__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class PreviousPage : Input<__Paginati__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class LastPage : Input<__Paginati__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class FirstPage : Input<__Paginati__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class EntriesPerPage : Input<__Paginati__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class TotalEntries : Input<__Paginati__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class TotalPages : Input<__Paginati__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class CurrentPage : Input<__Paginati__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class CurrentOffset : Input<__Paginati__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class DisableFirst : Input<__Paginati__, __TBool__, bool> {
        }
        #line default
        
        #line hidden
        public class DisableLast : Input<__Paginati__, __TBool__, bool> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
