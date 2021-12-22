using System;
using System.Globalization;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            decimal valor = 10536.25m;
            Console.WriteLine(valor.ToString(
                "C",
                CultureInfo.CreateSpecificCulture("en-US")
                ));
            Console.WriteLine(valor.ToString(
                "C",
                CultureInfo.CreateSpecificCulture("pt-BR")));
            Console.WriteLine(valor.ToString(
                "N",
                CultureInfo.CreateSpecificCulture("pt-BR")));
            Console.WriteLine(valor.ToString(
                "P",
                CultureInfo.CreateSpecificCulture("pt-BR")));
            Console.WriteLine(valor.ToString(
                "F",
                CultureInfo.CreateSpecificCulture("pt-BR")));
            Console.WriteLine(valor.ToString(
                "G",
                CultureInfo.CreateSpecificCulture("pt-BR")));
        }
    }
}
