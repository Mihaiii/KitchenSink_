// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "RadioPage.json"
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
using __RPeLabel__ = global::KitchenSink.RadioPage.PetsElementJson.Input.Label;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __RaPetReact__ = global::KitchenSink.RadioPage.Input.PetReaction;
using __RaSelected__ = global::KitchenSink.RadioPage.Input.SelectedPet;
using __RaHtml__ = global::KitchenSink.RadioPage.Input.Html;
using __RadioPag2__ = global::KitchenSink.RadioPage.Input;
using __Arr__ = global::Starcounter.Arr<global::KitchenSink.RadioPage.PetsElementJson>;
using __RadioPag1__ = global::KitchenSink.RadioPage.JsonByExample;
using __TArray__ = global::Starcounter.Templates.TArray<global::KitchenSink.RadioPage.PetsElementJson>;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __RaPetsElem1__ = global::KitchenSink.RadioPage.PetsElementJson.JsonByExample;
using __RPeSchema__ = global::KitchenSink.RadioPage.PetsElementJson.JsonByExample.Schema;
using __RaPetsElem__ = global::KitchenSink.RadioPage.PetsElementJson;
using __TString__ = global::Starcounter.Templates.TString;
using __RaSchema__ = global::KitchenSink.RadioPage.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __RadioPag__ = global::KitchenSink.RadioPage;
using __RaPetsElem2__ = global::KitchenSink.RadioPage.PetsElementJson.Input;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class RadioPage_json : s::TemplateAttribute {
    
    #line hidden
    public class Pets : s::TemplateAttribute {
    }
    #line default
}
#line default

#line hidden
public partial class RadioPage : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __RaSchema__ DefaultTemplate = new __RaSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public RadioPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public RadioPage(__RaSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __RaSchema__ Template { get { return (__RaSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__RadioPag__);
                ClassName = "RadioPage";
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/KitchenSink/RadioPage.html";
                Html.SetCustomAccessors((_p_) => { return ((__RadioPag__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__RadioPag__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Pets = Add<__TArray__>("Pets");
                Pets.SetCustomGetElementType((arr) => { return __RaPetsElem__.DefaultTemplate;});
                Pets.SetCustomAccessors((_p_) => { return ((__RadioPag__)_p_).__bf__Pets__; }, (_p_, _v_) => { ((__RadioPag__)_p_).__bf__Pets__ = (__Arr__)_v_; }, false);
                SelectedPet = Add<__TString__>("SelectedPet$");
                SelectedPet.DefaultValue = "";
                SelectedPet.Editable = true;
                SelectedPet.SetCustomAccessors((_p_) => { return ((__RadioPag__)_p_).__bf__SelectedPet__; }, (_p_, _v_) => { ((__RadioPag__)_p_).__bf__SelectedPet__ = (System.String)_v_; }, false);
                PetReaction = Add<__TString__>("PetReaction", bind:"CalculatedPetReaction");
                PetReaction.DefaultValue = "";
                PetReaction.SetCustomAccessors((_p_) => { return ((__RadioPag__)_p_).__bf__PetReaction__; }, (_p_, _v_) => { ((__RadioPag__)_p_).__bf__PetReaction__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __RadioPag__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TArray__ Pets;
            public __TString__ SelectedPet;
            public __TString__ PetReaction;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "RadioPage.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "RadioPage.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__Pets__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ Pets {
    #line 6 "RadioPage.json"
        get {
        #line hidden
            return Template.Pets.Getter(this); }
        #line 6 "RadioPage.json"
        set {
        #line hidden
            Template.Pets.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__SelectedPet__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String SelectedPet {
    #line 7 "RadioPage.json"
        get {
        #line hidden
            return Template.SelectedPet.Getter(this); }
        #line 7 "RadioPage.json"
        set {
        #line hidden
            Template.SelectedPet.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__PetReaction__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String PetReaction {
    #line 9 "RadioPage.json"
        get {
        #line hidden
            return Template.PetReaction.Getter(this); }
        #line 9 "RadioPage.json"
        set {
        #line hidden
            Template.PetReaction.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class PetsElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __RPeSchema__ DefaultTemplate = new __RPeSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public PetsElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public PetsElementJson(__RPeSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __RPeSchema__ Template { get { return (__RPeSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__RaPetsElem__);
                    ClassName = "PetsElementJson";
                    Properties.ClearExposed();
                    Label = Add<__TString__>("Label");
                    Label.DefaultValue = "";
                    Label.SetCustomAccessors((_p_) => { return ((__RaPetsElem__)_p_).__bf__Label__; }, (_p_, _v_) => { ((__RaPetsElem__)_p_).__bf__Label__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __RaPetsElem__(this) { Parent = parent }; }
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
        #line 5 "RadioPage.json"
            get {
            #line hidden
                return Template.Label.Getter(this); }
            #line 5 "RadioPage.json"
            set {
            #line hidden
                Template.Label.Setter(this, value); } }
            #line default
        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Label : Input<__RaPetsElem__, __TString__, string> {
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
        public class Html : Input<__RadioPag__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SelectedPet : Input<__RadioPag__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class PetReaction : Input<__RadioPag__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
