using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D15_Collections_ArrayList
{
    internal class Person
    {
        #region Properties
        internal string Name { get; set; }
        internal string City { get; set; }
        #endregion

        #region Constructors
        internal Person()
        {
            Name = string.Empty;
            City = string.Empty;
        }
        internal Person(string name, string city) 
        {
            Name = name;
            City = city;
        }
        #endregion

        #region Methods
        internal static void ListPerson(ArrayList list)     // estático porque não manipula os dados 
            // se não fôr estático não tenho como acreder ao Name e City da Person
        {
            foreach (Person item in list) 
            {
                Utility.WriteMessage($"{item.Name} -> {item.City}", "", "\n");
            }
        }
        #endregion
    }
}
