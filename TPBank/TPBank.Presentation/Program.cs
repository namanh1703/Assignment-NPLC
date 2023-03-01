namespace TPBank.Presentation
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main method of the application.
        /// </summary>
        /// <param name="args">Command line arguments passed to the application.</param>
        static void Main(string[] args)
        {
            var manage = new Manage();
            manage.Run();
        }
    }

}