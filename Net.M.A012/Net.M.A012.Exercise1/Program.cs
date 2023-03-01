using System.Reflection;

namespace Net.M.A012.Exercise1
{
    /// <summary>
    /// Build Student
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // create new Student with default values
            Student student1 = new Student("Nam Anh", "A1", "Male", age: 22, address: "Hanoi", mark: 80);

            // create new Student with some non-default values using named arguments
            Student student2 = new Student("Hương Giang", "B2", "Female", relationship: "In a relationship");

            // create new Student with default values, not input mark and grade
            Student student3 = new Student("Quynh", "A2", "Female", age: 25, address: "Hanoi");

            // calling the Graduate method on student1 without passing any argument
            student1.Graduate();

            // calling the Graduate method on student2 and passing a gradePoint argument
            student2.Graduate(3.5);

            // calling the Graduate method on student3 without passing any argument
            student3.Graduate();

            // calling the ToString method on student1 with default formatString
            string student1Info = student1.ToString();
            Console.WriteLine(student1Info);
            Console.WriteLine("\n");


            // calling the ToString method on student2 with custom formatString
            string student2Info = student2.ToString("name,    class,   gender,         entrydate,      grade");
            Console.WriteLine(student2Info);

            // calling the ToString method on student3 with custom formatString
            string student3Info = student3.ToString("name,address,entrydate,grade");
            Console.WriteLine(student3Info);
        }
    }
}