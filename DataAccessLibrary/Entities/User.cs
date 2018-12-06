using DataAccessLibrary.Enums;
using DataAccessLibrary.Interfaces;
using System;
using System.Collections.Generic;

namespace DataAccessLibrary.Entities
{
    public class User : IEntity
    {
        public User()
        {
            Id = new Guid();

            Friends = new List<User>();
            Groups = new List<Group>();
            Purchases = new List<Product>();
            Messages = new List<Message>();
        }

        public Guid Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }

        public IEnumerable<User> Friends { get; set; }
        public IEnumerable<Group> Groups { get; set; }
        public IEnumerable<Product> Purchases { get; set; } 
        public IEnumerable<Message> Messages { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime DeleteDate { get; set; }

        public Status Status { get; set; }
    }
}
