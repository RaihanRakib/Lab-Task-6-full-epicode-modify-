using System;
using System.Collections.Generic;
using System.Text;

namespace LabTask
{
    class Library
    {
        Book b;
        String libName;
        String libAddress;
        String[] listOfBook;
        int totalBook;
        public  Library()
        { }
        public Library(String ln,String la, String[] lb,int tb)
        {
            libName = ln;
            libAddress = la;
            listOfBook = lb;
            totalBook = tb;
        }

        void ShowLibInfo() // show library info
        {
            Console.WriteLine("Library name: " + libName);
            Console.WriteLine("Library Address: " + libAddress);
            Console.WriteLine("Library List of Book: " + listOfBook);
            Console.WriteLine("Total Book: " + totalBook);
        }
        void ShowAllBooks() //show all book info as well
        {
            Console.WriteLine("All Books are: ");
            b.ShowInfo();
        }
        public void Showallinfo()
        {
            ShowAllBooks();
            ShowLibInfo();
        }
        void AddNewBook(Book book) // add a new book into lib
        {
            listOfBook[totalBook+1] += book;
            totalBook++;
        }
        void DeleteBook(Book book) // delete book object
        {
            totalBook--;
        }
        void AddNewBookCopy(Book book, int copy)
        {
            listOfBook[totalBook + 1] += book;
            totalBook++;
        }
    }
}
