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

namespace MDG.UserControls
{
    public partial class LineItem : UserControl
    {
        public LineItem()
        {
            InitializeComponent();
        }

        public BillableItem ItemInfo;

        private void lblRemove_Click(object sender, EventArgs e)
        {
            Functions.ClearList();
            PublicVariables.ItemList.Remove(ItemInfo);
            Functions.PopulateList(); 
        }
    }
}
