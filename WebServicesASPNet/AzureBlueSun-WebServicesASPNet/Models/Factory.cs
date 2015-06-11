using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

namespace DBASPNet.Models
{
    public class Factory
    {
        public SqlGuid ID { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Currency { get; set; }
        public string StreetAddress { get; set; }
        public string ZipCode { get; set; }
    }
}