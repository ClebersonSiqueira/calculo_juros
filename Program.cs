using System;
using System.Globalization;
using System.Net.Http.Headers;

namespace calculo_juros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos meses calcular?");
            int mesUsuario = int.Parse(Console.ReadLine());
            Console.WriteLine("Porcentagem do ganho mensal?");
            double Porcento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Porcento = Porcento / 100;
            Console.WriteLine("Vai depositar quanto por mes?");
            double valorDepositado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Contas c = new Contas(mesUsuario, Porcento, valorDepositado);

            Console.WriteLine(c);
        }
    }
}
