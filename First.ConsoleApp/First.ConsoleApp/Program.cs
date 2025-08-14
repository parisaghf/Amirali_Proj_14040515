// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Amirali!");

//Console.WriteLine("Enter number:");
//var num1 = Console.ReadLine();


//Console.WriteLine("Enter number:");
//var num2 = Console.ReadLine();

//var num3 = Int32.Parse(num1) + Int32.Parse(num2);
//Console.WriteLine($"{num1} + {num2} = {num3}");

//-1---fjam kon tamam adade zoj ra------------------

//Console.WriteLine("***salam mikhahim adade zoj ra jam konim.");
//int jam = 0;
//for (int i = 0; i < 5;i++)
//{

//    int num = 0;
//   Console.WriteLine("enter number:");
//    num = Int32.Parse( Console.ReadLine());

//    if (num % 2 == 0)
//    {
//        jam = jam + num;
//    }

//}
//Console.WriteLine($"jam  mishavad: {jam}");

//-2---zarb kon tamam adade fard ra-----------------------


Console.WriteLine("***hala mikhahim adade fard ra zarb konim.");

int zarb = 1;
int j = 0;
while (j<5)
{
    int num = 0;
    Console.WriteLine("enter number:");
    num =int.Parse( Console.ReadLine());

    if (num % 2 != 0)
    {
        zarb = zarb * num;
    }
    j++;
}
Console.WriteLine($"zarb adade fard mishvad: {zarb}");

    
