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

    public partial class PRODUCTOS : XPBaseObject
    {
        string fId;
        [Key]
        public string Id
        {
            get { return fId; }
            set { SetPropertyValue<string>(nameof(Id), ref fId, value); }
        }
        string fNombre;
        public string Nombre
        {
            get { return fNombre; }
            set { SetPropertyValue<string>(nameof(Nombre), ref fNombre, value); }
        }
        FAMILIAS fFamilia;
        [Association(@"PRODUCTOSReferencesFAMILIAS")]
        public FAMILIAS Familia
        {
            get { return fFamilia; }
            set { SetPropertyValue<FAMILIAS>(nameof(Familia), ref fFamilia, value); }
        }
        MARCAS fMarca;
        [Association(@"PRODUCTOSReferencesMARCAS")]
        public MARCAS Marca
        {
            get { return fMarca; }
            set { SetPropertyValue<MARCAS>(nameof(Marca), ref fMarca, value); }
        }
        string fDescripcion;
        public string Descripcion
        {
            get { return fDescripcion; }
            set { SetPropertyValue<string>(nameof(Descripcion), ref fDescripcion, value); }
        }
        decimal fDto;
        [DbType("decimal(5,2)")]
        public decimal Dto
        {
            get { return fDto; }
            set { SetPropertyValue<decimal>(nameof(Dto), ref fDto, value); }
        }
        string fPeso;
        [DbType("decimal(10,4)")]
        public string Peso
        {
            get { return fPeso; }
            set { SetPropertyValue<string>(nameof(Peso), ref fPeso, value); }
        }
        decimal fUnidades;
        [DbType("decimal(10,4)")]
        public decimal Unidades
        {
            get { return fUnidades; }
            set { SetPropertyValue<decimal>(nameof(Unidades), ref fUnidades, value); }
        }
        decimal fPrecioVenta;
        [DbType("decimal(10,4)")]
        public decimal PrecioVenta
        {
            get { return fPrecioVenta; }
            set { SetPropertyValue<decimal>(nameof(PrecioVenta), ref fPrecioVenta, value); }
        }
        decimal fPrecioCompra;
        [DbType("decimal(10,4)")]
        public decimal PrecioCompra
        {
            get { return fPrecioCompra; }
            set { SetPropertyValue<decimal>(nameof(PrecioCompra), ref fPrecioCompra, value); }
        }
        USUARIOS fUsuario;
        [Association(@"PRODUCTOSReferencesUSUARIOS")]
        public USUARIOS Usuario
        {
            get { return fUsuario; }
            set { SetPropertyValue<USUARIOS>(nameof(Usuario), ref fUsuario, value); }
        }
    }

}