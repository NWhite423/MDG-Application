using MDG.UserControls;
using MDG.UserControls.MainMenu;
using MDG.Forms.Legal;
using MDG.UserControls.Legal;
using MDG.Forms.New;
using MDG.Forms.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MDG.Objects
{
    class Functions
    {
        //Misc Functions
        public static bool EntryIsDigits(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        //CreateJob Form Functions
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
                Card.Tag = "Card";

                //Create Card
                Point Position = new Point(0, (Card.Size.Height + 1) * i);
                Card.Location = new Point(LocationPoint.X, LocationPoint.Y + (Card.Size.Height + 1) * i);
                Card.Anchor = (AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
                FormC.Controls.Add(Card);

                i++;
            }
        }

        public static void AddJobtoCustomer(CustomerClass Customer, Job JobEntry)
        {
            var fileName = Path.Combine(
            Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)
                , @"Misc\XMLCustomers.xml");

            XDocument Doc = XDocument.Load(fileName);
            var Jobs = Customer.Jobs;
            var Name = Customer.Name;

            foreach (XElement CustomerItem in Doc.Descendants("Customer"))
            {
                if (CustomerItem.Element("Name").Value == Name)
                {
                    var JobItems = CustomerItem.Element("Jobs");
                    XElement JobItem = new XElement("Job",
                        new XElement("Name", JobEntry.Name),
                        new XElement("JobNumber", JobEntry.JobNumber),
                        new XElement("Path", JobEntry.Path),
                        new XElement("Representative",
                            new XElement("Name", JobEntry.Representative.Name),
                            new XElement("Phone", JobEntry.Representative.Phone),
                            new XElement("Email", JobEntry.Representative.Email)
                            ),
                        new XElement("Address", 
                            new XElement("AddressLine1", JobEntry.Address.AddressLine1),
                            new XElement("AddressLine2", JobEntry.Address.AddressLine2),
                            new XElement("City", JobEntry.Address.City),
                            new XElement("State", JobEntry.Address.State),
                            new XElement("Zip", JobEntry.Address.Zip)
                            )
                        );
                    var BillableItem = new XElement("BillableItems");
                    foreach (BillableItem billableItem in JobEntry.Items)
                    {
                        var BillItem = new XElement("BillableItem",
                            new XElement("Name", billableItem.Name),
                            new XElement("Amount", billableItem.Amount),
                            new XElement("Price", billableItem.Price)
                            );
                        BillableItem.Add(BillItem);
                    }
                    JobItem.Add(BillableItem);
                    JobItems.Add(JobItem);
                    Doc.Save(fileName);
                }
            }

            Directory.CreateDirectory(JobEntry.Path);
            foreach (string subDir in PublicVariables.JobSubDir)
            {
                Directory.CreateDirectory(JobEntry.Path + @"\" + subDir);
            }

            MessageBox.Show("Job information has been added to the customer and the directory has been created.");
            PopulateCustomerList();
        }

        //Main Menu functions
        public static void PopulateCustomerList()
        {
            PublicVariables.CustomerList.Clear();

            var fileName = Path.Combine(
               Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)
                   , @"Misc\XMLCustomers.xml");
            XDocument Doc = XDocument.Load(fileName);
            var Customers = Doc.Descendants("Customer");

            foreach (XElement Customer in Customers)
            {
                //Basic values and array setup
                CustomerClass customer = new CustomerClass();
                customer.Name = Customer.Element("Name").Value;
                customer.Category = Customer.Element("Category").Value;
                customer.Path = Customer.Element("Path").Value;

                string[] AddressArray = Customer.Element("Address").Value.Split(',');
                List<Representative> RepArray = new List<Representative> { };
                List<Job> JobArray = new List<Job> { };

                //Address
                customer.Address.AddressLine1 = AddressArray[0];
                customer.Address.AddressLine2 = AddressArray[1];
                customer.Address.City = AddressArray[2];
                customer.Address.State = AddressArray[3];
                customer.Address.Zip = AddressArray[4];

                //Jobs
                //TODO: Replace with actual grabbing of value.
                var XmlJobsArray = Customer.Element("Jobs").Elements();
                Debug.WriteLine(String.Format("There are {0} job entries", XmlJobsArray.Count()));
                foreach (XElement JobEntry in XmlJobsArray)
                {
                    Job entry = new Job
                    {
                        Name = JobEntry.Element("Name").Value,
                        JobNumber = JobEntry.Element("JobNumber").Value,
                        Path = JobEntry.Element("Path").Value
                    };
                    entry.Representative.Name = JobEntry.Element("Representative").Element("Name").Value;
                    entry.Representative.Phone = JobEntry.Element("Representative").Element("Phone").Value;
                    entry.Representative.Email = JobEntry.Element("Representative").Element("Email").Value;

                    entry.Address.AddressLine1 = JobEntry.Element("Address").Element("AddressLine1").Value;
                    entry.Address.AddressLine2 = JobEntry.Element("Address").Element("AddressLine2").Value;
                    entry.Address.City = JobEntry.Element("Address").Element("City").Value;
                    entry.Address.State = JobEntry.Element("Address").Element("State").Value;
                    entry.Address.Zip = JobEntry.Element("Address").Element("Zip").Value;

                    List<BillableItem> billableItems = new List<BillableItem> { };
                    foreach (XElement billItem in JobEntry.Element("BillableItems").Elements())
                    {
                        BillableItem billableItem = new BillableItem
                        {
                            Name = billItem.Element("Name").Value,
                            Amount = Convert.ToInt32(billItem.Element("Amount").Value),
                            Price = Convert.ToInt32(billItem.Element("Price").Value)
                        };
                        billableItems.Add(billableItem);
                    }
                    entry.Items = billableItems;
                    JobArray.Add(entry);
                }
                customer.Jobs = JobArray;

                //Representatives
                foreach (XElement Rep in Customers.Elements("Representatives").Elements())
                {
                    Representative RepClass = new Representative();
                    RepClass.Name = Rep.Element("Name").Value;
                    RepClass.Phone = Rep.Element("Phone").Value;
                    RepClass.Email = Rep.Element("Email").Value;
                    RepArray.Add(RepClass);
                }
                customer.Representatives = RepArray;

                //Add Customer to CustomerList
                PublicVariables.CustomerList.Add(customer);
            }
        }

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
            PopulateCustomerList();

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
            PopulateCustomerList();
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
                    Card.cmdRep.Enabled = false;
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

        public static void AddRepresentative(CustomerClass Class)
        {
            NewRepresentative RepForm = new NewRepresentative();
            DialogResult result = RepForm.ShowDialog();
            if (!result.Equals(DialogResult.Cancel))
            {
                Representative RepItem = new Representative
                {
                    Name = RepForm.txtName.Text,
                    Phone = RepForm.txtPhone.Text,
                    Email = RepForm.TxtEmail.Text
                };

                Class.Representatives.Add(RepItem);

                var fileName = Path.Combine(
                Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)
                    , @"Misc\XMLCustomers.xml");

                XDocument Doc = XDocument.Load(fileName);

                XElement entry = new XElement("Representative",
                    new XElement("Name", RepForm.txtName.Text),
                    new XElement("Phone", RepForm.txtPhone.Text),
                    new XElement("Email", RepForm.TxtEmail.Text)
                    );

                foreach (XElement customer in Doc.Descendants("Customer"))
                {
                    if (customer.Element("Name").Value == Class.Name)
                    {
                        MessageBox.Show("Representative created");
                        customer.Element("Representatives").Add(entry);
                        Doc.Save(fileName);
                        Functions.PopulateCustomerList();
                        Functions.ShowInformation(Class, 1);
                    }
                }
            }
        }

        public static void ShowInformation(CustomerClass Class, int Setting)
        {
            switch (Setting)
            {
                case 1:
                    {
                        Button button = new Button();
                        button.Size = new Size(150, 26);
                        button.Location = new Point(0, 0);
                        button.Text = "Add Representative";
                        button.Click += (s, e) => { AddRepresentative(Class); };
                        PublicVariables.Container.Panel2.Controls.Add(button);

                        var options = Class.Representatives;
                        int i = 0;
                        foreach (Representative Rep in options)
                        {
                            RepresentativeForm RepForm = new RepresentativeForm();
                            RepForm.lblName.Text = Rep.Name;
                            RepForm.lblPhone.Text = Rep.Phone;
                            RepForm.lblEmail.Text = Rep.Email;
                            RepForm.lblCompanyName.Text = Class.Name;

                            RepForm.Location = new Point(0, ((RepForm.Height + 1) * i) + 45);
                            RepForm.Width = RepForm.lblName.Width + 8;
                            PublicVariables.Container.Panel2.Controls.Add(RepForm);
                            i++;
                        }
                        break;
                    }
            }
        }

        //CreateAgreement
        public static void UpdateTableItems(NewContract form, int Field)
        {
            switch (Field)
            {
                case 1:
                    {
                        form.PnlSOW.Controls.Clear();
                        int i = 0;
                        List<ScopeOfWorkEntry> entries = form.SoWEntries;
                        foreach (ScopeOfWorkEntry entry in entries)
                        {
                            FieldEntry entryForm = new FieldEntry();
                            entryForm.Index = i;
                            entryForm.Concern = 0;
                            entryForm.masterForm = form;
                            entryForm.LblTitle.Text = entry.Title;
                            entryForm.txtItem.Text = entry.Entry;
                            Debug.WriteLine("Title: " + entry.Title + "\nText: " + entry.Entry);
                            entryForm.Location = new Point(0, (entryForm.Height + 1) * i);
                            form.PnlSOW.Controls.Add(entryForm);
                            i++;
                        }
                        return;
                    }
                case 2:
                    {
                        form.PnlExspenses.Controls.Clear();
                        int i = 0;
                        List<ScopeOfWorkEntry> entries = form.SoWEntries;
                        foreach (ScopeOfWorkEntry entry in entries)
                        {
                            FieldEntry entryForm = new FieldEntry();
                            entryForm.Index = i;
                            entryForm.Concern = 1;
                            entryForm.masterForm = form;
                            entryForm.LblTitle.Text = entry.Title;
                            entryForm.txtItem.Text = entry.Entry;
                            Debug.WriteLine("Title: " + entry.Title + "\nText: " + entry.Entry);
                            entryForm.Location = new Point(0, (entryForm.Height + 1) * i);
                            form.PnlExspenses.Controls.Add(entryForm);
                            i++;
                        }
                        return;
                    }
            }
        }
    }
}
