using System;
using System.Collections.Generic;

#nullable disable

namespace RecordlessDataAccess.DbModels
{
    public partial class Follower
    {
        public int Id { get; set; }
        public int? FollowerId { get; set; }
        public int? UserId { get; set; }

        public virtual Client FollowerNavigation { get; set; }
        public virtual Client User { get; set; }
    }
}
