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

namespace NumberGuesser_1300
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int targetNumber;
        private int guessCount = 1;

        public MainWindow()
        {
            InitializeComponent();
            guessingTextBox.Focus();
            targetNumber = new Random().Next(1, 101); // Zufallszahl zwischen 1 und 100 generieren
            music.Source = new Uri(@"C:\\Users\\damia\\source\\repos\\NumberGuesser_1300\\music\\Oldskool Jungle Drum n Bass Mix 92-97.mp3");
            music.Play();
        }
        private void guessingTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (int.TryParse(guessingTextBox.Text, out int userGuess))
                {
                    if (userGuess == targetNumber)
                    {
                        MessageBox.Show("Congratulations! You won. You had " + guessCount + " guesses", "Winner winner chicken dinner", MessageBoxButton.OK, MessageBoxImage.Information);
                        MessageBoxResult result = MessageBox.Show("Do you want to play again?", "Play again?", MessageBoxButton.YesNo, MessageBoxImage.Question);
                        if (result == MessageBoxResult.Yes)
                        {
                            targetNumber = new Random().Next(1, 101);
                            guessingTextBox.Clear();
                            guessCount = 1;
                        }
                        else
                        {
                            Window1 window = new Window1();
                            window.Show();  
                            this.Close();
                        }
                    }
                    else if (userGuess < targetNumber)
                    {
                        MessageBox.Show("Try a higher number.");
                        guessingTextBox.Clear();
                        guessCount++;
                        guessingTextBox.Focus();
                    }
                    else if (userGuess > 100)
                    {
                        MessageBox.Show("Please enter a valid number.");
                        guessingTextBox.Clear();

                    }
                    else if (userGuess < 1)
                    {
                        MessageBox.Show("Please enter a valid number.");
                        guessingTextBox.Clear();

                    }
                    else
                    {
                        MessageBox.Show("Try a lower number.");
                        guessingTextBox.Clear();
                        guessCount++;
                        guessingTextBox.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid number.");
                    guessingTextBox.Clear();

                }
            }
        }
    }
}



