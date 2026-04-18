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

        //СТАРТ
        private void Старт_Click(object sender, RoutedEventArgs e)
        {
            
            string radioUrl = UrlTextBox.Text;

            
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

        //СТОП
        private void Стоп_Click(object sender, RoutedEventArgs e)
        {
            player.Stop();
            player.Close();
        }
    }
}
