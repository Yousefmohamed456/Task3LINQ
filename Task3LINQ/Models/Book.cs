using System;
using System.Collections.Generic;
using System.Text;

namespace Task3LINQ.Models
{
    /*
      Q1: EF Core has a convention: a property named Id (or ClassNameId) becomes the Primary Key automatically.
      Q2: EF Core decides nullability from the C# type:
      decimal Price is a value type and can't be null, so the column is NOT NULL.
      string Country is a reference type and can be null, so the column is NULL.
    */
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public DateTime? PublishedDate { get; set; }
    }
}
