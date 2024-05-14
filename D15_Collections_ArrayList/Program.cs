using System;
using System.Collections;       // dá acesso à ArryList
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D15_Collections_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            #region ArrayList: multi tipos + inteiros

            // 1. Instanciar
            ArrayList listMulti = new ArrayList();
            ArrayList listIntegers = new ArrayList();

            // 2. Adicionar valores de tipos diferentes (um a um -> sem ciclo)
            listMulti.Add(10);
            listMulti.Add("a");
            listMulti.Add(false);
            listMulti.Add(DateTime.Today);

            // 3. Adicionar 5 valores do tipo inteiro autimaticamente
            for (int i = 0; i < 5; i++)
            {
                listIntegers.Add(i);
            }

            //listIntegers.Add("Vou dar cabo desta lista!");      // Mostrar a fraqueza dos ArrayList      
            // o nome é intenção -> dá para lhe meter texto
            // ArrayList é loosely typed -> PROBLEMA
            listIntegers.Add(-30);
            listIntegers.Add(19);

            // 4. Quantos elementos na lista?
            Utility.WriteTitle("ArrayList contagem");
            Utility.WriteMessage($"Nº de elementos - listMulti: {listMulti.Count}", "\n\n", "\n\n");
            Utility.WriteMessage($"Nº de elementos - listMulti: {listIntegers.Count}", "\n\n", "\n\n");

            // 5. Listar
            Utility.WriteTitle("ArrayList - listMulti");
            PersonUtility.ListData(listMulti);
            Utility.WriteMessage("\n");

            Utility.WriteTitle("ArrayList - listIntegers");
            PersonUtility.ListData(listIntegers);
            Utility.WriteMessage("\n");

            // 6. Listar, ordenando
            Utility.WriteTitle("ArrayList - listIntegers ordenada");
            listIntegers.Sort();
            PersonUtility.ListData(listIntegers);
            Utility.WriteMessage("\n");
           
            #endregion

            #region Person
            // 1. Criar 2 pessoas
            ArrayList listPerson = new ArrayList();

            Person person01 = new Person("Paulo", "Braga");
            Person person02 = new Person("José", "Carcavelos");

            listPerson.Add(person01);
            listPerson.Add(person02);


            //2. Listar
            Utility.WriteTitle("ArrayList - Person");

            /*
             * person01.ListPerson(ListPerson);     // errado
             * person02.ListPerson(ListPerson);     // errado
            */

            //PersonUtility.ListData(listPerson);       // errado

            Person.ListPerson(listPerson);

            #endregion

            Utility.TerminateConsole();
        }
    }
}
