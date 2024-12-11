using System.Text;

Console.OutputEncoding = Encoding.UTF8;
//1
/*{
    int[] array = { 0, 1, 2, 8, 4, 5, 6, 7, 44, 9 };

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
    
   
}*/
//2
/*{
    int[,] array = {
            { 9, 5, 3 },
            { 2, 7, 8 },
            { 6, 4, 1 }
        };

    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    int[] one = new int[rows * cols];
    int index = 0;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            one[index++] = array[i, j];
        }
    }

    Array.Sort(one);

    index = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = one[index++];
        }
    }

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}*/
//3
/*{
    int[] array = { 0, 1, 2, 8, 4, 5, 6, 7, 44, 9 };

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

    
    foreach (int n in newarray)
    {
        Console.Write(n + " ");
    }
}*/
//4
{
    int[,] array = {
            { 9, 5, 3 },
            { 2, 7, 8 },
            { 6, 4, 1 }
        };

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
}