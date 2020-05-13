using System;

namespace Store
{
    public class Book
    {
        public int Id { get; }
        public string ISBN { get; }
        public string Author { get; }
        public string Title { get; }

        public Book(int id, string isbn, string author, string title)
        {
            Id = id;
            ISBN = isbn;
            Author = author;
            Title = title;
        }
    }
}
