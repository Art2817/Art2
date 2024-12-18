using System.Text;

namespace Dz11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string[] text = { "рандом", "вибір", "Артем", "велосипед", "дерево" };//рандомнний вибір
            Random random = new Random();
            string word = text[random.Next(text.Length)].ToLower();


            char[] guessword = new string('_', word.Length).ToCharArray();
            int max = 6;
            int attempts = max;
            bool guess = false;

            Console.WriteLine("Спробуйте вгадати зашеффроване слово");
            Console.WriteLine($"Кількість літер у слові: {word.Length}");
            Console.WriteLine($"Кількість можливих невірних спроб: {max}");
            Console.WriteLine(new string(guessword));

            while (attempts > 0 && !guess)
            {
                Console.Write("\n введіть вашу літеру: ");
                char letter;

                try
                {
                    letter = char.ToLower(Console.ReadLine()![0]);
                }
                catch
                {
                    Console.WriteLine("Введіть лише одну літеру.");
                    continue;
                }

                if (!char.IsLetter(letter))
                {
                    Console.WriteLine("Вводьте тільки літериу ");
                    continue;
                }

                if (word.Contains(letter))
                {
                    Console.Write($"Така літера є у слові! Позиція літери: ");
                    bool found = false;


                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i] == letter)
                        {
                            guessword[i] = letter;
                            Console.Write($"{i + 1}, ");
                            found = true;
                        }
                    }

                    Console.WriteLine();
                    if (!found) Console.WriteLine("Щось пішло не так.");
                }
                else
                {
                    attempts--;
                    Console.WriteLine($"Такої літери немає! Залишилось спроб: {attempts}");
                }

                Console.WriteLine($"Слово: {new string(guessword)}");

                if (!guessword.Contains('_'))
                {
                    guess = true;
                }
            }

            if (guess)
            {
                Console.WriteLine("\nВітаємо, ви вгадали слово!");
                Console.WriteLine($"Зашифроване слово: {word}");
            }
            else
            {
                Console.WriteLine("\nНа жаль ви програли.");
                Console.WriteLine($"Зашифроване слово було: {word}");
            }

            Console.WriteLine("Дякуємо за гру!");
        }
    }
}