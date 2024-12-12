using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static WpfLibrary1.NumberCounter;
using WpfLibrary1;

namespace pr10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            
            InitializeComponent();
        }
        private void btnCount_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string input = txtInput.Text;
                string[] numberStrings = input.Split(' ');

                // Важная проверка!
                if (!numberStrings.All(s => int.TryParse(s, out _)))
                {
                    txtResult.Text = "Неправильно введены значения.";
                    return;
                }

                var numbers = numberStrings.Select(int.Parse).Where(n => n >= -100 && n <= 100).ToList(); // Фильтруем некорректные значения
                if (numbers.Count == 0)
                {
                    txtResult.Text = "Не введены числа.";
                    return;
                }

                var result = numbers.Count();

                txtResult.Text = $"Положительных: {result.Positive}\nОтрицательных: {result.Negative}";
            }
            catch (Exception ex)
            {
                txtResult.Text = $"ошибка: {ex.Message}";
            }
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            string developer = "Дудина Екатерина";
            int job = 10;
            string task = "Дан массив в диапазоне [-100;100] найти количество положительных и \r\nотрицательных.";
            MessageBox.Show($"Разработчик: {developer}\nНомер работы: {job}\nЗадание: {task}", "О программе");
        }
        // "Выход"
        private void MenuItem_Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
