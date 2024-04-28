using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E05_Calculadora_v01_SemClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Variáveis
            string[] menu =     // vetor
            {
                "+  Soma",
                "-  Subtração",
                "*  Multiplicação",
                "/  Divisão"
            };
            string operacao, saida;
            double valor01, valor02, resultado;
            #endregion
            #region Listar as operações
            Utility.WriteTitle("Calculadora sem classes (v01)");
            foreach (string item in menu)
            {
                Utility.WriteMessage(item, "", "\n");
            }
            #endregion
            #region Pedir valores e operação
            Utility.WriteMessage("Valor 1: ", "\n\n");
            valor01 = Convert.ToDouble(Console.ReadLine());     // melhorar com TryParse()
            Utility.WriteMessage("Valor 2: ");
            valor02 = Convert.ToDouble(Console.ReadLine());
            Utility.WriteMessage("Operação: ", "\n");
            operacao = Console.ReadLine();
            #endregion
            #region Realizar o cálculo
            switch (operacao)
            {
                case "+":
                    resultado = valor01 + valor02;
                    break;
                case "-":
                    resultado = valor01 - valor02;
                    break;
                case "*":
                    resultado = valor01 * valor02;
                    break;
                case "/":
                    resultado = valor01 / valor02;
                    break;
                default:
                    resultado = 0;
                    break;
            }
            #endregion
            #region Mostrar o resultado
            saida = $"Resultado: {valor01} {operacao} {valor02} = {resultado}";
            Utility.WriteMessage(saida, "\n\n");
            Utility.TerminateConsole();
            #endregion
        }
    }
}
