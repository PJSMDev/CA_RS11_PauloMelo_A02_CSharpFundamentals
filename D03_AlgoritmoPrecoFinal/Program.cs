/*
 * Calcular o preço final de um produto, mediante o preço inicial e a taxa de desconto. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D03_AlgoritmoPrecoFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            Utility.WriteTitle("Algoritmo do Preço Final");

            string productName;
            double initialPrice, finalPrice, discountRate;

            Utility.WriteMessage("Nome do produto: ");
            productName = Console.ReadLine();

            Utility.WriteMessage("Valor inicial: ");
            initialPrice = Convert.ToDouble(Console.ReadLine());

            Utility.WriteMessage("Taxa de desconto: ");
            discountRate = Convert.ToDouble(Console.ReadLine()) / 100;

            finalPrice = initialPrice - initialPrice * discountRate;

            Utility.WriteMessage($"Valor final do produto {productName}: {finalPrice}");

            Utility.TerminateConsole();
        }
    }
}
