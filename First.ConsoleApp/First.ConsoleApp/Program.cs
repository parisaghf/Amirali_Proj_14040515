// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Amirali!");




Console.WriteLine("*******************");

fibonachi2(2);
//fibonachi-----------------------------------------
void fibonachi2(int k)
{ 
int a, b, c;
a = 0;
b = 1;
c = 0;

    {
        Console.WriteLine(b);//  a و b مقدار های اولیه دنباله
        for (int i = 1; i <= k; i++)
        {
            c = a + b;
            a = b;
            b = c;
            Console.WriteLine(c);
        };


    }


    }

Console.WriteLine("*******************");

fibonachi2(5);