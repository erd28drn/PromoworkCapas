﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace GestionData.Modelos
{
    #region Contextos
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    public partial class VistasGeneralesDataModel : ObjectContext
    {
        #region Constructores
    
        /// <summary>
        /// Inicializa un nuevo objeto VistasGeneralesDataModel usando la cadena de conexión encontrada en la sección 'VistasGeneralesDataModel' del archivo de configuración de la aplicación.
        /// </summary>
        public VistasGeneralesDataModel() : base("name=VistasGeneralesDataModel", "VistasGeneralesDataModel")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto VistasGeneralesDataModel.
        /// </summary>
        public VistasGeneralesDataModel(string connectionString) : base(connectionString, "VistasGeneralesDataModel")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto VistasGeneralesDataModel.
        /// </summary>
        public VistasGeneralesDataModel(EntityConnection connection) : base(connection, "VistasGeneralesDataModel")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Métodos parciales
    
        partial void OnContextCreated();
    
        #endregion
    
        #region Propiedades de ObjectSet
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<vTareas> vTareas
        {
            get
            {
                if ((_vTareas == null))
                {
                    _vTareas = base.CreateObjectSet<vTareas>("vTareas");
                }
                return _vTareas;
            }
        }
        private ObjectSet<vTareas> _vTareas;

        #endregion

        #region Métodos AddTo
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet vTareas. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddTovTareas(vTareas vTareas)
        {
            base.AddObject("vTareas", vTareas);
        }

        #endregion

    }

    #endregion

    #region Entidades
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="VistasGenerales", Name="vTareas")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class vTareas : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto vTareas.
        /// </summary>
        /// <param name="idTarea">Valor inicial de la propiedad IdTarea.</param>
        /// <param name="usuarioCreacion">Valor inicial de la propiedad UsuarioCreacion.</param>
        /// <param name="usuarioModificacion">Valor inicial de la propiedad UsuarioModificacion.</param>
        /// <param name="desEmpresa">Valor inicial de la propiedad DesEmpresa.</param>
        /// <param name="numTrabajador">Valor inicial de la propiedad NumTrabajador.</param>
        /// <param name="nomTrabajador">Valor inicial de la propiedad NomTrabajador.</param>
        /// <param name="vencida">Valor inicial de la propiedad Vencida.</param>
        public static vTareas CreatevTareas(global::System.Int32 idTarea, global::System.String usuarioCreacion, global::System.String usuarioModificacion, global::System.String desEmpresa, global::System.Int32 numTrabajador, global::System.String nomTrabajador, global::System.Int32 vencida)
        {
            vTareas vTareas = new vTareas();
            vTareas.IdTarea = idTarea;
            vTareas.UsuarioCreacion = usuarioCreacion;
            vTareas.UsuarioModificacion = usuarioModificacion;
            vTareas.DesEmpresa = desEmpresa;
            vTareas.NumTrabajador = numTrabajador;
            vTareas.NomTrabajador = nomTrabajador;
            vTareas.Vencida = vencida;
            return vTareas;
        }

        #endregion

        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 IdTarea
        {
            get
            {
                return _IdTarea;
            }
            set
            {
                if (_IdTarea != value)
                {
                    OnIdTareaChanging(value);
                    ReportPropertyChanging("IdTarea");
                    _IdTarea = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("IdTarea");
                    OnIdTareaChanged();
                }
            }
        }
        private global::System.Int32 _IdTarea;
        partial void OnIdTareaChanging(global::System.Int32 value);
        partial void OnIdTareaChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String IdEventoExterno
        {
            get
            {
                return _IdEventoExterno;
            }
            set
            {
                OnIdEventoExternoChanging(value);
                ReportPropertyChanging("IdEventoExterno");
                _IdEventoExterno = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("IdEventoExterno");
                OnIdEventoExternoChanged();
            }
        }
        private global::System.String _IdEventoExterno;
        partial void OnIdEventoExternoChanging(global::System.String value);
        partial void OnIdEventoExternoChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> IdEmpresa
        {
            get
            {
                return _IdEmpresa;
            }
            set
            {
                OnIdEmpresaChanging(value);
                ReportPropertyChanging("IdEmpresa");
                _IdEmpresa = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IdEmpresa");
                OnIdEmpresaChanged();
            }
        }
        private Nullable<global::System.Int32> _IdEmpresa;
        partial void OnIdEmpresaChanging(Nullable<global::System.Int32> value);
        partial void OnIdEmpresaChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String NombreTarea
        {
            get
            {
                return _NombreTarea;
            }
            set
            {
                OnNombreTareaChanging(value);
                ReportPropertyChanging("NombreTarea");
                _NombreTarea = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("NombreTarea");
                OnNombreTareaChanged();
            }
        }
        private global::System.String _NombreTarea;
        partial void OnNombreTareaChanging(global::System.String value);
        partial void OnNombreTareaChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ObsercacionesTarea
        {
            get
            {
                return _ObsercacionesTarea;
            }
            set
            {
                OnObsercacionesTareaChanging(value);
                ReportPropertyChanging("ObsercacionesTarea");
                _ObsercacionesTarea = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ObsercacionesTarea");
                OnObsercacionesTareaChanged();
            }
        }
        private global::System.String _ObsercacionesTarea;
        partial void OnObsercacionesTareaChanging(global::System.String value);
        partial void OnObsercacionesTareaChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> IdUsuarioCreacion
        {
            get
            {
                return _IdUsuarioCreacion;
            }
            set
            {
                OnIdUsuarioCreacionChanging(value);
                ReportPropertyChanging("IdUsuarioCreacion");
                _IdUsuarioCreacion = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IdUsuarioCreacion");
                OnIdUsuarioCreacionChanged();
            }
        }
        private Nullable<global::System.Int32> _IdUsuarioCreacion;
        partial void OnIdUsuarioCreacionChanging(Nullable<global::System.Int32> value);
        partial void OnIdUsuarioCreacionChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> IdUsuarioModificacion
        {
            get
            {
                return _IdUsuarioModificacion;
            }
            set
            {
                OnIdUsuarioModificacionChanging(value);
                ReportPropertyChanging("IdUsuarioModificacion");
                _IdUsuarioModificacion = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IdUsuarioModificacion");
                OnIdUsuarioModificacionChanged();
            }
        }
        private Nullable<global::System.Int32> _IdUsuarioModificacion;
        partial void OnIdUsuarioModificacionChanging(Nullable<global::System.Int32> value);
        partial void OnIdUsuarioModificacionChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> IdTrabajador
        {
            get
            {
                return _IdTrabajador;
            }
            set
            {
                OnIdTrabajadorChanging(value);
                ReportPropertyChanging("IdTrabajador");
                _IdTrabajador = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IdTrabajador");
                OnIdTrabajadorChanged();
            }
        }
        private Nullable<global::System.Int32> _IdTrabajador;
        partial void OnIdTrabajadorChanging(Nullable<global::System.Int32> value);
        partial void OnIdTrabajadorChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> FechaCreacion
        {
            get
            {
                return _FechaCreacion;
            }
            set
            {
                OnFechaCreacionChanging(value);
                ReportPropertyChanging("FechaCreacion");
                _FechaCreacion = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("FechaCreacion");
                OnFechaCreacionChanged();
            }
        }
        private Nullable<global::System.DateTime> _FechaCreacion;
        partial void OnFechaCreacionChanging(Nullable<global::System.DateTime> value);
        partial void OnFechaCreacionChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> FechaModificacion
        {
            get
            {
                return _FechaModificacion;
            }
            set
            {
                OnFechaModificacionChanging(value);
                ReportPropertyChanging("FechaModificacion");
                _FechaModificacion = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("FechaModificacion");
                OnFechaModificacionChanged();
            }
        }
        private Nullable<global::System.DateTime> _FechaModificacion;
        partial void OnFechaModificacionChanging(Nullable<global::System.DateTime> value);
        partial void OnFechaModificacionChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> FechaVencimiento
        {
            get
            {
                return _FechaVencimiento;
            }
            set
            {
                OnFechaVencimientoChanging(value);
                ReportPropertyChanging("FechaVencimiento");
                _FechaVencimiento = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("FechaVencimiento");
                OnFechaVencimientoChanged();
            }
        }
        private Nullable<global::System.DateTime> _FechaVencimiento;
        partial void OnFechaVencimientoChanging(Nullable<global::System.DateTime> value);
        partial void OnFechaVencimientoChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Boolean> Finalizada
        {
            get
            {
                return _Finalizada;
            }
            set
            {
                OnFinalizadaChanging(value);
                ReportPropertyChanging("Finalizada");
                _Finalizada = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Finalizada");
                OnFinalizadaChanged();
            }
        }
        private Nullable<global::System.Boolean> _Finalizada;
        partial void OnFinalizadaChanging(Nullable<global::System.Boolean> value);
        partial void OnFinalizadaChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String UsuarioCreacion
        {
            get
            {
                return _UsuarioCreacion;
            }
            set
            {
                if (_UsuarioCreacion != value)
                {
                    OnUsuarioCreacionChanging(value);
                    ReportPropertyChanging("UsuarioCreacion");
                    _UsuarioCreacion = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("UsuarioCreacion");
                    OnUsuarioCreacionChanged();
                }
            }
        }
        private global::System.String _UsuarioCreacion;
        partial void OnUsuarioCreacionChanging(global::System.String value);
        partial void OnUsuarioCreacionChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String UsuarioModificacion
        {
            get
            {
                return _UsuarioModificacion;
            }
            set
            {
                if (_UsuarioModificacion != value)
                {
                    OnUsuarioModificacionChanging(value);
                    ReportPropertyChanging("UsuarioModificacion");
                    _UsuarioModificacion = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("UsuarioModificacion");
                    OnUsuarioModificacionChanged();
                }
            }
        }
        private global::System.String _UsuarioModificacion;
        partial void OnUsuarioModificacionChanging(global::System.String value);
        partial void OnUsuarioModificacionChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String DesEmpresa
        {
            get
            {
                return _DesEmpresa;
            }
            set
            {
                if (_DesEmpresa != value)
                {
                    OnDesEmpresaChanging(value);
                    ReportPropertyChanging("DesEmpresa");
                    _DesEmpresa = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("DesEmpresa");
                    OnDesEmpresaChanged();
                }
            }
        }
        private global::System.String _DesEmpresa;
        partial void OnDesEmpresaChanging(global::System.String value);
        partial void OnDesEmpresaChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 NumTrabajador
        {
            get
            {
                return _NumTrabajador;
            }
            set
            {
                if (_NumTrabajador != value)
                {
                    OnNumTrabajadorChanging(value);
                    ReportPropertyChanging("NumTrabajador");
                    _NumTrabajador = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("NumTrabajador");
                    OnNumTrabajadorChanged();
                }
            }
        }
        private global::System.Int32 _NumTrabajador;
        partial void OnNumTrabajadorChanging(global::System.Int32 value);
        partial void OnNumTrabajadorChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String NomTrabajador
        {
            get
            {
                return _NomTrabajador;
            }
            set
            {
                if (_NomTrabajador != value)
                {
                    OnNomTrabajadorChanging(value);
                    ReportPropertyChanging("NomTrabajador");
                    _NomTrabajador = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("NomTrabajador");
                    OnNomTrabajadorChanged();
                }
            }
        }
        private global::System.String _NomTrabajador;
        partial void OnNomTrabajadorChanging(global::System.String value);
        partial void OnNomTrabajadorChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ApeTrabajador
        {
            get
            {
                return _ApeTrabajador;
            }
            set
            {
                OnApeTrabajadorChanging(value);
                ReportPropertyChanging("ApeTrabajador");
                _ApeTrabajador = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ApeTrabajador");
                OnApeTrabajadorChanged();
            }
        }
        private global::System.String _ApeTrabajador;
        partial void OnApeTrabajadorChanging(global::System.String value);
        partial void OnApeTrabajadorChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Responsable
        {
            get
            {
                return _Responsable;
            }
            set
            {
                OnResponsableChanging(value);
                ReportPropertyChanging("Responsable");
                _Responsable = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Responsable");
                OnResponsableChanged();
            }
        }
        private global::System.String _Responsable;
        partial void OnResponsableChanging(global::System.String value);
        partial void OnResponsableChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Vencida
        {
            get
            {
                return _Vencida;
            }
            set
            {
                if (_Vencida != value)
                {
                    OnVencidaChanging(value);
                    ReportPropertyChanging("Vencida");
                    _Vencida = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Vencida");
                    OnVencidaChanged();
                }
            }
        }
        private global::System.Int32 _Vencida;
        partial void OnVencidaChanging(global::System.Int32 value);
        partial void OnVencidaChanged();

        #endregion

    
    }

    #endregion

    
}
