namespace StudentAcademy
{
    internal class Program
    {
        static void Main()
        {
            var students = new Dictionary<string, Student>();
            int studentCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentCount; i++)
            {
                string studentName = Console.ReadLine();
                decimal grade = decimal.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName, new Student(studentName));
                }

                students[studentName].Grades.Add(grade);
            }
            var filteredStudents = students
                .Where(s => s.Value.Grades
                .Average() >= 4.50m);
            foreach (var student in filteredStudents)
            {
                Console.WriteLine($"{student.Value}");
            }
        }
    }
    class Student
    {
        public Student(string name)
        {
            Name = name;
            Grades = new List<decimal>();
        }

        public string Name { get; set; }
        public List<decimal> Grades { get; set; }
        public override string ToString()
        {
            return $"{Name} -> {Grades.Average():F2}";
        }
    }
}