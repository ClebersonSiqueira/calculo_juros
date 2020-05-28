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
            Porcento = Porcento / 100; // transforma % em decimal
            Console.WriteLine("Vai depositar quanto por mes?");
            double valorDepositado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Qual a porcentagem do IR?");
            double ir = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ir = ir / 100; // transforma IR em decimal

            Contas c = new Contas(mesUsuario, Porcento, valorDepositado, ir);

            c.Calculo_periodo_completo();

            Console.WriteLine("Gostaria de mostrar o relatorio mes a mes? S/N");
            string resposta = Console.ReadLine();
            if (resposta == "s" || resposta == "S")
                c.Calculo_mensal();
        }
    }
}
