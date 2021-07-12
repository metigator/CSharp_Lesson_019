using System;

namespace CAStructVsClass
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2021, 05, 01, 08, 30, 00);

            dt = dt.AddDays(10);

            Console.WriteLine(dt);

            Console.ReadKey();
        }

         
    } 
}
