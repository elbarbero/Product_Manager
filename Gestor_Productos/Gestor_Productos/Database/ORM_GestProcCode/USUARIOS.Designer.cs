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

    public partial class USUARIOS : XPBaseObject
    {
        int fId;
        [Key(true)]
        public int Id
        {
            get { return fId; }
            set { SetPropertyValue<int>(nameof(Id), ref fId, value); }
        }
        string fNombre;
        [Size(150)]
        public string Nombre
        {
            get { return fNombre; }
            set { SetPropertyValue<string>(nameof(Nombre), ref fNombre, value); }
        }
        string fUsername;
        public string Username
        {
            get { return fUsername; }
            set { SetPropertyValue<string>(nameof(Username), ref fUsername, value); }
        }
        string fPassword;
        public string Password
        {
            get { return fPassword; }
            set { SetPropertyValue<string>(nameof(Password), ref fPassword, value); }
        }
        [Association(@"USUARIOSReferencesPRODUCTOS")]
        public XPCollection<PRODUCTOS> PRODUCTOSCollection { get { return GetCollection<PRODUCTOS>(nameof(PRODUCTOSCollection)); } }
        [Association(@"CONFIGURACIONReferencesUSUARIOS")]
        public XPCollection<CONFIGURACION> CONFIGURACIONs { get { return GetCollection<CONFIGURACION>(nameof(CONFIGURACIONs)); } }
    }

}
