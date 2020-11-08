using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Loading
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer dT = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();

            dT.Tick += new EventHandler(dT_Tick);
            dT.Interval = new TimeSpan(0, 0, 5);
            dT.Start();
        }
        private void dT_Tick (object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();

            dT.Stop();
            this.Close();
        }
    }
}
