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
using HostalDB_ViewModel.ServiceReference_Reserva;
using HostalDB_ViewModel.ServiceReference_User;

namespace HostalDB_ViewModel.ViewModels
{
    public class MaestroDetalleReservasDelCliente_VM : ViewModelBase
    {
        private ServiceReference_User.UserServiceClient _ServicioUsuario;
        private ServiceReference_Reserva.ReservaServiceClient _ServicioReserva;

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

        private int _parametroBusquedaIDUsuario;
        public int ParametroBusquedaIDUsuario
        {
            get { return _parametroBusquedaIDUsuario; }
            set
            {
                if (_parametroBusquedaIDUsuario == value) return;
                _parametroBusquedaIDUsuario = value;
                RaisePropertyChanged("ParametroBusquedaIDUsuario");
            }
        }

        #endregion

        #region Propiedades Reserva

        private ObservableCollection<ServiceReference_Reserva.reservaDTO> _ListaReservas;

        public ObservableCollection<ServiceReference_Reserva.reservaDTO> ListaReservas
        {
            get { return _ListaReservas; }
            set
            {
                _ListaReservas = value;
                RaisePropertyChanged("ListarReservas");

            }
        }

        private ServiceReference_Reserva.reservaDTO _ItemReserva;

        public ServiceReference_Reserva.reservaDTO ItemReserva
        {
            get { return _ItemReserva; }
            set
            {
                _ItemReserva = value;
                RaisePropertyChanged("ItemReserva");
            }
        }

        private int _parametroBusqueda_IDcliente;
        public int ParametroBusqueda_IDcliente
        {
            get { return _parametroBusqueda_IDcliente; }
            set
            {
                if (_parametroBusqueda_IDcliente == value) return;
                _parametroBusqueda_IDcliente = value;
                RaisePropertyChanged("ParametroBusqueda_IDreserva");
            }
        }

        #endregion

        #region Constructor
        public MaestroDetalleReservasDelCliente_VM()
        {
            if (IsInDesignMode) return;

            _ServicioReserva = new ServiceReference_Reserva.ReservaServiceClient();
            _ServicioUsuario = new ServiceReference_User.UserServiceClient();

            ListarUsuarios = new ObservableCollection<ServiceReference_User.userDTO>();
            ItemUsuario = new ServiceReference_User.userDTO();
            ListaReservas = new ObservableCollection<ServiceReference_Reserva.reservaDTO>();
            ItemReserva = new ServiceReference_Reserva.reservaDTO();



            BuscarUsuarioPorIDCommand = new CommandBase(p => true, p => BuscarUsuarioPorIDCommandAccion()) { IsEnable = true };

        


        }


        #endregion


        #region Eventos Asincrono y Sincrono
        private void BuscarUsuarioPorIDCommandAccion()
        {
           

            try
            {
                _ServicioUsuario.BuscarUsuarioPorIDAsync(ParametroBusquedaIDUsuario);

                _ServicioUsuario.BuscarUsuarioPorIDCompleted += _ServicioUsuario_BuscarUsuarioPorIDCompleted;

                _ServicioReserva.ListarReservasPorClienteAsync(ParametroBusquedaIDUsuario);
                _ServicioReserva.ListarReservasPorClienteCompleted += _ServicioReserva_ListarReservasPorClienteCompleted;
            }
            catch (Exception)
            {

                MessageBox.Show("Error al enviar parametros de busqueda");
            }
        }

        void _ServicioReserva_ListarReservasPorClienteCompleted(object sender, ServiceReference_Reserva.ListarReservasPorClienteCompletedEventArgs e)
        {
            ListaReservas.Clear();


            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message + e.Error);
                return;
            }
            else
            {
                foreach (var reservaDTOx in e.Result)
                {
                    ListaReservas.Add(reservaDTOx);
                }

            }
            _ServicioReserva.ListarReservasPorClienteCompleted -= _ServicioReserva_ListarReservasPorClienteCompleted;
        }

        private void _ServicioUsuario_BuscarUsuarioPorIDCompleted(object sender, BuscarUsuarioPorIDCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message + e.Error);
            }
            else
            {
              
                ItemUsuario = e.Result; 
            }



        }

        #endregion

        #region botones


        public ICommand BuscarUsuarioPorIDCommand { get; set; }

 

        #endregion
    }
}
