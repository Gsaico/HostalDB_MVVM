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
using HostalDB_ViewModel.ServiceReference_Habitacion;

namespace HostalDB_ViewModel.ViewModels
{

   
    public class HabitacionViewModel : ViewModelBase
    {
        private ServiceReference_Habitacion.HabitacionServiceClient _Serviciohabitacion;

        #region propiedades
        private ObservableCollection<ServiceReference_Habitacion.ListarHabitacionesDisponiblesClass> _ListarHabitacionesDisponibles;

        public ObservableCollection<ServiceReference_Habitacion.ListarHabitacionesDisponiblesClass> ListarHabitacionesDisponiblesx
        {
            get { return _ListarHabitacionesDisponibles; }
            set
            {
                _ListarHabitacionesDisponibles = value;
                RaisePropertyChanged("ListarHabitacionesDisponiblesx");

            }
        }

        private ObservableCollection<ServiceReference_Habitacion.habitacionDTO> _Listarhabitaciones;

        public ObservableCollection<ServiceReference_Habitacion.habitacionDTO> ListarHabitaciones
        {
            get { return _Listarhabitaciones; }
            set
            {
                _Listarhabitaciones = value;
                RaisePropertyChanged("ListarHabitaciones");

            }
        }

        private ServiceReference_Habitacion.habitacionDTO _ItemHabitacion;

        public ServiceReference_Habitacion.habitacionDTO ItemHabitacion
        {
            get { return _ItemHabitacion; }
            set
            {
                _ItemHabitacion = value;
                RaisePropertyChanged("Itemhabitacion");
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


        #region constructor
        public HabitacionViewModel()
        {
            if (IsInDesignMode) return;

            _Serviciohabitacion = new ServiceReference_Habitacion.HabitacionServiceClient();
            ListarHabitaciones = new ObservableCollection<ServiceReference_Habitacion.habitacionDTO>();
            ItemHabitacion = new ServiceReference_Habitacion.habitacionDTO();


            NuevoHabitacionCommand = new CommandBase(p => true, p => NuevoHabitacionCommandAccion()) { IsEnable = true };
            GuardarHabitacionCommand = new CommandBase(p => true, p => GuardarHabitacionCommandAccion()) { IsEnable = true };
            EliminarHabitacionCommand = new CommandBase(p => true, p => EliminarHabitacionCommandAccion()) { IsEnable = true };
            BuscarHabitacionPorIDCommand = new CommandBase(p => true, p => BuscarHabitacionPorIDCommandAccion()) { IsEnable = true };
            ListarTodasLasHabitacionesCommand = new CommandBase(p => true, p => ListarTodasLasHabitacionesCommandAccion()) { IsEnable = true };

            ListarHabitacionesDisponiblesCommand = new CommandBase(p => true, p => ListarHabitacionesDisponiblesCommandAccion()) { IsEnable = true };
            ListarHabitacionesOcupadasCommand = new CommandBase(p => true, p => ListarHabitacionesOcupadasCommandAccion()) { IsEnable = true };
            ListarHabitacionesPorCategoriaCommand = new CommandBase(p => true, p => ListarHabitacionesPorCategoriaCommandAccion()) { IsEnable = true };
            ListarHabitacionesPorTipoDehabitacionCommand = new CommandBase(p => true, p => ListarHabitacionesPorTipoDehabitacionCommandAccion()) { IsEnable = true };



        }

        #endregion

        #region Acciones asincronas

        private object ListarHabitacionesPorTipoDehabitacionCommandAccion()
        {
            throw new NotImplementedException();
        }

        private object ListarHabitacionesPorCategoriaCommandAccion()
        {
            throw new NotImplementedException();
        }

        private void ListarHabitacionesOcupadasCommandAccion()
        {
            try
            {
                _Serviciohabitacion.ListarHabitacionesOcupadasAsync();
                _Serviciohabitacion.ListarHabitacionesOcupadasCompleted += _Serviciohabitacion_ListarHabitacionesOcupadasCompleted;
            }
            catch (Exception)
            {

                MessageBox.Show("Error al devolver datos");
            }
        }

        private void _Serviciohabitacion_ListarHabitacionesOcupadasCompleted(object sender, ListarHabitacionesOcupadasCompletedEventArgs e)
        {
            ListarHabitaciones.Clear();


            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message + e.Error);
                return;
            }
            else
            {
                foreach (var habitacionesDTOx in e.Result)
                {
                    ListarHabitaciones.Add(habitacionesDTOx);
                }

            }
            _Serviciohabitacion.ListarHabitacionesOcupadasCompleted -= _Serviciohabitacion_ListarHabitacionesOcupadasCompleted;
        }

        private void ListarHabitacionesDisponiblesCommandAccion()
        {
            try
            {
                _Serviciohabitacion.ListarHabitacionesDisponiblesAsync ();
                _Serviciohabitacion.ListarHabitacionesDisponiblesCompleted += _Serviciohabitacion_ListarHabitacionesDisponiblesCompleted;
            }
            catch (Exception)
            {

                MessageBox.Show("Error al devolver datos");
            }
        }

        private void _Serviciohabitacion_ListarHabitacionesDisponiblesCompleted(object sender, ListarHabitacionesDisponiblesCompletedEventArgs e)
        {
    //        ListarHabitacionesDisponiblesx.Clear();


            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message + e.Error);
                return;
            }
            else
            {

            
 
                foreach (var habitacionesx in e.Result)
                {
                    ListarHabitacionesDisponiblesx.Add(habitacionesx);
                }

            }
            _Serviciohabitacion.ListarHabitacionesDisponiblesCompleted -= _Serviciohabitacion_ListarHabitacionesDisponiblesCompleted;
        }

        private object ListarTodasLasHabitacionesCommandAccion()
        {
            throw new NotImplementedException();
        }

        private object BuscarHabitacionPorIDCommandAccion()
        {
            throw new NotImplementedException();
        }

        private object EliminarHabitacionCommandAccion()
        {
            throw new NotImplementedException();
        }

        private object GuardarHabitacionCommandAccion()
        {
            throw new NotImplementedException();
        }

        private object NuevoHabitacionCommandAccion()
        {
            throw new NotImplementedException();
        }
        #endregion

       
        #region botones

        public ICommand NuevoHabitacionCommand { get; set; }
        public ICommand GuardarHabitacionCommand { get; set; }
        public ICommand EliminarHabitacionCommand { get; set; }
        // public ICommand ActualizarHabitacionCommand { get; set; }
        public ICommand BuscarHabitacionPorIDCommand { get; set; }
        public ICommand ListarTodasLasHabitacionesCommand { get; set; }
        public ICommand ListarHabitacionesDisponiblesCommand { get; set; }
        public ICommand ListarHabitacionesOcupadasCommand { get; set; }
        public ICommand ListarHabitacionesPorCategoriaCommand { get; set; }
        public ICommand ListarHabitacionesPorTipoDehabitacionCommand { get; set; }


        #endregion


    }
}
