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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HostalDB_View
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Después de la navegación de Frame, asegúrese de que el control HyperlinkButton que representa a la página actual está seleccionado
        private void ContentFrame_Navigated(object sender, NavigationEventArgs e)
        {
            //foreach (UIElement child in LinksStackPanel.Children)
            //{
            //    HyperlinkButton hb = child as HyperlinkButton;
            //    if (hb != null && hb.NavigateUri != null)
            //    {
            //        if (hb.NavigateUri.ToString().Equals(e.Uri.ToString()))
            //        {
            //            VisualStateManager.GoToState(hb, "ActiveLink", true);
            //        }
            //        else
            //        {
            //            VisualStateManager.GoToState(hb, "InactiveLink", true);
            //        }
            //    }
            //}
        }

        // Si se produce un error durante la navegación, mostrar una ventana de error
        private void ContentFrame_NavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            e.Handled = true;
            ChildWindow errorWin = new ErrorWindow(e.Uri);
            errorWin.Show();
        }

     
        private void Usuarios(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            this.ContentFrame.Navigate(new Uri("/Usuarios", UriKind.Relative));
        }

        private void ReservacionesDelClientex(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            this.ContentFrame.Navigate(new Uri("/ReservacionesDelCliente", UriKind.Relative));
        }

        private void HabitacionesDisponibles(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            this.ContentFrame.Navigate(new Uri("/HabitacionesDisponibles", UriKind.Relative));
        }

        private void HabitacionesOcupadas(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            this.ContentFrame.Navigate(new Uri("/HabitacionesOcupadas", UriKind.Relative));
        }
    }
}