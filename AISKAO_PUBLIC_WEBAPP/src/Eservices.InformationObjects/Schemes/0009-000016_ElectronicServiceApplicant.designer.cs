// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>TechnoLogica.Eservices.InformationObjects</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>True</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>True</IncludeSerializeMethod><UseBaseClass>True</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>True</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net40</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>ASCII</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace TechnoLogica.Eservices.InformationObjects {
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.IO;
    using System.Text;
    using System.Collections.Generic;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.38968")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ereg.egov.bg/segment/0009-000016")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://ereg.egov.bg/segment/0009-000016", IsNullable=true)]
    public partial class ElectronicServiceApplicant : InformationObject<ElectronicServiceApplicant> {
        
        private List<ElectronicServiceApplicantRecipientGroup> recipientGroupField;
        
        private string emailAddressField;
        
        /// <summary>
        /// ElectronicServiceApplicant class constructor
        /// </summary>
        public ElectronicServiceApplicant() {
            this.recipientGroupField = new List<ElectronicServiceApplicantRecipientGroup>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("RecipientGroup", Order=0)]
        public List<ElectronicServiceApplicantRecipientGroup> RecipientGroup {
            get {
                return this.recipientGroupField;
            }
            set {
                if ((this.recipientGroupField != null)) {
                    if ((recipientGroupField.Equals(value) != true)) {
                        this.recipientGroupField = value;
                        this.OnPropertyChanged("RecipientGroup");
                    }
                }
                else {
                    this.recipientGroupField = value;
                    this.OnPropertyChanged("RecipientGroup");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string EmailAddress {
            get {
                return this.emailAddressField;
            }
            set {
                if ((this.emailAddressField != null)) {
                    if ((emailAddressField.Equals(value) != true)) {
                        this.emailAddressField = value;
                        this.OnPropertyChanged("EmailAddress");
                    }
                }
                else {
                    this.emailAddressField = value;
                    this.OnPropertyChanged("EmailAddress");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.38968")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://ereg.egov.bg/segment/0009-000016")]
    public partial class ElectronicServiceApplicantRecipientGroup : InformationObject<ElectronicServiceApplicantRecipientGroup> {
        
        private List<ElectronicStatementAuthor> authorField;
        
        private string authorQualityField;
        
        private List<ElectronicServiceRecipient> recipientField;
        
        /// <summary>
        /// ElectronicServiceApplicantRecipientGroup class constructor
        /// </summary>
        public ElectronicServiceApplicantRecipientGroup() {
            this.recipientField = new List<ElectronicServiceRecipient>();
            this.authorField = new List<ElectronicStatementAuthor>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Author", Order=0)]
        public List<ElectronicStatementAuthor> Author {
            get {
                return this.authorField;
            }
            set {
                if ((this.authorField != null)) {
                    if ((authorField.Equals(value) != true)) {
                        this.authorField = value;
                        this.OnPropertyChanged("Author");
                    }
                }
                else {
                    this.authorField = value;
                    this.OnPropertyChanged("Author");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string AuthorQuality {
            get {
                return this.authorQualityField;
            }
            set {
                if ((this.authorQualityField != null)) {
                    if ((authorQualityField.Equals(value) != true)) {
                        this.authorQualityField = value;
                        this.OnPropertyChanged("AuthorQuality");
                    }
                }
                else {
                    this.authorQualityField = value;
                    this.OnPropertyChanged("AuthorQuality");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Recipient", Order=2)]
        public List<ElectronicServiceRecipient> Recipient {
            get {
                return this.recipientField;
            }
            set {
                if ((this.recipientField != null)) {
                    if ((recipientField.Equals(value) != true)) {
                        this.recipientField = value;
                        this.OnPropertyChanged("Recipient");
                    }
                }
                else {
                    this.recipientField = value;
                    this.OnPropertyChanged("Recipient");
                }
            }
        }
    }
}
