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

namespace WPF_Doubler_Game
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Title = "Game of Doubler";

            var Rand_Value = new Random();
            int Fin_Value = Rand_Value.Next(1024, 100000);

            var FinValueTextBox = new TextBox();
            FinValueTextBox.Text = Fin_Value.ToString();

            var ActualNumber = 0;
            var ActualValueTextBox = new TextBox();
            ActualValueTextBox.Text = ActualNumber.ToString();

        }
    }
}
