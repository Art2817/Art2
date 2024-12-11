using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 10.3
/*{
    //string input = "Artem , June,  August, sum mer, holiday ";
    Console.WriteLine("Введіть рядок, що містить слова, розділені комами:");
    string input = Console.ReadLine();

    string result = input.Replace(" ", "");

    Console.WriteLine("Результат: " + result);
}*/

//10.1
/*{
    Console.WriteLine("Введіть ім’я та прізвище через пробіл:");
    string input = Console.ReadLine();

    if (!string.IsNullOrEmpty(input))
    {
        string[] parts = input.Split(' ');

        if (parts.Length == 2)
        {
            string firstname = parts[0];
            string lastname = parts[1];

            if (firstname.Length > 0 && lastname.Length > 0)
            {
                char firstletter = char.ToUpper(firstname[0]);
                char secondletter = char.ToUpper(lastname[0]);

                if (firstletter == secondletter)
                {
                    Console.WriteLine("Прізвище починається на ту ж літеру, що і ім’я");
                }
                else
                {
                    Console.WriteLine("Прізвище не починається на ту ж літеру, що і ім’я");
                }
            }
            else
            {
                Console.WriteLine("Ім’я аб прізвище не можуть бути порожніми");
            }
        }
        else
        {
            
            Console.WriteLine("Ведіть лише ім’я та прізвище через пробіл " +
                "чи Ім’я або прізвище не можуть бути порожніми");
        }
    }
    else
    {
        Console.WriteLine("Введений рядок не може бути порожнімм");
    }
}*/
//10.3
{
    StringBuilder report = new StringBuilder();
    report.AppendLine("Текстовий звіт");
    report.AppendLine($"Дата: {DateTime.Now}");
    report.AppendLine("Список подій:");

    bool events = true;
    while (events)
    {
        Console.WriteLine("Введіть подію (або натисніть Enter для завершення): ");
        string? input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            events = false;
        }
        else
        {
            report.AppendLine($"- {input}");
        }
    }

    report.AppendLine("Кінець звіту");

    Console.WriteLine(report.ToString());
}
