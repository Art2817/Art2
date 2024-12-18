using System.Text;

namespace Dz13
{ 

class Program
{
    static List<string> ListArtem = new List<string>();

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;


        while (true)
        {
            Console.Clear();

            menu();


            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    add();
                    break;
                case "2":
                    show();
                    break;
                case "3":
                    markdone();
                    break;
                case "4":
                    daelete();
                    break;
                case "5":
                    Console.WriteLine("До побаченя");
                    return;
                default:
                    Console.WriteLine("Некоректний вибір спробуйте ще раз");
                    break;
            }

            Console.WriteLine("\n Натисніть будь яку клавішу щоб продовжити");
            Console.ReadKey();
        }
    }

    static void menu()
    {
        Console.WriteLine("Меню:");
        Console.WriteLine("1. Доддати");
        Console.WriteLine("2. Показати всі справи");
        Console.WriteLine("3. Виконана");
        Console.WriteLine("4. Видалити");
        Console.WriteLine("5. Вийти");
        Console.Write("Оберіть опцю: ");
    }

    static void add()
    {
        Console.Write("Введіть назву справи: ");
        string task = Console.ReadLine();


        if (!string.IsNullOrEmpty(task))
        {
            ListArtem.Add(task);
            Console.WriteLine("додано");
        }
        else
        {
            Console.WriteLine("Назва справи не може бути порожньою");
        }
    }

    static void show()
    {
        if (ListArtem.Count == 0)
        {
            Console.WriteLine("Список порожній ");
        }
        else
        {
            Console.WriteLine("Список справ:");
            for (int i = 0; i < ListArtem.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {ListArtem[i]}");
            }
        }
    }

    static void markdone()
    {
        show();

        Console.Write("Введіть номер справи для позначення її як виконаної: ");
        if (int.TryParse(Console.ReadLine(), out int taskn) && taskn > 0 && taskn <= ListArtem.Count)
        {
            string task = ListArtem[taskn - 1];
            ListArtem[taskn - 1] = task + " (Виконано)";
            Console.WriteLine("Справу виконана");
        }
        else
        {
            Console.WriteLine("Невірний номер справи");
        }
    }

    static void daelete()
    {
        show();
        Console.Write("Введіть номер справи для видалення; ");
        if (int.TryParse(Console.ReadLine(), out int taskn) && taskn > 0 && taskn <= ListArtem.Count)
        {
            ListArtem.RemoveAt(taskn - 1);
            Console.WriteLine("Справу видалено");
        }
        else
        {
            Console.WriteLine("Невірний номер справи");
        }
    }
}
}
