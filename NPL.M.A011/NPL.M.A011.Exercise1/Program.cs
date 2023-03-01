namespace NPL.M.A011.Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //test case
            Book b = new Book()
            {
                BookName = "Book1",
                ISBN = "1223",
                AuthorName = "Sach Hay",
                Publisher = "Nothing"
            };
            //print result
            Console.WriteLine(b.GetBookInformation());
        }
    }
}



