using MDG.UserControls;
using MDG.Forms.New;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MDG.Objects
{
    class Functions
    {
        public static void ClearList()
        {
            CreateJob FormC = PublicVariables.JobForm;
            //Delete all Billable Items
            for (int i = 0; i < FormC.Controls.Count; i++)
            {
                Control Cont = FormC.Controls[i];
                Debug.WriteLine("Parse Item: " + Cont.ToString());
                if (!(Cont is TextBox) && !(Cont is Label) && !(Cont is Button))
                {
                    Debug.WriteLine("Control Found, removing");
                    FormC.Controls.Remove(Cont);
                }
            }
            Debug.WriteLine(String.Format("========================= {0} Items Parsed =========================", FormC.Controls.Count));
        }

        public static void PopulateList()
        {
            CreateJob FormC = PublicVariables.JobForm;
            Point LocationPoint = new Point(12, 465);
            ClearList();
            //Populate cards
            int i = 0;
            foreach (BillableItem Item in PublicVariables.ItemList)
            {
                //Card Information
                LineItem Card = new LineItem();
                Card.lblTitle.Text = Item.Name;
                long count = Item.Amount;
                long price = Item.Price;
                string SecondLine = Item.Amount.ToString() + " * " + Item.Price.ToString() + " = " + (count * price).ToString();
                Card.lblInfo.Text = SecondLine;
                Card.ItemInfo = Item;

                //Create Card
                Point Position = new Point(0, (Card.Size.Height + 1) * i);
                Card.Location = new Point(LocationPoint.X, LocationPoint.Y + (Card.Size.Height + 1) * i);
                Card.Anchor = (AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
                FormC.Controls.Add(Card);

                i++;
            }
        }

        public static bool AddCustomer(CustomerClass Customer)
        {
            PublicVariables.CustomerList.Add(Customer);
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
                new XElement("Path", Customer.Path),
                new XElement(RepMaster),
                new XElement(Jobs)
                );

            //Write entry into Main XML file.
            XDocument Doc = XDocument.Load(fileName);
            Doc.Element("Customers").Add(Entry);
            MessageBox.Show("Entry created successfully.");
            Doc.Save(fileName);
            Directory.CreateDirectory(Customer.Path);
            PopulateCustomers();

            return true;
        }

        public static bool RemoveCustomer(CustomerClass Customer)
        {
            PublicVariables.CustomerList.Remove(Customer);
            var fileName = Path.Combine(
            Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)
                , @"Misc\XMLCustomers.xml");

            XDocument Doc = XDocument.Load(fileName);
            Doc.Descendants("Customer")
                .Where(node => (string)node.Element("Name") == Customer.Name)
                .Remove();

            Doc.Save(fileName);            
            return true;
        }
        
        public static void PopulateCustomers()
        {
            SplitContainer Container = PublicVariables.Container;
            Container.Panel1.Controls.Clear();
            int i = 0;
            foreach (CustomerClass Customer in PublicVariables.CustomerList)
            {
                CustomerInformation Card = new CustomerInformation();
                int y = Container.Panel1.Width;
                string Address = "";
                if (Customer.Address.AddressLine2 == "")
                {
                    Address += Customer.Address.AddressLine1 + "\n" + Customer.Address.City + ", " + Customer.Address.State + " " + Customer.Address.Zip;
                }
                else
                {
                    Address += Customer.Address.AddressLine1 + ", " + Customer.Address.AddressLine2 + "\n" + Customer.Address.City + ", " + Customer.Address.State + " " + Customer.Address.Zip;
                }
                if (Customer.Category == "Individual")
                {
                    Card.Title = "[I] " + Customer.Name;
                }
                if (Customer.Category == "Company")
                {
                    Card.Title = "[C] " + Customer.Name;
                }
                Card.Address = Address;
                Card.Location = new Point(0, (Card.Height + 1) * i);
                Card.Width = y - 20;
                Container.Panel1.Controls.Add(Card);
                Card.Class = Customer;
                i++;
            }
        }
    }
}
