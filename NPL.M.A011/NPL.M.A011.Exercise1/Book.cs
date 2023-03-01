using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPL.M.A011.Exercise1
{
    /// <summary>
    /// Create a class called Book to represent a book.
    /// </summary>
    class Book
    {
        // Instance variables for a book
        public string BookName { get; set; }     // Name of the book
        public string ISBN { get; set; }          // ISBN number of the book
        public string AuthorName { get; set; }    // Name of the author
        public string Publisher { get; set; }    // Publisher of the book


        /// <summary>
        /// Method to return the description of the book
        /// </summary>
        /// <returns>Return the information about the book as a string</returns>

        public string GetBookInformation()
        {
            // Return the book as a string
            return "Book Name: " + BookName + "\n" +
                   "ISBN: " + ISBN + "\n" +
                   "Author Name: " + AuthorName + "\n" +
                   "Publisher: " + Publisher;
        }
    }
}
