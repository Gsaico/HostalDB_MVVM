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

namespace HostalDB_View.ChildWindows
{
    public partial class HabitacionesDisponiblesChildWindow : ChildWindow
    {
        public HabitacionesDisponiblesChildWindow()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
         //   this.DialogResult = true;

         ////   if (null != OKButton_Click)
         //   {

         //       CustomEventArgs args = new CustomEventArgs();

         //       args.DisplayName = this.txtDisplayName.Text;

         //       this.OnOkButtonClicked(this, args);

         //       this.Close();

         //   }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}

