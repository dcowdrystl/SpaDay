using System;

namespace SpaDay.Models
{
    public class User
    {
        public int Id { get; }
        static private int nextId = 1;
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Date { get; }

        public User()
        {
            Id = nextId;
            nextId++;
        }

        public User(string u, string e, string p) : this()
        {
            Username = u;
            Email = e;
            Password = p;
            Date = DateTime.Now;
        }

        public override string ToString()
        {
            return Username;
        }
    }
}
