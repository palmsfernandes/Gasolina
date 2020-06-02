using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasolina
{
    class Program
    {
        static void Main(string[] args)
        {
            string combustivel;
            double litros;
            
            Console.Write("Escolha seu combustivel Alcool ou Gasolina: Alcool-a ou Gasolina-g: ");
            combustivel = Console.ReadLine();

            Console.Write("Quantos litros?: ");
            litros = Convert.ToDouble(Console.ReadLine());

            double g = 4.50;
            double a = 2.90;
            double resultado;
            double desconto;

            if(combustivel == "g" && litros <= 20 )
            {
                resultado = g * litros;
                desconto = resultado - resultado * 0.04;
                Console.WriteLine("Você pagará R$:" + desconto);
                Console.WriteLine("Valor bruto R$:" + resultado);
                Console.WriteLine("Desconto atribuido R$:" + (resultado - desconto));
            }

            if (combustivel == "g" && litros > 20)
            {
                resultado = g * litros;
                desconto = resultado - resultado * 0.06;
                Console.WriteLine("Você pagará R$:" + desconto);
                Console.WriteLine("Valor bruto R$:" + resultado);
                Console.WriteLine("Desconto atribuido R$:" + (resultado - desconto));
            }

            if (combustivel == "a" && litros <= 20)
            {
                resultado = a * litros;
                desconto = resultado - resultado * 0.03;
                Console.WriteLine("Você pagará R$:" + desconto);
                Console.WriteLine("Valor bruto R$:" + resultado);
                Console.WriteLine("Desconto atribuido R$:" + (resultado - desconto));
            }

            if (combustivel == "a" && litros > 20)
            {
                resultado = a * litros;
                desconto = resultado - resultado * 0.05;
                Console.WriteLine("Você pagará R$:" + desconto);
                Console.WriteLine("Valor bruto R$:" + resultado);
                Console.WriteLine("Desconto atribuido R$:" + (resultado - desconto));
            }

            Console.ReadLine();
        }
    }
}
