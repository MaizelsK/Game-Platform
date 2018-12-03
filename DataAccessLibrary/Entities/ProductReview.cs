using DataAccessLibrary.Enums;
using DataAccessLibrary.Interfaces;
using System;

namespace DataAccessLibrary.Entities
{
    public class ProductReview : IEntity
    {
        public ProductReview()
        {
            Id = new Guid();
        }

        public Guid Id { get; set; }
        public User Author { get; set; }
        public string Text { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime DeleteDate { get; set; }

        public ReviewType ReviewType { get; set; }
    }
}