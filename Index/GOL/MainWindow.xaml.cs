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
using System.Drawing;

namespace GOL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //frmGame newFrm = new frmGame();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, RoutedEventArgs e)
        {
            OpenNewWin();
        }

        private void btnExitGame_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void OpenNewWin()
        {
            var newW = new frmGame();
            newW.Show();
            this.Close();
        }
/*        public void MultiplyTransform(Matrix matrix);

       private void MultiplyTransformMatrix(PaintEventArgs e)
       {

            // Create transform matrix.
            Matrix transformMatrix = new Matrix();

            // Translate matrix, prepending translation vector.
            transformMatrix.Translate(200.0F, 100.0F);

            // Rotate transformation matrix of graphics object,

            // prepending rotation matrix.
            e.Graphics.RotateTransform(30.0F);

            // Multiply (prepend to) transformation matrix of

            // graphics object to translate graphics transformation.
            e.Graphics.MultiplyTransform(transformMatrix);

            // Draw rotated, translated ellipse.
            e.Graphics.DrawEllipse(new Pen(Color.Blue, 3), -80, -40, 160, 80);
        }
        */
    }
}
