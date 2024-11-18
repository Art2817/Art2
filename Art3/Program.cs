using System.Text;
Console.OutputEncoding = Encoding.UTF8;


{
    Console.WriteLine("Введіть номер дня тижня (1-7):"); 
    string input = Console.ReadLine(); 


        if (input != null && input.All(char.IsDigit))

        { 
        int day_number = int.Parse(input); 
        switch (day_number) 
        { 
            case 1: 
                Console.WriteLine("Це понеділок."); 
                break; 

            case 2: 
                Console.WriteLine("Це вівторок."); 
                break; 
            
            case 3: 
                Console.WriteLine("Це середа."); 
                break; 

            case 4:
                Console.WriteLine("Це четвер."); 
                break; 
            
            case 5: 
                Console.WriteLine("Це п'ятниця."); 
                break; 

            case 6: 
                Console.WriteLine("Це субота."); 
                break; 
            
            case 7:
                Console.WriteLine("Це неділя."); 
                break; 
            
            default: 
                Console.WriteLine("Невірний номер дня.");
                break; 
        } 
        }

        else 
        { 
            Console.WriteLine("Невірний номер дня."); 
        } 
} 