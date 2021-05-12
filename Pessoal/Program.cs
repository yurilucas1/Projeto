using System;

namespace Pessoal {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            Console.WriteLine("teste");
            double numero = 0.0;
            for(int i = 0; i < 10; i++) {
                numero += 1.25;
                Console.WriteLine(numero);
            }
        }
    }
}
