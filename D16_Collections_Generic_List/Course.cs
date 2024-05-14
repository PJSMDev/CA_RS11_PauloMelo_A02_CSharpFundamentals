using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D16_Collections_Generic_List
{
    internal class Course
    {
        #region Properties
        internal string Code { get; set; }
        internal string Area { get; set; }
        internal string Title { get; set; }
        #endregion

        #region Constructors
        internal Course()
        {
            Code = string.Empty;
            Area = string.Empty;
            Title = string.Empty;
        }

        internal Course(string code, string area, string title)
        {
            Code = code;
            Area = area;
            Title = title;
        }
        #endregion

        #region Methods
        internal static void ListCourse(List<Course> list)
        {
            foreach (Course item in list)
            {
                Utility.WriteMessage($"Course {item.Code}: {item.Area} - {item.Title}", "", "\n");
            }
        }
        #endregion
    }
}
