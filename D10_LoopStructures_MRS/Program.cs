using System;
using System.Collections.ObjectModel;
using D00_Utility;

namespace D10_LoopStructures
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            #region Variáveis
            string string01 = "";
            string string02 = "x";
            string name = string.Empty;     // Atribuir um valor vazio a uma string
            #endregion

            #region WHILE (enquanto a condição for verdadeira)
            // O teste é feito no início
            // Não garante que seja feito uma única vez

            Utility.WriteTitle("WHILE");

            while (string01 != "x")
            {
                Console.Clear();
                Utility.WriteTitle("While");
                Utility.WriteMessage("Para saíres escreve x: ");
                string01 = Console.ReadLine();
                // É preciso dar a oportunidade de ser falso para evitar um loop infinito
                // É preciso controlar o valor da variável para gerir o ciclo e evitar que seja infinito
            }

            Utility.WriteMessage("\n");

            #endregion

            #region DO...WHILE (repetir até)
            // O teste é feito no fim
            // Garante que é feito pelo menos 1 vez
            Utility.WriteTitle("DO...WHILE");

            do
            {
                Utility.WriteMessage("Para saíres escreve x: ");
                string02 = Console.ReadLine();
            } while (string02 != "x");
            // Exemplo: Garantir que um PIN é introduzido pelo menos uma vez

            Utility.WriteMessage("\n");

            #endregion

            #region FOR (para)
            // Repetir x número de vezes
            Utility.WriteTitle("FOR");

            // asc
            for (int i = 0; i < 3; i++)    // i++    i = i + 1
            {
                Utility.WriteMessage($"i = {i}\n");
            }

            Utility.WriteMessage("\n");

            // desc
            for (int i = 2; i >= 0; i--)    // i--  i = i - 1
            {
                Utility.WriteMessage($"i = {i}\n");
            }

            Utility.WriteMessage("\n");

            #endregion

            #region FOREACH (para cada elemento: usado com arrays e collections)
            // Percorrer todos os elementos dum array ou duma collection
            // Para percorrer arrays de forma rápida
            // Tem de percorrer todos os elementos do array e aplica-se a cada elemento

            Utility.WriteTitle("FOREACH");

            // Declaração e atribuição
            // Trabalhar em linha
            int[] numbers = { 3, 10, 1, 20, 0, 4 };     // LINQ
            
            // Declaração
            int[] values = new int[3];
            // Atribuição
            values[0] = 10;
            values[1] = 100;
            values[2] = 1000;

            // Trabalhar em bloco
            string[] words =
            {
                "a",
                "b",
                "c"
            };
            
            foreach (int item in numbers)
            {
                Utility.WriteMessage(item.ToString(), "", "\n");
            }

            // Strongly typed (variável fortemente tipada)

            //foreach (var item in collection)
            //{

            //}
            // collection pode ser um vetor ou uma matriz

            Utility.WriteMessage("\n");

            foreach (string item in words)       // item pode ter um nome qualquer
            {
                Utility.WriteMessage(item, "", "\n");
            }
            #endregion

            Utility.TerminateConsole();

        }

    }

}
