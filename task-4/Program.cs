using System;

namespace Program
{

    public class Student
    {
        string name;
        string grade;
        int age;

        public Student()
        {
            this.name = string.Empty;
            this.grade = string.Empty;
            this.age = 0;
        }

        public Student(string name, string grade, int age)
        {
            this.name = name;
            this.grade = grade;
            this.age = age;
        }

        public void display(List<Student> students)
        {
            Console.WriteLine("Student List:");
            foreach (Student s in students)
            {
                Console.Write("{ ");
                Console.Write("Name: " + s.name + ", ");
                Console.Write("Grade: " + s.grade + ", ");
                Console.Write("Age: " + s.age);
                Console.Write("} | ");
            }
            Console.WriteLine();
        }

        public void display()
        {
            Console.WriteLine("Student Details:");
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Grade: " + this.grade);
            Console.WriteLine("Age: " + this.age);
        }

        public List<String> filterWithGrade(List<Student> students, String threshold)
        {
            List<String> result = new List<String>();
            result = students.Where(s => s.grade.CompareTo(threshold) <= 0).Select(s => s.name).ToList();
            return result;
        }

        public List<String> sortByName(List<Student> students, String orderBy = "asc")
        {
            List<String> result = new List<String>();
            if (orderBy == "desc")
            {
                result = students.OrderByDescending(s => s.name).Select(s => s.name).ToList();
            }
            else
            {
                result = students.OrderBy(s => s.name).Select(s => s.name).ToList();
            }
            return result;
        }

        public List<String> sortByGrade(List<Student> students, String orderBy = "asc")
        {
            List<String> result = new List<String>();
            if (orderBy == "desc")
            {
                result = students.OrderByDescending(s => s.grade).Select(s => s.name).ToList();
            }
            else
            {
                result = students.OrderBy(s => s.grade).Select(s => s.name).ToList();
            }
            return result;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("John", "A", 20));
            students.Add(new Student("Jane", "B", 21));
            students.Add(new Student("Bob", "C", 22));
            students.Add(new Student("Alice", "D", 23));
            students.Add(new Student("Mike", "E", 24));

            Student student = new Student();
            student.display(students);
            List<String> filteredResults = student.filterWithGrade(students, "B");
            List<String> sortedNames = student.sortByName(students);
            List<String> sortedGrades = student.sortByGrade(students);
            Console.WriteLine("Filtered Results: " + string.Join(", ", filteredResults));
            Console.WriteLine("Sorted Names: " + string.Join(", ", sortedNames));
            Console.WriteLine("Sorted Grades: " + string.Join(", ", sortedGrades));
        }
    }

}