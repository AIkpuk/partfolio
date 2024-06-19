 using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace AddNewVaribel
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            BT_AddVarivels.Click += (e, a) =>
            {
                if (TB_FirstVar.IsVisible)
                {
                    TB_SecondVar.Visibility = Visibility.Visible;
                }
                else
                {
                    TB_FirstVar.Visibility = Visibility.Visible;
                }

            };

            while (TB_FirstVar.Text.Length < 1)
            {
                if (TB_FirstVar.Text.Length > 1)
                {
                    Itog.Visibility = Visibility.Visible;
                }
                else 
                {
                    Itog.Visibility = Visibility.Hidden;
                }
            } 
            
            
            while (Itog.IsVisible)
            {
                AddCalcButt();
            }
            
                
            


            void AddCalcButt()
            {
                Button newButton = new Button();
                newButton.Content = "Посчитать";
                ST_all.Children.Add(newButton);

                newButton.Click += (e, a) =>
                {
                    string Length1 = TB_FirstVar.Text;
                    string Length2 = TB_SecondVar.Text;

                    double x = Convert.ToDouble(Length1);
                    double y = Convert.ToDouble(Length2);
                    string Mult = Convert.ToString(x * y);
                    Itog.Text = Mult;
                };
            }
           
        }
      
    }
}
