// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.3.0.31926
//    <NameSpace>TechnoLogica.Eservices.InformationObjects</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>True</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>True</IncludeSerializeMethod><UseBaseClass>True</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>True</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net40</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><CustomUsings>InformationObjects.Nomenclatures</CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace TechnoLogica.Eservices.InformationObjects {
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using InformationObjects.Nomenclatures;
    using System.IO;
    using System.Collections.Generic;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.3.0.31927")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ereg.egov.bg/segment/0009-000017")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://ereg.egov.bg/segment/0009-000017", IsNullable=false)]
    public partial class ReceiptNotAcknowledgedMessage : InformationObject<ReceiptNotAcknowledgedMessage> {
        
        private DocumentURI messageURIField;
        
        private ElectronicServiceProviderBasicData electronicServiceProviderField;
        
        private DocumentElectronicTransportType transportTypeField;
        
        private bool transportTypeFieldSpecified;
        
        private List<ElectronicDocumentDiscrepancyType> discrepanciesField;
        
        private ElectronicServiceApplicant applicantField;
        
        private DocumentTypeURI documentTypeURIField;
        
        private string documentTypeNameField;
        
        private System.DateTime messageCreationTimeField;
        
        private bool messageCreationTimeFieldSpecified;
        
        private XMLDigitalSignature signatureField;
        
        /// <summary>
        /// ReceiptNotAcknowledgedMessage class constructor
        /// </summary>
        public ReceiptNotAcknowledgedMessage() {
            this.signatureField = new XMLDigitalSignature();
            this.documentTypeURIField = new DocumentTypeURI();
            this.applicantField = new ElectronicServiceApplicant();
            this.discrepanciesField = new List<ElectronicDocumentDiscrepancyType>();
            this.electronicServiceProviderField = new ElectronicServiceProviderBasicData();
            this.messageURIField = new DocumentURI();
        }
        
        public DocumentURI MessageURI {
            get {
                return this.messageURIField;
            }
            set {
                if ((this.messageURIField != null)) {
                    if ((messageURIField.Equals(value) != true)) {
                        this.messageURIField = value;
                        this.OnPropertyChanged("MessageURI");
                    }
                }
                else {
                    this.messageURIField = value;
                    this.OnPropertyChanged("MessageURI");
                }
            }
        }
        
        public ElectronicServiceProviderBasicData ElectronicServiceProvider {
            get {
                return this.electronicServiceProviderField;
            }
            set {
                if ((this.electronicServiceProviderField != null)) {
                    if ((electronicServiceProviderField.Equals(value) != true)) {
                        this.electronicServiceProviderField = value;
                        this.OnPropertyChanged("ElectronicServiceProvider");
                    }
                }
                else {
                    this.electronicServiceProviderField = value;
                    this.OnPropertyChanged("ElectronicServiceProvider");
                }
            }
        }
        
        public DocumentElectronicTransportType TransportType {
            get {
                return this.transportTypeField;
            }
            set {
                if ((transportTypeField.Equals(value) != true)) {
                    this.transportTypeField = value;
                    this.OnPropertyChanged("TransportType");
                }
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TransportTypeSpecified {
            get {
                return this.transportTypeFieldSpecified;
            }
            set {
                if ((transportTypeFieldSpecified.Equals(value) != true)) {
                    this.transportTypeFieldSpecified = value;
                    this.OnPropertyChanged("TransportTypeSpecified");
                }
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Discrepancy", IsNullable=false)]
        public List<ElectronicDocumentDiscrepancyType> Discrepancies {
            get {
                return this.discrepanciesField;
            }
            set {
                if ((this.discrepanciesField != null)) {
                    if ((discrepanciesField.Equals(value) != true)) {
                        this.discrepanciesField = value;
                        this.OnPropertyChanged("Discrepancies");
                    }
                }
                else {
                    this.discrepanciesField = value;
                    this.OnPropertyChanged("Discrepancies");
                }
            }
        }
        
        public ElectronicServiceApplicant Applicant {
            get {
                return this.applicantField;
            }
            set {
                if ((this.applicantField != null)) {
                    if ((applicantField.Equals(value) != true)) {
                        this.applicantField = value;
                        this.OnPropertyChanged("Applicant");
                    }
                }
                else {
                    this.applicantField = value;
                    this.OnPropertyChanged("Applicant");
                }
            }
        }
        
        public DocumentTypeURI DocumentTypeURI {
            get {
                return this.documentTypeURIField;
            }
            set {
                if ((this.documentTypeURIField != null)) {
                    if ((documentTypeURIField.Equals(value) != true)) {
                        this.documentTypeURIField = value;
                        this.OnPropertyChanged("DocumentTypeURI");
                    }
                }
                else {
                    this.documentTypeURIField = value;
                    this.OnPropertyChanged("DocumentTypeURI");
                }
            }
        }
        
        public string DocumentTypeName {
            get {
                return this.documentTypeNameField;
            }
            set {
                if ((this.documentTypeNameField != null)) {
                    if ((documentTypeNameField.Equals(value) != true)) {
                        this.documentTypeNameField = value;
                        this.OnPropertyChanged("DocumentTypeName");
                    }
                }
                else {
                    this.documentTypeNameField = value;
                    this.OnPropertyChanged("DocumentTypeName");
                }
            }
        }
        
        public System.DateTime MessageCreationTime {
            get {
                return this.messageCreationTimeField;
            }
            set {
                if ((messageCreationTimeField.Equals(value) != true)) {
                    this.messageCreationTimeField = value;
                    this.OnPropertyChanged("MessageCreationTime");
                }
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MessageCreationTimeSpecified {
            get {
                return this.messageCreationTimeFieldSpecified;
            }
            set {
                if ((messageCreationTimeFieldSpecified.Equals(value) != true)) {
                    this.messageCreationTimeFieldSpecified = value;
                    this.OnPropertyChanged("MessageCreationTimeSpecified");
                }
            }
        }
        
        public XMLDigitalSignature Signature {
            get {
                return this.signatureField;
            }
            set {
                if ((this.signatureField != null)) {
                    if ((signatureField.Equals(value) != true)) {
                        this.signatureField = value;
                        this.OnPropertyChanged("Signature");
                    }
                }
                else {
                    this.signatureField = value;
                    this.OnPropertyChanged("Signature");
                }
            }
        }
    }
}
