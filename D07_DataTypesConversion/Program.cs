using System;
using D00_Utility;

namespace D07_DataTypesConversion
{

    internal class Program
    {

        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            #region Variáveis
            string string01 = "1";
            string string02 = "2";
            string string03 = "C#";
            int int01 = 10;
            int int02 = 20;
            long long01 = 2000000;
            float float01 = 3.8F;
            double double01 = 10.5;
            bool logical = true;
            #endregion

            #region Sem conversão
            Utility.WriteMessage(string01 + int01);    // 110 concatenar
            Utility.WriteMessage(int01 + string01);   // 101 concatenar 
            Utility.WriteMessage("\n");
            #endregion

            #region Conversão implicita: combinar tipos de dados da mesma natureza
            Console.WriteLine(int02 + long01);
            Console.WriteLine(float01 + double01);
            Console.WriteLine();
            #endregion

            #region Conversão explicita
            
            #region Método ToString(): data type extension method --> converter para string
            Console.WriteLine(string01 + int02.ToString());    // "1" + 20 --> "1" + "20" = "120"
            Console.WriteLine(string01 + long01.ToString());
            Console.WriteLine(string01 + float01.ToString());
            Console.WriteLine(string01 + double01.ToString());
            Console.WriteLine(string01 + logical.ToString());
            Console.WriteLine();
            #endregion

            #region Classe Convert: converter diferentes tipos de dados
            Console.WriteLine(Convert.ToInt16(string01) + int01);    // "1" + 10 --> 1 + 10 = 11
            Console.WriteLine();
            #endregion

            #region Método number.Parse(): converter string em número
            Console.WriteLine(int01 + int.Parse(string01));
            //Console.WriteLine(int01 + int.Parse(string03));     // 10 + "C#" --> Erro!
            // Durante a execução! RunTime Error!
            Console.WriteLine(long01 + long.Parse(string01));
            Console.WriteLine(float01 + float.Parse(string02));
            Console.WriteLine(double01 + double.Parse(string02));
            Console.WriteLine();
            #endregion

            #region Método number.TryParse(): converter string em número com tratamento de erro
            int resultNumber1;
            int resultNumber2;
            bool resultSucess1;
            bool resultSucess2;

            resultSucess1 = int.TryParse(string01, out resultNumber1);  // "1"  --> 1
            resultSucess2 = int.TryParse(string03, out resultNumber2);  // "C#" --> erro
            // Se conseguir converter fica True guardado na variável Booleana
            // Number.TryParse() precisa sempre de duas variáveis
            // Uma com o tipo de dados (string) e outro com um bool
            // Para usar como controlo de condicionais

            Console.WriteLine($"1. Out: {resultNumber1} + Result: {resultSucess1}");   // True
            Console.WriteLine($"2. Out: {resultNumber2} + Result: {resultSucess2}");   // False
            Console.WriteLine();
            #endregion

            #region Operator Cast: converter números em outros números
            Console.WriteLine((long)int01 + long01);
            Console.WriteLine((int)long01 + int01);
            Console.WriteLine((float)double01 + float01);
            Console.WriteLine((double)float01 + double01);
            #endregion

            #endregion

            Utility.TerminateConsole();

        }

    }

}
