namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // �������� �������� �� ��������
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
                MessageBox.Show("������������ ����", "������", 
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
                    labelAnswer.Text ="� ������������������ ������� ����� 2 �����";
                    break;
                case int.MinValue / 10:
                    labelAnswer.Text = "����������� ������������ �������";
                    break;
                case int.MinValue / 100:
                    labelAnswer.Text = "����������� ������� ������";
                    break;
                case int.MinValue / 1000:
                    labelAnswer.Text = "������������ ������ �����";
                    break;
                default:
                    labelAnswer.Text = "�����: " + result;
                    break;
            }
        }
        private void buttonClean_Click(object sender, EventArgs e)
        {
            textBoxSequence.Text = "";
            labelAnswer.Text = "�����: ";
        }
        private void buttonTask_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� ������������������ ������������ �����. ����� " +
                "���������� ������������ �����, ������� ������ ����� ��������, " +
                "�. �. ��������������� � ������������", "�������", 
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
                check[0] = int.MinValue; //� ������������������ ������� ����� 2 �����
                return check;
            }

            foreach (char c in input)
            {
                if (!Char.IsDigit(c) && c != '-' && c != ' ' && c != ',')
                {
                    check[0] = int.MinValue / 10; //����������� ������������ �������
                    return check;
                }
            }

            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i] == "")
                {
                    check[0] = int.MinValue / 100; //����������� ������� ������
                    return check;
                }
                if (Double.TryParse(parts[i], out array[i]))
                {
                    continue;
                }
                else
                {
                    check[0] = int.MinValue / 1000; //�� ������� ������������� � �����
                    return check;
                }
            }
            return array; //��� � �������
        }
    }
}