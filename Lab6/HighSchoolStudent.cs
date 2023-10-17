namespace Lab6
{
    /// <summary>
    /// A class representing a HighSchoolStudent inherits from the Student base class and implements the IStudent interface.
    /// </summary>
    public class HighSchoolStudent : Student, IStudent
    {
        private double _averageMark;
        private int _grade;
        private int _numberOfSubjects;
        private string _class = "Hallway";
        private bool _isStudy = false;
        private const double MAX_MARK = 12;
        private const int MIN_CLASS = 1;
        private const int MAX_CLASS = 12;
        private const int MAX_SUBJECTS = 30;
        readonly string[] CLASSES = {
            "HallWay",
            "Math class",
            "Physics class",
            "Chemistry class",
            "Biology class",
            "History class",
            "Geography class",
            "Informatics class",
            "English class"
        };

        /// <summary>
        /// reates a new instance of the HighSchoolStudent class.
        /// </summary>
        /// <param name="name">Name of student.</param>
        /// <param name="age">Age of student.</param>
        /// <param name="gender">Gender of student.</param>
        /// <param name="averageMark">Average mark.</param>
        /// <param name="grade">Grade of student.</param>
        /// <param name="numberOfSubjects">Number of subjects.</param>
        public HighSchoolStudent(string name, int age, string gender, double averageMark, int grade, int numberOfSubjects) : base(name, age, gender)
        {
            AverageMark = averageMark;
            Grade = grade;
            NumberOfSubjects = numberOfSubjects;
        }

        /// <summary>
        /// Setter and getter for the _averageMark field.
        /// Student`s average mark.
        /// </summary>
        public double AverageMark
        {
            get => _averageMark;
            set
            {
                if (value > 0 && value <= MAX_MARK)
                {
                    _averageMark = value;
                }
                else
                {
                    Errors.SetErrorCode(4);
                }
            }
        }

        /// <summary>
        /// Setter and getter for the _grade field.
        /// Student`s grade. 
        /// </summary>
        public int Grade
        {
            get => _grade;
            set
            {
                if (value >= MIN_CLASS && value <= MAX_CLASS)
                {
                    _grade = value;
                }
                else
                {
                    Errors.SetErrorCode(5);
                }
            }
        }

        /// <summary>
        /// Setter and getter for the _numberOfSubjects field.
        /// Student`s number of subjects. 
        /// </summary>
        public int NumberOfSubjects
        {
            get => _numberOfSubjects;
            set
            {
                if (value > 0 && value <= MAX_SUBJECTS)
                {
                    _numberOfSubjects = value;
                }
                else
                {
                    Errors.SetErrorCode(6);
                }
            }
        }

        /// <summary>
        /// Setter and getter for the _class field.
        /// Student`s class. 
        /// </summary>
        public string Class
        {
            get => _class;
            set
            {
                if (CLASSES.Contains(value))
                {
                    _class = char.ToUpper(value[0]) + value.Substring(1).ToLower().Trim();
                }
                else
                {
                    Errors.SetErrorCode(9);
                }
            }
        }

        /// <summary>
        /// Setter and getter for the _isStudy field.
        /// Shows whether the student is studying. 
        /// </summary>
        public bool IsStudy
        {
            get => _isStudy;
            set => _isStudy = value;
        }

        public override void AttendClass(string className)
        {
            Class = className;
        }

        public override void Study()
        {
            IsStudy = !IsStudy;
        }

        public override string ToString()
        {
            return Errors.ErrorCode > 0 ? Errors.GetError() :
                $"Student:\n" +
                $"{base.ToString()}" +
                $"Average mark: {AverageMark:F2};\n" +
                $"Grade: {Grade};\n" +
                $"Number of Subjects: {NumberOfSubjects};\n" +
                $"Attended class: {Class};\n" +
                $"Study status: {IsStudy};\n";
        }
    }
}
