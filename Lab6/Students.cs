namespace Lab6
{
    public class Students
    {
        private Student[] _students;

        /// <summary>
        /// Return and set value of _students.
        /// </summary>
        public Student[] StudentShip
        {
            get => _students;
            set => _students = value;
        }

        /// <summary>
        /// Creates an array of the Student class that will contain people associated with the Student.
        /// </summary>
        public Students()
        {
            _students = new Student[0];
        }

        /// <summary>
        /// Adds an object to the array.
        /// </summary>
        /// <param name="students">An instance of the StudentShip class or those derived from StudentShip</param>
        public void AddPerson(Student students)
        {
            Array.Resize(ref _students, StudentShip.Length + 1);
            StudentShip[StudentShip.Length - 1] = students;
        }

        /// <summary>
        /// Delete an object from the array.
        /// </summary>
        /// <param name="index">The index of the element to be deleteed</param>
        public void DeleteStudent(int index)
        {
            if (index >= 0 && index < StudentShip.Length)
            {
                Array.Copy(StudentShip, index + 1, StudentShip, index, StudentShip.Length - index - 1);
                Array.Resize(ref _students, StudentShip.Length - 1);
            }
            else
            {
                Errors.SetErrorCode(7);
            }
        }


        /// <summary>
        /// Edit element of array
        /// </summary>
        /// <param name="index">Index of element to edit</param>
        /// <param name="newStudent">New value</param>
        public void EditStudentShip(int index, Student newStudent)
        {
            if (index >= 0 && index < StudentShip.Length)
            {
                StudentShip[index] = newStudent;
            }
            else
            {
                Errors.SetErrorCode(8);
            }
        }
    }
}
