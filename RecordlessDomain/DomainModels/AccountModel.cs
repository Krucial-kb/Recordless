using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordlessDomain.DomainModels
{
    public class AccountModel
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public int? Following { get; set; }
        public int? Followers { get; set; }
        public int? ClientId { get; set; }
        public bool? RecordlessPro { get; set; }
    }
}
