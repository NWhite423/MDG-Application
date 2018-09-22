using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDG.Forms.New;
using MDG.UserControls;
using MDG.Objects;
using System.Xml.Linq;
using System.IO;
using System.Reflection;

namespace MDG.Forms
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateCustomer form = new CreateCustomer();
            form.Show();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            var fileName = Path.Combine(
               Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)
                   , @"Misc\XMLCustomers.xml");
            XDocument Doc = XDocument.Load(fileName);
            var Customers = Doc.Descendants("Customer");
            
            foreach (XElement Customer in Customers)
            {
                //Basic values and array setup
                CustomerClass Class = new CustomerClass();
                Class.Name = Customer.Element("Name").Value;
                Class.Category = Customer.Element("Category").Value;
                Class.Path = Customer.Element("Path").Value;

                string[] AddressArray = Customer.Element("Address").Value.Split(',');
                List<Representative> RepArray = new List<Representative> { };
                List<Job> JobArray = new List<Job> { };

                //Address
                Class.Address.AddressLine1 = AddressArray[0];
                Class.Address.AddressLine2 = AddressArray[1];
                Class.Address.City = AddressArray[2];
                Class.Address.State = AddressArray[3];
                Class.Address.Zip = AddressArray[4];

                //Jobs
                //TODO: Replace with actual grabbing of value.
                Class.Jobs = JobArray;

                //Representatives
                foreach (XElement Rep in Customers.Elements("Representatives").Elements())
                {
                    Representative RepClass = new Representative();
                    RepClass.Name = Rep.Element("Name").Value;
                    RepClass.Phone = Rep.Element("Phone").Value;
                    RepClass.Email = Rep.Element("Email").Value;
                    RepArray.Add(RepClass);
                }
                Class.Representatives = RepArray;

                //Add Customer to CustomerList
                PublicVariables.CustomerList.Add(Class);
            }
            PublicVariables.Container = SplitContainerMain;
            Functions.PopulateCustomers();
        }

        private void SplitContainerMain_Panel1_Resize(object sender, EventArgs e)
        {
            foreach (CustomerInformation Item in SplitContainerMain.Panel1.Controls)
            {
                
                Item.Width = SplitContainerMain.Panel1.Width-15;
            }
        }
    }


}
