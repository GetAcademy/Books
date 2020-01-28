using NUnit.Framework;

namespace Books.UnitTest
{
    public class Tests
    {
        [Test]
        public void TestBasicFields()
        {
            var book = new Book(
                "Verdenshistorien", "Ola Nordmann", 2000, 260);
            Assert.AreEqual("Verdenshistorien", book.Title);
            Assert.AreEqual("Ola Nordmann", book.Author);
            Assert.AreEqual(2000, book.PublishedYear );
            Assert.AreEqual(260, book.PageCount);
        }

        [Test]
        public void TestAddChapters()
        {
            var book = new Book("A", "ON", 2000, 260);
            book.AddChapter("Abc");
            book.AddChapter("Cde");
            Assert.AreEqual(2, book.ChapterCount);
        }

        [Test]
        public void TestSearchForChapterInBook()
        {
            var book = new Book("A", "ON", 2000, 260);
            book.AddChapter("en to tre fire");
            book.AddChapter("tre fire fem seks");
            var result = book.SearchChapters("tre");
            Assert.AreEqual(2, result.Length);
            Assert.AreEqual("en to tre fire", result[0]);
            Assert.AreEqual("tre fire fem seks", result[1]);
        }
    }
}