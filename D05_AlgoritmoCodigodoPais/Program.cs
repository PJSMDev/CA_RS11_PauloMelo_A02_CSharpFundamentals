using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D05_AlgoritmoCodigodoPais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            Utility.WriteTitle("Algoritmo do Código do País");

            string personName, countryCode;

            Utility.WriteMessage("Nome da pessoa: ");
            personName = Console.ReadLine();

            Utility.WriteMessage("Código do país: ");
            countryCode = Console.ReadLine();

            #region v1: If

            //if (countryCode == "PT" || countryCode == "pt")
            //{
            //    Utility.WriteMessage($"Olá {personName}, tu é de Portual", "", "\n");
            //}
            //else if (countryCode == "SP" || countryCode == "sp")
            //{
            //    Utility.WriteMessage($"Olá {personName}, tu é de Espanha", "", "\n");
            //}
            //else if (countryCode == "BR" || countryCode == "br")
            //{
            //    Utility.WriteMessage($"Olá {personName}, tu é do Brasil", "", "\n");
            //}
            //else if (countryCode == "FR" || countryCode == "fr")
            //{
            //    Utility.WriteMessage($"Olá {personName}, tu é da França", "", "\n");
            //}
            //else if (countryCode == "TU" || countryCode == "tu")
            //{
            //    Utility.WriteMessage($"Olá {personName}, tu é da Tunísia", "", "\n");
            //}
            //else
            //{
            //    Console.WriteLine($"Desculpa {personName} mas o teu país não está listado");
            //}

            #endregion

            #region Switch

            switch (countryCode)
            {
                case "PT":
                case "pt":
                    Utility.WriteMessage($"Olá {personName}, tu é de Portual", "", "\n");
                    break;
                case "SP":
                case "sp":
                    Utility.WriteMessage($"Olá {personName}, tu é da Espanha", "", "\n");
                    break;
                case "BR":
                case "br":
                    Utility.WriteMessage($"Olá {personName}, tu é do Brasil", "", "\n");
                    break;
                case "FR":
                case "fr":
                    Utility.WriteMessage($"Olá {personName}, tu é da França", "", "\n");
                    break;
                case "TU":
                case "tu":
                    Utility.WriteMessage($"Olá {personName}, tu é da Tunísia", "", "\n");
                    break;
                default:
                    Console.WriteLine($"Desculpa {personName} mas o teu país não está listado");
                    break;
            }

            #endregion

            Utility.TerminateConsole();
        }
    }
}
