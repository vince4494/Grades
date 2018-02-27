using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeStatistics
    {
        //constructor
        public GradeStatistics()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }

        public string LetterGrade
        {
            get
            {
                string result;
                if(Math.Round(AverageGrade) >= 90)
                {
                    result = "A";
                }
                else if(Math.Round(AverageGrade) >= 80)
                {
                    result =  "B";

                }
                else if(Math.Round(AverageGrade) >= 70)
                {
                    result = "C";
                }
                else if(Math.Round(AverageGrade) >= 60)
                {
                    result = "D";
                }
                else
                {
                    result = "F";
                }
                return result;
            }
        }

        //declaring public variables
        public float AverageGrade;
        public float LowestGrade;
        public float HighestGrade;
  
    }
}
