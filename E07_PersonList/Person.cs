using System;

namespace E07_PersonList
{
    internal class Person
    {
        #region Properties
        internal string Name { get; set; }
        internal double ID { get; set; }
        #endregion

        #region Constructors
        internal Person()
        {
            ID = 0;
            Name = string.Empty;
        }
        internal Person(double id, string name)
        {
            ID = id;
            Name = name;
        }
        #endregion
    }
}
