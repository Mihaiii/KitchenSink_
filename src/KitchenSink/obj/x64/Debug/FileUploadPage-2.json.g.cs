// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "FileUploadPage.json"
// Version: 2
// DO NOT MODIFY DIRECTLY - CHANGES WILL BE OVERWRITTEN

using System;
using System.Collections;
using System.Collections.Generic;
using Starcounter.Advanced;
using Starcounter;
using Starcounter.Internal;
using Starcounter.Templates;
using System.IO;
#pragma warning disable 0108
#pragma warning disable 1591

namespace KitchenSink {
using __FFiSchema1__ = global::KitchenSink.FileUploadPage.FileUploadTaskPage.JsonByExample.Schema;
using __FiFileUplo5__ = global::KitchenSink.FileUploadPage.FileUploadTaskPage.Input;
using __FFiFileName1__ = global::KitchenSink.FileUploadPage.FileUploadTaskPage.Input.FileName;
using __FFiFileSize2__ = global::KitchenSink.FileUploadPage.FileUploadTaskPage.Input.FileSize;
using __FFiFileSize3__ = global::KitchenSink.FileUploadPage.FileUploadTaskPage.Input.FileSizeString;
using __FFiProgress__ = global::KitchenSink.FileUploadPage.FileUploadTaskPage.Input.Progress;
using __FFiMessage__ = global::KitchenSink.FileUploadPage.FileUploadTaskPage.Input.Message;
using __TArray1__ = global::Starcounter.Templates.TArray<global::KitchenSink.FileUploadPage.FileUploadTaskPage>;
using __FileUplo1__ = global::KitchenSink.FileUploadPage.JsonByExample;
using __Arr__ = global::Starcounter.Arr<global::KitchenSink.FileUploadPage.FileUploadFilePage>;
using __Arr1__ = global::Starcounter.Arr<global::KitchenSink.FileUploadPage.FileUploadTaskPage>;
using __FileUplo2__ = global::KitchenSink.FileUploadPage.Input;
using __FiHtml__ = global::KitchenSink.FileUploadPage.Input.Html;
using __FiSessionI__ = global::KitchenSink.FileUploadPage.Input.SessionId;
using __FiUploadUr__ = global::KitchenSink.FileUploadPage.Input.UploadUrl;
using s = Starcounter;
using st = Starcounter.Templates;
using _ScTemplate_ = Starcounter.Templates.Template;
using __FiFileUplo4__ = global::KitchenSink.FileUploadPage.FileUploadTaskPage.JsonByExample;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __TArray__ = global::Starcounter.Templates.TArray<global::KitchenSink.FileUploadPage.FileUploadFilePage>;
using __FileUplo__ = global::KitchenSink.FileUploadPage;
using __Json__ = global::Starcounter.Json;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __FiSchema__ = global::KitchenSink.FileUploadPage.JsonByExample.Schema;
using __TString__ = global::Starcounter.Templates.TString;
using __FiFileUplo__ = global::KitchenSink.FileUploadPage.FileUploadFilePage;
using __FiFileUplo3__ = global::KitchenSink.FileUploadPage.FileUploadTaskPage;
using __FFiSchema__ = global::KitchenSink.FileUploadPage.FileUploadFilePage.JsonByExample.Schema;
using __FiFileUplo1__ = global::KitchenSink.FileUploadPage.FileUploadFilePage.JsonByExample;
using __FiFileUplo2__ = global::KitchenSink.FileUploadPage.FileUploadFilePage.Input;
using __FFiFileName__ = global::KitchenSink.FileUploadPage.FileUploadFilePage.Input.FileName;
using __FFiFilePath__ = global::KitchenSink.FileUploadPage.FileUploadFilePage.Input.FilePath;
using __FFiFileSize__ = global::KitchenSink.FileUploadPage.FileUploadFilePage.Input.FileSize;
using __FFiFileSize1__ = global::KitchenSink.FileUploadPage.FileUploadFilePage.Input.FileSizeString;
using __FFiDeleteCl__ = global::KitchenSink.FileUploadPage.FileUploadFilePage.Input.DeleteClick;
using __TLong__ = global::Starcounter.Templates.TLong;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class FileUploadPage_json : s::TemplateAttribute {
    
    #line hidden
    public class Files : s::TemplateAttribute {
    }
    #line default
    
    #line hidden
    public class Tasks : s::TemplateAttribute {
    }
    #line default
}
#line default

#line hidden
public partial class FileUploadPage : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __FiSchema__ DefaultTemplate = new __FiSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FileUploadPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FileUploadPage(__FiSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __FiSchema__ Template { get { return (__FiSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__FileUplo__);
                ClassName = "FileUploadPage";
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/KitchenSink/FileUploadPage.html";
                Html.SetCustomAccessors((_p_) => { return ((__FileUplo__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__FileUplo__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                SessionId = Add<__TString__>("SessionId");
                SessionId.DefaultValue = "";
                SessionId.SetCustomAccessors((_p_) => { return ((__FileUplo__)_p_).__bf__SessionId__; }, (_p_, _v_) => { ((__FileUplo__)_p_).__bf__SessionId__ = (System.String)_v_; }, false);
                UploadUrl = Add<__TString__>("UploadUrl");
                UploadUrl.DefaultValue = "/KitchenSink/fileupload/upload";
                UploadUrl.SetCustomAccessors((_p_) => { return ((__FileUplo__)_p_).__bf__UploadUrl__; }, (_p_, _v_) => { ((__FileUplo__)_p_).__bf__UploadUrl__ = (System.String)_v_; }, false);
                Files = Add<__TArray__>("Files");
                Files.SetCustomGetElementType((arr) => { return __FiFileUplo__.DefaultTemplate;});
                Files.SetCustomAccessors((_p_) => { return ((__FileUplo__)_p_).__bf__Files__; }, (_p_, _v_) => { ((__FileUplo__)_p_).__bf__Files__ = (__Arr__)_v_; }, false);
                Tasks = Add<__TArray1__>("Tasks");
                Tasks.SetCustomGetElementType((arr) => { return __FiFileUplo3__.DefaultTemplate;});
                Tasks.SetCustomAccessors((_p_) => { return ((__FileUplo__)_p_).__bf__Tasks__; }, (_p_, _v_) => { ((__FileUplo__)_p_).__bf__Tasks__ = (__Arr1__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __FileUplo__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ SessionId;
            public __TString__ UploadUrl;
            public __TArray__ Files;
            public __TArray1__ Tasks;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "FileUploadPage.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "FileUploadPage.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__SessionId__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String SessionId {
    #line 3 "FileUploadPage.json"
        get {
        #line hidden
            return Template.SessionId.Getter(this); }
        #line 3 "FileUploadPage.json"
        set {
        #line hidden
            Template.SessionId.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__UploadUrl__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String UploadUrl {
    #line 4 "FileUploadPage.json"
        get {
        #line hidden
            return Template.UploadUrl.Getter(this); }
        #line 4 "FileUploadPage.json"
        set {
        #line hidden
            Template.UploadUrl.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__Files__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ Files {
    #line 13 "FileUploadPage.json"
        get {
        #line hidden
            return Template.Files.Getter(this); }
        #line 13 "FileUploadPage.json"
        set {
        #line hidden
            Template.Files.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr1__ __bf__Tasks__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr1__ Tasks {
    #line 23 "FileUploadPage.json"
        get {
        #line hidden
            return Template.Tasks.Getter(this); }
        #line 23 "FileUploadPage.json"
        set {
        #line hidden
            Template.Tasks.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__FileUplo__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SessionId : Input<__FileUplo__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class UploadUrl : Input<__FileUplo__, __TString__, string> {
        }
        #line default
    }
    #line default
    
    #line hidden
    public partial class FileUploadFilePage : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __FFiSchema__ DefaultTemplate = new __FFiSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public FileUploadFilePage() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public FileUploadFilePage(__FFiSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __FFiSchema__ Template { get { return (__FFiSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class JsonByExample {
            
            #line hidden
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__FiFileUplo__);
                    ClassName = "FileUploadFilePage";
                    Properties.ClearExposed();
                    FileName = Add<__TString__>("FileName");
                    FileName.DefaultValue = "";
                    FileName.SetCustomAccessors((_p_) => { return ((__FiFileUplo__)_p_).__bf__FileName__; }, (_p_, _v_) => { ((__FiFileUplo__)_p_).__bf__FileName__ = (System.String)_v_; }, false);
                    FilePath = Add<__TString__>("FilePath");
                    FilePath.DefaultValue = "";
                    FilePath.SetCustomAccessors((_p_) => { return ((__FiFileUplo__)_p_).__bf__FilePath__; }, (_p_, _v_) => { ((__FiFileUplo__)_p_).__bf__FilePath__ = (System.String)_v_; }, false);
                    FileSize = Add<__TLong__>("FileSize");
                    FileSize.DefaultValue = 0L;
                    FileSize.SetCustomAccessors((_p_) => { return ((__FiFileUplo__)_p_).__bf__FileSize__; }, (_p_, _v_) => { ((__FiFileUplo__)_p_).__bf__FileSize__ = (System.Int64)_v_; }, false);
                    FileSizeString = Add<__TString__>("FileSizeString");
                    FileSizeString.DefaultValue = "";
                    FileSizeString.SetCustomAccessors((_p_) => { return ((__FiFileUplo__)_p_).__bf__FileSizeString__; }, (_p_, _v_) => { ((__FiFileUplo__)_p_).__bf__FileSizeString__ = (System.String)_v_; }, false);
                    DeleteClick = Add<__TLong__>("DeleteClick$");
                    DeleteClick.DefaultValue = 0L;
                    DeleteClick.Editable = true;
                    DeleteClick.SetCustomAccessors((_p_) => { return ((__FiFileUplo__)_p_).__bf__DeleteClick__; }, (_p_, _v_) => { ((__FiFileUplo__)_p_).__bf__DeleteClick__ = (System.Int64)_v_; }, false);
                    DeleteClick.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.DeleteClick() { App = (FileUploadFilePage)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((FileUploadFilePage)pup).Handle((Input.DeleteClick)input); });
                }
                public override object CreateInstance(s.Json parent) { return new __FiFileUplo__(this) { Parent = parent }; }
                public __TString__ FileName;
                public __TString__ FilePath;
                public __TLong__ FileSize;
                public __TString__ FileSizeString;
                public __TLong__ DeleteClick;
            }
            #line default
        }
        #line default
        #line hidden
        private System.String __bf__FileName__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String FileName {
        #line 7 "FileUploadPage.json"
            get {
            #line hidden
                return Template.FileName.Getter(this); }
            #line 7 "FileUploadPage.json"
            set {
            #line hidden
                Template.FileName.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__FilePath__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String FilePath {
        #line 8 "FileUploadPage.json"
            get {
            #line hidden
                return Template.FilePath.Getter(this); }
            #line 8 "FileUploadPage.json"
            set {
            #line hidden
                Template.FilePath.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__FileSize__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 FileSize {
        #line 9 "FileUploadPage.json"
            get {
            #line hidden
                return Template.FileSize.Getter(this); }
            #line 9 "FileUploadPage.json"
            set {
            #line hidden
                Template.FileSize.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__FileSizeString__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String FileSizeString {
        #line 10 "FileUploadPage.json"
            get {
            #line hidden
                return Template.FileSizeString.Getter(this); }
            #line 10 "FileUploadPage.json"
            set {
            #line hidden
                Template.FileSizeString.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__DeleteClick__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 DeleteClick {
        #line 12 "FileUploadPage.json"
            get {
            #line hidden
                return Template.DeleteClick.Getter(this); }
            #line 12 "FileUploadPage.json"
            set {
            #line hidden
                Template.DeleteClick.Setter(this, value); } }
            #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class Input {
            
            #line hidden
            public class FileName : Input<__FiFileUplo__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class FilePath : Input<__FiFileUplo__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class FileSize : Input<__FiFileUplo__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class FileSizeString : Input<__FiFileUplo__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class DeleteClick : Input<__FiFileUplo__, __TLong__, long> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    public partial class FileUploadTaskPage : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __FFiSchema1__ DefaultTemplate = new __FFiSchema1__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public FileUploadTaskPage() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public FileUploadTaskPage(__FFiSchema1__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __FFiSchema1__ Template { get { return (__FFiSchema1__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class JsonByExample {
            
            #line hidden
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__FiFileUplo3__);
                    ClassName = "FileUploadTaskPage";
                    Properties.ClearExposed();
                    FileName = Add<__TString__>("FileName");
                    FileName.DefaultValue = "";
                    FileName.SetCustomAccessors((_p_) => { return ((__FiFileUplo3__)_p_).__bf__FileName__; }, (_p_, _v_) => { ((__FiFileUplo3__)_p_).__bf__FileName__ = (System.String)_v_; }, false);
                    FileSize = Add<__TLong__>("FileSize");
                    FileSize.DefaultValue = 0L;
                    FileSize.SetCustomAccessors((_p_) => { return ((__FiFileUplo3__)_p_).__bf__FileSize__; }, (_p_, _v_) => { ((__FiFileUplo3__)_p_).__bf__FileSize__ = (System.Int64)_v_; }, false);
                    FileSizeString = Add<__TString__>("FileSizeString");
                    FileSizeString.DefaultValue = "";
                    FileSizeString.SetCustomAccessors((_p_) => { return ((__FiFileUplo3__)_p_).__bf__FileSizeString__; }, (_p_, _v_) => { ((__FiFileUplo3__)_p_).__bf__FileSizeString__ = (System.String)_v_; }, false);
                    Progress = Add<__TLong__>("Progress");
                    Progress.DefaultValue = 0L;
                    Progress.SetCustomAccessors((_p_) => { return ((__FiFileUplo3__)_p_).__bf__Progress__; }, (_p_, _v_) => { ((__FiFileUplo3__)_p_).__bf__Progress__ = (System.Int64)_v_; }, false);
                    Message = Add<__TString__>("Message");
                    Message.DefaultValue = "";
                    Message.SetCustomAccessors((_p_) => { return ((__FiFileUplo3__)_p_).__bf__Message__; }, (_p_, _v_) => { ((__FiFileUplo3__)_p_).__bf__Message__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __FiFileUplo3__(this) { Parent = parent }; }
                public __TString__ FileName;
                public __TLong__ FileSize;
                public __TString__ FileSizeString;
                public __TLong__ Progress;
                public __TString__ Message;
            }
            #line default
        }
        #line default
        #line hidden
        private System.String __bf__FileName__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String FileName {
        #line 16 "FileUploadPage.json"
            get {
            #line hidden
                return Template.FileName.Getter(this); }
            #line 16 "FileUploadPage.json"
            set {
            #line hidden
                Template.FileName.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__FileSize__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 FileSize {
        #line 17 "FileUploadPage.json"
            get {
            #line hidden
                return Template.FileSize.Getter(this); }
            #line 17 "FileUploadPage.json"
            set {
            #line hidden
                Template.FileSize.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__FileSizeString__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String FileSizeString {
        #line 18 "FileUploadPage.json"
            get {
            #line hidden
                return Template.FileSizeString.Getter(this); }
            #line 18 "FileUploadPage.json"
            set {
            #line hidden
                Template.FileSizeString.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__Progress__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 Progress {
        #line 19 "FileUploadPage.json"
            get {
            #line hidden
                return Template.Progress.Getter(this); }
            #line 19 "FileUploadPage.json"
            set {
            #line hidden
                Template.Progress.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__Message__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Message {
        #line 21 "FileUploadPage.json"
            get {
            #line hidden
                return Template.Message.Getter(this); }
            #line 21 "FileUploadPage.json"
            set {
            #line hidden
                Template.Message.Setter(this, value); } }
            #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class Input {
            
            #line hidden
            public class FileName : Input<__FiFileUplo3__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class FileSize : Input<__FiFileUplo3__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class FileSizeString : Input<__FiFileUplo3__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class Progress : Input<__FiFileUplo3__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class Message : Input<__FiFileUplo3__, __TString__, string> {
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
