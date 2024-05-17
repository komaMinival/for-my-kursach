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
namespace Quiz_Game_WPF_MOO_ICT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int qNum = 0;
        int i;
        int score;
        public MainWindow()
        {
            InitializeComponent();
        
            StartGame();
            NextQuestion();
        }
        private void checkAnswer(object sender, RoutedEventArgs e)
        {
            
            Button senderButton = sender as Button; 
            if (senderButton.Tag.ToString() == "1")
            {
                score++;
            }
            
            if (qNum < 0)
            {
                qNum = 0;
            }
            else
            {
                
                qNum++;
            }
            
            scoreText.Content = "Answered Correctly " + score + "/" + questionNumbers.Count;
            
            NextQuestion();
        }
        private void RestartGame()
        {
            
            score = 0; // set score to 0
            qNum = -1; // set qnum to -1
            i = 0; // set i to 0
            StartGame(); // run the start game function
        }
        private void NextQuestion()
        {
            
            if (qNum < questionNumbers.Count)
            {
                i = questionNumbers[qNum];
            }
            else
            {
                
                RestartGame();
            }
            
            foreach (var x in myCanvas.Children.OfType<Button>())
            {
                x.Tag = "0";
                x.Background = Brushes.DarkSalmon;
            }
            
            switch (i)
            {
                case 1:
                    txtQuestion.Text = "Как назвается игра, которая представлена на данном изображение?"; // this the question for the quiz
                    ans1.Content = "DOTA 2"; // each of the buttons can have their own answers in this game
                    ans2.Content = "Mincraft";
                    ans3.Content = "split";
                    ans4.Content = "cs2";
                    ans2.Tag = "1"; 
                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/1.jpg")); 
                    break; 
                case 2:
                    txtQuestion.Text = "Как назвается игра, которая представлена на данном изображение?";
                    ans1.Content = "dota2";
                    ans2.Content = "hardsd";
                    ans3.Content = "launch";
                    ans4.Content = "cs2";
                    ans1.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/2.jpg"));
                    break;
                case 3:
                    txtQuestion.Text = "Как назвается игра, которая представлена на данном изображение?";
                    ans1.Content = "BatleField";
                    ans2.Content = "ROMAloh";
                    ans3.Content = "CS 2";
                    ans4.Content = "Dota 2";
                    ans3.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/3.jpg"));
                    break;
                case 4:
                    txtQuestion.Text = "Как назвается игра, которая представлена на данном изображение?";
                    ans1.Content = "KAma";
                    ans2.Content = "SIMIS 4";
                    ans3.Content = "Winx";
                    ans4.Content = "MK11";
                    ans4.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/4.jpg"));
                    break;
                case 5:
                    txtQuestion.Text = "Как назвается игра, которая представлена на данном изображение?";
                    ans1.Content = "Forza Horizon 5";
                    ans2.Content = "GRID Autosport";
                    ans3.Content = "MINIcar";
                    ans4.Content = "CARdrift";
                    ans1.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/5.jpg"));
                    break;
                case 6:
                    txtQuestion.Text = "Как назвается игра, которая представлена на данном изображение?";
                    ans1.Content = "MK11";
                    ans2.Content = "CS2";
                    ans3.Content = "Assain Creed 4";
                    ans4.Content = "Spider man 2";
                    ans3.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/6.jpg"));
                    break;
                case 7:
                    txtQuestion.Text = "Как назвается игра, которая представлена на данном изображение?";
                    ans1.Content = "Maks 2";
                    ans2.Content = "Rust";
                    ans3.Content = "HUn Ya 2";
                    ans4.Content = "CS2";
                    ans2.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/7.jpg"));
                    break;
                case 8:
                    txtQuestion.Text = "Как назвается игра, которая представлена на данном изображение?";
                    ans1.Content = "cs2";
                    ans2.Content = "dota 2";
                    ans3.Content = "Eust";
                    ans4.Content = "The Witcher 3";
                    ans4.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/8.jpg"));
                    break;
                case 9:
                    txtQuestion.Text = "Как назвается игра, которая представлена на данном изображение?";
                    ans1.Content = "cs2";
                    ans2.Content = "The wintcher 3";
                    ans3.Content = "Sonik";
                    ans4.Content = "komabest 3";
                    ans3.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/9.jpg"));
                    break;
                case 10:
                    txtQuestion.Text = "Как назвается игра, которая представлена на данном изображение?";
                    ans1.Content = "Сталкер: Тень чернобыля";
                    ans2.Content = "cs 2";
                    ans3.Content = "dota 2";
                    ans4.Content = "koma";
                    ans1.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/10.jpg"));
                    break;
            }
        }
        private void StartGame()
        {
            // this is the start game function
            // inside of this function we will randomise the questions list and save it back into the list 
            // create a new randomlist variable and use the line below to randomise the order of the content
            var randomList = questionNumbers.OrderBy(a => Guid.NewGuid()).ToList();
            // save the random list to the question numbers list again
            questionNumbers = randomList;
            // empty the question order label on the canvas
            questionOrder.Content = null;
            // run a for loop to add the value which will display the randomised list to the display so we can see how the list has been ramdomised
            for (int i = 0; i < questionNumbers.Count; i++)
            {
                questionOrder.Content += " " + questionNumbers[i].ToString();
            }
        }
    }
}