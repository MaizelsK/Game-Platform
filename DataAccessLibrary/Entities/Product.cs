using DataAccessLibrary.Interfaces;
using System;
using System.Collections.Generic;

namespace DataAccessLibrary.Entities
{
    public class Product : IEntity
    {
        public Product()
        {
            Id = new Guid();
            Reviews = new List<ProductReview>();
        }

        public Guid Id { get; set; }
        public Developer Developer { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public decimal Price { get; set; }
        public IEnumerable<ProductReview> Reviews { get; set; }
    }
}