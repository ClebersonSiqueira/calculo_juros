using System;
using System.Globalization;
using System.Net.Http.Headers;

namespace calculo_juros
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes = 1;
            double valor = 0.0;
            Console.WriteLine("Quantos meses calcular?");
            int mesUsuario = int.Parse(Console.ReadLine());
            Console.WriteLine("Porcentagem do ganho mensal?");
            double Porcento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Porcento = Porcento / 100;
            Console.WriteLine("Vai depositar quanto por mes?");
            double valorDepositado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while(mes <= mesUsuario)
            {
                valor = valor + (valor * Porcento);
                valor += valorDepositado;
                Console.WriteLine("Meses deccoridos: " + mes + ", Valor em conta " + valor.ToString("F2", CultureInfo.InvariantCulture));
                mes++;
            }
            double juros = valor - (valorDepositado * mesUsuario);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Valor total em " + mesUsuario + " meses: " + valor.ToString("F2", CultureInfo.InvariantCulture) + ". Valores ganhos em juros: " + juros);
        }
    }
}
