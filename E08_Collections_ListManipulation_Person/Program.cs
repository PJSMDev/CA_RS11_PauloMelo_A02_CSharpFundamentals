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

            try
            {
                #region Variables

                int switchOption = 0;
                string name;
                List<Person> personList = new List<Person>();

                #endregion

                #region Title

                Utility.WriteTitle("Menu");

                #endregion

                #region Flux
                do
                {
                    try
                    {
                        PersonUtility.ShowMenu();

                        string inputOption = Console.ReadLine();

                        if (!PersonUtility.TryParseOption(inputOption, out switchOption) || !PersonUtility.ValidateSwitchOption(switchOption))
                        {
                            Utility.WriteMessage("Invalid option.\nEnter a number [1 - 8].", "\n", "\n\n");
                        }

                        switch (switchOption)
                        {
                            case 1:
                                Console.Clear();
                                Utility.WriteMessage("Insert name: ");
                                name = Console.ReadLine();
                                Person.AddPerson(personList, name);
                                Person.ListPerson(personList);
                                break;
                            case 2:
                                Console.Clear();
                                Utility.WriteMessage("Position to insert: ");
                                if (int.TryParse(Console.ReadLine(), out int position))
                                {
                                    Utility.WriteMessage("Insert name: ");
                                    string nameToInsert = Console.ReadLine();
                                    Person.InsertPersonByPosition(personList, position - 1, nameToInsert);
                                    Person.ListPerson(personList);
                                }
                                else
                                {
                                    Utility.WriteMessage("Invalid input.", "", "\n\n");
                                }
                                break;
                            case 3:
                                Console.Clear();
                                Utility.WriteMessage("Enter ID to find: ");
                                if (int.TryParse(Console.ReadLine(), out int idToSearch))
                                {
                                    Person personToFind = Person.FindPersonById(personList, idToSearch);
                                    if (personToFind != null)
                                    {
                                        Utility.WriteMessage($"Person found: ID {personToFind.Id} -> Name: {personToFind.Name}", "", "\n\n");
                                    }
                                    else
                                    {
                                        Utility.WriteMessage("Person not found.", "", "\n\n");
                                    }
                                }
                                else
                                {
                                    Utility.WriteMessage("Invalid ID. Please enter a number.", "", "\n\n");
                                }
                                break;
                            case 4:
                                Console.Clear();
                                Utility.WriteMessage("Enter the ID to remove: ");
                                if (int.TryParse(Console.ReadLine(), out int idToRemove))
                                {
                                    if (Person.RemovePersonById(personList, idToRemove))
                                    {
                                        Utility.WriteMessage($"ID: {idToRemove} removed successfully.", "", "\n\n");
                                        Person.ListPerson(personList);
                                    }
                                    else
                                    {
                                        Utility.WriteMessage($"ID {idToRemove} not found.", "", "\n\n");
                                    }
                                }
                                else
                                {
                                    Utility.WriteMessage("Invalid input.", "", "\n\n");
                                }
                                break;
                            case 5:
                                Console.Clear();
                                Person.SortListById(personList);
                                Person.ListPerson(personList);
                                break;
                            case 6:
                                Console.Clear();
                                Person.SortListByName(personList);
                                Person.ListPerson(personList);
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
                    catch (Exception ex)
                    {
                        Utility.WriteMessage($"Error: {ex.Message}", "", "\n\n");
                    }
                } while (switchOption != 8);
                #endregion
            }
            finally
            {
                Utility.TerminateConsole();
            }
        }
    }
}
