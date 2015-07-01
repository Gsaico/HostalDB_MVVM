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

namespace HostalDB_View.UserControls
{
    public partial class HabitacionesDisponiblesUserControl : UserControl
    {
        public HabitacionesDisponiblesUserControl()
        {
            InitializeComponent();
        }
        HostalDB_ViewModel.ServiceReference_Habitacion.HabitacionServiceClient _Serviciohabitacion = new HostalDB_ViewModel.ServiceReference_Habitacion.HabitacionServiceClient();
       
       

        void _Serviciohabitacion_ListarHabitacionesDisponiblesCompleted(object sender, HostalDB_ViewModel.ServiceReference_Habitacion.ListarHabitacionesDisponiblesCompletedEventArgs e)
        {
            dgvHabitacionesDisponibles.SelectedItems.Clear();
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message + e.Error);
                return;
            }
            else
            {
                dgvHabitacionesDisponibles.ItemsSource = e.Result;

            }
            _Serviciohabitacion.ListarHabitacionesDisponiblesCompleted -= _Serviciohabitacion_ListarHabitacionesDisponiblesCompleted;
        }

        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            _Serviciohabitacion.ListarHabitacionesDisponiblesAsync();
            _Serviciohabitacion.ListarHabitacionesDisponiblesCompleted += _Serviciohabitacion_ListarHabitacionesDisponiblesCompleted;
        }

       

       
    }
}
