using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Books.UnitTest
{
    class LibraryTest
    {
        [Test]
        public void TestSearch()
        {
            var library = new Library();

            var book1 = new Book("A", "ON", 2000, 260);
            book1.AddChapter("en to tre fire");
            book1.AddChapter("tre fire fem seks");

            library.AddBook(book1);

            var book2 = new Book("B", "PN", 2000, 260);
            book2.AddChapter("en  tre ");
            book2.AddChapter("tre  fem ");

            library.AddBook(book2);

            library.SearchBooksAndChapters("tre");

        }
    }
}
