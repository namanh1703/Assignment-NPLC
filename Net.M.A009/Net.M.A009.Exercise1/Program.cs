using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace StringFormatting
{
    /// <summary>
    /// Write code to format string as name. Each name is a string that meets conditions:
    ///- Each word starts with upper case character, all following character(s) is lower case.
    ///- Words are separated by one space only.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            InputName();
        }
        /// <summary>
        /// Check for whitespace, or the user did not enter anything
        /// </summary>
        private static void InputName()
        {
            Console.Write("Enter string name you want to format: ");
            string name = Console.ReadLine();

            //Check if the user has left a space or not entered anything
            while (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Please enter a valid name.");
                Console.WriteLine("Enter a name: ");
                name = Console.ReadLine().Trim();
            }

            Console.WriteLine("Formatted name: " + FormatName(name));
        }

        /// <summary>
        /// Format string as name.
        /// </summary>
        /// <param name="name">format the entered name</param>
        /// <returns>string after formatting</returns>
        static string FormatName(string name)
        {
            // Trim the extra white space
            Regex trimmer = new Regex(@"\s\s+");
            name = trimmer.Replace(name, " ");

            // Split name into words
            string[] wordsName = name.Split(' ');

            // Format each word
            for (int i = 0; i < wordsName.Length; i++)
            {
                wordsName[i] = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(wordsName[i].ToLower());
            }
            // Join words back into a single string
            return string.Join(" ", wordsName);
        }
    }
}
