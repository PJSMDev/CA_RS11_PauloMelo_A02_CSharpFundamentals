using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E06_Calculadora_v04
{
    internal class Calculator
    {
        
        // Todo MRS: Devias trabalhar com Regions
        
        internal double Value01 { get; set; }
        internal double Value02 { get; set; }
        internal double Result { get; set; }
        internal string Operator { get; set; }

        internal void ReadOperation()
        {
            Utility.WriteMessage("Operação matemática: ");
            Operator = (Console.ReadLine());
        }

        internal void ReadValues()
        {
            Utility.WriteMessage("Valor 1: ");
            Value01 = Convert.ToDouble(Console.ReadLine());

            Utility.WriteMessage("Valor 2: ");
            Value02 = Convert.ToDouble(Console.ReadLine());
        }

        internal void Addition()
        {
            Result = Value01 + Value02;
        }

        internal void Subtraction()
        {
            Result = Value01 - Value02;
        }

        internal void Multiplication()
        {
            Result = Value01 * Value02;
        }

        internal void Division()
        {
            // Todo MRS: Isto não podia ser resolvido com um simples IF?
            switch (Value02) 
            {
                case 0:
                    DisplayErrorDivisionByZero();
                    break;
                default:
                    Result = Value01 / Value02;
                    break;
            }
        }

        // ---------------------------------------
        // Todo MRS: Os 3 métodos seguintes não são específicos desta classe, pois não? Ou passam para a Utility ou para a CalculatorUtility.
        internal void DisplayErrorDivisionByZero()
        {
            Utility.WriteMessage("Divisão por 0. Impossível.", "", "\n");
        }

        internal void DisplayGenericError()
        {
            Utility.WriteMessage("Erro.", "", "\n");
        }

        internal void NumericFormatError()
        {
            Utility.WriteMessage("Erro. Insira valores numéricos.", "", "\n\n");
        }
        // ---------------------------------------

        
        internal void Calculation()
        {
            switch (Operator)
            {
                case "+":
                    Addition();
                    break;
                case "-":
                    Subtraction();
                    break;
                case "*":
                    Multiplication();
                    break;
                case "/":
                    Division();
                    break;
                default:
                    DisplayGenericError();
                    break;
            }
        }

        internal void PrintResult()
        {
            Utility.WriteMessage($"{Value01} {Operator} {Value02} = {Result}");
        }
    }
}
