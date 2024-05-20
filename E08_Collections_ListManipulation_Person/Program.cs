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

            // Todo MRS: só se faz 1 try. Acho que já tinha referido isto anteriormente.
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

                #region Fluxo
                do
                {
                    try
                    {
                        PersonUtility.ShowMenu();

                        // Todo MRS: devia ser um try.parse. E se o user escreve aaa? O ideal é fazer um método utilitário para o efeito.
                        switchOption = int.Parse(Console.ReadLine());

                        // Todo MRS: as verificações se o nº é válido ou não, deviam ser feitas num método que só devolve para o Main se é válido ou não.
                        switch (switchOption)
                        {
                            case 1:
                                Console.Clear();
                                Utility.WriteMessage("Insert name: ");      // devo tirar o insert name daqui?
                                name = Console.ReadLine();
                                Person.AddPerson(personList, name);
                                break;
                            case 2:
                                Console.Clear();
                                Utility.WriteMessage("Position to insert: ");
                                if (int.TryParse(Console.ReadLine(), out int position))
                                {
                                    Utility.WriteMessage("Insert name: ");
                                    string nameToInsert = Console.ReadLine();
                                    Person.InsertPersonByPosition(personList, position - 1, nameToInsert);
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
                                    }
                                    else
                                    {
                                        Utility.WriteMessage($"ID {idToRemove} not found.", "", "\n\n");
                                    }
                                }
                                else
                                {
                                    Utility.WriteMessage("Invalid input. Please enter a valid integer.", "", "\n\n");
                                }
                                break;
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
                        // Todo MRS: o try não deve  ser usado para substituir o try.parse
                        Utility.WriteMessage("Invalid option.\nPlease enter a number [1 - 8]", "", "\n\n");       
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
