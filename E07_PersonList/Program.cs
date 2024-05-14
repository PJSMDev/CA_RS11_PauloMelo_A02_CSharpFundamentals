using System;
using System.Collections;
using D00_Utility;

namespace E07_PersonList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            #region Variables
            string continueInsert = "y";
            double id = 0;
            #endregion

            #region ArrayList - Person
            ArrayList listPerson = new ArrayList();
            #endregion

            Utility.WriteTitle("Person - Insert");

            #region Methods
            while (continueInsert.ToLower() == "y")
            {
                Utility.WriteMessage("Name: ");
                string name = Console.ReadLine();
                id++; 

                Person newPerson = new Person(id, name);

                listPerson.Add(newPerson);

                Utility.WriteMessage("Continue (y/n)? ");
                continueInsert = Console.ReadLine();

                if (continueInsert.ToLower() != "y" && continueInsert.ToLower() != "n")
                {
                    Utility.WriteMessage("Invalid input. Please enter 'y' or 'n'.", "", "\n");
                    continueInsert = "y"; 
                }
            }

            Utility.WriteTitle("Person - List");

            PersonUtility.ListData(listPerson);
            #endregion

            Utility.TerminateConsole();
        }
    }
}
