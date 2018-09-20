using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MDG.Objects
{
    class Functions
    {
        public static bool AddCustomer(CustomerClass Customer)
        {
            var fileName = Path.Combine(
            Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)
                , @"Misc\XMLCustomers.xml");
            string AddressArray = Customer.Address.AddressLine1 + "," + Customer.Address.AddressLine2 + "," + Customer.Address.City + "," + Customer.Address.State + "," + Customer.Address.Zip;

            XElement Jobs = new XElement("Jobs");
            XElement RepMaster = new XElement("Representatives");
            foreach (Representative Rep in Customer.Representatives)
            {
                XElement RepEntry = new XElement("Representative");
                XElement RepName = new XElement("Name", Rep.Name);
                XElement RepPhone = new XElement("Phone", Rep.Phone);
                XElement RepEmail = new XElement("Email", Rep.Email);
                object[] Items = new object[] { RepName, RepPhone, RepEmail };
                RepEntry.Add(Items);
                RepMaster.Add(RepEntry);
            }

            XElement Entry = new XElement("Customer",
                new XElement("Name", Customer.Name),
                new XElement("Category", Customer.Category),
                new XElement("Address", AddressArray),
                new XElement(RepMaster),
                new XElement(Jobs)
                );

            //Write entry into XML file.
            XDocument Doc = XDocument.Load(fileName);
            Doc.Element("Customers").Add(Entry);
            MessageBox.Show("Entry created successfully.");
            Doc.Save(fileName);
            return true;
        }
    }
}
