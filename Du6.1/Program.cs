using System.Text;
using System.Text.RegularExpressions;

Console.OutputEncoding = Encoding.UTF8;


//Обчислення середнього заробітку
/*{
    Console.WriteLine("Введіть кількість працівників:");
    int employees = int.Parse(Console.ReadLine());


    decimal totalsalary = 0;

    for (int i = 1; i <= employees; i++)
    {
        Console.WriteLine($"Введіть зарплату працівника N{i}:");
        decimal salary = decimal.Parse(Console.ReadLine());

        totalsalary += salary;
    }


    decimal average = totalsalary / employees;

    Console.WriteLine($"Середній заробіток працівників: {average}");
}*/

//Побудова графіку зірочками
/*{
    Console.Write("Введіть кількість рядків графіка: ");
    int rows = int.Parse(Console.ReadLine());

    for (int i = 1; i <= rows; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}*/

//Генерація простих чисел
/*{
    Console.Write("Введіть максимальне число: ");
    int max = int.Parse(Console.ReadLine());

    for (int number = 2; number <= max; number++)
    {
        if (Prime(number))
        {
            Console.WriteLine(number);
        }
    }
}

bool Prime(int number)
{
    if (number < 2) return false;

    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
        {
            return false;
        }
    }

    return true;
}*/

//Перевірка паролю
/*{
    Console.Write("Введіть пароль: ");
    string password = Console.ReadLine();
    if (password.Length >= 8 &&
        Regex.IsMatch(password, @"\d") &&
        Regex.IsMatch(password, @"[\W_]"))
    {
        Console.WriteLine("Пароль правильний");
    }
    else
    {
        Console.WriteLine("Пароль неправильний");
    }
}*/

//Генерація фібоначчівської послідовності
/*{
    Console.Write("Введіть кількість чисел Фібоначчі: ");
    int n = int.Parse(Console.ReadLine());
    int a = 0, b = 1;

    Console.WriteLine("Послідовність Фібоначчі:");
    for (int i = 0; i < n; i++)
    {
        Console.Write($"{a} ");
        int c = a;
        a = b;
        b = c + b;
    }
}*/

//Калькулятор оплати праці за годину
/*{
    Console.Write("Введіть кількість годин за день: ");
    double hours = double.Parse(Console.ReadLine());

    Console.Write("Введіть годинну ставку: ");
    double salary = double.Parse(Console.ReadLine());

    double pay = hours * salary;
    Console.WriteLine($"Оплата за день: {pay}");
}*/

//Генерація таблиці множення для конкретного числа
/*{
    Console.Write("Введіть число: ");
    int num = int.Parse(Console.ReadLine());

    Console.WriteLine($"Таблиця множення для числа {num}:");
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{num} x {i} = {num * i}");
    }
}*/

//Перевірка на простоту
/*{
    Console.Write("Введіть число: ");
    int number = int.Parse(Console.ReadLine());

    int divisor = 0;

    for (int i = 1; i <= number; i++)
    {
        if (number % i == 0)
        {
            divisor++;
        }
    }

    if (divisor == 2)
    {
        Console.WriteLine("число є простим.");
    }
    else
    {
        Console.WriteLine("число не є простим");
    }
}*/

{
    Console.Write("Введіть число: ");
    int number = int.Parse(Console.ReadLine());

    if (Prime(number))
    {
        Console.WriteLine("Число є простим.");
    }
    else
    {
        Console.WriteLine("Число не є простим.");
    }
}

bool Prime(int number)
{
    if (number < 2) return false;
    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0) return false;
    }
    return true;
}
