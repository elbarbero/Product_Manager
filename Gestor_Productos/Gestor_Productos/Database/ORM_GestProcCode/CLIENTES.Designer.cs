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

    public partial class CLIENTES : XPBaseObject
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
        string fApellidos;
        [Size(150)]
        public string Apellidos
        {
            get { return fApellidos; }
            set { SetPropertyValue<string>(nameof(Apellidos), ref fApellidos, value); }
        }
        string fDNI;
        [Size(12)]
        public string DNI
        {
            get { return fDNI; }
            set { SetPropertyValue<string>(nameof(DNI), ref fDNI, value); }
        }
        string fTlfFijo;
        [Size(9)]
        public string TlfFijo
        {
            get { return fTlfFijo; }
            set { SetPropertyValue<string>(nameof(TlfFijo), ref fTlfFijo, value); }
        }
        string fTlfMovil;
        [Size(9)]
        public string TlfMovil
        {
            get { return fTlfMovil; }
            set { SetPropertyValue<string>(nameof(TlfMovil), ref fTlfMovil, value); }
        }
        string fEmail;
        public string Email
        {
            get { return fEmail; }
            set { SetPropertyValue<string>(nameof(Email), ref fEmail, value); }
        }
    }

}
