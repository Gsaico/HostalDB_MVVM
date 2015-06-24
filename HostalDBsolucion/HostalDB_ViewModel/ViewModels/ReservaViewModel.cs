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

namespace HostalDB_ViewModel.ViewModels
{
    public class ReservaViewModel : ViewModelBase
    {
        private ServiceReference_Reserva.ReservaServiceClient _ServicioReserva;

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


        #region constructor
        public ReservaViewModel()
        {
            if (IsInDesignMode) return;

            _ServicioReserva = new ServiceReference_Reserva.ReservaServiceClient();
            ListaReservas = new ObservableCollection<ServiceReference_Reserva.reservaDTO>();
            ItemReserva = new ServiceReference_Reserva.reservaDTO();


            NuevaReservaCommand = new CommandBase(p => true, p => NuevaReservaCommandAccion()) { IsEnable = true };
            GuardarReservaCommand = new CommandBase(p => true, p => GuardarReservaCommandAccion()) { IsEnable = true };
            EliminarReservaCommand = new CommandBase(p => true, p => EliminarReservaCommandAccion()) { IsEnable = true };
            BuscarReservaPorIDCommand = new CommandBase(p => true, p => BuscarReservaPorIDCommandAccion()) { IsEnable = true };
            ListarTodasLasReservasCommand = new CommandBase(p => true, p => ListarTodasLasReservasCommandAccion()) { IsEnable = true };

            ListarReservasPorClienteCommand = new CommandBase(p => true, p => ListarReservasPorClienteCommandAccion()) { IsEnable = true };



        }

       

        #endregion

        #region Acciones asincronas

        private void ListarReservasPorClienteCommandAccion()
        {
            try
            {
                _ServicioReserva.ListarReservasPorClienteAsync(ParametroBusqueda_IDcliente); 

                _ServicioReserva.ListarReservasPorClienteCompleted += _ServicioUsuario_ListarReservasPorClienteCompleted;
            }
            catch (Exception)
            {

                MessageBox.Show("Error al devolver resultados de busqueda");
            }
        }

        private void _ServicioUsuario_ListarReservasPorClienteCompleted(object sender, ListarReservasPorClienteCompletedEventArgs e)
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
            _ServicioReserva.ListarReservasPorClienteCompleted -= _ServicioUsuario_ListarReservasPorClienteCompleted;
        }

        private void ListarTodasLasReservasCommandAccion()
        {
            try
            {
                _ServicioReserva.ListarTodasLasReservasAsync ();
                _ServicioReserva.ListarTodasLasReservasCompleted += _ServicioUsuario_ListarTodasLasReservasCompleted;
            }
            catch (Exception)
            {

                MessageBox.Show("Error al devolver datos");
            }
        }

        private void _ServicioUsuario_ListarTodasLasReservasCompleted(object sender, ListarTodasLasReservasCompletedEventArgs e)
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
            _ServicioReserva.ListarTodasLasReservasCompleted -= _ServicioUsuario_ListarTodasLasReservasCompleted;
        }

        private object BuscarReservaPorIDCommandAccion()
        {
            throw new NotImplementedException();
        }

        private object EliminarReservaCommandAccion()
        {
            throw new NotImplementedException();
        }

        private object GuardarReservaCommandAccion()
        {
            throw new NotImplementedException();
        }

        private object NuevaReservaCommandAccion()
        {
            throw new NotImplementedException();
        }

      

        #endregion

       
        #region botones

        public ICommand NuevaReservaCommand { get; set; }
        public ICommand GuardarReservaCommand { get; set; }
        public ICommand EliminarReservaCommand { get; set; }
        public ICommand BuscarReservaPorIDCommand { get; set; }
        public ICommand ListarTodasLasReservasCommand { get; set; }
        public ICommand ListarReservasPorClienteCommand { get; set; }


        #endregion

    }
}
