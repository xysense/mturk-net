﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.0.30319.33440.
// 
namespace MTurk.DTO.Internals {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://mechanicalturk.amazonaws.com/AWSMechanicalTurkDataSchemas/2005-10-01/Quest" +
        "ionFormAnswers.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://mechanicalturk.amazonaws.com/AWSMechanicalTurkDataSchemas/2005-10-01/Quest" +
        "ionFormAnswers.xsd", IsNullable=false)]
    public partial class QuestionFormAnswers {
        
        private QuestionFormAnswersAnswer[] answerField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Answer")]
        public QuestionFormAnswersAnswer[] Answer {
            get {
                return this.answerField;
            }
            set {
                this.answerField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://mechanicalturk.amazonaws.com/AWSMechanicalTurkDataSchemas/2005-10-01/Quest" +
        "ionFormAnswers.xsd")]
    public partial class QuestionFormAnswersAnswer {
        
        private string questionIdentifierField;
        
        private string[] itemsField;
        
        private ItemsChoiceType[] itemsElementNameField;
        
        /// <remarks/>
        public string QuestionIdentifier {
            get {
                return this.questionIdentifierField;
            }
            set {
                this.questionIdentifierField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FreeText", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("OtherSelectionText", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("SelectionIdentifier", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("UploadedFileKey", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("UploadedFileSizeInBytes", typeof(string), DataType="positiveInteger")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://mechanicalturk.amazonaws.com/AWSMechanicalTurkDataSchemas/2005-10-01/Quest" +
        "ionFormAnswers.xsd", IncludeInSchema=false)]
    public enum ItemsChoiceType {
        
        /// <remarks/>
        FreeText,
        
        /// <remarks/>
        OtherSelectionText,
        
        /// <remarks/>
        SelectionIdentifier,
        
        /// <remarks/>
        UploadedFileKey,
        
        /// <remarks/>
        UploadedFileSizeInBytes,
    }
}
