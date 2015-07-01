﻿using System;
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

namespace HostalDB_ViewModel.ViewModels
{
    public class UserViewModel : ViewModelBase
    {
        private  ServiceReference_User.UserServiceClient _ServicioUsuario;
        //= new ServiceReference_User.UserServiceClient();


        #region propiedades Usuario


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

        private ServiceReference_User.userDTO _ItemUsuario;

        public ServiceReference_User.userDTO ItemUsuario
        {
            get { return _ItemUsuario; }
            set
            {
                _ItemUsuario = value;
                RaisePropertyChanged("ItemUsuario");
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


        
        public UserViewModel()
        {
           if (IsInDesignMode) return;

            _ServicioUsuario = new ServiceReference_User.UserServiceClient();
            ListarUsuarios = new ObservableCollection<ServiceReference_User.userDTO>();
            ItemUsuario = new ServiceReference_User.userDTO();

            _ServicioUsuario.InsertarUsuarioCompleted += _ServicioUsuario_InsertarUsuariosCompleted;

            _ServicioUsuario.EliminarUsuarioCompleted += _ServicioUsuario_EliminarUsuariosCompleted;
 
            ListarCommand = new CommandBase(p => true, p => ListarCommandAccion()) { IsEnable = true };
            BuscarCommand = new CommandBase(p => true, p => BuscarCommandAccion()) { IsEnable = true };
            GuardarCommand = new CommandBase(p => true, p => GuardarCommandAccion()) { IsEnable = true };
            EliminarCommand = new CommandBase(p => true, p => EliminarCommandAccion()) { IsEnable = true };
            NuevoCommand = new CommandBase(p => true, p => NuevoCommandAccion()) { IsEnable = true }; 

            
        }

        

        private void NuevoCommandAccion()
        {
            if (ItemUsuario != null && ItemUsuario.user_id != 0)
            {
                MessageBoxResult result = MessageBox.Show("Realmente desea ingresar un nuevo usuario.","Nuevo Usuario",
                    MessageBoxButton.OKCancel);

                if (result == MessageBoxResult.OK)
                {
                    ItemUsuario = new userDTO();
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

                ItemUsuario = new userDTO();
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

        void _ServicioUsuario_ActualizarUsuarioCompleted(object sender, ActualizarUsuarioCompletedEventArgs e)
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
        private void _ServicioUsuario_InsertarUsuariosCompleted(object sender, InsertarUsuarioCompletedEventArgs e)
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

        void _ServicioUsuario_BuscarUsuarioCompleted(object sender, BuscarUsuarioCompletedEventArgs e)
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

        private void _ServicioUsuario_EliminarUsuariosCompleted(object sender, EliminarUsuarioCompletedEventArgs e)
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
        #endregion


    }
}
