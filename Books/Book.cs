using System.Collections.Generic;
using System.Linq;

namespace Books
{
    public class Book
    {
        private List<string> _chapters;

        public string Title { get; }
        public string Author { get; }
        public int PublishedYear { get; }
        public int PageCount { get; }
        public int ChapterCount => _chapters.Count;

        public Book(string title, string author, int publishedYear, int pageCount)
        {
            Title = title;
            Author = author;
            PublishedYear = publishedYear;
            PageCount = pageCount;
            _chapters = new List<string>();
        }

        public void AddChapter(string chapterName)
        {
            _chapters.Add(chapterName);
        }

        public string[] SearchChapters(string searchText)
        {
            return _chapters.FindAll(c => c.Contains(searchText)).ToArray();
        }
    }
}
