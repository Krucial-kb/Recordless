using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordlessDomain.DomainModels
{
    public class FollowingModel
    {
        public int Id { get; set; }
        public int? FollowingId { get; set; }
        public int? UserId { get; set; }
    }
}
