using System.Text;

Console.OutputEncoding = Encoding.UTF8;

{
    Console.WriteLine("Введіть значення:");

    string input = Console.ReadLine();

    try
    {
        Console.WriteLine($"Перетворено в decimal: {decimal.Parse(input)} ");
    }
    catch (FormatException)
    {
        Console.WriteLine("Формат не відповідає decimal.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("Значення виходить за межі decimal.");
    }




    try
    {
        Console.WriteLine($"Перетворено в bool: {bool.Parse(input)}");
    }
    catch (FormatException)
    {
        Console.WriteLine("Формат не відповідає bool.");
    }




    try
    {
        Console.WriteLine($"Перетворено в int: {int.Parse(input)}");
    }
    catch (FormatException)
    {
        Console.WriteLine("Формат не відповідає int.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("Значення виходить за межі int.");
    }




    try
    {
        Console.WriteLine($"Перетворено в byte: {byte.Parse(input)}");
    }
    catch (FormatException)
    {
        Console.WriteLine("Формат не відповідає byte.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("Значення виходить за межі byte.");
    }



    try
    {
        Console.WriteLine($"Перетворено в short: {short.Parse(input)}");
    }
    catch (FormatException)
    {
        Console.WriteLine("Формат не відповідає short.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("Значення виходить за межі short.");
    }



    try
    {
        Console.WriteLine($"Перетворено в long: {long.Parse(input)}");
    }
    catch (FormatException)
    {
        Console.WriteLine("Формат не відповідає long.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("Значення виходить за межі long.");
    }



    try
    {
        Console.WriteLine($"Перетворено в float: {float.Parse(input)}");
    }
    catch (FormatException)
    {
        Console.WriteLine("Формат не відповідає float.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("Значення виходить за межі float.");
    }




    try
    {
        Console.WriteLine($"Перетворено в double: {double.Parse(input)}");
    }
    catch (FormatException)
    {
        Console.WriteLine("Формат не відповідає double.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("Значення виходить за межі double.");
    }




    if (input.Length == 1)
    {
        char charValue = input[0];
        Console.WriteLine($"Перетворено в char: {charValue}");
    }
    else
    {
        Console.WriteLine("Формат не відповідає char (повинен бути один символ).");
    }



    Console.WriteLine($"Перетворено в string: {input}");
}