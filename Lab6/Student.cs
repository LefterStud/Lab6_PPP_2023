
using System.Text.RegularExpressions;

namespace Lab6
{
    /// <summary>
    /// An abstract class that represents a student and implements the IStudent interface.
    /// </summary>
    public abstract class Student : IStudent
    {
        private readonly string _name;
        private int _age;
        private string _gender;
        const int MAX_AGE = 120;
        const int MIN_AGE = 7;
        readonly string[] GENDER = { "male", "female" };

        /// <summary>
        /// Creates a new instance of the Student class.
        /// </summary>
        /// <param name="name">Name of student.</param>
        /// <param name="age">Age of student.</param>
        /// <param name="gender">Gender of student.</param>
        protected Student(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        /// <summary>
        /// Setter and getter for the _name field.
        /// Students`s name.
        /// </summary>
        public string Name
        {
            get => _name;
            init
            {
                if (!string.IsNullOrEmpty(value) && Regex.IsMatch(value, @"^[A-Za-z ]+$"))
                {
                    _name = value.Trim();
                }
                else
                {
                    Errors.SetErrorCode(1);
                }

            }
        }

        /// <summary>
        /// Setter and getter for the _age field.
        /// Age of Students.
        /// </summary>
        public int Age
        {
            get => _age;
            set
            {
                if (value >= MIN_AGE && value <= MAX_AGE)
                {
                    _age = value;
                }
                else
                {
                    Errors.SetErrorCode(2);
                }
            }

        }

        /// <summary>
        /// Setter and getter for the _gender field.
        /// Gender of Students.
        /// </summary>
        public string Gender
        {
            get => _gender;
            set
            {
                if (value.ToLower() == GENDER[0] || value.ToLower() == GENDER[1])
                {
                    _gender = char.ToUpper(value[0]) + value.Substring(1).ToLower().Trim();
                }
                else
                {
                    Errors.SetErrorCode(3);
                }
            }
        }


        public abstract void AttendClass(string className);


        public abstract void Study();

        public override string ToString()
        {
            return Errors.ErrorCode > 0 ? Errors.GetError() :
                $"Name: {Name};\n" +
                $"Age: {Age};\n" +
                $"Gender: {Gender};\n";
        }
    }
}
