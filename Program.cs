using System;
using System.Text.RegularExpressions;
using System.Threading;
using System.Globalization;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        f();
        Console.ReadLine();
    }

    static void f()
    {
        double d = 345.78;

        Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("bg-BG");
        Console.WriteLine(Thread.CurrentThread.CurrentCulture);
        Console.WriteLine(CultureInfo.CurrentCulture);

        CultureInfo ct = new CultureInfo("en-US");

        Console.WriteLine(d.ToString("C"));
        Console.WriteLine(d.ToString("C", ct));
        Console.WriteLine(d.ToString("p"));
        Console.WriteLine(d.ToString("p", ct));


        DateTime today = DateTime.Now;
        DateTime tomorrow = today.AddDays(1);
        Console.WriteLine(today.ToString("d"));
        Console.WriteLine(today.ToString("d", ct));
        Console.WriteLine(tomorrow.ToString("D"));
        Console.WriteLine(tomorrow.ToString("D", ct));
        Console.WriteLine(today.ToString("f"));
        Console.WriteLine(today.ToString("f", ct));
        Console.WriteLine(today.ToString("F"));
        Console.WriteLine(today.ToString("F", ct));

        Console.WriteLine(today.ToString("hh"));     
        Console.WriteLine(today.ToString("hh", ct));
        Console.WriteLine(today.ToString("hh:mm"));    
        Console.WriteLine(today.ToString("hh:mm", ct));
        Console.ReadLine();
    }
}