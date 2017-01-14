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

        private GenLogics myGenMechanics;
        public frmGame()
        {
            InitializeComponent();
            myGenMechanics = new GenLogics();
            MyBtnProps btnContent = new MyBtnProps() { Name = "T" };

            btnCollection();

            //int row = (int)btn00.GetValue(GameBoard.Row)
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
                
            }
        }

        #region btnEvents

        private void btnClick(object sender, RoutedEventArgs e)
        {
            string btnName; int yPos, xPos; bool living = true;

            ((Button)sender).Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#99ff33"));

            btnName = ((Button)sender).Name;
            yPos = int.Parse(btnName.Substring(3, 1));
            xPos = int.Parse(btnName.Substring(4, 1));

            lbl_yPos.Content = yPos;
            lbl_xPos.Content = xPos;

            myGenMechanics.setPosition(yPos, xPos, living);
        }

        private void btnRigtClick(object sender, MouseButtonEventArgs e)
        {
            string btnName;  int yPos, xPos;  bool living = false;

            ((Button)sender).Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#e6e6e6"));

            btnName = ((Button)sender).Name;
            yPos = int.Parse(btnName.Substring(3, 1));
            xPos = int.Parse(btnName.Substring(4, 1));

            myGenMechanics.setPosition(yPos, xPos, living);
        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            var newW = new MainWindow();
            newW.Show();
            this.Close();
        }

        #region NavBarButtons
        private void btnNewGen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLoadGen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnPlayGenSerie_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion NavBarBussons
        #endregion btnEvents
    }
}
