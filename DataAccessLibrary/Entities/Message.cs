using DataAccessLibrary.Interfaces;
using System;

namespace DataAccessLibrary.Entities
{
    public class Message : IEntity
    {
        public Message()
        {
            Id = new Guid();
        }

        public Guid Id { get; set; }
        public User From { get; set; }
        public User To { get; set; }

        public string Text { get; set; }

        public DateTime SendDate { get; set; }
        public DateTime DeleteDate { get; set; }
    }
}