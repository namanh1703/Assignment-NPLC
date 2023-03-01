namespace UserSort
{
    /// <summary>
    /// Write code to sort list of users.
    /// Application allows user to input list of users as Full Name (First Name and Last Name). 
    /// You need to get last name of users then sort them in alphabet.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Show name after sorting
            SortUserName();
        }
        /// <summary>
        /// Sort the list of users based on their last names
        /// </summary>
        private static void SortUserName()
        {
            /* //Input list name, each name is a new line
            List<string> users = new List<string>();
            Console.WriteLine("Enter the names of users");
            Console.WriteLine("Each name is a new line");
            Console.WriteLine("Type 'done' when your finished: ");

            //Check if user type "done" then stop
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "done")
                {
                    break;
                }
                users.Add(input);
            }
             */

            //Input list String name
            List<string> users = new List<string>()
            {
                "Tony Stark",
                "Steve Rogers",
                "Bruce Banner",
                "Thor",
                "Natasha Romanoff",
                "Clint Barton",
                "James Rhodes",
                "Scott Lang",
                "Doctor Strange",
                "Carol Danvers",
                "Peter Parker"
            };

            // Sort the list of users based on their last names
            var sortedUsers = users.OrderBy(user => user.Split(" ").Last());
            // Print the sorted list of users
            Console.WriteLine("Sorted list of users: ");
            foreach (var user in sortedUsers)
            {
                Console.WriteLine(user);
            }
        }
    }
}
