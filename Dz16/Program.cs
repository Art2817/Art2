using System;
using System.IO;
using System.Text;
namespace Dz16
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            try
            {

                Console.Write("Введіть шлях до вихіідного файлу: ");
                string sourcePath = Console.ReadLine();


                Console.Write("Введіть шлях до файлу в який потрібно скопіюват:");
                string destinationPath = Console.ReadLine();

                if (!File.Exists(sourcePath))
                {
                    Console.WriteLine("Вихідний файл не знайдено");
                    return;
                }

                File.Copy(sourcePath, destinationPath);

                Console.WriteLine("Файл успішно скопійовано ");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Сталася помилка: {ex.Message}");
            }
        }
    }
}