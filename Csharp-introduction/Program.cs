using System.Security.Cryptography.X509Certificates;
using System;
using System.Globalization;

internal class Program
{
    private static void Main()
    {
        int number;
        while (true)
        {
            number = int.Parse(Console.ReadLine());
            if (number >= 1 && number < 100) break;
            Console.WriteLine($"Number {number} is outside of range from 1 to 100");
        }
        if(number % 3 == 0 && number % 5 == 0)
        {
            Console.WriteLine("Fizz Buzz");
        }
        else if(number % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else if(number % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else
        {
            Console.WriteLine($"Number : {number}");
        }
        Console.WriteLine("#################################################");

        decimal value;
        int rate;
        while (true)
        {
            Console.Write("Enter rate : ");
            rate = int.Parse(Console.ReadLine());
            if (rate >= 1 && rate < 100) break;
            Console.WriteLine($"Rate {rate} is outside of range from 1 to 100");
        }
        Console.Write("Enter value : ");
        value = decimal.Parse(Console.ReadLine()) * rate / 100;
        Console.WriteLine($"Value = {value}");
        Console.WriteLine("#################################################");

        int a, b, c, d;
        while (true)
        {
            Console.Write("Enter a : ");
            a = int.Parse(Console.ReadLine());
            if (a >= 1 && a < 10) break;
            Console.WriteLine($"a {a} is outside of range from 1 to 10");
        }
        while (true)
        {
            Console.Write("Enter b : ");
            b = int.Parse(Console.ReadLine());
            if (b >= 1 && b < 10) break;
            Console.WriteLine($"b {b} is outside of range from 1 to 10");
        }
        while (true)
        {
            Console.Write("Enter c : ");
            c = int.Parse(Console.ReadLine());
            if (c >= 1 && c < 10) break;
            Console.WriteLine($"c {c} is outside of range from 1 to 10");
        }
        while (true)
        {
            Console.Write("Enter d : ");
            d = int.Parse(Console.ReadLine());
            if (d >= 1 && d < 10) break;
            Console.WriteLine($"d {d} is outside of range from 1 to 10");
        }
        int num = a * 1000 + b * 100 + c * 10 + d;
        Console.WriteLine($"Number = {num}");
        Console.WriteLine("#################################################");

        while (true)
        {
            Console.Write("Enter number : ");
            number = int.Parse(Console.ReadLine());
            if (number >= 100000 && number < 1000000) break;
            Console.WriteLine($"number {number} is outside of range from 10*5 to 10^6");
        }
        Console.Write($"Select two numbers from the {number} that you want swap places : ");
        string str = $"{number}";
        a = int.Parse((string) Console.ReadLine());
        b = int.Parse((string)Console.ReadLine());
        string substr = str.Substring(a, 1);
        string substr2 = str.Substring(b, 1);
        str = str.Remove(a, 1);
        str = str.Insert(a, substr2);
        str = str.Remove(b, 1);
        str = str.Insert(b, substr);
        number = int.Parse(str);
        Console.WriteLine($"Numnber : {number}");
        Console.WriteLine("#################################################");
        
        CultureInfo en = new CultureInfo("en-US");
        Console.Write("Enter date(dd.mm.yyyy) : ");
        DateTime date;
        date = DateTime.Parse(Console.ReadLine());
        Console.WriteLine($"Date : {date.ToString("MMMM", en)} {date.ToString("dddd", en)}");
        Console.WriteLine("#################################################");

        int temperature;
        short t;
        Console.Write("Enter temprature type fahrenheit -  [0], celsius - [1] : ");
        t = short.Parse(Console.ReadLine());
        while (true)
        {
            if (t == 0)
            {
                Console.Write("Enter temperature in fahrenheit : ");
                temperature = int.Parse(Console.ReadLine());
                if (temperature >= 0) break;
            }
            else
            {
                Console.Write("Enter temperature in celsius : ");
                temperature = int.Parse(Console.ReadLine());
                if (temperature >= -273) break;
            }
        }
        switch (t)
        {
            case 0:
                Console.WriteLine($"{temperature} fahrenheit is {temperature - 273} celsius");
                break;
            case 1:
                Console.WriteLine($"{temperature} celsius is {temperature + 273} fahrenheit");
                break;
        }
        Console.WriteLine("#################################################");

        Console.Write("Enter a : ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Enter b : ");
        b = int.Parse(Console.ReadLine());
        if (a > b) (a, b) = (b, a);
        for(; a < b; a++)
        {
            if(a % 2 == 0)
            {
                Console.Write($"{a}  ");
            }
        }

    }
}