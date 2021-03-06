﻿using DevExpress.Xpf.Accordion;
using DevExpress.Xpf.Docking;
using DevExpress.Xpo;
using Gestor_Productos.Database;
using Gestor_Productos.Database.ORM_GestProc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Gestor_Productos.Vistas
{
    /// <summary>
    /// Lógica de interacción para vMenu.xaml
    /// </summary>
    public partial class vMenu : DevExpress.Xpf.Core.ThemedWindow
    {
        public static USUARIOS usuario;
        public vMenu(USUARIOS user)
        {
            InitializeComponent();
            usuario = user;
            ViewModelvMenu viewModel = new ViewModelvMenu(this);
            DataContext = viewModel;

            /*--DocumentPanel panel1 = dockLayoutManager1.DockController.AddDocumentPanel(documentGroup1, new Uri(@"Vistas\vProductos.xaml", UriKind.Relative));
            panel1.Caption = "PRODUCTOS";
            panel1.Name = "pProductos";
            panel1.Content = Activator.CreateInstance(typeof(vProductos), new object[] { "llega" });
            //Console.WriteLine(documentGroup1.flo);
            //DocumentPanel.SetMDISize(panel1, new System.Windows.Size(400, 300));
            dockLayoutManager1.LayoutController.Activate(panel1);--*/

            /*LayoutPanel panelInterfaz = new LayoutPanel
            {
                Name = "pProductos",
                ClosingBehavior = ClosingBehavior.ImmediatelyRemove,
                Content = Activator.CreateInstance(typeof(vProductos), panel1.Name = "pProductos"),
                Caption = "PRODUCTOS",
                IsActive = true
            };
            documentGroup1.Add(panelInterfaz);*/

        }

        public class ViewModelvMenu : INotifyPropertyChanged
        {
            #region variables globales
            private vMenu ventana;
            public UnitOfWork uow;

            public event PropertyChangedEventHandler PropertyChanged;
            #endregion

            #region Constructor
            protected void OnPropertyChanged(string name)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
            }
            //Constructor para visualizar albaranes
            public ViewModelvMenu(vMenu ventana)
            {
                this.ventana = ventana;
                uow = ConexionBBDD.getNewUnitOfWork();
            }
            #endregion

            #region Eventos

            public void Materiales_MouseUp(object sender, MouseButtonEventArgs e, DocumentGroup dg)
            {
                LayoutPanel panelInterfaz = new LayoutPanel
                {
                    Name = "pProductos",
                    ClosingBehavior = ClosingBehavior.ImmediatelyRemove,
                    Content = Activator.CreateInstance(typeof(vProductos), new object[] { "llega" }),
                    Caption = "PRODUCTOS",
                    IsActive = true
                };
                dg.Add(panelInterfaz);
                panelInterfaz.Focus();
            }

            public void Clientes_MouseUp(object sender, MouseButtonEventArgs e)
            {

            }

            public void Proveedores_MouseUp(object sender, MouseButtonEventArgs e)
            {

            }

            public void Colmenas_MouseUp(object sender, MouseButtonEventArgs e)
            {

            }

            public void Cosechas_MouseUp(object sender, MouseButtonEventArgs e)
            {

            }

            public void Configuracion_MouseUp(object sender, MouseButtonEventArgs e)
            {

            }

            public void CerrarSesion_MouseUp(object sender, MouseButtonEventArgs e)
            {
                vLogin vlogin = new vLogin();
                ventana.Close();
                vlogin.ShowDialog();
                //viewLogin.Visibility = Visibility.Visible;
                //ventana.Close();
            }

            #endregion

        }
    }
}
