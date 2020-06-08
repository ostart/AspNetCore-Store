using System;
using System.Linq;

namespace Store.Memory
{
    public class BookRepository: IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1, "ISBN 1231231231", "D. Knuth", "Art Of Programming"),
            new Book(2, "ISBN 1231231232", "M. Fowler", "Refactoring"),
            new Book(3, "ISBN 1231231233", "B. Kernighan, D. Ritchie", "C Programming Language"),
        };

        public Book[] GetAllByTitleOrAuthor(string titleOrAuthor)
        {
            return books.Where(book => book.Title.Contains(titleOrAuthor) || book.Author.Contains(titleOrAuthor)).ToArray();
        }

        public Book[] GetAllByIsbn(string isbn)
        {
            return books.Where(book => book.Isbn == isbn).ToArray();
        }
    }
}
