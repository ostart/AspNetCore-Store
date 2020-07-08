using System;
using System.Collections.Generic;
using System.Linq;

namespace Store
{
    public class Order
    {
        public int Id { get; }

        private List<OrderItem> items;
        public IReadOnlyCollection<OrderItem> Items => items;

        public int TotalCount
        {
            get { return items.Sum(item => item.Count); }
        }

        public decimal TotalPrice
        {
            get { return items.Sum(item => item.Price * item.Count); }
        }

        public void AddItem(Book book, int count)
        {
            if (book == null) throw new ArgumentNullException(nameof(book));
            var orderItem = items.SingleOrDefault(item => item.BookId == book.Id);

            if (orderItem == null)
            {
                items.Add(new OrderItem(book.Id, count, book.Price));
            }
            else
            {
                items.Remove(orderItem);
                items.Add(new OrderItem(book.Id, orderItem.Count + count, book.Price));
            }
        }

        public Order(int id, IEnumerable<OrderItem> items)
        {
            if (items == null) throw new ArgumentNullException(nameof(items));
            Id = id;
            this.items = new List<OrderItem>(items);
        }
    }
}
