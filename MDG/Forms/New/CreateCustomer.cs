using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDG.Objects;
using MDG.Forms.Common;
using System.IO;

namespace MDG.Forms.New
{
    public partial class CreateCustomer : Form
    {
        public CreateCustomer()
        {
            InitializeComponent();

        }

        public CustomerClass Customer { get; set; }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            NewRepresentative form = new NewRepresentative
            {
                Modifing = false,
                Customer = Customer,
                RepWindow = pnlReps
            };
            DialogResult result = form.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                Customer = form.Customer;
            }
        }

        public List<Representative> Representatives = new List<Representative> { };

        private void cmdSave_Click(object sender, EventArgs e)
        {
            
        }

        private void CreateCustomer_Load(object sender, EventArgs e)
        {
            Customer = new CustomerClass
            {
                Representatives = new List<Representative> { }
            };
        }
    }
}
