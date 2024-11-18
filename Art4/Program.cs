using System.Text;
Console.OutputEncoding = Encoding.UTF8;

{
    Console.WriteLine("Введіть перше ціле число:"); 
    int number1 = int.Parse(Console.ReadLine());


    Console.WriteLine("Введіть математичну дію (+, -, *, /):");
    string operation = Console.ReadLine();


    Console.WriteLine("Введіть друге ціле число:"); 
    int number2 = int.Parse(Console.ReadLine()); 


    switch (operation) 
    { 
        case "+": 
            Console.WriteLine("Результат: " + (number1 + number2)); 
            break; 


        case "-": 
            Console.WriteLine("Результат: " + (number1 - number2)); 
            break; 


        case "*": 
            Console.WriteLine("Результат: " + (number1 * number2)); 
            break; 


        case "/": 

            if (number2 != 0) 
            { 
                Console.WriteLine("Результат: " + (number1 / (double)number2));  
            } 

            else 
            { 
                Console.WriteLine("Ділення на нуль неможливе."); 
            } 
            break; 


        default: 
            Console.WriteLine("Невірна математична дія."); 
            break; 
    } 
}