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

namespace HostalDB_View
{
    public partial class App : Application
    {
        public App()
        {
            this.Startup += this.Application_Startup;
            this.UnhandledException += this.Application_UnhandledException;

            InitializeComponent();
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            this.RootVisual = new MainPage();
        }

        private void Application_UnhandledException(object sender, ApplicationUnhandledExceptionEventArgs e)
        {
            // Si la aplicación se está ejecutando fuera del depurador, informe de la excepción mediante
            // un control ChildWindow.
            if (!System.Diagnostics.Debugger.IsAttached)
            {
                // NOTA: esto permitirá a la aplicación continuar ejecutándose después de que una excepción se haya producido
                // pero no controlado. 
                // Para las aplicaciones de producción, este control de errores se debe reemplazar por algo que 
                // informará del error al sitio web y detendrá la aplicación.
                e.Handled = true;
                ChildWindow errorWin = new ErrorWindow(e.ExceptionObject);
                errorWin.Show();
            }
        }
    }
}