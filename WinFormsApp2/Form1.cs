namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // считывем значения из настроек
            textBoxSequence.Text = Properties.Settings.Default.input;
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            string input;
            try
            {
                input = this.textBoxSequence.Text;
            }
            catch(FormatException)
            {
                MessageBox.Show("Некорректный ввод", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxSequence.Focus();
                return;
            }

            Properties.Settings.Default.input = input;
            Properties.Settings.Default.Save();

            int result = Logic.DigitsAreMore(input);
            switch (result)
            {
                case int.MinValue:
                    labelAnswer.Text ="В последовательность введено менее 2 чисел";
                    break;
                case int.MinValue / 10:
                    labelAnswer.Text = "Содержаться неподходящие символы";
                    break;
                case int.MinValue / 100:
                    labelAnswer.Text = "Содержаться пробелы подряд";
                    break;
                case int.MinValue / 1000:
                    labelAnswer.Text = "Некорректная запись числа";
                    break;
                default:
                    labelAnswer.Text = "Ответ: " + result;
                    break;
            }
        }
        private void buttonClean_Click(object sender, EventArgs e)
        {
            textBoxSequence.Text = "";
            labelAnswer.Text = "Ответ: ";
        }
        private void buttonTask_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Дана последовательность вещественных чисел. Найти " +
                "количество вещественных чисел, которые больше своих “соседей”, " +
                "т. е. предшествующего и последующего", "Задание", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void textBoxSequence_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonResult.Focus();
            }
        }
        private void buttonResult_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxSequence.Focus();
            }
        }
        private void buttonResult_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                textBoxSequence.Focus();
            }
        }
    }
    public class Logic
    {
        public static int DigitsAreMore(string input)
        {
            double[] array = CheckAndConverseInput(input);
            if (array.Length != 1)
            {
                int count = 0;
                for (int i = 1; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i - 1] && array[i] > array[i + 1])
                        count++;
                }
                if (array[0] > array[1])
                    count++;
                if (array[array.Length - 1] > array[array.Length - 2])
                    count++;
                return count;
            }
            else
            {
                return (int)array[0];
            }
        }

        public static double[] CheckAndConverseInput(string input)
        {
            double[] check = new double[1];
            string[] parts = input.Split(' ');
            double[] array = new double[parts.Length];
            if (array.Length < 2)
            {
                check[0] = int.MinValue; //В последовательность введено менее 2 чисел
                return check;
            }

            foreach (char c in input)
            {
                if (!Char.IsDigit(c) && c != '-' && c != ' ' && c != ',')
                {
                    check[0] = int.MinValue / 10; //Содержаться неподходящие символы
                    return check;
                }
            }

            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i] == "")
                {
                    check[0] = int.MinValue / 100; //Содержаться пробелы подряд
                    return check;
                }
                if (Double.TryParse(parts[i], out array[i]))
                {
                    continue;
                }
                else
                {
                    check[0] = int.MinValue / 1000; //Не удалось преобразовать в число
                    return check;
                }
            }
            return array; //Все в порядке
        }
    }
}