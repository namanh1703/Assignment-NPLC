using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.M.A012.Exercise1
{
    /// <summary>
    /// Represents a student.
    /// </summary>
    using System;

    class Student
    {
        //Properties including Name, Class, Gender, Relationship, EntryDate, Age, Address, Mark, and Grade.
        public string Name { get; set; }
        public string Class { get; set; }
        public string Gender { get; set; }
        public string Relationship { get; set; }
        public DateTime EntryDate { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public decimal Mark { get; set; }
        public string Grade { get; set; }

        //The constructor method also has default values for some of the parameters such as "relationship",
        //"entryDate", "age", "address", and "grade".
        public Student(string name, string studentClass, string gender, string relationship = "Single", DateTime? entryDate = null,
                        int age = 0, string address = "", decimal mark = 0, string grade = "F")
        {
            Name = name;
            Class = studentClass;
            Gender = gender;
            Relationship = relationship;
            EntryDate = entryDate ?? DateTime.Today;
            Age = age;
            Address = address;
            Mark = mark;
            Grade = grade;
        }

        public void Graduate(double gradePoint = 0)
        {
            if (gradePoint > 4.0)
            {
                Console.WriteLine("Error Input Grade Point. Max value Grade Point is 4.0");
            }
            else if (gradePoint == 4.0)
            {
                Grade = "A";
            }
            else if (gradePoint >= 3.7)
            {
                Grade = "A-";
            }
            else if (gradePoint >= 3.3)
            {
                Grade = "B+";
            }
            else if (gradePoint >= 3.0)
            {
                Grade = "B";
            }
            else if (gradePoint >= 2.7)
            {
                Grade = "B-";
            }
            else if (gradePoint >= 2.3)
            {
                Grade = "C+";
            }
            else if (gradePoint >= 2.0)
            {
                Grade = "C";
            }
            else if (gradePoint >= 1.0)
            {
                Grade = "D";
            }
            else
            {
                Grade = "F";
            }
        }
        public void Graduate()
        {
            decimal mark = Mark;
            if (mark > 100)
            {
                Console.WriteLine("Error Input Mark. Max value Mark Point is 100");
            }
            else if (mark >= 85)
            {
                Grade = "A";
            }
            else if (mark >= 80)
            {
                Grade = "A-";
            }
            else if (mark >= 75)
            {
                Grade = "B+";
            }
            else if (mark >= 70)
            {
                Grade = "B";
            }
            else if (mark >= 65)
            {
                Grade = "B-";
            }
            else if (mark >= 60)
            {
                Grade = "C+";
            }
            else if (mark >= 55)
            {
                Grade = "C";
            }
            else if (mark >= 50)
            {
                Grade = "D";
            }
            else
            {
                Grade = "F";
            }
        }

        public override string ToString()
        {
            return ToString("name, grade");
        }

        public string ToString(string formatString)
        {
            string[] fields = formatString.Split(',');
            string output = "";
            foreach (string field in fields)
            {
                switch (field.Trim().ToLower())
                {
                    case "name":
                        output += $"Name: {Name}\n";
                        break;
                    case "class":
                        output += $"Class: {Class}\n";
                        break;
                    case "gender":
                        output += $"Gender: {Gender}\n";
                        break;
                    case "relationship":
                        output += $"Relationship: {Relationship}\n";
                        break;
                    case "entrydate":
                        output += $"Entry Date: {EntryDate.ToString("d")}\n";
                        break;
                    case "age":
                        output += $"Age: {Age}\n";
                        break;
                    case "address":
                        output += $"Address: {Address}\n";
                        break;
                    case "mark":
                        output += $"Mark: {Mark}\n";
                        break;
                    case "grade":
                        output += $"Grade: {Grade}\n";
                        break;
                    default:
                        throw new FormatException($"Invalid format string field: {field.Trim()}");
                }
            }
            return output;
        }
    }

}
