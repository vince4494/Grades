using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Grades
{
    public abstract class GradeTracker : IGradeTracker
    {
        public abstract void AddGrade(float grade);
        public abstract GradeStatistics ComputeStatistics();
        public abstract void WriteGrades(TextWriter destination);
        //auto implemented property
        public string Name
        {
            //when someone wants to read the name property
            get
            {
                return _name;
            }

            //when someone wants to write to this property
            //check to see if string is null or empty
            set
            {

                //exception displayed if gradebook name is set to null
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }
                else if (!Regex.IsMatch(value, @"^[a-zA-Z]+$"))
                {
                    throw new ArgumentException("Name cannot be a number");
                }

                if (_name != value && NameChanged != null)
                {
                    NameChangedEventArgs args = new NameChangedEventArgs();
                    args.ExistingName = _name;
                    args.NewName = value;

                    NameChanged(this, args);

                }

                _name = value;
            }
        }

        public event NameChangedDelegate NameChanged;

        //field created to hold string value for Name
        protected string _name;


    }
}
