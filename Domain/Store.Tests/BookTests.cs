using System;
using Xunit;

namespace Store.Tests
{
    public class BookTests
    {
        [Fact]
        public void IsIsbn_WithNull_ReturnFalse()
        {
            bool actual = Book.IsIsbn(null);
            Assert.False(actual);
        }

        [Fact]
        public void IsIsbn_WithWhitespaces_ReturnFalse()
        {
            bool actual = Book.IsIsbn("   ");
            Assert.False(actual);
        }

        [Fact]
        public void IsIsbn_InvalidIsbn_ReturnFalse()
        {
            bool actual = Book.IsIsbn("ISBN 123");
            Assert.False(actual);
        }

        [Fact]
        public void IsIsbn_With10Numbers_ReturnTrue()
        {
            bool actual = Book.IsIsbn("ISBN 1231231231");
            Assert.True(actual);
        }

        [Fact]
        public void IsIsbn_With13Numbers_ReturnTrue()
        {
            bool actual = Book.IsIsbn("ISBN 123-123-123 0123");
            Assert.True(actual);
        }

        [Fact]
        public void IsIsbn_WithTrashStart_ReturnFalse()
        {
            bool actual = Book.IsIsbn("xxxISBN ISBN 123-123-123 0123 yyyy");
            Assert.False(actual);
        }
    }
}
