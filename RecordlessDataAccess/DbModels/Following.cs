using System;
using System.Collections.Generic;

#nullable disable

namespace RecordlessDataAccess.DbModels
{
    public partial class Following
    {
        public int Id { get; set; }
        public int? FollowingId { get; set; }
        public int? UserId { get; set; }

        public virtual Client FollowingNavigation { get; set; }
        public virtual Client User { get; set; }
    }
}
