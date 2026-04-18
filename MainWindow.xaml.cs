using System;
using System.Windows;
using System.Windows.Media;

namespace МоеРадио
{
    public partial class MainWindow : Window
    {
        private MediaPlayer player = new MediaPlayer();

        public MainWindow()
        {
            InitializeComponent();
        }

        // Кнопка СТАРТ
        private void Старт_Click(object sender, RoutedEventArgs e)
        {
            // Берём ссылку из текстового поля
            string radioUrl = UrlTextBox.Text;

            // Проверяем, что ссылка не пустая
            if (!string.IsNullOrEmpty(radioUrl))
            {
                try
                {
                    player.Open(new Uri(radioUrl));
                    player.Play();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Введите ссылку на радиостанцию!");
            }
        }

        // Кнопка СТОП
        private void Стоп_Click(object sender, RoutedEventArgs e)
        {
            player.Stop();
            player.Close();
        }
    }
}