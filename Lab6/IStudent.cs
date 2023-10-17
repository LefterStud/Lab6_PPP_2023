namespace Lab6
{
    public interface IStudent
    {
        /// <summary>
        /// The method that determines the class attended by the student
        /// </summary>
        /// <param name="className">Name of class</param>
        void AttendClass(string className);

        /// <summary>
        /// Changes the status of the student (studying/not studying).
        /// </summary>
        void Study();
    }
}
