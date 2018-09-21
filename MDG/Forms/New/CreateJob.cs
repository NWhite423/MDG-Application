using MDG.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MDG.Forms.Common;
using MDG.UserControls;
using System.Diagnostics;

namespace MDG.Forms.New
{
    public partial class CreateJob : Form
    {
        public CreateJob()
        {
            InitializeComponent();
        }

        public CustomerClass Class { get; set; }
        
        private void CreateJob_Load(object sender, EventArgs e)
        {
            //Get Project Number
            string ProjectNumber = DateTime.Now.Year.ToString();
            ProjectNumber += "-" + (Directory.GetDirectories(Class.Path).Count()+1).ToString("D2");
            lblProjectNumber.Text = "Project Number: " + ProjectNumber;
            PublicVariables.JobForm = this;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            BillableItem LineItem = new BillableItem();
            BillableItemForm Form = new BillableItemForm();
            DialogResult Result = Form.ShowDialog();
            if (Result.Equals(DialogResult.OK))
            {
                LineItem.Name = Form.txtTitle.Text;
                string Amount = Form.txtCount.Text;
                string Price = Form.txtPrice.Text;
                Debug.WriteLine("Amount: " + Amount + PublicVariables.NewLine + "Price: " + Price);
                LineItem.Amount = Convert.ToInt32(Amount);
                LineItem.Price = Convert.ToInt32(Price);
                PublicVariables.ItemList.Add(LineItem);
                Functions.PopulateList();
            }
            /*Point Position = new Point(0, (Item.Size.Height + 1) * Count);
            Item.Location = new Point(LocationPoint.X, LocationPoint.Y + (Item.Size.Height+1)*Count);
            Item.Anchor = (AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            this.Controls.Add(Item);
            Count++;*/
        }
    }
}
