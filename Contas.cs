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
        private double juros, capitalAplicado, descontoIr;
        public double Porcentagem { get; set; }
        public double ValorDepositado { get; set; }
        public int Meses { get; set; }
        public double IR { get; set; }





        public Contas(int meses, double porcentagem, double valorDepositados, double ir)
        {
            Porcentagem = porcentagem;
            ValorDepositado = valorDepositados;
            Meses = meses;
            IR = ir;
        }

        public void Calculo_periodo_completo()
        {
            capitalAplicado = ValorDepositado * (Meses + 1);
            Total = ValorDepositado * (Math.Pow(Porcentagem + 1, Meses + 1) - 1);
            Total = Total / Porcentagem;
            descontoIr = (Total - capitalAplicado) * IR; // calcula 1/4 de IR em cima dos ganhos
            Total -= descontoIr;
            juros = Total - capitalAplicado;
            Total -= ValorDepositado;
            Console.WriteLine("Valor total em " + Meses + " meses: "
                + Total.ToString("F2", CultureInfo.InvariantCulture) + ". Valores ganhos em juros: "
                + juros.ToString("F2", CultureInfo.InvariantCulture) + ", Desconto de IR: "
                + descontoIr.ToString("F2", CultureInfo.InvariantCulture));
        }

        public void Calculo_mensal()
        {
            
            Total = 0.0;
            for (int i = 1; i <= Meses; i++)
            {
                capitalAplicado = ValorDepositado * (i + 1);
                Total = ValorDepositado * (Math.Pow(Porcentagem + 1, i + 1) - 1);
                Total = Total / Porcentagem;
                descontoIr = (Total - capitalAplicado) * IR; // calcula 1/4 de IR em cima dos ganhos
                Total -= descontoIr;
                juros = Total - capitalAplicado;
                Total -= ValorDepositado;

                Console.WriteLine("Meses decorridos: " + i + ", Valor em conta "
                    + Total.ToString("F2", CultureInfo.InvariantCulture));
            }
            

            // Tem esse modo abaixo, que ficaria mais correto, pois calcula o lucro realmente mes a mes
            /*
            Total = 0.0;
            for (int i = 1; i <= Meses; i++)
            {
                Total += ValorDepositado;
                double totalAnterior = Total;
                Total = Total * (1 + Porcentagem); //Calcula a % de ganhos em cima do total dos meses anteriores
                double ganhos = Total - totalAnterior;
                descontoIr = ganhos * IR;
                Total -= descontoIr;
                ganhos = Total - totalAnterior;
                Console.WriteLine("Meses deccoridos: " + i + ", Valor em conta " + Total.ToString("F2", CultureInfo.InvariantCulture)
                    + ", ganhos no mes: " + ganhos.ToString("F2", CultureInfo.InvariantCulture) 
                    + ", Valor de IR do mes: " + descontoIr.ToString("F2", CultureInfo.InvariantCulture));
            }*/
        }






    }
}
