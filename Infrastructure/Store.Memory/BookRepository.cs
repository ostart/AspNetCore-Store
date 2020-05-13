using System;
using System.Linq;

namespace Store.Memory
{
    public class BookRepository: IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1, "ISBN1231231231", "D. Knuth", "Art Of Programming"),
            new Book(2, "ISBN1231231232", "M. Fowler", "Refactoring"),
            new Book(3, "ISBN1231231232", "B. Kernighan, D. Ritchie", "C Programming Language"),
        };

        public Book[] GetAllByTitle(string titlePart)
        {
            return books.Where(book => book.Title.Contains(titlePart)).ToArray();
        }
    }
}
