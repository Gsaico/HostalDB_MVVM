using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using HostalDB_ViewModel;
using System.Windows.Navigation;
///


namespace HostalDB_View.UserControls
{
    public partial class UsuarioUserControl : UserControl
    {


        public UsuarioUserControl()
        {
          
            InitializeComponent();
        }
        HostalDB_ViewModel.ServiceReference_User.UserServiceClient _ServicioUsuario = new HostalDB_ViewModel.ServiceReference_User.UserServiceClient();
        private void acbBuscar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void acbBuscar_TextChanged(object sender, RoutedEventArgs e)
        {
            _ServicioUsuario.BuscarUsuarioAsync(acbBuscar.Text ); 
            _ServicioUsuario.BuscarUsuarioCompleted += _ServicioUsuario_BuscarUsuarioCompleted;
        }

        private void _ServicioUsuario_BuscarUsuarioCompleted(object sender, HostalDB_ViewModel.ServiceReference_User.BuscarUsuarioCompletedEventArgs e)
        {
            dgvUsuarios.SelectedItems.Clear();
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message + e.Error);
                return;
            }
            else
            {
                dgvUsuarios.ItemsSource = e.Result;

            }
            _ServicioUsuario.ListarUsuariosCompleted -= _ServicioUsuario_ListarUsuariosCompleted;
        }

        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
          

            _ServicioUsuario.ListarUsuariosAsync();
            _ServicioUsuario.ListarUsuariosCompleted += _ServicioUsuario_ListarUsuariosCompleted;


        }

        private void _ServicioUsuario_ListarUsuariosCompleted(object sender, HostalDB_ViewModel.ServiceReference_User.ListarUsuariosCompletedEventArgs e)
        {

            

            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message + e.Error);
                return;
            }
            else
            {
                dgvUsuarios.ItemsSource = e.Result;

            }
            _ServicioUsuario.ListarUsuariosCompleted -= _ServicioUsuario_ListarUsuariosCompleted;


        }

        private void btnReservarhabitacion_Click(object sender, RoutedEventArgs e)
        {
          //  this.ContentFrame.Navigate(new Uri("/Usuarios", UriKind.Relative));

            
         //   ListarFacturas cabecera = new ListarFacturas();
        //    CanvasPrincipalv.Children.Clear();
          //  CanvasPrincipalv.Children.Add(cabecera);

            string idcliente = txtUserID.Text ;
            string Nombrecliente = txtNombres.Text ;

            this.Content = new ReservaDeHabitacionesUserControl(idcliente, Nombrecliente);//estoy abriendo otra pagina silver

          //  ReservaDeHabitacionesUserControl ps = this.Parent as new  ReservaDeHabitacionesUserControl(strParametro1);
           // ps.Navigate(new Page2()); 

           // Views.ReservaDeHabitaciones lg = new Views.ReservaDeHabitaciones(_parametros);
         //   this.ContentFrame.Content = lg;


        }

        
        // Views.ReservaDeHabitaciones xxx = new Views.ReservaDeHabitaciones();

        //   NavigationService.c.Navigate(new Uri("/Usuarios", UriKind.Relative));

        // ContentFrame.Navigate(new Uri("/Usuarios", UriKind.Relative));





        // ContentFrame.Navigate(new Uri("/Home", UriKind.Relative));

        //  ContentFrame.Navigate(new Uri("/Usuarios", UriKind.Relative));




        //  ChildWindows.AlumnoChild child = new ChildWindows.AlumnoChild();
        // child.Closed += child_Closed;
        // child.Show();

        //  HostalDB_View.Views.ReservaDeHabitaciones reservahabitacionesform = new HostalDB_View.Views.ReservaDeHabitaciones();



        // CanvasPrincipalv.Children.Clear();
        // CanvasPrincipalv.Children.Add(cabecera);
      
    }
}
