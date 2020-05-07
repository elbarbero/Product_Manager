﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Gestor_Productos.Database.ORM_GestProc
{

    public partial class IMPUESTOS : XPBaseObject
    {
        int fId;
        [Key(true)]
        public int Id
        {
            get { return fId; }
            set { SetPropertyValue<int>(nameof(Id), ref fId, value); }
        }
        string fNombre;
        public string Nombre
        {
            get { return fNombre; }
            set { SetPropertyValue<string>(nameof(Nombre), ref fNombre, value); }
        }
        decimal fValor;
        [DbType("decimal(5,2)")]
        public decimal Valor
        {
            get { return fValor; }
            set { SetPropertyValue<decimal>(nameof(Valor), ref fValor, value); }
        }
        decimal fValorRecargo;
        [DbType("decimal(5,2)")]
        public decimal ValorRecargo
        {
            get { return fValorRecargo; }
            set { SetPropertyValue<decimal>(nameof(ValorRecargo), ref fValorRecargo, value); }
        }
        [Association(@"MATERIALESReferencesIMPUESTOS")]
        public XPCollection<MATERIALES> MATERIALESCollection { get { return GetCollection<MATERIALES>(nameof(MATERIALESCollection)); } }
        [Association(@"LINEAS_COMPRASReferencesIMPUESTOS")]
        public XPCollection<LINEAS_COMPRAS> LINEAS_COMPRASs { get { return GetCollection<LINEAS_COMPRAS>(nameof(LINEAS_COMPRASs)); } }
        [Association(@"LINEAS_VENTASReferencesIMPUESTOS")]
        public XPCollection<LINEAS_VENTAS> LINEAS_VENTASs { get { return GetCollection<LINEAS_VENTAS>(nameof(LINEAS_VENTASs)); } }
    }

}