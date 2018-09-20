using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDG.Objects
{
    public class Address
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }

    public class Representative
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }

    public class CustomerClass
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public List<string> Jobs { get; set; }
        public List<Representative> Representatives { get; set; }
        public Address Address = new Address();
    }
}
