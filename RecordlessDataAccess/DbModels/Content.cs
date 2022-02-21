using System;
using System.Collections.Generic;

#nullable disable

namespace RecordlessDataAccess.DbModels
{
    public partial class Content
    {
        public int Id { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Title { get; set; }
        public byte[] Thumbnail { get; set; }
        public byte[] MediaContent { get; set; }
    }
}
