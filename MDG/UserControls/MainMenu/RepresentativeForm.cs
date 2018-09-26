using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDG.Objects;
using System.Threading;
using MDG.Forms.Common;

namespace MDG.UserControls.MainMenu
{
    public partial class RepresentativeForm : UserControl
    {
        public CustomerClass Customer { get; set; }
        public Representative Representative { get; set; }

        public RepresentativeForm()
        {
            InitializeComponent();
        }

        private void cmdModify_Click(object sender, EventArgs e)
        {
            NewRepresentative representative = new NewRepresentative
            {
                Modifing = true,
                Customer = Customer
            };
            representative.txtName.Text = Representative.Name;
            representative.txtTitle.Text = Representative.Title;
            representative.txtPhone.Text = Representative.Phone;
            representative.TxtEmail.Text = Representative.Email;
            representative.Show();
        }
    }
}
