using System;

namespace Negozio_es13
{
    class Program
    {
        static void Main(string[] args)
        {
            double sconto = 0;
            double costominore = 0;
            double prezzototale = 0;
            Console.Write("Quanto costa il primo prodotto? ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Quanto costa il secondo prodotto? ");
            double b = double.Parse(Console.ReadLine());
            if(a > b)
            {
                sconto = (b/100)*50;
                costominore = b - sconto;
                prezzototale = a + costominore;
                Console.WriteLine($"Importo scontato da pagare : {prezzototale}");
            }
            else
            {
                sconto = (a / 100) * 50;
                costominore = a - sconto;
                prezzototale = b + costominore;
                Console.WriteLine($"Importo scontato da pagare : {prezzototale}");
            }
            Console.ReadLine();
        }
    }
}
