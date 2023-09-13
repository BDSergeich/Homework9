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

namespace Homework9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> listWords = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (srcSentenceToReverse.Text.Length == 0)
            {
                MessageBox.Show("Пустую строку не перевернуть!","Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                reversedSentece.Content = Reverse(srcSentenceToReverse.Text);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (srcSentenceToSplit.Text.Length == 0)
            {
                MessageBox.Show("Пустую строку не разобрать на слова!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                listWords = GetWordsArrayFromString(srcSentenceToSplit.Text).ToList();
                listWordsView.ItemsSource = listWords;
            }

        }



        /// <summary>
        /// Метод из 5 моудля. Разделяет пользовательский текст на отдельные слова и возвращает массив слов
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static string[] GetWordsArrayFromString(string s)
        {
            char[] separators = new char[] { ' ', '.', ',', '!', '?' };
            string[] result = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return result;
        }


        /// <summary>
        /// Метод из 5 модуля. Преворачивает фразу задом на перёд
        /// </summary>
        /// <param name="inputPhrase"></param>
        /// <returns></returns>
        static string Reverse(string inputPhrase)
        {
            string result = "";
            string[] words = GetWordsArrayFromString(inputPhrase);
            for (int i = words.Length - 1; i >= 0; i--)
            {
                result += words[i] + " ";
            }
            return result;
        }

    }
}
