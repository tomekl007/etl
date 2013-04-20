﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("StocExchangeModel", "company_record", "Companies", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(ParsXtmlExamle.Company), "Records", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(ParsXtmlExamle.Record), true)]

#endregion

namespace ParsXtmlExamle
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class StocExchangeEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new StocExchangeEntities object using the connection string found in the 'StocExchangeEntities' section of the application configuration file.
        /// </summary>
        public StocExchangeEntities() : base("name=StocExchangeEntities", "StocExchangeEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new StocExchangeEntities object.
        /// </summary>
        public StocExchangeEntities(string connectionString) : base(connectionString, "StocExchangeEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new StocExchangeEntities object.
        /// </summary>
        public StocExchangeEntities(EntityConnection connection) : base(connection, "StocExchangeEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Company> Companies
        {
            get
            {
                if ((_Companies == null))
                {
                    _Companies = base.CreateObjectSet<Company>("Companies");
                }
                return _Companies;
            }
        }
        private ObjectSet<Company> _Companies;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Record> Records
        {
            get
            {
                if ((_Records == null))
                {
                    _Records = base.CreateObjectSet<Record>("Records");
                }
                return _Records;
            }
        }
        private ObjectSet<Record> _Records;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Companies EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCompanies(Company company)
        {
            base.AddObject("Companies", company);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Records EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToRecords(Record record)
        {
            base.AddObject("Records", record);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="StocExchangeModel", Name="Company")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Company : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Company object.
        /// </summary>
        /// <param name="symbol">Initial value of the Symbol property.</param>
        public static Company CreateCompany(global::System.String symbol)
        {
            Company company = new Company();
            company.Symbol = symbol;
            return company;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Symbol
        {
            get
            {
                return _Symbol;
            }
            set
            {
                if (_Symbol != value)
                {
                    OnSymbolChanging(value);
                    ReportPropertyChanging("Symbol");
                    _Symbol = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("Symbol");
                    OnSymbolChanged();
                }
            }
        }
        private global::System.String _Symbol;
        partial void OnSymbolChanging(global::System.String value);
        partial void OnSymbolChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("StocExchangeModel", "company_record", "Records")]
        public EntityCollection<Record> Records
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Record>("StocExchangeModel.company_record", "Records");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Record>("StocExchangeModel.company_record", "Records", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="StocExchangeModel", Name="Record")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Record : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Record object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        public static Record CreateRecord(global::System.String id)
        {
            Record record = new Record();
            record.Id = id;
            return record;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Double> High
        {
            get
            {
                return _High;
            }
            set
            {
                OnHighChanging(value);
                ReportPropertyChanging("High");
                _High = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("High");
                OnHighChanged();
            }
        }
        private Nullable<global::System.Double> _High;
        partial void OnHighChanging(Nullable<global::System.Double> value);
        partial void OnHighChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Double> Low
        {
            get
            {
                return _Low;
            }
            set
            {
                OnLowChanging(value);
                ReportPropertyChanging("Low");
                _Low = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Low");
                OnLowChanged();
            }
        }
        private Nullable<global::System.Double> _Low;
        partial void OnLowChanging(Nullable<global::System.Double> value);
        partial void OnLowChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Double> Close
        {
            get
            {
                return _Close;
            }
            set
            {
                OnCloseChanging(value);
                ReportPropertyChanging("Close");
                _Close = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Close");
                OnCloseChanged();
            }
        }
        private Nullable<global::System.Double> _Close;
        partial void OnCloseChanging(Nullable<global::System.Double> value);
        partial void OnCloseChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Volume
        {
            get
            {
                return _Volume;
            }
            set
            {
                OnVolumeChanging(value);
                ReportPropertyChanging("Volume");
                _Volume = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Volume");
                OnVolumeChanged();
            }
        }
        private Nullable<global::System.Int32> _Volume;
        partial void OnVolumeChanging(Nullable<global::System.Int32> value);
        partial void OnVolumeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Double> ChangeOne
        {
            get
            {
                return _ChangeOne;
            }
            set
            {
                OnChangeOneChanging(value);
                ReportPropertyChanging("ChangeOne");
                _ChangeOne = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ChangeOne");
                OnChangeOneChanged();
            }
        }
        private Nullable<global::System.Double> _ChangeOne;
        partial void OnChangeOneChanging(Nullable<global::System.Double> value);
        partial void OnChangeOneChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Double> ChangeTwo
        {
            get
            {
                return _ChangeTwo;
            }
            set
            {
                OnChangeTwoChanging(value);
                ReportPropertyChanging("ChangeTwo");
                _ChangeTwo = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ChangeTwo");
                OnChangeTwoChanged();
            }
        }
        private Nullable<global::System.Double> _ChangeTwo;
        partial void OnChangeTwoChanging(Nullable<global::System.Double> value);
        partial void OnChangeTwoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.String _Id;
        partial void OnIdChanging(global::System.String value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> DateOfRecord
        {
            get
            {
                return _DateOfRecord;
            }
            set
            {
                OnDateOfRecordChanging(value);
                ReportPropertyChanging("DateOfRecord");
                _DateOfRecord = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DateOfRecord");
                OnDateOfRecordChanged();
            }
        }
        private Nullable<global::System.DateTime> _DateOfRecord;
        partial void OnDateOfRecordChanging(Nullable<global::System.DateTime> value);
        partial void OnDateOfRecordChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String CompanySymbol
        {
            get
            {
                return _CompanySymbol;
            }
            set
            {
                OnCompanySymbolChanging(value);
                ReportPropertyChanging("CompanySymbol");
                _CompanySymbol = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("CompanySymbol");
                OnCompanySymbolChanged();
            }
        }
        private global::System.String _CompanySymbol;
        partial void OnCompanySymbolChanging(global::System.String value);
        partial void OnCompanySymbolChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("StocExchangeModel", "company_record", "Companies")]
        public Company Company
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Company>("StocExchangeModel.company_record", "Companies").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Company>("StocExchangeModel.company_record", "Companies").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Company> CompanyReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Company>("StocExchangeModel.company_record", "Companies");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Company>("StocExchangeModel.company_record", "Companies", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
