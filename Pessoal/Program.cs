using System;
using System.Globalization;
namespace Pessoal {
    class Program {
        static void Main(string[] args) {

            Console.Write("Peso: ");
            double p = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double cal = (0.063 * p + 3.653) * 239;
            Console.WriteLine("Resoltado: " + cal.ToString("F2"), CultureInfo.InvariantCulture); ;
        }
    }
}
