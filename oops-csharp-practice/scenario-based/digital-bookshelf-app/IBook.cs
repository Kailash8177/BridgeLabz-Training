using System;
using System.Collections.Generic;
using System.Text;

namespace digital_bookshelf_app
{
    public interface IBook
    {

        bool AddBook(string title, string author);
        void DisplayBooks();
        void SortBooksAlphabetically();
        void SearchByAuthor(string author);
    }
}
