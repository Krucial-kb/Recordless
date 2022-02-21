using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordlessDomain.DomainModels
{
    public class ClientModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool? IsVerified { get; set; }
        public byte[] ProfilePicture { get; set; }
        public int? MediaCount { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
