using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDG_Application.CreateDialogs;

namespace MDG_Application
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ContractorAgreement_Click(object sender, EventArgs e)
        {
            CreateContractAgreement CAD = new CreateContractAgreement();
            CAD.Show();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            int index = DataGridOverview.Rows.Add(new object[] { "Test Customer", "1", "$640.00" });
            
        }
    }
}
