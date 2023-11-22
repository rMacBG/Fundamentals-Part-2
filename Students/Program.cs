namespace Students
{
    public class Student
    {
        public Student(string firstName, string lastName, float grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }

    internal class Program
    {
        static void Main()
        {
            int counter = int.Parse(Console.ReadLine()); 
            List<Student> students = new List<Student>();

            for (int i = 0; i < counter; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split()
                    .ToArray();
                Student student = new Student(tokens[0], tokens[1], float.Parse(tokens[2]));

                students.Add(student);
            }
           students = students
                .OrderByDescending(student => student.Grade)
                .ToList();
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}