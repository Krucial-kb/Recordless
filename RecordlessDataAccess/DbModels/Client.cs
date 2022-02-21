using System;
using System.Collections.Generic;

#nullable disable

namespace RecordlessDataAccess.DbModels
{
    public partial class Client
    {
        public Client()
        {
            Accounts = new HashSet<Account>();
            Contents = new HashSet<Content>();
            FollowerFollowerNavigations = new HashSet<Follower>();
            FollowerUsers = new HashSet<Follower>();
            FollowingFollowingNavigations = new HashSet<Following>();
            FollowingUsers = new HashSet<Following>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool? IsVerified { get; set; }
        public byte[] ProfilePicture { get; set; }
        public int? MediaCount { get; set; }
        public DateTime? DateCreated { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Content> Contents { get; set; }
        public virtual ICollection<Follower> FollowerFollowerNavigations { get; set; }
        public virtual ICollection<Follower> FollowerUsers { get; set; }
        public virtual ICollection<Following> FollowingFollowingNavigations { get; set; }
        public virtual ICollection<Following> FollowingUsers { get; set; }
    }
}
