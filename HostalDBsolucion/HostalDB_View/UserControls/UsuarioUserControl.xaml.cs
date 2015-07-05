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
using HostalDB_ViewModel.ServiceReference_User;
///

using HostalDB_ViewModel.ServiceReference_UserRole; 

namespace HostalDB_View.UserControls
{
    public partial class UsuarioUserControl : UserControl
    {


        public UsuarioUserControl()
        {
          
            InitializeComponent();
        }
        HostalDB_ViewModel.ServiceReference_User.UserServiceClient _ServicioUsuario = new HostalDB_ViewModel.ServiceReference_User.UserServiceClient();
        HostalDB_ViewModel.ServiceReference_Role.RoleServiceClient _ServicioRole = new HostalDB_ViewModel.ServiceReference_Role.RoleServiceClient();
        HostalDB_ViewModel.ServiceReference_UserRole.User_RoleServiceClient _ServicioUserRole = new HostalDB_ViewModel.ServiceReference_UserRole.User_RoleServiceClient();

        

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
          
            string idcliente = txtUserID.Text ;
            string Nombrecliente = txtNombres.Text ;

            this.Content = new ReservaDeHabitacionesUserControl(idcliente, Nombrecliente);//estoy abriendo otra pagina silver

         

        }

        

        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {   //cargar  todos los clientes
            _ServicioUsuario.ListarUsuariosAsync();
            _ServicioUsuario.ListarUsuariosCompleted += _ServicioUsuario_ListarUsuariosCompleted;
            //cargar los roles para la administracion
            _ServicioRole.ListarTodosLosRolesAsync();
            _ServicioRole.ListarTodosLosRolesCompleted +=_ServicioRole_ListarTodosLosRolesCompleted;
        }

        private void _ServicioRole_ListarTodosLosRolesCompleted(object sender, HostalDB_ViewModel.ServiceReference_Role.ListarTodosLosRolesCompletedEventArgs e)
        {

            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message + e.Error);
                return;
            }
            else
            {
                cboRoles.ItemsSource = e.Result;

            }
            _ServicioRole.ListarTodosLosRolesCompleted -= _ServicioRole_ListarTodosLosRolesCompleted;
        }

        private void dgvUsuarios_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int iduser;




            iduser = ((HostalDB_ViewModel.ServiceReference_User.userDTO)dgvUsuarios.SelectedItem).user_id;
           // iduser = dgvUsuarios.GetValue(It);

          //  userDTO ddd = new userDTO();

          //  ddd = dgvUsuarios.SelectedItem;

            _ServicioUserRole.ListarUserRolePorIDUSERAsync(iduser);
            _ServicioUserRole.ListarUserRolePorIDUSERCompleted  +=_ServicioUserRole_ListarUserRolePorIDUSERCompleted;

        }

        private void _ServicioUserRole_ListarUserRolePorIDUSERCompleted(object sender, HostalDB_ViewModel.ServiceReference_UserRole.ListarUserRolePorIDUSERCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message + e.Error);
                return;
            }
            else
            {

                dgvRolesDelUsuario.ItemsSource = e.Result;
            }
            _ServicioUserRole.ListarUserRolePorIDUSERCompleted -= _ServicioUserRole_ListarUserRolePorIDUSERCompleted;
        }

       

       

        
        
      
    }

    

    public class ListarRolesDelUsuarioClassx
    {

        public int IDuserrol { get; set; }
        public int IDuser { get; set; }
        public int IDrol { get; set; }
        public String strAuthority { get; set; }


        public ListarRolesDelUsuarioClassx(int IDuserrol, int IDuser, int IDrol, String strAuthority)
        {

            this.IDuserrol = IDuserrol;
            this.IDuser = IDuser;
            this.IDrol = IDrol;
            this.strAuthority = strAuthority;
    }
    }
   
   }

