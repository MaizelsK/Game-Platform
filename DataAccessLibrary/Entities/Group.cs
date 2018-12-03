using DataAccessLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Entities
{
    public class Group : IEntity
    {
        public Group()
        {
            Id = new Guid();
            Subscribers = new List<User>();
            Posts = new List<Post>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public User Creator { get; set; }
        public IEnumerable<User> Subscribers { get; set; }
        public IEnumerable<Post> Posts { get; set; }
        
        public DateTime CreateDate { get; set; }
        public DateTime DeleteDate { get; set; }
    }
}
