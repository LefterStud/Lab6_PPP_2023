namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Певні константи для випадкової генерації значень.
            const double MIN_MARK = 0.0;
            const double MAX_MARK = 12.0;
            const int MIN_AGE = 10;
            const int MAX_AGE = 90;
            const int MIN_CLASS = 1;
            const int MAX_CLASS = 12;
            const int MAX_SUBJECTS = 30;
            string[] GENDER = { "Male", "Female" };
            string[] NAMES = {
                "Alice",
                "Bob",
                "Charlie",
                "David",
                "Emma",
                "Frank",
                "Grace",
                "Henry",
                "Isabel",
                "Jack"
            };
            string[] CLASSES = {
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
            Random r = new Random();
            Student student1 = new HighSchoolStudent(NAMES[r.Next(NAMES.Length)], r.Next(MIN_AGE, MAX_AGE), GENDER[r.Next(GENDER.Length)],
                r.NextDouble() * (MAX_MARK - MIN_MARK) + MIN_MARK, r.Next(MIN_CLASS, MAX_CLASS), r.Next(1, MAX_SUBJECTS));
            Student student2 = new HighSchoolStudent(NAMES[r.Next(NAMES.Length)], r.Next(MIN_AGE, MAX_AGE), GENDER[r.Next(GENDER.Length)],
                r.NextDouble() * (MAX_MARK - MIN_MARK) + MIN_MARK, r.Next(MIN_CLASS, MAX_CLASS), r.Next(1, MAX_SUBJECTS));
            Student student3 = new HighSchoolStudent(NAMES[r.Next(NAMES.Length)], r.Next(MIN_AGE, MAX_AGE), GENDER[r.Next(GENDER.Length)],
                r.NextDouble() * (MAX_MARK - MIN_MARK) + MIN_MARK, r.Next(MIN_CLASS, MAX_CLASS), r.Next(1, MAX_SUBJECTS));
            Student student4 = new HighSchoolStudent(NAMES[r.Next(NAMES.Length)], r.Next(MIN_AGE, MAX_AGE), GENDER[r.Next(GENDER.Length)],
                r.NextDouble() * (MAX_MARK - MIN_MARK) + MIN_MARK, r.Next(MIN_CLASS, MAX_CLASS), r.Next(1, MAX_SUBJECTS));
            Student student5 = new HighSchoolStudent(NAMES[r.Next(NAMES.Length)], r.Next(MIN_AGE, MAX_AGE), GENDER[r.Next(GENDER.Length)],
                r.NextDouble() * (MAX_MARK - MIN_MARK) + MIN_MARK, r.Next(MIN_CLASS, MAX_CLASS), r.Next(1, MAX_SUBJECTS));

            Students studentShip = new Students();
            studentShip.AddPerson(student1);
            studentShip.AddPerson(student2);
            studentShip.AddPerson(student3);
            studentShip.AddPerson(student4);
            studentShip.AddPerson(student5);
            foreach (var student in studentShip.StudentShip)
            {
                Console.WriteLine("--------------------------------------------\n" + student);
            }

            Console.WriteLine("\nTry to use interface:\n");
            student1.Study();
            student1.AttendClass(CLASSES[r.Next(CLASSES.Length)]);
            Console.WriteLine(student1.ToString());

        }
    }
}