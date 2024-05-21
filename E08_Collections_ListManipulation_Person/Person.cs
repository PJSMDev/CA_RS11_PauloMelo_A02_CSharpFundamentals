using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E08_Collections_ListManipulation_Person
{
    internal class Person
    {

        #region Properties

        internal static int NextId { get; set; } = 1;
        internal string Name { get; set; }
        internal int Id { get; set; }

        #endregion

        #region Constructors

        internal Person()
        {
            Id = 0;
            Name = string.Empty;
        }

        internal Person(string name)
        {
            Id = NextId++;
            Name = name;
        }

        #endregion

        #region Methods

        #region 1. AddPerson()

        internal static void AddPerson(List<Person> list, string name)
        {
            Person newPerson = new Person(name);
            list.Add(newPerson);
            Utility.WriteMessage($"ID: {newPerson.Id} - Name: {name} added successfully.", "", "\n\n");
        }

        #endregion

        #region 2. Insert Person by Position

        internal static void InsertPersonByPosition(List<Person> list, int position, string nameToInsert)
        {
            if (position >= 0 && position <= list.Count)
            {
                Person personToInsert = new Person(nameToInsert);
                list.Insert(position, personToInsert);
                Utility.WriteMessage($"ID: {personToInsert.Id} - Name: {nameToInsert} inserted successfully.", "", "\n\n");
            }
            else
            {
                Utility.WriteMessage("Invalid position.", "", "\n\n");
            }
        }

        #endregion

        #region 3. Find Person by ID

        internal static Person FindPersonById(List<Person> list, int id)
        {
            return list.Find(person => person.Id == id);
        }

        #endregion

        #region 4. Remove Person by ID

        internal static bool RemovePersonById(List<Person> list, int idToRemove)
        {
            Person personToRemove = FindPersonById(list, idToRemove);
            if (personToRemove != null)
            {
                list.Remove(personToRemove);
                Utility.WriteMessage($"ID: {idToRemove} removed sucessfully.", "", "\n\n");
                return true;
            }
            else
            {
                Utility.WriteMessage($"ID {idToRemove} not found.", "", "\n\n");
                return false;
            }
        }

        #endregion

        #region 5. Sort List by ID

        internal static void SortListById(List<Person> list)
        {
            Utility.WriteMessage("List sorted by ID.", "", "\n\n");
            list.Sort((person01, person02) => person01.Id.CompareTo(person02.Id));
        }

        #endregion

        #region 6. Sort List by Name

        internal static void SortListByName(List<Person> list)
        {
            Utility.WriteMessage("List sorted by Name.", "", "\n\n");
            list.Sort((person01, person02) => person01.Name.CompareTo(person02.Name));
        }

        #endregion

        #region 7. List Person

        internal static void ListPerson(List<Person> list)
        {
            Console.Clear();

            foreach (Person person in list)
            {
                Utility.WriteMessage($"ID: {person.Id} -> Name: {person.Name}", "", "\n");
            }

            Utility.WriteMessage("\n");
        }

        #endregion

        #endregion

    }
}