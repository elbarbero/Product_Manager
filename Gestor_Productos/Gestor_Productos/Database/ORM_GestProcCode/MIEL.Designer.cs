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

    public partial class MIEL : XPBaseObject
    {
        long fId;
        [Key(true)]
        public long Id
        {
            get { return fId; }
            set { SetPropertyValue<long>(nameof(Id), ref fId, value); }
        }
        string fTipo;
        public string Tipo
        {
            get { return fTipo; }
            set { SetPropertyValue<string>(nameof(Tipo), ref fTipo, value); }
        }
        COSECHAS fCosecha;
        [Association(@"MIELReferencesCOSECHAS")]
        public COSECHAS Cosecha
        {
            get { return fCosecha; }
            set { SetPropertyValue<COSECHAS>(nameof(Cosecha), ref fCosecha, value); }
        }
        [Association(@"LINEAS_VENTASReferencesMIEL")]
        public XPCollection<LINEAS_VENTAS> LINEAS_VENTASs { get { return GetCollection<LINEAS_VENTAS>(nameof(LINEAS_VENTASs)); } }
    }

}
