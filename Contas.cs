using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace calculo_juros
{
    class Contas
    {
        private double Total { get; set; }
        private int i = 1;
        private double juros;
        public double Porcentagem { get; set; }
        public double ValorDepositado { get; set; }
        public int Meses { get; set; }
        




        public Contas(int meses, double porcentagem, double valorDepositados)
        {
            Porcentagem = porcentagem;
            ValorDepositado = valorDepositados;
            Meses = meses;
        }

        private void Calculo()
        {

            for (i = 1; i <= Meses; i++)
            {
                Total = Total + (Total * Porcentagem);
                Total += ValorDepositado;
                Console.WriteLine("Meses deccoridos: " + i + ", Valor em conta " + Total.ToString("F2", CultureInfo.InvariantCulture));
            }
        }

        private void rendimentos()
        {
            juros = Total - (ValorDepositado * Meses);
        }

        public override string ToString()
        {
            Calculo();
            rendimentos();
            return "Valor total em " + Meses + " meses: " + Total.ToString("F2", CultureInfo.InvariantCulture) + ". Valores ganhos em juros: " + juros.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
