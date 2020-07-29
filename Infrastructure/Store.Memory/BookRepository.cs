using System.Collections.Generic;
using System.Linq;

namespace Store.Memory
{
    public class BookRepository: IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1, "ISBN 1231231231", "D. Knuth", "Art Of Programming", "Super classical book about programming", 12.45m),
            new Book(2, "ISBN 1231231232", "M. Fowler", "Refactoring", "Must read for refactoring code knowledge", 7.14m),
            new Book(3, "ISBN 1231231233", "B. Kernighan, D. Ritchie", "C Programming Language", "C forever", 10.99m),
        };

        public Book[] GetAllByTitleOrAuthor(string titleOrAuthor)
        {
            return books.Where(book => book.Title.Contains(titleOrAuthor) || book.Author.Contains(titleOrAuthor)).ToArray();
        }

        public Book[] GetAllByIsbn(string isbn)
        {
            return books.Where(book => book.Isbn == isbn).ToArray();
        }

        public Book GetById(int id)
        {
            return books.Single(x => x.Id == id);
        }

        public Book[] GetAllByIds(IEnumerable<int> bookIds)
        {
            var foundBooks = from book in books
                join bookId in bookIds on book.Id equals bookId
                select book;
            return foundBooks.ToArray();
        }
    }
}
