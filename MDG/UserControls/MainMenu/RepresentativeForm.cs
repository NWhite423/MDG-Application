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

namespace MDG.UserControls.MainMenu
{
    public partial class RepresentativeForm : UserControl
    {
        public RepresentativeForm()
        {
            InitializeComponent();
        }

        private void lblEmail_click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblEmail.Text);
        }
    }
}
