using System.Text;
Console.OutputEncoding = Encoding.UTF8;

int n1 = 1;
string client1 = "Alice";
string product1 = "smartphone";
float price1 = 305.99f;
string address1 = "Moon Street";
int a1 = 10;

Console.WriteLine($"Order No {n1}");
Console.WriteLine($"Client: {client1}.");
Console.WriteLine($"Product: {product1}, price {price1} EUR.");
Console.WriteLine($"Address: {address1}, {a1}.\n");

int n2 = 2;
string client2 = "Tom";
string product2 = "laptop";
float price2 = 570.95f;
string address2 = "Terra Street";
int a2 = 17;

Console.WriteLine($"Order No {n2}");
Console.WriteLine($"Client: {client2}.");
Console.WriteLine($"Product: {product2}, price {price2} EUR.");
Console.WriteLine($"Address: {address2}, {a2}.\n");

int n3 = 3;
string client3 = "Jack";
string product3 = "keyboard";
float price3 = 5.50f;
//double price3 = Convert.ToDouble(Console.ReadLine());
string address3 = "Green Walley";
//string address3 = Console.ReadLine();
int a3 = 32;

Console.WriteLine($"Order No {n3}");
Console.WriteLine($"Client: {client3}.");
Console.WriteLine($"Product: {product3}, price {price3} EUR.");
Console.WriteLine($"Address: {address3}, {a3}.");