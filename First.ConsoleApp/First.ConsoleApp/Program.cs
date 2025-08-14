// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Amirali!");

//Console.WriteLine("Enter number:");
//var num1 = Console.ReadLine();


//Console.WriteLine("Enter number:");
//var num2 = Console.ReadLine();

//var num3 = Int32.Parse(num1) + Int32.Parse(num2);
//Console.WriteLine($"{num1} + {num2} = {num3}");

//--------------------------------------------------------

int jam = 0;
for (int i = 0; i < 5;i++)
{

    int num = 0;
    Console.WriteLine("enter number:");
    num = Int32.Parse( Console.ReadLine());

    if (num % 1 != 1)
    {
        jam = jam + num;
    }

}

Console.WriteLine(jam);
