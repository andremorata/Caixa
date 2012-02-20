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

[assembly: EdmRelationshipAttribute("CaixaDBModel", "Movimento_TipoMovimento", "TipoMovimento", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Caixa.TipoMovimento), "Movimentos", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Caixa.Movimentos), true)]

#endregion

namespace Caixa
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class CaixaDBEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new CaixaDBEntities object using the connection string found in the 'CaixaDBEntities' section of the application configuration file.
        /// </summary>
        public CaixaDBEntities() : base("name=CaixaDBEntities", "CaixaDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new CaixaDBEntities object.
        /// </summary>
        public CaixaDBEntities(string connectionString) : base(connectionString, "CaixaDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new CaixaDBEntities object.
        /// </summary>
        public CaixaDBEntities(EntityConnection connection) : base(connection, "CaixaDBEntities")
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
        public ObjectSet<Movimentos> Movimentos
        {
            get
            {
                if ((_Movimentos == null))
                {
                    _Movimentos = base.CreateObjectSet<Movimentos>("Movimentos");
                }
                return _Movimentos;
            }
        }
        private ObjectSet<Movimentos> _Movimentos;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<TipoMovimento> TipoMovimento
        {
            get
            {
                if ((_TipoMovimento == null))
                {
                    _TipoMovimento = base.CreateObjectSet<TipoMovimento>("TipoMovimento");
                }
                return _TipoMovimento;
            }
        }
        private ObjectSet<TipoMovimento> _TipoMovimento;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Movimentos EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToMovimentos(Movimentos movimentos)
        {
            base.AddObject("Movimentos", movimentos);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the TipoMovimento EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToTipoMovimento(TipoMovimento tipoMovimento)
        {
            base.AddObject("TipoMovimento", tipoMovimento);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="CaixaDBModel", Name="Movimentos")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Movimentos : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Movimentos object.
        /// </summary>
        /// <param name="descricao">Initial value of the Descricao property.</param>
        /// <param name="valor">Initial value of the Valor property.</param>
        /// <param name="data">Initial value of the Data property.</param>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="tipoMovimento">Initial value of the TipoMovimento property.</param>
        public static Movimentos CreateMovimentos(global::System.String descricao, global::System.Double valor, global::System.DateTime data, global::System.Guid id, global::System.Guid tipoMovimento)
        {
            Movimentos movimentos = new Movimentos();
            movimentos.Descricao = descricao;
            movimentos.Valor = valor;
            movimentos.Data = data;
            movimentos.Id = id;
            movimentos.TipoMovimento = tipoMovimento;
            return movimentos;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Descricao
        {
            get
            {
                return _Descricao;
            }
            set
            {
                OnDescricaoChanging(value);
                ReportPropertyChanging("Descricao");
                _Descricao = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Descricao");
                OnDescricaoChanged();
            }
        }
        private global::System.String _Descricao;
        partial void OnDescricaoChanging(global::System.String value);
        partial void OnDescricaoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double Valor
        {
            get
            {
                return _Valor;
            }
            set
            {
                OnValorChanging(value);
                ReportPropertyChanging("Valor");
                _Valor = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Valor");
                OnValorChanged();
            }
        }
        private global::System.Double _Valor;
        partial void OnValorChanging(global::System.Double value);
        partial void OnValorChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime Data
        {
            get
            {
                return _Data;
            }
            set
            {
                OnDataChanging(value);
                ReportPropertyChanging("Data");
                _Data = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Data");
                OnDataChanged();
            }
        }
        private global::System.DateTime _Data;
        partial void OnDataChanging(global::System.DateTime value);
        partial void OnDataChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Observacao
        {
            get
            {
                return _Observacao;
            }
            set
            {
                OnObservacaoChanging(value);
                ReportPropertyChanging("Observacao");
                _Observacao = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Observacao");
                OnObservacaoChanged();
            }
        }
        private global::System.String _Observacao;
        partial void OnObservacaoChanging(global::System.String value);
        partial void OnObservacaoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid Id
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
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Guid _Id;
        partial void OnIdChanging(global::System.Guid value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid TipoMovimento
        {
            get
            {
                return _TipoMovimento;
            }
            set
            {
                OnTipoMovimentoChanging(value);
                ReportPropertyChanging("TipoMovimento");
                _TipoMovimento = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("TipoMovimento");
                OnTipoMovimentoChanged();
            }
        }
        private global::System.Guid _TipoMovimento;
        partial void OnTipoMovimentoChanging(global::System.Guid value);
        partial void OnTipoMovimentoChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("CaixaDBModel", "Movimento_TipoMovimento", "TipoMovimento")]
        public TipoMovimento Tipo
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<TipoMovimento>("CaixaDBModel.Movimento_TipoMovimento", "TipoMovimento").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<TipoMovimento>("CaixaDBModel.Movimento_TipoMovimento", "TipoMovimento").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<TipoMovimento> TipoReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<TipoMovimento>("CaixaDBModel.Movimento_TipoMovimento", "TipoMovimento");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<TipoMovimento>("CaixaDBModel.Movimento_TipoMovimento", "TipoMovimento", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="CaixaDBModel", Name="TipoMovimento")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class TipoMovimento : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new TipoMovimento object.
        /// </summary>
        /// <param name="descricao">Initial value of the Descricao property.</param>
        /// <param name="id">Initial value of the Id property.</param>
        public static TipoMovimento CreateTipoMovimento(global::System.String descricao, global::System.Guid id)
        {
            TipoMovimento tipoMovimento = new TipoMovimento();
            tipoMovimento.Descricao = descricao;
            tipoMovimento.Id = id;
            return tipoMovimento;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Descricao
        {
            get
            {
                return _Descricao;
            }
            set
            {
                OnDescricaoChanging(value);
                ReportPropertyChanging("Descricao");
                _Descricao = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Descricao");
                OnDescricaoChanged();
            }
        }
        private global::System.String _Descricao;
        partial void OnDescricaoChanging(global::System.String value);
        partial void OnDescricaoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid Id
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
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Guid _Id;
        partial void OnIdChanging(global::System.Guid value);
        partial void OnIdChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("CaixaDBModel", "Movimento_TipoMovimento", "Movimentos")]
        public EntityCollection<Movimentos> Movimentos
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Movimentos>("CaixaDBModel.Movimento_TipoMovimento", "Movimentos");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Movimentos>("CaixaDBModel.Movimento_TipoMovimento", "Movimentos", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
