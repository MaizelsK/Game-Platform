using DataAccessLibrary.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DataAccessLibrary.Entities
{
    public class Developer : IEntity
    {
        public Developer()
        {
            Id = new Guid();
            Products = new List<Product>();
        }

        public Guid Id { get;  set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public IEnumerable<Product> Products { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime DeleteDate { get; set; }
    }
}