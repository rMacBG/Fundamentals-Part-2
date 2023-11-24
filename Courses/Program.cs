using System.ComponentModel;

namespace Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var db = new Dictionary<string, Course>();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] arguments = input.Split(" : ");

                string courseName = arguments[0];
                string studentName = arguments[1];

                if (!db.ContainsKey(courseName))
                {
                    Course course = new Course(courseName);
                    db.Add(course.CourseName, course);
                }

                //Course foundCourse = db[courseName];
                //List<string> courseStudents = foundCourse.Students;
                //courseStudents.Add(studentName);

                db[courseName].Students.Add(studentName);

            }
            foreach (var course in db)
            {
                Console.WriteLine(course.Value);
            }
        }
    }

    public class Course
    {
        public Course(string courseName)
        {
            CourseName = courseName;
            Students = new List<string>();
        }
        public string CourseName { get; set; }
        public List<string> Students { get; set; }

        public override string ToString()
        {
            string result = $"{CourseName}: {Students.Count}\n";

            for (int i = 0; i < Students.Count; i++) 
            {
                result += $"-- {Students[i]}\n";

            }

            return result.Trim();
        }
    }
}