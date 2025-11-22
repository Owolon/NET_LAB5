namespace NET_LAB5W
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string DetectSentenceType(string sentence)
        {
            char last = sentence.Trim().Last();
            if (last == '.') return "Повествовательное";
            if (last == '?') return "Вопросительное";
            if (last == '!') return "Восклицательное";
            return "Неизвестный тип";
        }
        public string Task_TWO(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return "Строка пустая.";

            input = input.Trim();

            if (!input.EndsWith("."))
                return "Последовательность должна заканчиваться точкой.";

            string clean = input.Substring(0, input.Length - 1);
            string[] words = clean.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (words.Length < 2)
                return "Должно быть не менее 2 слов.";

            string last = words[words.Length - 1];
            int maxLen = words.Max(w => w.Length);
            List<string> result = new List<string>();

            foreach (var w in words)
            {
                if (w != last && w.Length == maxLen)
                    result.Add(w);
            }

            if (result.Count == 0)
                return "Нет подходящих слов.";

            return string.Join(" ", result);
        }

        public string Task_THREE(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return "Введите слово.";

            string word = input.Trim();

            if (word.Length == 0)
                return "Пустая строка.";

            bool hasRepeat = false;

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = i + 1; j < word.Length; j++)
                {
                    if (word[i] == word[j])
                    {
                        hasRepeat = true;
                        break;
                    }
                }
                if (hasRepeat) break;
            }

            if (hasRepeat)
                return "Есть одинаковые буквы.";
            else
                return "Все буквы разные.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(textBox1)) return;

            label3.Text = "Результат: " + DetectSentenceType(textBox1.Text); 
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(textBox2)) return;
            label6.Text = "Результат: " + Task_TWO(textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(textBox3)) return;
            label7.Text = "Результат: " + Task_THREE(textBox3.Text);
        }
        private bool ValidateInput(TextBox tb)
        {
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                errorProvider1.SetError(tb, "Поле не может быть пустым");
                return false;
            }

            errorProvider1.SetError(tb, "");
            return true;
        }

    }
}
