using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDG.Forms.New;

namespace MDG.Objects
{
    class PublicVariables
    {
        public static string Seperator = @"\";
        public static string NewLine = "\r\n";
        public static List<CustomerClass> CustomerList = new List<CustomerClass> { };
        public static SplitContainer Container = new SplitContainer();
        public static List<BillableItem> ItemList = new List<BillableItem> { };
        public static CreateJob JobForm;
        public static List<string> JobSubDir = new List<string> { "CAD", "Legal", "Finances", "Excel", "Misc", "Output", "Input" };
    }
}
