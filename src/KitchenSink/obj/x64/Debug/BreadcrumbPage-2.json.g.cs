// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "BreadcrumbPage.json"
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
using __Breadcru6__ = global::KitchenSink.BreadcrumbPageBreadcrumbsElement.Input;
using __BrIsActive__ = global::KitchenSink.BreadcrumbPageBreadcrumbsElement.Input.IsActive;
using __BrIsGhost__ = global::KitchenSink.BreadcrumbPageBreadcrumbsElement.Input.IsGhost;
using __BrIsAdd__ = global::KitchenSink.BreadcrumbPageBreadcrumbsElement.Input.IsAdd;
using __BrSelect1__ = global::KitchenSink.BreadcrumbPageBreadcrumbsElement.Input.Select;
using __BrAddSibli__ = global::KitchenSink.BreadcrumbPageBreadcrumbsElement.Input.AddSibling;
using __TArray1__ = global::Starcounter.Templates.TArray<global::KitchenSink.BreadcrumbPageBreadcrumbsElement>;
using __BrSchema3__ = global::KitchenSink.BreadcrumbPageCurrentTreeItem.JsonByExample.Schema;
using __Breadcru7__ = global::KitchenSink.BreadcrumbPage.JsonByExample;
using __Arr1__ = global::Starcounter.Arr<global::KitchenSink.BreadcrumbPageBreadcrumbsElement>;
using __Breadcru8__ = global::KitchenSink.BreadcrumbPageCurrentTreeItem;
using __Breadcru9__ = global::KitchenSink.BreadcrumbPageCurrentTreeItem.JsonByExample;
using __Breadcru10__ = global::KitchenSink.BreadcrumbPageCurrentTreeItem.Input;
using __BrName2__ = global::KitchenSink.BreadcrumbPageCurrentTreeItem.Input.Name;
using __BrIsAdd1__ = global::KitchenSink.BreadcrumbPageCurrentTreeItem.Input.IsAdd;
using __BrParentNa__ = global::KitchenSink.BreadcrumbPageCurrentTreeItem.Input.ParentName;
using __BrSave__ = global::KitchenSink.BreadcrumbPageCurrentTreeItem.Input.Save;
using __Breadcru11__ = global::KitchenSink.BreadcrumbPage.Input;
using __BrHtml__ = global::KitchenSink.BreadcrumbPage.Input.Html;
using s = Starcounter;
using st = Starcounter.Templates;
using _ScTemplate_ = Starcounter.Templates.Template;
using __BrSearchQu__ = global::KitchenSink.BreadcrumbPageBreadcrumbsElement.Input.SearchQuery;
using __BrName1__ = global::KitchenSink.BreadcrumbPageBreadcrumbsElement.Input.Name;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __Arr__ = global::Starcounter.Arr<global::KitchenSink.BreadcrumbPageBreadcrumbsSiblingsElement>;
using __Breadcru__ = global::KitchenSink.BreadcrumbPage;
using __Json__ = global::Starcounter.Json;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __BrSchema__ = global::KitchenSink.BreadcrumbPage.JsonByExample.Schema;
using __TString__ = global::Starcounter.Templates.TString;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using __BrSchema1__ = global::KitchenSink.BreadcrumbPageBreadcrumbsElement.JsonByExample.Schema;
using __TBool__ = global::Starcounter.Templates.TBool;
using __Breadcru1__ = global::KitchenSink.BreadcrumbPageBreadcrumbsElement;
using __Breadcru2__ = global::KitchenSink.BreadcrumbPageBreadcrumbsSiblingsElement;
using __BrSchema2__ = global::KitchenSink.BreadcrumbPageBreadcrumbsSiblingsElement.JsonByExample.Schema;
using __Breadcru3__ = global::KitchenSink.BreadcrumbPageBreadcrumbsSiblingsElement.JsonByExample;
using __Breadcru4__ = global::KitchenSink.BreadcrumbPageBreadcrumbsSiblingsElement.Input;
using __BrName__ = global::KitchenSink.BreadcrumbPageBreadcrumbsSiblingsElement.Input.Name;
using __BrSelect__ = global::KitchenSink.BreadcrumbPageBreadcrumbsSiblingsElement.Input.Select;
using __TArray__ = global::Starcounter.Templates.TArray<global::KitchenSink.BreadcrumbPageBreadcrumbsSiblingsElement>;
using __Breadcru5__ = global::KitchenSink.BreadcrumbPageBreadcrumbsElement.JsonByExample;
using __TLong__ = global::Starcounter.Templates.TLong;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class BreadcrumbPage_json : s::TemplateAttribute {
    
    #line hidden
    public class Breadcrumbs : s::TemplateAttribute {
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class Siblings : s::TemplateAttribute {
        }
        #line default
    }
    #line default
    
    #line hidden
    public class CurrentTreeItem : s::TemplateAttribute {
    }
    #line default
}
#line default

#line hidden
public partial class BreadcrumbPageCurrentTreeItem : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __BrSchema3__ DefaultTemplate = new __BrSchema3__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public BreadcrumbPageCurrentTreeItem() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public BreadcrumbPageCurrentTreeItem(__BrSchema3__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __BrSchema3__ Template { get { return (__BrSchema3__)base.Template; } set { base.Template = value; } }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new TreeItem Data { get { return (TreeItem)base.Data; } set { base.Data = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Breadcru8__);
                ClassName = "BreadcrumbPageCurrentTreeItem";
                Properties.ClearExposed();
                Name = Add<__TString__>("Name$");
                Name.DefaultValue = "";
                Name.Editable = true;
                Name.SetCustomAccessors((_p_) => { return ((__Breadcru8__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__Breadcru8__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                IsAdd = Add<__TBool__>("IsAdd");
                IsAdd.DefaultValue = false;
                IsAdd.SetCustomAccessors((_p_) => { return ((__Breadcru8__)_p_).__bf__IsAdd__; }, (_p_, _v_) => { ((__Breadcru8__)_p_).__bf__IsAdd__ = (System.Boolean)_v_; }, false);
                ParentName = Add<__TString__>("ParentName");
                ParentName.DefaultValue = "";
                ParentName.SetCustomAccessors((_p_) => { return ((__Breadcru8__)_p_).__bf__ParentName__; }, (_p_, _v_) => { ((__Breadcru8__)_p_).__bf__ParentName__ = (System.String)_v_; }, false);
                Save = Add<__TLong__>("Save$");
                Save.DefaultValue = 0L;
                Save.Editable = true;
                Save.SetCustomAccessors((_p_) => { return ((__Breadcru8__)_p_).__bf__Save__; }, (_p_, _v_) => { ((__Breadcru8__)_p_).__bf__Save__ = (System.Int64)_v_; }, false);
                Save.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.Save() { App = (BreadcrumbPageCurrentTreeItem)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((BreadcrumbPageCurrentTreeItem)pup).Handle((Input.Save)input); });
            }
            public override object CreateInstance(s.Json parent) { return new __Breadcru8__(this) { Parent = parent }; }
            public __TString__ Name;
            public __TBool__ IsAdd;
            public __TString__ ParentName;
            public __TLong__ Save;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Name__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
    #line 28 "BreadcrumbPage.json"
        get {
        #line hidden
            return Template.Name.Getter(this); }
        #line 28 "BreadcrumbPage.json"
        set {
        #line hidden
            Template.Name.Setter(this, value); } }
        #line default
    #line hidden
    private System.Boolean __bf__IsAdd__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Boolean IsAdd {
    #line 123 "JOCKE4"
        get {
        #line hidden
            return Template.IsAdd.Getter(this); }
        #line 123 "JOCKE4"
        set {
        #line hidden
            Template.IsAdd.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__ParentName__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String ParentName {
    #line 30 "BreadcrumbPage.json"
        get {
        #line hidden
            return Template.ParentName.Getter(this); }
        #line 30 "BreadcrumbPage.json"
        set {
        #line hidden
            Template.ParentName.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Save__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Save {
    #line 32 "BreadcrumbPage.json"
        get {
        #line hidden
            return Template.Save.Getter(this); }
        #line 32 "BreadcrumbPage.json"
        set {
        #line hidden
            Template.Save.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Name : Input<__Breadcru8__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class IsAdd : Input<__Breadcru8__, __TBool__, bool> {
        }
        #line default
        
        #line hidden
        public class ParentName : Input<__Breadcru8__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Save : Input<__Breadcru8__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default

#line hidden
public partial class BreadcrumbPageBreadcrumbsSiblingsElement : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __BrSchema2__ DefaultTemplate = new __BrSchema2__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public BreadcrumbPageBreadcrumbsSiblingsElement() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public BreadcrumbPageBreadcrumbsSiblingsElement(__BrSchema2__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __BrSchema2__ Template { get { return (__BrSchema2__)base.Template; } set { base.Template = value; } }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new TreeItem Data { get { return (TreeItem)base.Data; } set { base.Data = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Breadcru2__);
                ClassName = "BreadcrumbPageBreadcrumbsSiblingsElement";
                Properties.ClearExposed();
                Name = Add<__TString__>("Name");
                Name.DefaultValue = "";
                Name.SetCustomAccessors((_p_) => { return ((__Breadcru2__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__Breadcru2__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                Select = Add<__TLong__>("Select$");
                Select.DefaultValue = 0L;
                Select.Editable = true;
                Select.SetCustomAccessors((_p_) => { return ((__Breadcru2__)_p_).__bf__Select__; }, (_p_, _v_) => { ((__Breadcru2__)_p_).__bf__Select__ = (System.Int64)_v_; }, false);
                Select.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.Select() { App = (BreadcrumbPageBreadcrumbsSiblingsElement)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((BreadcrumbPageBreadcrumbsSiblingsElement)pup).Handle((Input.Select)input); });
            }
            public override object CreateInstance(s.Json parent) { return new __Breadcru2__(this) { Parent = parent }; }
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
    #line 20 "BreadcrumbPage.json"
        get {
        #line hidden
            return Template.Name.Getter(this); }
        #line 20 "BreadcrumbPage.json"
        set {
        #line hidden
            Template.Name.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Select__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Select {
    #line 22 "BreadcrumbPage.json"
        get {
        #line hidden
            return Template.Select.Getter(this); }
        #line 22 "BreadcrumbPage.json"
        set {
        #line hidden
            Template.Select.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Name : Input<__Breadcru2__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Select : Input<__Breadcru2__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default

#line hidden
public partial class BreadcrumbPageBreadcrumbsElement : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __BrSchema1__ DefaultTemplate = new __BrSchema1__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public BreadcrumbPageBreadcrumbsElement() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public BreadcrumbPageBreadcrumbsElement(__BrSchema1__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __BrSchema1__ Template { get { return (__BrSchema1__)base.Template; } set { base.Template = value; } }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new TreeItem Data { get { return (TreeItem)base.Data; } set { base.Data = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Breadcru1__);
                ClassName = "BreadcrumbPageBreadcrumbsElement";
                Properties.ClearExposed();
                Name = Add<__TString__>("Name", bind:"FormattedName");
                Name.DefaultValue = "";
                Name.SetCustomAccessors((_p_) => { return ((__Breadcru1__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__Breadcru1__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                SearchQuery = Add<__TString__>("SearchQuery$");
                SearchQuery.DefaultValue = "";
                SearchQuery.Editable = true;
                SearchQuery.SetCustomAccessors((_p_) => { return ((__Breadcru1__)_p_).__bf__SearchQuery__; }, (_p_, _v_) => { ((__Breadcru1__)_p_).__bf__SearchQuery__ = (System.String)_v_; }, false);
                SearchQuery.AddHandler((Json pup, Property<String> prop, String value) => { return (new Input.SearchQuery() { App = (BreadcrumbPageBreadcrumbsElement)pup, Template = (TString)prop, Value = value }); }, (Json pup, Starcounter.Input<String> input) => { ((BreadcrumbPageBreadcrumbsElement)pup).Handle((Input.SearchQuery)input); });
                IsActive = Add<__TBool__>("IsActive");
                IsActive.DefaultValue = false;
                IsActive.SetCustomAccessors((_p_) => { return ((__Breadcru1__)_p_).__bf__IsActive__; }, (_p_, _v_) => { ((__Breadcru1__)_p_).__bf__IsActive__ = (System.Boolean)_v_; }, false);
                IsGhost = Add<__TBool__>("IsGhost", bind:"IsGhostParentSet");
                IsGhost.DefaultValue = false;
                IsGhost.SetCustomAccessors((_p_) => { return ((__Breadcru1__)_p_).__bf__IsGhost__; }, (_p_, _v_) => { ((__Breadcru1__)_p_).__bf__IsGhost__ = (System.Boolean)_v_; }, false);
                IsAdd = Add<__TBool__>("IsAdd");
                IsAdd.DefaultValue = false;
                IsAdd.SetCustomAccessors((_p_) => { return ((__Breadcru1__)_p_).__bf__IsAdd__; }, (_p_, _v_) => { ((__Breadcru1__)_p_).__bf__IsAdd__ = (System.Boolean)_v_; }, false);
                Select = Add<__TLong__>("Select$");
                Select.DefaultValue = 0L;
                Select.Editable = true;
                Select.SetCustomAccessors((_p_) => { return ((__Breadcru1__)_p_).__bf__Select__; }, (_p_, _v_) => { ((__Breadcru1__)_p_).__bf__Select__ = (System.Int64)_v_; }, false);
                Select.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.Select() { App = (BreadcrumbPageBreadcrumbsElement)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((BreadcrumbPageBreadcrumbsElement)pup).Handle((Input.Select)input); });
                Siblings = Add<__TArray__>("Siblings");
                Siblings.SetCustomGetElementType((arr) => { return __Breadcru2__.DefaultTemplate;});
                Siblings.SetCustomAccessors((_p_) => { return ((__Breadcru1__)_p_).__bf__Siblings__; }, (_p_, _v_) => { ((__Breadcru1__)_p_).__bf__Siblings__ = (__Arr__)_v_; }, false);
                AddSibling = Add<__TLong__>("AddSibling$");
                AddSibling.DefaultValue = 0L;
                AddSibling.Editable = true;
                AddSibling.SetCustomAccessors((_p_) => { return ((__Breadcru1__)_p_).__bf__AddSibling__; }, (_p_, _v_) => { ((__Breadcru1__)_p_).__bf__AddSibling__ = (System.Int64)_v_; }, false);
                AddSibling.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.AddSibling() { App = (BreadcrumbPageBreadcrumbsElement)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((BreadcrumbPageBreadcrumbsElement)pup).Handle((Input.AddSibling)input); });
            }
            public override object CreateInstance(s.Json parent) { return new __Breadcru1__(this) { Parent = parent }; }
            public __TString__ Name;
            public __TString__ SearchQuery;
            public __TBool__ IsActive;
            public __TBool__ IsGhost;
            public __TBool__ IsAdd;
            public __TLong__ Select;
            public __TArray__ Siblings;
            public __TLong__ AddSibling;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Name__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
    #line 6 "BreadcrumbPage.json"
        get {
        #line hidden
            return Template.Name.Getter(this); }
        #line 6 "BreadcrumbPage.json"
        set {
        #line hidden
            Template.Name.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__SearchQuery__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String SearchQuery {
    #line 10 "BreadcrumbPage.json"
        get {
        #line hidden
            return Template.SearchQuery.Getter(this); }
        #line 10 "BreadcrumbPage.json"
        set {
        #line hidden
            Template.SearchQuery.Setter(this, value); } }
        #line default
    #line hidden
    private System.Boolean __bf__IsActive__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Boolean IsActive {
    #line 123 "JOCKE4"
        get {
        #line hidden
            return Template.IsActive.Getter(this); }
        #line 123 "JOCKE4"
        set {
        #line hidden
            Template.IsActive.Setter(this, value); } }
        #line default
    #line hidden
    private System.Boolean __bf__IsGhost__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Boolean IsGhost {
    #line 123 "JOCKE4"
        get {
        #line hidden
            return Template.IsGhost.Getter(this); }
        #line 123 "JOCKE4"
        set {
        #line hidden
            Template.IsGhost.Setter(this, value); } }
        #line default
    #line hidden
    private System.Boolean __bf__IsAdd__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Boolean IsAdd {
    #line 123 "JOCKE4"
        get {
        #line hidden
            return Template.IsAdd.Getter(this); }
        #line 123 "JOCKE4"
        set {
        #line hidden
            Template.IsAdd.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Select__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Select {
    #line 14 "BreadcrumbPage.json"
        get {
        #line hidden
            return Template.Select.Getter(this); }
        #line 14 "BreadcrumbPage.json"
        set {
        #line hidden
            Template.Select.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__Siblings__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ Siblings {
    #line 23 "BreadcrumbPage.json"
        get {
        #line hidden
            return Template.Siblings.Getter(this); }
        #line 23 "BreadcrumbPage.json"
        set {
        #line hidden
            Template.Siblings.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__AddSibling__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 AddSibling {
    #line 25 "BreadcrumbPage.json"
        get {
        #line hidden
            return Template.AddSibling.Getter(this); }
        #line 25 "BreadcrumbPage.json"
        set {
        #line hidden
            Template.AddSibling.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Name : Input<__Breadcru1__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SearchQuery : Input<__Breadcru1__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class IsActive : Input<__Breadcru1__, __TBool__, bool> {
        }
        #line default
        
        #line hidden
        public class IsGhost : Input<__Breadcru1__, __TBool__, bool> {
        }
        #line default
        
        #line hidden
        public class IsAdd : Input<__Breadcru1__, __TBool__, bool> {
        }
        #line default
        
        #line hidden
        public class Select : Input<__Breadcru1__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class AddSibling : Input<__Breadcru1__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default

#line hidden
public partial class BreadcrumbPage : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __BrSchema__ DefaultTemplate = new __BrSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public BreadcrumbPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public BreadcrumbPage(__BrSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __BrSchema__ Template { get { return (__BrSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Breadcru__);
                ClassName = "BreadcrumbPage";
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/KitchenSink/BreadcrumbPage.html";
                Html.SetCustomAccessors((_p_) => { return ((__Breadcru__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Breadcru__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Breadcrumbs = Add<__TArray1__>("Breadcrumbs");
                Breadcrumbs.SetCustomGetElementType((arr) => { return __Breadcru1__.DefaultTemplate;});
                Breadcrumbs.SetCustomAccessors((_p_) => { return ((__Breadcru__)_p_).__bf__Breadcrumbs__; }, (_p_, _v_) => { ((__Breadcru__)_p_).__bf__Breadcrumbs__ = (__Arr1__)_v_; }, false);
                CurrentTreeItem = Add<__BrSchema3__>("CurrentTreeItem");
                CurrentTreeItem.SetCustomAccessors((_p_) => { return ((__Breadcru__)_p_).__bf__CurrentTreeItem__; }, (_p_, _v_) => { ((__Breadcru__)_p_).__bf__CurrentTreeItem__ = (__Breadcru8__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Breadcru__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TArray1__ Breadcrumbs;
            public __BrSchema3__ CurrentTreeItem;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "BreadcrumbPage.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "BreadcrumbPage.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr1__ __bf__Breadcrumbs__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr1__ Breadcrumbs {
    #line 26 "BreadcrumbPage.json"
        get {
        #line hidden
            return Template.Breadcrumbs.Getter(this); }
        #line 26 "BreadcrumbPage.json"
        set {
        #line hidden
            Template.Breadcrumbs.Setter(this, value); } }
        #line default
    #line hidden
    private __Breadcru8__ __bf__CurrentTreeItem__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Breadcru8__ CurrentTreeItem {
    #line 33 "BreadcrumbPage.json"
        get {
        #line hidden
            return (__Breadcru8__)Template.CurrentTreeItem.Getter(this); }
        #line 33 "BreadcrumbPage.json"
        set {
        #line hidden
            Template.CurrentTreeItem.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Breadcru__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
