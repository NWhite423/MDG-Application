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

            int i = 0;
            foreach (XElement Customer in Customers)
            {
                CustomerInformation Card = new CustomerInformation();
                int y = SplitContainerMain.Panel1.Width;
                Card.Title = Customer.Element("Name").Value;
                Card.Category = Customer.Element("Category").Value;
                string Address = "";
                string[] AddressParts = Customer.Element("Address").Value.Split(',');
                if (AddressParts[1] == "")
                {
                    Address += AddressParts[0] + "\n" + AddressParts[2] + ", " + AddressParts[3] + " " + AddressParts[4];
                } else
                {
                    Address += AddressParts[0] + "\n" + AddressParts[1] + "\n" + AddressParts[2] + ", " + AddressParts[3] + " " + AddressParts[4];
                }
                Card.Address = Address;
                Card.Location = new Point(0, 191 * i);
                Card.Width = y - 20;
                SplitContainerMain.Panel1.Controls.Add(Card);

                i++;
            }
        }

        private void SplitContainerMain_Panel1_Resize(object sender, EventArgs e)
        {
            foreach (CustomerInformation Card in SplitContainerMain.Panel1.Controls)
            {
                Card.Width = SplitContainerMain.Panel1.Width - 20;
            }
        }
    }


}
