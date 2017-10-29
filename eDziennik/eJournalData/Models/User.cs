using System;
using System.Collections.Generic;
using System.Text;

namespace eJournalData.Models
{
    public class User
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string HashedPassword { get; set; }
        public Role Role { get; set; }
        public bool Blocked { get; set; }
        public int InvalidLoginAttempts { get; set; }
    }

    public enum Role
    {
        Teacher,
        Administrator,
        Headmaster,
        Parent,
        Pupil,
        Office
    }
}
