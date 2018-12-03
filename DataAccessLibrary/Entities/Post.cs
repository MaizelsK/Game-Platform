using DataAccessLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Entities
{
    public class Post : IEntity
    {
        public Post()
        {
            Id = new Guid();
            Comments = new List<Comment>();
        }

        public Guid Id { get; set; }
        public User Author { get; set; }

        public string Header { get; set; }
        public string Text { get; set; }
        public IEnumerable<Comment> Comments { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime DeleteDate { get; set; }

    }
}
