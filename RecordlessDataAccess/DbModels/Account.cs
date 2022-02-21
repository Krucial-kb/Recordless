using System;
using System.Collections.Generic;

#nullable disable

namespace RecordlessDataAccess.DbModels
{
    public partial class Account
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

        public virtual Client Client { get; set; }
    }
}
