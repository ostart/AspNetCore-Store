﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public class OrderItem
    {
        public int BookId { get; }
        public int Count { get; }
        public decimal Price { get; }

        public OrderItem(int bookId, int count, decimal price)
        {
            if (count <= 0) throw new ArgumentOutOfRangeException("count must be greater then 0");
            BookId = bookId;
            Count = count;
            Price = price;
        }
    }
}
