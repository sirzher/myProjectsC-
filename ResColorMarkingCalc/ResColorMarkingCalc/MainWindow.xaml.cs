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

namespace ResColorMarkingCalc
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double value = 0;  //номинал резистора
        double admittance = 0;
        byte strip1;
        byte strip2;
        double strip3;
        double stripb;
        double stripg;
        byte strip4;
        string multiplier = ""; //допуск
        public MainWindow()
        {
            
            InitializeComponent();
        }

        //Файл
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //Справка
        private void MenuItem_Click1(object sender, RoutedEventArgs e)
        {
     
            MessageBox.Show("Калькулятор позволяет рассчитывать сопротивление и допуск сопротивления резисторов с цветовой маркировкой в виде 4 или 5 цветных колец.\nАвтор: Смбатян Азнив", "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // 1 полоса
        private void RBt1Brown_Checked(object sender, RoutedEventArgs e)
        {
            if (RBt1Brown.IsChecked == true)
            {
                Strip1.Fill = Brushes.Brown;
                strip1 = 1;
            }
        }

        private void RBt1Red_Checked(object sender, RoutedEventArgs e)
        {
            if (RBt1Red.IsChecked == true)
            {
                Strip1.Fill = Brushes.Red;
                strip1 = 2;
            }
        }

        private void RBt1Orange_Checked(object sender, RoutedEventArgs e)
        {
            if (RBt1Orange.IsChecked == true)
            {
                Strip1.Fill = Brushes.Orange;
                strip1 = 3;
            }
        }

        private void RBt1Yellow_Checked(object sender, RoutedEventArgs e)
        {
            if (RBt1Yellow.IsChecked == true)
            {
                Strip1.Fill = Brushes.Yellow;
                strip1 = 4;
            }
        }

        private void RBt1Green_Checked(object sender, RoutedEventArgs e)
        {
            if (RBt1Green.IsChecked == true)
            {
                Strip1.Fill = Brushes.Green;
                strip1 = 5;
            }
        }

        private void RBt1Blue_Checked(object sender, RoutedEventArgs e)
        {
            if (RBt1Blue.IsChecked == true)
            {
                Strip1.Fill = Brushes.DarkBlue;
                strip1 = 6;
            }
        }

        private void RBt1Purple_Checked(object sender, RoutedEventArgs e)
        {
            if (RBt1Purple.IsChecked == true)
            {
                Strip1.Fill = Brushes.Purple;
                strip1 = 7;
            }
        }

        private void RBt1Grey_Checked(object sender, RoutedEventArgs e)
        {
            if (RBt1Gray.IsChecked == true)
            {
                Strip1.Fill = Brushes.Gray;
                strip1 = 8;
            }
        }

        private void RBt1White_Checked(object sender, RoutedEventArgs e)
        {
            if (RBt1White.IsChecked == true)
            {
                Strip1.Fill = Brushes.White;
                strip1 = 9;
            }
        }
        //2 полоса
        private void RBt2Black_Checked(object sender, RoutedEventArgs e)
        {
            if (RBt2Black.IsChecked == true)
            {
                Strip2.Fill = Brushes.Black;
                strip2 = 0;
            }
        }
        private void RBt2Brown_Checked(object sender, RoutedEventArgs e)
        {

            if (RBt2Brown.IsChecked == true)
            {
                Strip2.Fill = Brushes.Brown;
                strip2 = 1;
            }

        }

        private void RBt2Red_Checked(object sender, RoutedEventArgs e)
        {
            if (RBt2Red.IsChecked == true)
            {
                Strip2.Fill = Brushes.Red;
                strip2 = 2;
            }
        }

        private void RBt2Orange_Checked(object sender, RoutedEventArgs e)
        {
            if (RBt2Orange.IsChecked == true)
            {
                Strip2.Fill = Brushes.Orange;
                strip2 = 3;
            }
        }

        private void RBt2Yellow_Checked(object sender, RoutedEventArgs e)
        {
            if (RBt2Yellow.IsChecked == true)
            {
                Strip2.Fill = Brushes.Yellow;
                strip2 = 4;
            }
        }

        private void RBt2Green_Checked(object sender, RoutedEventArgs e)
        {
            if (RBt2Green.IsChecked == true)
            {
                Strip2.Fill = Brushes.Green;
                strip2 = 5;
            }
        }

        private void RBt2Blue_Checked(object sender, RoutedEventArgs e)
        {
            if (RBt2Blue.IsChecked == true)
            {
                Strip2.Fill = Brushes.DarkBlue;
                strip2 = 6;
            }
        }

        private void RBt2Purple_Checked(object sender, RoutedEventArgs e)
        {
            if (RBt2Purple.IsChecked == true)
            {
                Strip2.Fill = Brushes.Purple;
                strip2 = 7;
            }
        }

        private void RBt2Gray_Checked(object sender, RoutedEventArgs e)
        {
            if (RBt2Gray.IsChecked == true)
            {
                Strip2.Fill = Brushes.Gray;
                strip2 = 8;
            }
        }

        private void RBt2White_Checked(object sender, RoutedEventArgs e)
        {
            if (RBt2White.IsChecked == true)
            {
                Strip2.Fill = Brushes.White;
                strip2 = 9;
            }
        }

        //3 полоса
        private void RBt3Silver_Checked(object sender, RoutedEventArgs e)
        {
            if (RBt3Silver.IsChecked == true)
            {
                Strip3.Fill = Brushes.Silver;
                strip3 = 0.01;
                
            }
        }

        private void RBt3Gold_Checked(object sender, RoutedEventArgs e)
        {
            if (RBt3Gold.IsChecked == true)
            {
                Strip3.Fill = Brushes.Gold;
                strip3 = 0.1;
            }
        }

        private void RBt3Black_Checked(object sender, RoutedEventArgs e)
        {
            if (RBt3Black.IsChecked == true)
            {
                Strip3.Fill = Brushes.Black;
                strip3 = 1;
            }
        }

        private void RBt3Brown_Checked(object sender, RoutedEventArgs e)
        {
            if (RBt3Brown.IsChecked == true)
            {
                
                Strip3.Fill = Brushes.Brown;
                strip3 = 10;
            }
        }

        private void RBt3Red_Checked(object sender, RoutedEventArgs e)
        {
            if (RBt3Red.IsChecked == true)
            {
                Strip3.Fill = Brushes.Red;
                strip3 = 100;
            }
        }

        private void RBt3Orange_Checked(object sender, RoutedEventArgs e)
        {
            if (RBt3Orange.IsChecked == true)
            {
                Strip3.Fill = Brushes.Orange;
                strip3 = 1000;
            }
        }

        private void RBt3Yellow_Checked(object sender, RoutedEventArgs e)
        {
            if (RBt3Yellow.IsChecked == true)
            {
                Strip3.Fill = Brushes.Yellow;
                strip3 = 10000;
            }
        }

        private void RBt3Green_Checked(object sender, RoutedEventArgs e)
        {
            if (RBt3Green.IsChecked == true)
            {
                Strip3.Fill = Brushes.Green;
                strip3 = 100000;
            }
        }

        private void RBt3Blue_Checked(object sender, RoutedEventArgs e)
        {
            if (RBt3Blue.IsChecked == true)
            {
                Strip3.Fill = Brushes.DarkBlue;
                strip3 = 1000000;
            }
        }

        private void RBt3Purple_Checked(object sender, RoutedEventArgs e)
        {
            if (RBt3Purple.IsChecked == true)
            {
                Strip3.Fill = Brushes.Purple;
                strip3 = 10000000;
            }
        }

        private void RBt3Grey_Checked(object sender, RoutedEventArgs e)
        {
            if (RBt3Gray.IsChecked == true)
            {
                Strip3.Fill = Brushes.Gray;
                strip3 = 100000000;
            }
        }

        private void RBt3White_Checked(object sender, RoutedEventArgs e)
        {
            if (RBt3White.IsChecked == true)
            {
                Strip3.Fill = Brushes.White;
                strip3 = 1000000000;
            }
        }

        //4 полоса
        private void RBt4Silver_Checked(object sender, RoutedEventArgs e)
        {
            if (RBt4Silver.IsChecked == true)
            {
                Strip4.Fill = Brushes.Silver;
                admittance = 10;

            }
        }

        private void RBt4Gold_Checked(object sender, RoutedEventArgs e)
        {
            if (RBt4Gold.IsChecked == true)
            {
                Strip4.Fill = Brushes.Gold;
                admittance = 5;
            }
        }

        private void RBt4Brown_Checked(object sender, RoutedEventArgs e)
        {
            if (RBt4Brown.IsChecked == true)
            {
                Strip4.Fill = Brushes.Brown;
                admittance = 1;
            }
        }

        private void RBt4Red_Checked(object sender, RoutedEventArgs e)
        {
            if (RBt4Red.IsChecked == true)
            {
                Strip4.Fill = Brushes.Red;
                admittance = 2;
            }
        }

        private void RBt4Green_Checked(object sender, RoutedEventArgs e)
        {
            if (RBt4Green.IsChecked == true)
            {
                Strip4.Fill = Brushes.Green;
                admittance = 0.5;
            }
        }

        private void RBt4Blue_Checked(object sender, RoutedEventArgs e)
        {
            if (RBt4Blue.IsChecked == true)
            {
                Strip4.Fill = Brushes.DarkBlue;
                admittance = 0.25;
            }
        }

        private void RBt4Purple_Checked(object sender, RoutedEventArgs e)
        {
            if (RBt4Purple.IsChecked == true)
            {
                Strip4.Fill = Brushes.Purple;
                admittance = 0.10;
            }
        }

        private void RBt4Gray_Checked(object sender, RoutedEventArgs e)
        {
            if (RBt4Gray.IsChecked == true)
            {
                Strip4.Fill = Brushes.Gray;
                admittance = 0.05;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            value = Convert.ToDouble(strip1 * 10 + strip2) * strip3;
            if (strip3 < 100)
            {
                multiplier = "Ом";

            }
            else if (strip3 < 100000)
            {
                multiplier = "кОм";
                value /= 1000;
            }
            else if (strip3 < 1000000000)
            {
                multiplier = "мОм";
                value /= 1000000;
            }
            else
            {
                multiplier = "гОм";
                value /= 1000000000;
            }
            TBValue.Text = Convert.ToString(value) + multiplier + "±" + admittance;
        }
    }
}
