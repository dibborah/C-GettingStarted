using System;
using System.IO.Compression;

namespace ClassesNObjects
{
    // We are creating a blueprint of the book data type inside our program
    class Book
    {
        public string title;// class attribues
        public string author;// class attribues
        public int pages;

        public Book()
        {
            
        }

        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}