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
using GOL.GameGrid;
using GOL.GameGrid.Props;

namespace GOL
{
    /// <summary>
    /// Interaction logic for frmGame.xaml
    /// </summary>
    public partial class frmGame : Window
    {

        string HelloWorld = "Hello World";
        private string btnDataContext;
        public frmGame()
        {
            InitializeComponent();
            MyBtnProps btnContent = new MyBtnProps() { Name = "T" };

            GameBoard.ShowGridLines = new Grid();
            

            /*
            if (IsAlive == true)
            {
                btn01.Background = new SolidColorBrush(Color.FromArgb(100, 102, 255, 179));
            }
            else
            {
                btn01.Background = new SolidColorBrush(Color.FromArgb(100, 242, 242, 242));
            }
            */

            btnCollection();
        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            var newW = new MainWindow();
            newW.Show();
            this.Close();
        }
        private void btnCollection()
        {
            MyBtnProps btnDataContext = new MyBtnProps() { IsAlive = "T" };
            //btn00.DataContext = btnDataContext;
            var btnCollection = new List<Button>();
            #region Grid Buttons added to collection.
            btnCollection.Add(btn01);
            btnCollection.Add(btn01);
            btnCollection.Add(btn02);
            btnCollection.Add(btn03);
            btnCollection.Add(btn04);
            btnCollection.Add(btn05);
            btnCollection.Add(btn06);
            btnCollection.Add(btn07);
            btnCollection.Add(btn08);
            btnCollection.Add(btn09);

            btnCollection.Add(btn10);
            btnCollection.Add(btn11);
            btnCollection.Add(btn12);
            btnCollection.Add(btn13);
            btnCollection.Add(btn14);
            btnCollection.Add(btn15);
            btnCollection.Add(btn16);
            btnCollection.Add(btn17);
            btnCollection.Add(btn18);
            btnCollection.Add(btn19);

            btnCollection.Add(btn20);
            btnCollection.Add(btn21);
            btnCollection.Add(btn22);
            btnCollection.Add(btn23);
            btnCollection.Add(btn24);
            btnCollection.Add(btn25);
            btnCollection.Add(btn26);
            btnCollection.Add(btn27);
            btnCollection.Add(btn28);
            btnCollection.Add(btn29);

            btnCollection.Add(btn30);
            btnCollection.Add(btn31);
            btnCollection.Add(btn32);
            btnCollection.Add(btn33);
            btnCollection.Add(btn34);
            btnCollection.Add(btn35);
            btnCollection.Add(btn36);
            btnCollection.Add(btn37);
            btnCollection.Add(btn38);
            btnCollection.Add(btn39);

            btnCollection.Add(btn40);
            btnCollection.Add(btn41);
            btnCollection.Add(btn42);
            btnCollection.Add(btn43);
            btnCollection.Add(btn44);
            btnCollection.Add(btn45);
            btnCollection.Add(btn46);
            btnCollection.Add(btn47);
            btnCollection.Add(btn48);
            btnCollection.Add(btn49);

            btnCollection.Add(btn50);
            btnCollection.Add(btn51);
            btnCollection.Add(btn52);
            btnCollection.Add(btn53);
            btnCollection.Add(btn54);
            btnCollection.Add(btn55);
            btnCollection.Add(btn56);
            btnCollection.Add(btn57);
            btnCollection.Add(btn58);
            btnCollection.Add(btn59);

            btnCollection.Add(btn60);
            btnCollection.Add(btn61);
            btnCollection.Add(btn62);
            btnCollection.Add(btn63);
            btnCollection.Add(btn64);
            btnCollection.Add(btn65);
            btnCollection.Add(btn66);
            btnCollection.Add(btn67);
            btnCollection.Add(btn68);
            btnCollection.Add(btn69);

            btnCollection.Add(btn70);
            btnCollection.Add(btn71);
            btnCollection.Add(btn72);
            btnCollection.Add(btn73);
            btnCollection.Add(btn74);
            btnCollection.Add(btn75);
            btnCollection.Add(btn76);
            btnCollection.Add(btn77);
            btnCollection.Add(btn78);
            btnCollection.Add(btn79);

            btnCollection.Add(btn80);
            btnCollection.Add(btn81);
            btnCollection.Add(btn82);
            btnCollection.Add(btn83);
            btnCollection.Add(btn84);
            btnCollection.Add(btn85);
            btnCollection.Add(btn86);
            btnCollection.Add(btn87);
            btnCollection.Add(btn88);
            btnCollection.Add(btn89);

            btnCollection.Add(btn90);
            btnCollection.Add(btn91);
            btnCollection.Add(btn92);
            btnCollection.Add(btn93);
            btnCollection.Add(btn94);
            btnCollection.Add(btn95);
            btnCollection.Add(btn96);
            btnCollection.Add(btn97);
            btnCollection.Add(btn98);
            btnCollection.Add(btn99);
            #endregion Buttons added to collection.


            foreach (var item in btnCollection)
            {
                item.DataContext = btnDataContext;
                btn01.Background = new SolidColorBrush(Color.FromArgb(100, 102, 255, 179));
                /*
                if (item.DataContext == "hello")
                {
                    item.BorderBrush = Brushes.Blue;
                }
                */
            }
        }

        #region LeftBtnClickEvents
        private void btn00_Click(object sender, RoutedEventArgs e)
        {
            btn00.Background = Brushes.Green;
        }
        private void btn01_Click(object sender, RoutedEventArgs e)
        {
            btn01.Background = Brushes.Green;
        }
        private void btn02_Click(object sender, RoutedEventArgs e)
        {
            btn02.Background = Brushes.Green;
        }
        private void btn03_Click(object sender, RoutedEventArgs e)
        {
            btn03.Background = Brushes.Green;
        }
        private void btn04_Click(object sender, RoutedEventArgs e)
        {
            btn04.Background = Brushes.Green;
        }
        private void btn05_Click(object sender, RoutedEventArgs e)
        {
            btn05.Background = Brushes.Green;
        }

        private void btn06_Click(object sender, RoutedEventArgs e)
        {
            btn60.Background = Brushes.Green;
        }
        private void btn07_Click(object sender, RoutedEventArgs e)
        {
            btn07.Background = Brushes.Green;
        }
        private void btn08_Click(object sender, RoutedEventArgs e)
        {
            btn08.Background = Brushes.Green;
        }
        private void btn09_Click(object sender, RoutedEventArgs e)
        {
            btn09.Background = Brushes.Green;
        }

        #endregion LeftBtnClickEvents

        #region RightBtnClickEvent
        private void btn00_RightClick(object sender, MouseButtonEventArgs e)
        {
            btn00.Background = Brushes.Red;
        }
        private void btn01_RightClick(object sender, MouseButtonEventArgs e)
        {
            btn01.Background = Brushes.Red;
        }
        private void btn02_RightClick(object sender, MouseButtonEventArgs e)
        {
            btn02.Background = Brushes.Red;
        }
        private void btn03_RightClick(object sender, MouseButtonEventArgs e)
        {
            btn03.Background = Brushes.Red;
        }
        private void btn04_RightClick(object sender, MouseButtonEventArgs e)
        {
            btn04.Background = Brushes.Red;
        }
        private void btn05_RightClick(object sender, MouseButtonEventArgs e)
        {
            btn05.Background = Brushes.Red;
        }
        private void btn06_RightClick(object sender, MouseButtonEventArgs e)
        {
            btn06.Background = Brushes.Red;
        }
        private void btn07_RightClick(object sender, MouseButtonEventArgs e)
        {
            btn07.Background = Brushes.Red;
        }
        private void btn08_RightClick(object sender, MouseButtonEventArgs e)
        {
            btn08.Background = Brushes.Red;
        }
        private void btn09_RightClick(object sender, MouseButtonEventArgs e)
        {
            btn09.Background = Brushes.Red;
        }
        #endregion RightBtnClickEvent
    }
}
