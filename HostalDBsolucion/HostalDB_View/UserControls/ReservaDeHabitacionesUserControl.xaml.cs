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
    public partial class ReservaDeHabitacionesUserControl : UserControl
    {
        string IDcliente, Nombrecliente;
        public ReservaDeHabitacionesUserControl(string idcliente, string nombrecliente)

        {
            InitializeComponent();
            IDcliente = idcliente;
            Nombrecliente = nombrecliente;
             txtIDUser.Text = IDcliente;
            txtNombres.Text = Nombrecliente;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

        private void btnAgregarHabitaciones_Click(object sender, RoutedEventArgs e)
        {
            ChildWindows.HabitacionesDisponiblesChildWindow child = new ChildWindows.HabitacionesDisponiblesChildWindow();
            child.Closed += child_Closed;
            child.Show();
            
        }

        private void child_Closed(object sender, EventArgs e)
        {
            var r = sender as ChildWindows.HabitacionesDisponiblesChildWindow;
        }


    }
}
