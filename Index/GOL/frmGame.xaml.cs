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
using System.Windows.Shapes;
using GOL;

namespace GOL
{
    /// <summary>
    /// Interaction logic for frmGame.xaml
    /// </summary>
    public partial class frmGame : Window
    {
        //MainWindow mainWin = new MainWindow();
        public frmGame()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            var newW = new MainWindow();
            newW.Show();
        }
    }
}
