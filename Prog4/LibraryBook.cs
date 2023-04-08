// S5034
// CIS 199-50
// Program 4
// December 4, 2021

// This file is to create LibraryBooks to use for storing thueir information in the correct place,
// determining if they are checked out or not,
// and returning them to the shelf.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog4
{
    public class LibraryBook
    {
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }
        public string BookPublisher { get; set; }
        public int yearOfPublication;
        public int YearOfPublication
        {
            get
            {
                return yearOfPublication;
            }
            set
            {
                if (value > 0)
                {
                    yearOfPublication = value;
                }
                else
                {
                    yearOfPublication = 2019;
                }
            }
        }
        public string ISBN { get; set; }

        public bool checkedOut { get; set; }

        public LibraryBook(string Title, string Author, string Publisher, int Year, string CallNumber, bool CheckedOut)
        {
            BookTitle = Title;
            BookAuthor = Author;
            BookPublisher = Publisher;
            YearOfPublication = Year;
            ISBN = CallNumber;
            checkedOut = CheckedOut;
        }

        public void CheckedOut()
        {
            checkedOut = true;
        }

        public void ReturnToShelf()
        {
            checkedOut = false;
        }

        public bool IsCheckedOut()
        {
            return checkedOut;
        }

        public override string ToString()
        {
            string output = $"Title: {BookTitle}{Environment.NewLine}" +
                $" Author: {BookAuthor}{Environment.NewLine}" +
                $"Publisher : {BookPublisher}{Environment.NewLine}" +
                $"Year: {YearOfPublication}{Environment.NewLine}" +
                $"Call Number: {ISBN}{Environment.NewLine}";
            return output;
        }
    }
}
