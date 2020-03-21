using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace BorderlessWPFWindow
{
    public partial class WindowTemplate : Window
    {
        private void Window_StateChanged(object sender, EventArgs e)
        {
            titleBar2.WindowStateChanged(WindowState);
            UpdateMarginOnWindowState();
        }

        private void UpdateMarginOnWindowState()
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.BorderThickness = new Thickness(7);
                return;
            }

            this.BorderThickness = new Thickness(0);
        }
    }
}
