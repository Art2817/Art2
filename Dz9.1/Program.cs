using System.Text;

Console.OutputEncoding = Encoding.UTF8;
//1
{
    Random random = new Random();
    int[] array = new int[10];

    // Заповнення
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 11);
    }

    // Вивід
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();

    int max = array[0];
    int secondmax = array[0];

    foreach (int num in array)
    {
        if (num > max)
        {
            secondmax = max;
            max = num;
        }
        else if (num > secondmax && num != max)
        {
            secondmax = num;
        }
    }

        Console.WriteLine($"Другий найбільший елемент: {secondmax}");
    
   
}


//2
/*{
    Random random = new Random();
    int[,] array = new int[3, 3];

    // Заповнення
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 11);
        }
    }

    // Вивід
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }

    int[] one = new int [array.Length];
    int index = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            one[index++] = array[i, j];
        }
    }

    Array.Sort(one);

    index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = one[index++];
        }
    }

    // Вивід
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}*/


//3
/*{
    Random random = new Random();
    int[] array = new int[10];

    // Заповнення
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 11);
    }

    // Вивід
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();

    Console.Write("Введіть індекс для видалення: ");
    int index = int.Parse(Console.ReadLine());

    if (index < 0 || index >= array.Length)
    {
        Console.WriteLine("Неправильний індекс.");
        return;
    }


    int[] newarray = new int[array.Length - 1];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (i != index)
        {
            newarray[j++] = array[i];
        }
    }

    // Вивід
    for (int i = 0; i < newarray.Length; i++)
    {
        Console.Write(newarray[i] + " ");
    }
    Console.WriteLine();
}*/


//4
/*{
    Random random = new Random();
    int[,] array = new int[3, 3];

    // Заповнення
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 11);
        }
    }

    // Вивід
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }

    int diagonal = 0;
    int diagonal2 = 0;

    int n = array.GetLength(0);

    for (int i = 0; i < n; i++)
    {
        diagonal += array[i, i];
        diagonal2 += array[i, n - i - 1];
    }

    Console.WriteLine($"Сума діагоналі 1: {diagonal}");
    Console.WriteLine($"Сума діагоналі 2: {diagonal2}");
}*/