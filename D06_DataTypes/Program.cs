using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;


namespace D06_DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            #region 1. Declarar variáveis e criar objetos
            byte age;     // 0 - 255
            float hight;
            double weight;

            bool isAssigned;      // true (1), false (0)

            DateTime date;
            DateTime hour;
            DateTime now;
            DateTime currentDate;
            DateTime emptyDate;

            string completeName;        // objeto!!!
            // não devemos usar String (são coisas diferentes)
            // não concatenar strings com +
            #endregion

            #region 2. Atribuir valores
            // números
            age = 10;
            hight = 20.5F;     // é preciso distinguir os Float
            weight = 10.5;        // é mais prático usar double

            // booleano
            isAssigned = true;

            // datas
            date = new DateTime(2024, 4, 1);
            hour = new DateTime(2024, 4, 1, 19, 5, 0);       // o valor puro "hora" não existe, faz sempre parte da data
            now = DateTime.Now;       // timestamp: data + hora
            currentDate = DateTime.Today;     // data
            emptyDate = DateTime.MinValue;      // menor valor possível -> 1/1/001 12:00:00 AM

            // string
            completeName = "m";
            #endregion

            #region 3. Declarar e atribuir
            string horario = "19:00 - 22:30";

            #endregion

            #region 4. Vetor (array single dimensional)

            Utility.WriteTitle("Vetor");

            // 4 nomes
            // string é objeto
            string[] names = new string[4];     // 4 linhas, começando em 0
            int[] numbers = new int[4];     // no caso dos Ints não preciso new int[]
            //int[] numbers;

            names[0] = "Ana";
            names[1] = "Milena";
            names[2] = "Amélia";
            Utility.WriteMessage("Apelido: ");
            names[3] = Console.ReadLine();

            Utility.WriteMessage("Vetor", "\n", "\n\n");

            Utility.WriteMessage(names[0]);
            Utility.WriteMessage(names[1]);
            Utility.WriteMessage(names[2]);
            Utility.WriteMessage(names[3], "", "\n");

            Utility.WriteMessage($"{names[0]} {names[1]} {names[2]} {names[3]}", "", "\n");

            // Atribuir os valores ao vetor
            for (int i = 0; i < 4; i++)     // tamanho não dinâmico
            {
                numbers[i] = i;
            }

            // Escrever na consola
            for (int i = 0; i < numbers.Length; i++)        // tamanho dinâmico
            {
                Utility.WriteMessage($"Valor {i}: {numbers[i]}", "\n");
            }

            Utility.WriteMessage("\n\n\n");

            #endregion

            #region 5. Matrizes (array multi dimensional)

            Utility.WriteTitle("Matrizes");

            string[,] classGroup = new string[4,2];

            classGroup[0, 0] = "Ana";
            classGroup[0, 1] = "Porto";
            classGroup[1, 0] = "Milena";
            classGroup[1, 1] = "Espinho";
            classGroup[2, 0] = "Amélia";
            classGroup[2, 1] = "Braga";
            classGroup[3, 0] = "João";
            classGroup[3, 1] = "Lisboa";

            //turma[3, 0] = Console.ReadLine();        // não posso usar o Read() porque ele lê Ints
            //turma[3, 0] = Console.Read().ToString();      // é preciso converter
            //turma[3, 0] = Convert.ToString(Console.Read());
            //turma[3, 1] = Console.ReadLine();

            for (int i = 0; i < classGroup.GetLength(0); i++)
            {
                for (int j = 0; j < classGroup.GetLength(1); j++)
                {
                    Utility.WriteMessage($"Posição [{i},{j}] = {classGroup[i,j]}", "", "\n");
                }
            }

            Utility.WriteMessage("\n\n");

            #endregion

            #region 6. Trabalhar com a consola
            Utility.WriteTitle("Variáveis numéricas");

            // as strings são imutáveis (é um endereço de memória na heap)
            completeName = completeName + " rs";        // concatenação: m + rs = m rs
            // vai passar a haver duas strings na heap
            // NUNCA USAR O + PARA CONCATENAR STRINGS!!!
            Utility.WriteMessage($"Nome completo: {completeName}", "", "\n");

            Utility.WriteMessage($"Byte - idade: {age}");
            //Console.WriteLine("Byte - idade: " + idade);        // Não concatenar com o +
            // USAR SEMPRE STRING INTERPOLATION
            // string interpolation -> concatenação de forma segura
            // A variável pode ser convertida
            Utility.WriteMessage($"Float - altura: {hight}", "\n");
            Utility.WriteMessage($"Double - peso: {weight}", "\n", "\n\n\n");

            Utility.WriteTitle("Variável booleana");
            //Console.WriteLine($"\nBoolean: {inscrito}\n\n\n");       // Método de conversão dentro das {}

            Utility.WriteMessage($"Boolean: {isAssigned}", "", "\n\n\n");
            // Se não quiser Enters no início
            //Utility.WriteMessage($"Boolean: {isAssigned}", "\n\n\n");


            Utility.WriteTitle("Variável string");
            // Deve-se concatenar strings com a class StringBuilder e o método Add
            //completeName = completeName + " rs";
            //Console.WriteLine($"\nString - nome completo: {completeName} \n\n\n");
            Utility.WriteMessage($"String - nome completo: {completeName}");
            //Console.WriteLine($"\nString - horário: {horario} \n\n\n");
            Utility.WriteMessage($"String - horário: {horario}", "\n" ,"\n\n\n");

            Utility.WriteTitle("Variáveis data e hora");
            //Console.WriteLine($"\nDate - data: {date}");
            Utility.WriteMessage($"Date - data: {date}");
            //Console.WriteLine($"\nLong date - data: {date.ToLongDateString()}");
            Utility.WriteMessage($"Long date - data: {date.ToLongDateString()}", "\n");
            //Console.WriteLine($"\nShort date - data: {data.ToShortDateString()}");
            Utility.WriteMessage($"Short date - data: {date.ToShortDateString()}", "\n");

            //Console.WriteLine($"Time - horas: {hour}");
            Utility.WriteMessage($"Time - horas: {hour}", "\n");
            //Console.WriteLine($"Long time - horas: {hour.ToLongTimeString()}");
            Utility.WriteMessage($"Long time - horas: {hour.ToLongTimeString()}", "\n");
            //Console.WriteLine($"Short time - horas: {hour.ToShortTimeString()}");
            Utility.WriteMessage($"Short time - horas: {hour.ToShortTimeString()}", "\n");

            //Console.WriteLine($"Date - agora: {now}");
            Utility.WriteMessage($"Date - agora: {now}", "\n");
            //Console.WriteLine($"Date - data atual: {currentDate}");
            Utility.WriteMessage($"Date - data atual: {currentDate}", "\n");
            //Console.WriteLine($"Date - data vazia: {emptyDate}");
            Utility.WriteMessage($"Date - data vazia: {emptyDate}", "\n");
            // Aparece sempre datetime
            // É preciso formatar

            //Console.WriteLine($"Year - agora: {now.Year}");
            Utility.WriteMessage($"Year - agora: {now.Year}", "\n");
            //Console.WriteLine($"Month - agora: {now.Month}");
            Utility.WriteMessage($"Month - agora: {now.Month}", "\n");
            //Console.WriteLine($"Day - agora: {now.Day}");
            Utility.WriteMessage($"Day - agora: {now.Day}", "\n");
            //Console.WriteLine($"Hour - {now.Hour}");
            Utility.WriteMessage($"Hour - {now.Hour}", "\n");
            //Console.WriteLine($"Minute - {now.Minute}");
            Utility.WriteMessage($"Minute - {now.Minute}", "\n");
            //Console.WriteLine($"Second - {now.Second}");
            Utility.WriteMessage($"Second - {now.Second}", "\n");
            #endregion

            // Método estático: é chamado a partir da sua classe
            Utility.TerminateConsole();
        }
    }
}
