using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
//agregados
using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using HostalDB_ViewModel.Commands;
using HostalDB_ViewModel.ServiceReference_User;
using HostalDB_ViewModel.ServiceReference_Role;

using HostalDB_ViewModel.ServiceReference_UserRole; 

namespace HostalDB_ViewModel.ViewModels
{
    public class UserViewModel : ViewModelBase
    {
        private  ServiceReference_User.UserServiceClient _ServicioUsuario;
        private ServiceReference_Role.RoleServiceClient  _ServicioRole;
        private ServiceReference_UserRole.User_RoleServiceClient _ServicioUserRole;


        #region propiedades Cliente


        private ObservableCollection<ServiceReference_User.userDTO> _ListarUsuarios;

        public ObservableCollection<ServiceReference_User.userDTO> ListarUsuarios
        {
            get { return _ListarUsuarios; }
            set
            {
                _ListarUsuarios = value;
                RaisePropertyChanged("ListarUsuarios");

            }
        }

        private ObservableCollection<ServiceReference_User.user_roleDTO > _ListarUsuarioRolesx;

        public ObservableCollection<ServiceReference_User.user_roleDTO> ListarUsuarioRolesx
        {
            get { return _ListarUsuarioRolesx; }
            set
            {
                _ListarUsuarioRolesx = value;
                RaisePropertyChanged("ListarUsuarioRolesx");

            }
        }

        private ServiceReference_User.user_roleDTO _ItemUsuarioRolx;

        public ServiceReference_User.user_roleDTO ItemUsuarioRolx
        {
            get { return _ItemUsuarioRolx; }
            set
            {
                _ItemUsuarioRolx = value;

                RaisePropertyChanged("ItemUsuarioRolx");
               
            }
        }
        private ServiceReference_User.userDTO _ItemUsuario;

        public ServiceReference_User.userDTO ItemUsuario
        {
            get { return _ItemUsuario; }
            set
            {
                _ItemUsuario = value;
                
                RaisePropertyChanged("ItemUsuario");
              //  ListarRolesDelUsuarioCommandAccion();
            }
        }

        private string _parametroBusqueda;
        public string ParametroBusqueda
        {
            get { return _parametroBusqueda; }
            set
            {
                if (_parametroBusqueda == value) return;
                _parametroBusqueda = value;
                RaisePropertyChanged("ParametroBusqueda");
            }
        }

        #endregion

        #region propiedades Roles


        private ObservableCollection<ServiceReference_Role.roleDTO> _ListaRoles;

        public ObservableCollection<ServiceReference_Role.roleDTO> ListaRoles
        {
            get { return _ListaRoles; }
            set
            {
                _ListaRoles = value;
                RaisePropertyChanged("ListaRoles");

            }
        }

        private ServiceReference_Role.roleDTO _ItemRol;

        public ServiceReference_Role.roleDTO ItemRol
        {
            get { return _ItemRol; }
            set
            {
                _ItemRol = value;
                RaisePropertyChanged("ItemRol");
            }
        }

        //private string _ParametroSelecteditem;
        //public string ParametroSelectedItem
        //{
        //    get { return _ParametroSelecteditem; }
        //    set
        //    {
        //        if (_ParametroSelecteditem == value) return;
        //        _ParametroSelecteditem = value;
        //        RaisePropertyChanged("ParametroSelectedItem");
        //        MessageBox.Show(ParametroSelectedItem.ToString() );
        //    }
        //}
       #endregion

        #region propiedades USER ROLE


        private ObservableCollection<ServiceReference_UserRole.user_roleDTO > _ListaUsuarioRoles;

        public ObservableCollection<ServiceReference_UserRole.user_roleDTO> ListaUsuarioRoles
        {
            get { return _ListaUsuarioRoles; }
            set
            {
                _ListaUsuarioRoles = value;
                RaisePropertyChanged("ListaUsuarioRoles");

            }
        }

        private ServiceReference_UserRole.user_roleDTO _ItemUsuarioRol;

        public ServiceReference_UserRole.user_roleDTO ItemUsuarioRol
        {
            get { return _ItemUsuarioRol; }
            set
            {
                _ItemUsuarioRol = value;
                RaisePropertyChanged("ItemUsuarioRol");
            }
        }

      
        #endregion


        public UserViewModel()
        {
           if (IsInDesignMode) return;//por sia acas0

            _ServicioUsuario = new ServiceReference_User.UserServiceClient();
            _ServicioRole = new ServiceReference_Role.RoleServiceClient();
            _ServicioUserRole = new ServiceReference_UserRole.User_RoleServiceClient();

            ListarUsuarios = new ObservableCollection<ServiceReference_User.userDTO>();
            ItemUsuario = new ServiceReference_User.userDTO();

            ListaRoles = new ObservableCollection<ServiceReference_Role.roleDTO>();
            ItemRol = new ServiceReference_Role.roleDTO();

            ListaUsuarioRoles = new ObservableCollection<ServiceReference_UserRole.user_roleDTO>();
            ItemUsuarioRol = new ServiceReference_UserRole.user_roleDTO();

            //para guardar dartos del cliente
            _ServicioUsuario.InsertarUsuarioCompleted += _ServicioUsuario_InsertarUsuariosCompleted;

             _ServicioUsuario.EliminarUsuarioCompleted += _ServicioUsuario_EliminarUsuariosCompleted;

             _ServicioUserRole.EliminarUserRoleCompleted +=_ServicioUserRole_EliminarUserRoleCompleted;
 
            ListarCommand = new CommandBase(p => true, p => ListarCommandAccion()) { IsEnable = true };
            BuscarCommand = new CommandBase(p => true, p => BuscarCommandAccion()) { IsEnable = true };
            GuardarCommand = new CommandBase(p => true, p => GuardarCommandAccion()) { IsEnable = true };
            EliminarCommand = new CommandBase(p => true, p => EliminarCommandAccion()) { IsEnable = true };
            NuevoCommand = new CommandBase(p => true, p => NuevoCommandAccion()) { IsEnable = true };

            //eliminar rol del cliente
            EliminarRolDelUsuarioCommand = new CommandBase(p => true, p => EliminarRolDelUsuarioCommandAccion()) { IsEnable = true };

            //Agregar nuevo rol al usuario
            AgregarNuevoRolAlUsuarioCommand = new CommandBase(p => true, p => AgregarNuevoRolAlUsuarioCommandAccion()) { IsEnable = true };

            
            //para listar roles disponibles para agregar
            ListarRolesCommand = new CommandBase(p => true, p => ListarRolesCommandAccion()) { IsEnable = true };


            ListarRolesDelUsuarioCommand = new CommandBase(p => true, p => ListarRolesDelUsuarioCommandAccion()) { IsEnable = true };
             
        }

        private void AgregarNuevoRolAlUsuarioCommandAccion()
        {
            ItemUsuarioRol = new ServiceReference_UserRole.user_roleDTO();
            ItemUsuarioRol.role_id = ItemRol.role_id;
            ItemUsuarioRol.user_id = ItemUsuario.user_id;
            _ServicioUserRole.InsertarUserRoleAsync(ItemUsuarioRol);
            _ServicioUserRole.InsertarUserRoleCompleted +=_ServicioUserRole_InsertarUserRoleCompleted;
        }

        private void _ServicioUserRole_InsertarUserRoleCompleted(object sender, ServiceReference_UserRole.InsertarUserRoleCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message + e.Error);
            }
            else
            {
                bool estado;
                estado = Convert.ToBoolean (e.Result);


                MessageBox.Show(estado ? "Se Agrego correctamente el Rol" : "No se pudo Agregar el Rol");
                //  ListarCommandAccion();
                ListarRolesDelUsuarioCommandAccion();

              
                 
            }
        }

        private void _ServicioUserRole_EliminarUserRoleCompleted(object sender, ServiceReference_UserRole.EliminarUserRoleCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message + e.Error);
            }
            else
            {
                MessageBox.Show(e.Result ? "Se elimino Correctamente" : "No se pudo eliminar" + "Rol");
              //  ListarCommandAccion();
            }
        }

        private void EliminarRolDelUsuarioCommandAccion()
        {
            if (ItemUsuarioRol != null && ItemUsuarioRol.id != 0)
            {
                MessageBoxResult result = MessageBox.Show("ESta usted seguro de eliminar el ROL del usuario: " +
                    ItemUsuarioRol.user_id, "Eliminar Rol", MessageBoxButton.OKCancel);

                if (result == MessageBoxResult.OK)
                {
                    _ServicioUserRole.EliminarUserRoleAsync(ItemUsuarioRol.id);

                }
                else
                {

                    MessageBox.Show("No hay datos del usuario, para almacenar en el sistema");
                }

            }
            else
            {

                MessageBox.Show("Seleccione el Rol");
            }
        }

        //Metodo asincrono para listar detalle de roles del usurior
        private void ListarRolesDelUsuarioCommandAccion()
        {
            try
            {
                _ServicioUserRole.ListarUserRolePorIDUSERAsync(Convert.ToInt32( ItemUsuario.user_id)); //llamada asincrona
                _ServicioUserRole.ListarUserRolePorIDUSERCompleted  +=_ServicioUserRole_ListarUserRolePorIDUSERCompleted;  //aqui recupero el resultado de mi llamada asincrona
            }
            catch (Exception)
            {

                MessageBox.Show("Error al devolver datos");
            }
        }

        private void _ServicioUserRole_ListarUserRolePorIDUSERCompleted(object sender, ServiceReference_UserRole.ListarUserRolePorIDUSERCompletedEventArgs e)
        {
            ListaUsuarioRoles.Clear();

            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message + e.Error);
                return;
            }
            else
            {
                foreach (var userroleDTOx in e.Result)
                {
                      ListaUsuarioRoles.Add(userroleDTOx);
                }



            }
            _ServicioUserRole.ListarUserRolePorIDUSERCompleted += _ServicioUserRole_ListarUserRolePorIDUSERCompleted;
        }

       

      

        private void _ServicioUsuario_InsertarUsuariosCompleted(object sender, ServiceReference_User.InsertarUsuarioCompletedEventArgs e)
        {
            //Este metodo se ejecuta cuando se ACABA DE GUARDAR un nuevo usuario a la BD
            //metodo que me devuelve el Id del usuario con el que se guardo.
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message + e.Error);
            }
            else
            {
                MessageBox.Show("Usuario Agregado con ID: " + e.Result.ToString());
                ListarCommandAccion();
            }
        }


        //Metodo asincrono para listar roles disponibles para agregar
        private void ListarRolesCommandAccion()
        {
            try
            {
                _ServicioRole.ListarTodosLosRolesAsync(); //llamada asincrona
                _ServicioRole.ListarTodosLosRolesCompleted  +=_ServicioRole_ListarTodosLosRolesCompleted;  //aqui recupero el resultado de mi llamada asincrona
            }
            catch (Exception)
            {

                MessageBox.Show("Error al devolver datos");
            }
        }

        private void _ServicioRole_ListarTodosLosRolesCompleted(object sender, ServiceReference_Role.ListarTodosLosRolesCompletedEventArgs e)
        {
            ListaRoles.Clear(); 
       
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message + e.Error);
                return;
            }
            else
            {
                foreach (var roleDTOx in e.Result)
                {
                    ListaRoles.Add(roleDTOx);
                }

            }
            _ServicioRole.ListarTodosLosRolesCompleted -= _ServicioRole_ListarTodosLosRolesCompleted;
        }

        

        private void NuevoCommandAccion()
        {
            if (ItemUsuario != null && ItemUsuario.user_id != 0)
            {
                MessageBoxResult result = MessageBox.Show("Realmente desea ingresar un nuevo usuario.","Nuevo Usuario",
                    MessageBoxButton.OKCancel);

                if (result == MessageBoxResult.OK)
                {
                    ItemUsuario = new HostalDB_ViewModel.ServiceReference_User.userDTO();
                    ItemUsuario.enabled = 1;
                    ItemUsuario.accountExpired = 0;
                    ItemUsuario.accountLocked = 0;
                    ItemUsuario.passwordExpired = 0;
                }
                else
                {

                    MessageBox.Show("No hay datos del usuario, para almacenar en el sistema");
                }

            }
            else
            {

                ItemUsuario = new HostalDB_ViewModel.ServiceReference_User.userDTO();
                ItemUsuario.enabled = 1;
                ItemUsuario.accountExpired = 0;
                ItemUsuario.accountLocked = 0;
                ItemUsuario.passwordExpired = 0;
            }

        }

        private void EliminarCommandAccion()
        {
            if (ItemUsuario != null && ItemUsuario.user_id != 0)
            {
                MessageBoxResult result = MessageBox.Show("ESta usted seguro de eliminar el usuario: "+
                    ItemUsuario.nombre,"Eliminar Usuario", MessageBoxButton.OKCancel);

                if (result == MessageBoxResult.OK)
                {
                    _ServicioUsuario.EliminarUsuarioAsync(ItemUsuario.user_id );

                }
                else
                {

                    MessageBox.Show("No hay datos del usuario, para almacenar en el sistema");
                }

            }
            else
            {

                MessageBox.Show("Seleccione Usuario");
            }
        }

        private void GuardarCommandAccion()
        {
            try
            {
                if (ItemUsuario.user_id == 0)//
                {
                    ItemUsuario.accountExpired = 0;
                    ItemUsuario.accountLocked = 0;
                    ItemUsuario.passwordExpired = 0;
                    ItemUsuario.enabled = 1;

                    _ServicioUsuario.InsertarUsuarioAsync(ItemUsuario);
        

                    //Se llama a insertar un nuevo usuario a la BD
                }
                else
                {
                  

                    _ServicioUsuario.ActualizarUsuarioAsync(ItemUsuario);
                    _ServicioUsuario.ActualizarUsuarioCompleted += _ServicioUsuario_ActualizarUsuarioCompleted;
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message + "Error al guardar Usuario");
            }
        }

        void _ServicioUsuario_ActualizarUsuarioCompleted(object sender, HostalDB_ViewModel.ServiceReference_User.ActualizarUsuarioCompletedEventArgs e)
        {
            if (e.Result == true)
            {
                MessageBox.Show("El  Usuario se actualizo correctamente" );
                ListarCommandAccion();
            }
            else
            {
                MessageBox.Show(e.Error.Message + e.Error);
            }
        }
       

       
        private void BuscarCommandAccion()
        {
            
            
            try
            {
                _ServicioUsuario.BuscarUsuarioAsync(ParametroBusqueda); //falta implementar
                _ServicioUsuario.BuscarUsuarioCompleted += _ServicioUsuario_BuscarUsuarioCompleted;
            }
            catch (Exception)
            {

                MessageBox.Show("Error al devolver resultados de busqueda");
            }
        }

        void _ServicioUsuario_BuscarUsuarioCompleted(object sender, HostalDB_ViewModel.ServiceReference_User.BuscarUsuarioCompletedEventArgs e)
        {
            ListarUsuarios.Clear();


            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message + e.Error);
                return;
            }
            else
            {
                foreach (var userDTOx in e.Result)
                {
                    ListarUsuarios.Add(userDTOx);
                }

            }
            _ServicioUsuario.BuscarUsuarioCompleted -= _ServicioUsuario_BuscarUsuarioCompleted;
        }

        private void _ServicioUsuario_EliminarUsuariosCompleted(object sender, HostalDB_ViewModel.ServiceReference_User.EliminarUsuarioCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message + e.Error);
            }
            else 
            {
                MessageBox.Show(e.Result ? "Se elimino Correctamente" : "No se pudo eliminar" + "Estado usuario");
                ListarCommandAccion();
            }
        }

       

        #region constructor
        private void ListarCommandAccion()
        {
            try
            {
                _ServicioUsuario.ListarUsuariosAsync();
                _ServicioUsuario.ListarUsuariosCompleted += _ServicioUsuario_ListarUsuariosCompleted;
            }
            catch (Exception)
            {

                MessageBox.Show("Error al devolver datos");
            }
        }

        void _ServicioUsuario_ListarUsuariosCompleted(object sender, ServiceReference_User.ListarUsuariosCompletedEventArgs e)
        {
            ListarUsuarios.Clear();


            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message + e.Error);
                return;
            }
            else
            {
                foreach (var userDTOx in e.Result)
                {
                    ListarUsuarios.Add(userDTOx);
                }

            }
            _ServicioUsuario.ListarUsuariosCompleted -= _ServicioUsuario_ListarUsuariosCompleted;

        }


        #endregion

        #region botones

        public ICommand NuevoCommand { get; set; }
        public ICommand GuardarCommand { get; set; }
        public ICommand EliminarCommand { get; set; }
      //  public ICommand ActualizarCommand { get; set; }
        public ICommand BuscarCommand { get; set; }
        public ICommand ListarCommand { get; set; }
        
        //Para listar todos los roles disponibles para agregar
        public ICommand ListarRolesCommand { get; set; }
        
         //Para listar detalle de roles del usuario
        public ICommand ListarRolesDelUsuarioCommand { get; set; }

        //Para Eliminar Rol del cliente
        public ICommand EliminarRolDelUsuarioCommand { get; set; }

        //Para Eliminar Rol del cliente
        public ICommand AgregarNuevoRolAlUsuarioCommand { get; set; }
        #endregion

    }
}
