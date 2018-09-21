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

    public class BillableItem
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }
    }

    public class Job
    {
        public string Name { get; set; }
        public List<BillableItem> Items { get; set; }
        public Address Address = new Address();
        public Representative Representative = new Representative();
    }

    public class CustomerClass
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Path { get; set; }
        public Address Address = new Address();
        public List<Job> Jobs { get; set; }
        public List<Representative> Representatives { get; set; }
    }
}
