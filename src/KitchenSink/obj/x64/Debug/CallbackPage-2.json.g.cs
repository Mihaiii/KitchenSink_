// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "CallbackPage.json"
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
using __CCaErrorMes__ = global::KitchenSink.CallbackPage.CallbackPageItem.Input.ErrorMessage;
using __TArray__ = global::Starcounter.Templates.TArray<global::KitchenSink.CallbackPage.CallbackPageItem>;
using __Callback1__ = global::KitchenSink.CallbackPage.JsonByExample;
using __Arr__ = global::Starcounter.Arr<global::KitchenSink.CallbackPage.CallbackPageItem>;
using __Callback2__ = global::KitchenSink.CallbackPage.Input;
using __CaHtml__ = global::KitchenSink.CallbackPage.Input.Html;
using __CaSaveClic__ = global::KitchenSink.CallbackPage.Input.SaveClick;
using __CCaSaveAndC__ = global::KitchenSink.CallbackPage.CallbackPageItem.Input.SaveAndClientMessageClick;
using __CaSaveAndS__ = global::KitchenSink.CallbackPage.Input.SaveAndSpinClick;
using __CaSuccessM__ = global::KitchenSink.CallbackPage.Input.SuccessMessage;
using __CaErrorMes__ = global::KitchenSink.CallbackPage.Input.ErrorMessage;
using __CaSaveAndC__ = global::KitchenSink.CallbackPage.Input.SaveAndClientMessageClick;
using s = Starcounter;
using st = Starcounter.Templates;
using _ScTemplate_ = Starcounter.Templates.Template;
using __CaSaveAndM__ = global::KitchenSink.CallbackPage.Input.SaveAndMessageClick;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __CCaSaveAndM__ = global::KitchenSink.CallbackPage.CallbackPageItem.Input.SaveAndMessageClick;
using __Callback__ = global::KitchenSink.CallbackPage;
using __CaSchema__ = global::KitchenSink.CallbackPage.JsonByExample.Schema;
using __TString__ = global::Starcounter.Templates.TString;
using __TLong__ = global::Starcounter.Templates.TLong;
using __CaCallback__ = global::KitchenSink.CallbackPage.CallbackPageItem;
using __CCaSuccessM__ = global::KitchenSink.CallbackPage.CallbackPageItem.Input.SuccessMessage;
using __Json__ = global::Starcounter.Json;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __CCaSchema__ = global::KitchenSink.CallbackPage.CallbackPageItem.JsonByExample.Schema;
using __CaCallback1__ = global::KitchenSink.CallbackPage.CallbackPageItem.JsonByExample;
using __CaCallback2__ = global::KitchenSink.CallbackPage.CallbackPageItem.Input;
using __CCaSaveClic__ = global::KitchenSink.CallbackPage.CallbackPageItem.Input.SaveClick;
using __CCaSaveAndS__ = global::KitchenSink.CallbackPage.CallbackPageItem.Input.SaveAndSpinClick;
using __TObject__ = global::Starcounter.Templates.TObject;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class CallbackPage_json : s::TemplateAttribute {
    
    #line hidden
    public class Items : s::TemplateAttribute {
    }
    #line default
}
#line default

#line hidden
public partial class CallbackPage : Page {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __CaSchema__ DefaultTemplate = new __CaSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CallbackPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CallbackPage(__CaSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __CaSchema__ Template { get { return (__CaSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : Page.JsonByExample.Schema {
            public Schema()
                : base() {
                InstanceType = typeof(__Callback__);
                ClassName = "CallbackPage";
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/KitchenSink/CallbackPage.html";
                Html.SetCustomAccessors((_p_) => { return ((__Callback__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Callback__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                SaveClick = Add<__TLong__>("SaveClick$");
                SaveClick.DefaultValue = 0L;
                SaveClick.Editable = true;
                SaveClick.SetCustomAccessors((_p_) => { return ((__Callback__)_p_).__bf__SaveClick__; }, (_p_, _v_) => { ((__Callback__)_p_).__bf__SaveClick__ = (System.Int64)_v_; }, false);
                SaveClick.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SaveClick() { App = (CallbackPage)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CallbackPage)pup).Handle((Input.SaveClick)input); });
                SaveAndSpinClick = Add<__TLong__>("SaveAndSpinClick$");
                SaveAndSpinClick.DefaultValue = 0L;
                SaveAndSpinClick.Editable = true;
                SaveAndSpinClick.SetCustomAccessors((_p_) => { return ((__Callback__)_p_).__bf__SaveAndSpinClick__; }, (_p_, _v_) => { ((__Callback__)_p_).__bf__SaveAndSpinClick__ = (System.Int64)_v_; }, false);
                SaveAndSpinClick.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SaveAndSpinClick() { App = (CallbackPage)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CallbackPage)pup).Handle((Input.SaveAndSpinClick)input); });
                SaveAndMessageClick = Add<__TLong__>("SaveAndMessageClick$");
                SaveAndMessageClick.DefaultValue = 0L;
                SaveAndMessageClick.Editable = true;
                SaveAndMessageClick.SetCustomAccessors((_p_) => { return ((__Callback__)_p_).__bf__SaveAndMessageClick__; }, (_p_, _v_) => { ((__Callback__)_p_).__bf__SaveAndMessageClick__ = (System.Int64)_v_; }, false);
                SaveAndMessageClick.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SaveAndMessageClick() { App = (CallbackPage)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CallbackPage)pup).Handle((Input.SaveAndMessageClick)input); });
                SuccessMessage = Add<__TString__>("SuccessMessage$");
                SuccessMessage.DefaultValue = "";
                SuccessMessage.Editable = true;
                SuccessMessage.SetCustomAccessors((_p_) => { return ((__Callback__)_p_).__bf__SuccessMessage__; }, (_p_, _v_) => { ((__Callback__)_p_).__bf__SuccessMessage__ = (System.String)_v_; }, false);
                ErrorMessage = Add<__TString__>("ErrorMessage$");
                ErrorMessage.DefaultValue = "";
                ErrorMessage.Editable = true;
                ErrorMessage.SetCustomAccessors((_p_) => { return ((__Callback__)_p_).__bf__ErrorMessage__; }, (_p_, _v_) => { ((__Callback__)_p_).__bf__ErrorMessage__ = (System.String)_v_; }, false);
                SaveAndClientMessageClick = Add<__TLong__>("SaveAndClientMessageClick$");
                SaveAndClientMessageClick.DefaultValue = 0L;
                SaveAndClientMessageClick.Editable = true;
                SaveAndClientMessageClick.SetCustomAccessors((_p_) => { return ((__Callback__)_p_).__bf__SaveAndClientMessageClick__; }, (_p_, _v_) => { ((__Callback__)_p_).__bf__SaveAndClientMessageClick__ = (System.Int64)_v_; }, false);
                SaveAndClientMessageClick.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SaveAndClientMessageClick() { App = (CallbackPage)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CallbackPage)pup).Handle((Input.SaveAndClientMessageClick)input); });
                Items = Add<__TArray__>("Items");
                Items.SetCustomGetElementType((arr) => { return __CaCallback__.DefaultTemplate;});
                Items.SetCustomAccessors((_p_) => { return ((__Callback__)_p_).__bf__Items__; }, (_p_, _v_) => { ((__Callback__)_p_).__bf__Items__ = (__Arr__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Callback__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TLong__ SaveClick;
            public __TLong__ SaveAndSpinClick;
            public __TLong__ SaveAndMessageClick;
            public __TString__ SuccessMessage;
            public __TString__ ErrorMessage;
            public __TLong__ SaveAndClientMessageClick;
            public __TArray__ Items;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "CallbackPage.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "CallbackPage.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SaveClick__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SaveClick {
    #line 3 "CallbackPage.json"
        get {
        #line hidden
            return Template.SaveClick.Getter(this); }
        #line 3 "CallbackPage.json"
        set {
        #line hidden
            Template.SaveClick.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SaveAndSpinClick__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SaveAndSpinClick {
    #line 4 "CallbackPage.json"
        get {
        #line hidden
            return Template.SaveAndSpinClick.Getter(this); }
        #line 4 "CallbackPage.json"
        set {
        #line hidden
            Template.SaveAndSpinClick.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SaveAndMessageClick__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SaveAndMessageClick {
    #line 5 "CallbackPage.json"
        get {
        #line hidden
            return Template.SaveAndMessageClick.Getter(this); }
        #line 5 "CallbackPage.json"
        set {
        #line hidden
            Template.SaveAndMessageClick.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__SuccessMessage__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String SuccessMessage {
    #line 6 "CallbackPage.json"
        get {
        #line hidden
            return Template.SuccessMessage.Getter(this); }
        #line 6 "CallbackPage.json"
        set {
        #line hidden
            Template.SuccessMessage.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__ErrorMessage__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String ErrorMessage {
    #line 7 "CallbackPage.json"
        get {
        #line hidden
            return Template.ErrorMessage.Getter(this); }
        #line 7 "CallbackPage.json"
        set {
        #line hidden
            Template.ErrorMessage.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SaveAndClientMessageClick__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SaveAndClientMessageClick {
    #line 8 "CallbackPage.json"
        get {
        #line hidden
            return Template.SaveAndClientMessageClick.Getter(this); }
        #line 8 "CallbackPage.json"
        set {
        #line hidden
            Template.SaveAndClientMessageClick.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__Items__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ Items {
    #line 19 "CallbackPage.json"
        get {
        #line hidden
            return Template.Items.Getter(this); }
        #line 19 "CallbackPage.json"
        set {
        #line hidden
            Template.Items.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Callback__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SaveClick : Input<__Callback__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class SaveAndSpinClick : Input<__Callback__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class SaveAndMessageClick : Input<__Callback__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class SuccessMessage : Input<__Callback__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class ErrorMessage : Input<__Callback__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SaveAndClientMessageClick : Input<__Callback__, __TLong__, long> {
        }
        #line default
    }
    #line default
    
    #line hidden
    public partial class CallbackPageItem : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __CCaSchema__ DefaultTemplate = new __CCaSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public CallbackPageItem() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public CallbackPageItem(__CCaSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __CCaSchema__ Template { get { return (__CCaSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class JsonByExample {
            
            #line hidden
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__CaCallback__);
                    ClassName = "CallbackPageItem";
                    Properties.ClearExposed();
                    SaveClick = Add<__TLong__>("SaveClick$");
                    SaveClick.DefaultValue = 0L;
                    SaveClick.Editable = true;
                    SaveClick.SetCustomAccessors((_p_) => { return ((__CaCallback__)_p_).__bf__SaveClick__; }, (_p_, _v_) => { ((__CaCallback__)_p_).__bf__SaveClick__ = (System.Int64)_v_; }, false);
                    SaveClick.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SaveClick() { App = (CallbackPageItem)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CallbackPageItem)pup).Handle((Input.SaveClick)input); });
                    SaveAndSpinClick = Add<__TLong__>("SaveAndSpinClick$");
                    SaveAndSpinClick.DefaultValue = 0L;
                    SaveAndSpinClick.Editable = true;
                    SaveAndSpinClick.SetCustomAccessors((_p_) => { return ((__CaCallback__)_p_).__bf__SaveAndSpinClick__; }, (_p_, _v_) => { ((__CaCallback__)_p_).__bf__SaveAndSpinClick__ = (System.Int64)_v_; }, false);
                    SaveAndSpinClick.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SaveAndSpinClick() { App = (CallbackPageItem)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CallbackPageItem)pup).Handle((Input.SaveAndSpinClick)input); });
                    SaveAndMessageClick = Add<__TLong__>("SaveAndMessageClick$");
                    SaveAndMessageClick.DefaultValue = 0L;
                    SaveAndMessageClick.Editable = true;
                    SaveAndMessageClick.SetCustomAccessors((_p_) => { return ((__CaCallback__)_p_).__bf__SaveAndMessageClick__; }, (_p_, _v_) => { ((__CaCallback__)_p_).__bf__SaveAndMessageClick__ = (System.Int64)_v_; }, false);
                    SaveAndMessageClick.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SaveAndMessageClick() { App = (CallbackPageItem)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CallbackPageItem)pup).Handle((Input.SaveAndMessageClick)input); });
                    SuccessMessage = Add<__TString__>("SuccessMessage$");
                    SuccessMessage.DefaultValue = "";
                    SuccessMessage.Editable = true;
                    SuccessMessage.SetCustomAccessors((_p_) => { return ((__CaCallback__)_p_).__bf__SuccessMessage__; }, (_p_, _v_) => { ((__CaCallback__)_p_).__bf__SuccessMessage__ = (System.String)_v_; }, false);
                    ErrorMessage = Add<__TString__>("ErrorMessage$");
                    ErrorMessage.DefaultValue = "";
                    ErrorMessage.Editable = true;
                    ErrorMessage.SetCustomAccessors((_p_) => { return ((__CaCallback__)_p_).__bf__ErrorMessage__; }, (_p_, _v_) => { ((__CaCallback__)_p_).__bf__ErrorMessage__ = (System.String)_v_; }, false);
                    SaveAndClientMessageClick = Add<__TLong__>("SaveAndClientMessageClick$");
                    SaveAndClientMessageClick.DefaultValue = 0L;
                    SaveAndClientMessageClick.Editable = true;
                    SaveAndClientMessageClick.SetCustomAccessors((_p_) => { return ((__CaCallback__)_p_).__bf__SaveAndClientMessageClick__; }, (_p_, _v_) => { ((__CaCallback__)_p_).__bf__SaveAndClientMessageClick__ = (System.Int64)_v_; }, false);
                    SaveAndClientMessageClick.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SaveAndClientMessageClick() { App = (CallbackPageItem)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CallbackPageItem)pup).Handle((Input.SaveAndClientMessageClick)input); });
                }
                public override object CreateInstance(s.Json parent) { return new __CaCallback__(this) { Parent = parent }; }
                public __TLong__ SaveClick;
                public __TLong__ SaveAndSpinClick;
                public __TLong__ SaveAndMessageClick;
                public __TString__ SuccessMessage;
                public __TString__ ErrorMessage;
                public __TLong__ SaveAndClientMessageClick;
            }
            #line default
        }
        #line default
        #line hidden
        private System.Int64 __bf__SaveClick__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 SaveClick {
        #line 11 "CallbackPage.json"
            get {
            #line hidden
                return Template.SaveClick.Getter(this); }
            #line 11 "CallbackPage.json"
            set {
            #line hidden
                Template.SaveClick.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__SaveAndSpinClick__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 SaveAndSpinClick {
        #line 12 "CallbackPage.json"
            get {
            #line hidden
                return Template.SaveAndSpinClick.Getter(this); }
            #line 12 "CallbackPage.json"
            set {
            #line hidden
                Template.SaveAndSpinClick.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__SaveAndMessageClick__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 SaveAndMessageClick {
        #line 13 "CallbackPage.json"
            get {
            #line hidden
                return Template.SaveAndMessageClick.Getter(this); }
            #line 13 "CallbackPage.json"
            set {
            #line hidden
                Template.SaveAndMessageClick.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__SuccessMessage__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String SuccessMessage {
        #line 14 "CallbackPage.json"
            get {
            #line hidden
                return Template.SuccessMessage.Getter(this); }
            #line 14 "CallbackPage.json"
            set {
            #line hidden
                Template.SuccessMessage.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__ErrorMessage__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String ErrorMessage {
        #line 15 "CallbackPage.json"
            get {
            #line hidden
                return Template.ErrorMessage.Getter(this); }
            #line 15 "CallbackPage.json"
            set {
            #line hidden
                Template.ErrorMessage.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__SaveAndClientMessageClick__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 SaveAndClientMessageClick {
        #line 17 "CallbackPage.json"
            get {
            #line hidden
                return Template.SaveAndClientMessageClick.Getter(this); }
            #line 17 "CallbackPage.json"
            set {
            #line hidden
                Template.SaveAndClientMessageClick.Setter(this, value); } }
            #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class Input {
            
            #line hidden
            public class SaveClick : Input<__CaCallback__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class SaveAndSpinClick : Input<__CaCallback__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class SaveAndMessageClick : Input<__CaCallback__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class SuccessMessage : Input<__CaCallback__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class ErrorMessage : Input<__CaCallback__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class SaveAndClientMessageClick : Input<__CaCallback__, __TLong__, long> {
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
