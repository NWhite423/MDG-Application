using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDG.UserControls;
using MDG.Forms.New;

namespace MDG.Objects
{
    class PublicVariables
    {
        //String things
        public static string Seperator = @"\";
        public static string NewLine = "\n";
        public static string Space = " ";
        public static string Comma = ", ";

        //Controls
        public static List<CustomerClass> CustomerList = new List<CustomerClass> { };
        public static SplitContainer Container = new SplitContainer();
        public static List<BillableItem> ItemList = new List<BillableItem> { };
        public static CreateJob JobForm;
        public static CustomerPanelUC CustomerPanel;

        //Lists
        public static List<string> JobSubDir = new List<string> { "CAD", "Legal", "Finances", "Excel", "Misc", "Output", "Input" };
    }
}
