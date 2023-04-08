// S5034
// CIS 199-50
// Program 4
// December 4, 2021

// This file is used to print the books and change their contents.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array of Library Books
            LibraryBook[] books = {

                new LibraryBook("Harry Potter and the Sorcerer's Stone",
                "J. K. Rowling",
                "Bloomsburry (UK)",
                1997,
                "9780590353403",
                false),

                new LibraryBook("Hunger Games",
                "Suzanne Collins",
                "Scholastic Press",
                2008,
                "9780590353402",
                false),

                new LibraryBook("Dante's Inferno",
                "Dante Alighieri",
                "",
                1826,
                "9780374176747",
                false),

                new LibraryBook("Make Your Bed",
                "William H. McRaven",
                "Grand Central Publishing",
                2017,
                "9781455570249",
                false),

                new LibraryBook("Series of Unfortunate Events",
                "Lemony Snicket",
                "HarperCollins",
                1999,
                "97805903536847",
                false) };

            PrintBooks(books); // First Print, No Change

            Console.WriteLine();
            Console.WriteLine();

            books[0].CheckedOut();
            books[1].CheckedOut();

            books[2].BookPublisher = "Publisher 1";
            books[3].ISBN = "930485739385";
            books[4].BookPublisher = "Publisher 2";

            PrintBooks(books); // Second Print, after 2 are checked out, 2 publishers are changed, and an ISBN is changed

            Console.WriteLine();
            Console.WriteLine();

            books[0].ReturnToShelf();
            books[1].ReturnToShelf();

            PrintBooks(books); // Third Print, after 2 checked out books are retuned to the shelf

            Console.ReadKey(); // Allowing user to see printed books
        }

        public static void PrintBooks(LibraryBook[] libraryBooks) // Method used to print books
        {
            // Loop to print books
            for(int i = 0; i < libraryBooks.Length; i++)
            {
                Console.WriteLine(libraryBooks[i].ToString());
            }
        }
    }
}
