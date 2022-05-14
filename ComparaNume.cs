using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace LabMTP_
{
    class ComparaNume : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
           return string.Compare(x.NumeStudent, y.NumeStudent);
        }
    }
}
