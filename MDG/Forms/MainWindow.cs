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
using MDG.Forms.Legal;
using System.Xml.Linq;
using System.IO;
using System.Reflection;
using System.Diagnostics;

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
            Functions.PopulateCustomerList();
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

        private void newContractAgreementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewContract Form = new NewContract();
            Form.Show();
        }
    }
}
