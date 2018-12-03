using DataAccessLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Entities
{
    public class Comment : IEntity
    {
        public Comment()
        {
            Id = new Guid();
        }

        public Guid Id { get; set; }
        public User Author { get; set; }

        public string Text { get; set; }
        public int LikeCount { get; set; }
        public int DislikeCount { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime DeleteDate { get; set; }
    }
}
