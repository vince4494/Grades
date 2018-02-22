using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {
        //constructor 
        public GradeBook()
        {
            grades = new List<float>();
        }

        //compute statistics class 
        public GradeStatistics ComputeStatistics()
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

        //adds grade to list
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        //auto implemented property
        public string Name
        {
            //when someone wants to read the name property
            get
            {
                return _name;
            }

            //when someone wants to wrtite to this property
            //check to see if string is null or empty
            set
            {
                if(!String.IsNullOrEmpty(value))
                {
                    _name = value;
                }
            }
        }

        //field created to hold string value for Name
        private string _name;

        private List<float> grades;

    }
}
