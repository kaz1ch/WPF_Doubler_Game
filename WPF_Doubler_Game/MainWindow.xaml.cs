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
            int Fin_Value = Rand_Value.Next(512, 2048);

            FinValueTextBox.Text = Fin_Value.ToString();

            var ActualNumber = 0;
            ActualValueTextBox.Text = ActualNumber.ToString();

            var TurnNumber = 0;
            TurnNumberTextBox.Text = TurnNumber.ToString();
        }

        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            var ActualNumber = int.Parse(ActualValueTextBox.Text);
            var FinalNumber = int.Parse(FinValueTextBox.Text);
            var TurnNumber = int.Parse(TurnNumberTextBox.Text);

            ActualNumber++;
            ActualValueTextBox.Text = ActualNumber.ToString();

            TurnNumber++;
            TurnNumberTextBox.Text = TurnNumber.ToString();

            var WinMessage = $"Победа! Вы прошли игру за {TurnNumber} ходов!";
            var LoseMessage = $"Вас наполняет горечь поражения! Вы не только не прошли игру, но и потратили на это {TurnNumber} ходов!";

            if (ActualNumber == FinalNumber)
            {
                MessageBox.Show(WinMessage);
                this.Close();
            }

            if (ActualNumber > FinalNumber)
            {
                MessageBox.Show(LoseMessage);
                this.Close();
            }

        }

        private void MultiplyButton_Click(object sender, RoutedEventArgs e)
        {
            var ActualNumber = int.Parse(ActualValueTextBox.Text);
            var FinalNumber = int.Parse(FinValueTextBox.Text);
            var TurnNumber = int.Parse(TurnNumberTextBox.Text);

            ActualNumber *=2;
            ActualValueTextBox.Text = ActualNumber.ToString();

            TurnNumber++;
            TurnNumberTextBox.Text = TurnNumber.ToString();

            var WinMessage = $"Победа! Вы прошли игру за {TurnNumber} ходов!";
            var LoseMessage = $"Вас наполняет горечь поражения! Вы не только не прошли игру, но и потратили на это {TurnNumber} ходов!";

            if (ActualNumber == FinalNumber)
            {
                MessageBox.Show(WinMessage);
                this.Close();
            }

            if (ActualNumber > FinalNumber)
            {
                MessageBox.Show(LoseMessage);
                this.Close();
            }
        }
    }
}
