// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Amirali!");
 
Console.WriteLine("Enter number:");
var num1 = Console.ReadLine();


Console.WriteLine("Enter number:");
var num2 = Console.ReadLine();

var num3 = Int32.Parse(num1) + Int32.Parse(num2);
Console.WriteLine($"{num1} + {num2} = {num3}");
