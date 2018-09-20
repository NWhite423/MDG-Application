using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDG.UserControls
{
    public partial class CustomerInformation : UserControl
    {
        public CustomerInformation()
        {
            InitializeComponent();
        }

        public string Title
        {
            get
            {
                return lblTitle.Text;
            }
            set
            {
                lblTitle.Text = value;
            }
        }

        public string Category
        {
            get
            {
                return lblCategory.Text;
            }
            set
            {
                lblCategory.Text = value;
            }
        }

        public string Address
        {
            get
            {
                return lblAddress.Text;
            }
            set
            {
                lblAddress.Text = value;
            }
        }
    }
}
