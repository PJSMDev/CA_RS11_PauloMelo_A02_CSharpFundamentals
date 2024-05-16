using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E08_Collections_ListManipulation_Person
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Set Unicode

            Utility.SetUnicodeConsole();

            #endregion

            #region Variables

            int switchOption = 0;
            string name;
            List<Person> personList = new List<Person>();

            #endregion

            #region Title

            Utility.WriteTitle("Menu");

            #endregion

            #region Fluxo

            do
            {
                try
                {
                    PersonUtility.ShowMenu();

                    switchOption = int.Parse(Console.ReadLine());

                    switch (switchOption)
                    {
                        case 1:
                            Console.Clear();
                            Utility.WriteMessage("Insert name: ");      // devo tirar o insert name daqui?
                            name = Console.ReadLine();
                            Person.AddPerson(personList, name);
                            break;
                        //case 2:
                        //    Console.Clear();
                        //    Person.InsertPersonByPosition();
                        //    break;
                        case 3:     // vai precisar de um tryparse, o trycatch abaixo não apanha isto
                            
                        //case 4:
                        //    Console.Clear();
                        //    Person.RemovePersonById();
                        //    break;
                        case 5:
                            Console.Clear();
                            Person.SortListById(personList);
                            break;
                        case 6:
                            Console.Clear();
                            Person.SortListByName(personList);
                            break;
                        case 7:
                            Console.Clear();
                            Person.ListPerson(personList);
                            break;
                        case 8:
                            break;
                        default:
                            break;
                    }
                }
                catch (FormatException ex)
                {
                    Utility.WriteMessage("Invalid option.\nPlease enter a number [1 - 8]", "", "\n\n");       // talvez precise de um clear()
                }
                catch (Exception ex)
                {
                    Utility.WriteMessage($"Error: {ex.Message}", "", "\n\n"); // talvez precise de um clear
                }
            } while (switchOption != 8);

            #endregion

            #region Terminate Console

            Utility.TerminateConsole();

            #endregion

        }
    }
}
