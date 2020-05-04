using System;
using okml_lib;

namespace okml_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var class1 = new Class1();
            class1.CreateSamplePdf();
        }
    }
}
