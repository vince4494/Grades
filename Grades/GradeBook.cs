using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeBook
    {
        //constructor 
        public GradeBook()
        {
            grades = new List<float>();
        }

        //adds grade to list
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        List<float> grades;

    }
}
