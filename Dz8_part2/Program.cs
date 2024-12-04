enum WeekDays
{
    Monday ,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

class Program
{
    static void Main()
    {
        Console.Write("Введіть кількість днів: ");
        int days = int.Parse(Console.ReadLine());

        WeekDays day = (WeekDays)((days - 1) % 7 + 1);

        Console.WriteLine("Це буде: " + day);
    }
}

