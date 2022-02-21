using System;
using System.Collections.Generic;

#nullable disable

namespace RecordlessApi.DbModels
{
    public partial class Following
    {
        public int Id { get; set; }
        public int? FollowingId { get; set; }
        public int? UserId { get; set; }
    }
}
