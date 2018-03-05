using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook : GradeTracker
    {
        //constructor 
        public GradeBook()
        {
            _name = "Empty";
            grades = new List<float>();
        }

        //compute statistics class 
        public override GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();
            float sum = 0;

            if (grades.Count == 0)
            {
                Console.WriteLine("There are no grades in the GradeBook");
            }

            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);

                sum += grade;
            }

            stats.AverageGrade = sum / grades.Count;
            return stats;
        }

        public override void WriteGrades(TextWriter destination)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                destination.WriteLine(grades[i]);
            }

        }

        //adds grade to list
        public override void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        protected List<float> grades;

    }
}
