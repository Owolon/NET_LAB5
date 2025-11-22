using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_LAB5
{
    class Maini
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\nВыберите задание:");
                Console.WriteLine("1 – Тип предложения");
                Console.WriteLine("2 – Слова максимальной длины");
                Console.WriteLine("3 – Проверка одинаковых буквы");
                Console.WriteLine("0 – Выход");
                Console.Write("Ваш выбор: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        Task_ONE();
                        break;

                    case "2":
                        Task_TWO();
                        break;

                    case "3":
                        Task_THREE();
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Неверный выбор.");
                        break;
                }
            }
        }
        static void Task_ONE()
        {
            Console.Write("Введите предложение: ");
            string s = Console.ReadLine().Trim();

            if (s.Length == 0)
            {
                Console.WriteLine("Пустая строка!");
                return;
            }

            char last = s[s.Length - 1];

            if (last == '.')
                Console.WriteLine("Повествовательное предложение.");
            else if (last == '?')
                Console.WriteLine("Вопросительное предложение.");
            else if (last == '!')
                Console.WriteLine("Восклицательное предложение.");
            else
                Console.WriteLine("Тип предложения определить невозможно.");
        }
        static void Task_TWO()
        {
            Console.WriteLine("Введите строку (2–50 слов, латиница, последнее слово с точкой):");
            string input = Console.ReadLine().Trim();

            if (input.Length == 0 || input[input.Length - 1] != '.')
            {
                Console.WriteLine("Ошибка! Последнее слово должно заканчиваться точкой.");
                return;
            }

            string noDot = input.Substring(0, input.Length - 1);
            string[] words = noDot.Split(' ');

            if (words.Length < 2)
            {
                Console.WriteLine("Введите более растпространённое предложение.");
                return;
            }

            string lastWord = words[words.Length - 1];

            int maxLen = 0;
            foreach (string w in words)
            {
                if (w != lastWord && w.Length > maxLen)
                    maxLen = w.Length;
            }

            Console.WriteLine("Слова максимальной длины отличные от последнего:");

            foreach (string w in words)
            {
                if (w != lastWord && w.Length == maxLen)
                    Console.WriteLine(w);
            }
        }

        static void Task_THREE()
        {
            Console.Write("Введите слово: ");
            string word = Console.ReadLine().Trim();

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
                Console.WriteLine("Есть одинаковые буквы.");
            else
                Console.WriteLine("Все буквы разные.");
        }
    }
}
