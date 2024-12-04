using System.Text;

Console.OutputEncoding = Encoding.UTF8;
//1
/*{
    Random random = new Random();
    int[] array = new int[10];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-10, 11);
    }

    for (int i = 0; i < array.Length; i += 2)
    {
            Console.WriteLine($"Елемент з індексом {i}: {array[i]}");
    }
}*/
//2
/*{
    Random random = new Random();
    int[] array = new int[10];

    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-10, 11);
        sum += array[i];
        Console.WriteLine($"Елемент з індексом {i}: {array[i]}");
    }

    if (sum >= 0)
    {
        Console.WriteLine("Сума елементів масиву є невід'ємним числом.");
    }
    else
    {
        Console.WriteLine("Сума елементів масиву є від'ємним числом.");
    }
}*/
//3
/*{
    int[,] array = new int[9, 9];

    for (int i = 0; i < 9; i++)
    {
        for (int j = 0; j < 9; j++)
        {
            array[i, j] = (i + 1) * (j + 1);
        }
    }

    Console.WriteLine("Таблиця множення:");
    for (int i = 0; i < 9; i++)
    {
        for (int j = 0; j < 9; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}*/
//4
{
    Random random = new Random();
    int[,] array = new int[5, 5];

    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            array[i, j] = random.Next(-100, 101);
        }
    }

    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    int max = array[0, 0];
    int min = array[0, 0];
    int maxx = 0, maxy = 0, minx = 0, miny = 0;

    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            if (array[i, j] > max)
            {
                max = array[i, j];
                maxx = i;
                maxy = j;
            }
            if (array[i, j] < min)
            {
                min = array[i, j];
                minx = i;
                miny = j;
            }
        }
    }

    Console.WriteLine($"Максимальний елемент: {max}");
    Console.WriteLine($"Мінімальний елемент: {min}");
    Console.WriteLine($"Координати максимального елемента: ({maxy}, {maxx})");
    Console.WriteLine($"Координати мінімального елемента: ({ miny }, { minx })");
}
//5