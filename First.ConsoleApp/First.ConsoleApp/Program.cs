// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Amirali!");




Console.WriteLine("*******************");

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
fibonachi2(2);
//fibonachi-----------------------------------------
void fibonachi2(int k)
{ 
int a, b, c;
a = 0;
b = 1;
c = 0;

int zarb = 1;
int j = 0;
while (j<5)
{
    int num = 0;
    Console.WriteLine("enter number:");
    num =int.Parse( Console.ReadLine());
    {
        Console.WriteLine(b);//  a و b مقدار های اولیه دنباله
        for (int i = 1; i <= k; i++)
        {
            c = a + b;
            a = b;
            b = c;
            Console.WriteLine(c);
        };


    if (num % 2 != 0)
    {
        zarb = zarb * num;
    }
    j++;
}
Console.WriteLine($"zarb adade fard mishvad: {zarb}");

    
//-------------------------------------------------------

    }

Console.WriteLine("*******************");

fibonachi2(5);