using MDG.UserControls;
using MDG.UserControls.MainMenu;
using MDG.Forms.Legal;
using MDG.UserControls.Legal;
using MDG.Forms.New;
using MDG.Forms.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Linq; 

namespace MDG.Objects
{
    class Functions
    {
        public class Common
        {
            public static string ConvertAddressString(object input, bool multiLine = false)
            {
                string value = "";
                string NewLine = PublicVariables.NewLine;
                string Space = PublicVariables.Space;
                string Comma = PublicVariables.Comma;
                if (input is string[] addressValue)
                {
                    if (multiLine)
                    {
                        if (addressValue[1] == "")
                        {
                            value = addressValue[0] + NewLine + addressValue[2] + Comma + addressValue[3] + Space + addressValue[4];
                        }
                        else
                        {
                            value = addressValue[0] + NewLine + addressValue[1] + NewLine + addressValue[2] + Comma + addressValue[3] + Space + addressValue[4];
                        }
                    }
                    if (addressValue[1] == "")
                    {
                        value = addressValue[0] + Comma + addressValue[2] + Comma + addressValue[3] + Space + addressValue[4];
                    }
                    else
                    {
                        value = addressValue[0] + Comma + addressValue[1] + Comma + addressValue[2] + Comma + addressValue[3] + Space + addressValue[4];
                    }
                }
                else
                {
                    if (input is Address addressValueO)
                    {
                        if (multiLine)
                        {
                            if (addressValueO.AddressLine2 == "")
                            {
                                value = addressValueO.AddressLine1 + NewLine + addressValueO.City + Comma + addressValueO.State + Space + addressValueO.Zip;
                            }
                            else
                            {
                                value = addressValueO.AddressLine1 + NewLine + addressValueO.AddressLine2 + NewLine + addressValueO.City + Comma + addressValueO.State + Space + addressValueO.Zip;
                            }
                        }
                        if (addressValueO.AddressLine2 == "")
                        {
                            value = addressValueO.AddressLine1 + Comma + addressValueO.City + Comma + addressValueO.State + Space + addressValueO.Zip;
                        }
                        else
                        {
                            value = addressValueO.AddressLine1 + Comma + addressValueO.AddressLine2 + Comma + addressValueO.City + Comma + addressValueO.State + Space + addressValueO.Zip;
                        }
                    }
                    else
                    {
                        throw new ArgumentException("input can only be a 'string[]' or 'Address' object", "original");
                    }
                }
                return value;
            }

            public static int GetPointUnderControl(Control control)
            {
                int point = control.Height + 1;
                return point;
            }

            public static void CreateErrorReport(string msg)
            {
                string errorDir = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\Error Reports\";
                if (!Directory.Exists(errorDir))
                {
                    Directory.CreateDirectory(errorDir);
                }

                string filePath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\Error Reports\" +
                                    "Error Report " + DateTime.Now.ToString("MM-dd-yyyy hh-mm-ss") + ".txt";

                File.WriteAllText(filePath, msg);
            }
        }

        public class Settings
        {
            public static void InitializeSettings()
            {
                string fileName = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\Misc\XMLSettings.xml";
                XDocument document = XDocument.Load(fileName);
                var categories = document.Descendants("Category");
                foreach (XElement element in categories)
                {
                    SettingCategory settingCategory = new SettingCategory
                    {
                        Name = element.Attribute("name").Value
                    };
                    Debug.WriteLine("Creating Category: " + settingCategory.Name);
                    settingCategory.Entries = new List<SettingEntry> { };
                    var entries = element.Elements();
                    foreach (XElement setting in entries)
                    {
                        SettingEntry settingEntry = new SettingEntry
                        {
                            Name = setting.Element("Name").Value,
                            Type = setting.Element("Type").Value,
                            Value = setting.Element("Value").Value
                        };
                        settingCategory.Entries.Add(settingEntry);
                        string debug = String.Format("Name: {0}\nType: {1}\nValue: {2}", settingEntry.Name, settingEntry.Type, settingEntry.Value);
                        Debug.WriteLine(debug);
                    }
                    PublicVariables.Settings.Add(settingCategory);
                }
            }

            public static object FindSettingValue(string Category, string Setting)
            {
                foreach (SettingCategory category in PublicVariables.Settings)
                {
                    if (category.Name == Category)
                    {
                        foreach (SettingEntry entry in category.Entries)
                        {
                            if (entry.Name == Setting)
                            {
                                return (object)entry.Value;
                            }
                        }
                    }
                }
                return null;
            }
        }

        public class General
        {
            public static void InitializeCustomers()
            {
                try
                {
                    object WorkDir = Settings.FindSettingValue("General", "Working Directory");
                    string fileName = (string)WorkDir + @"\XMLCustomers.xml";
                    if (!File.Exists(fileName))
                    {
                        string source = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\Misc\XMLCustomers.xml";
                        File.Copy(source, fileName);
                        MessageBox.Show("Creating customers file in the active directory.");
                    }

                    XDocument Doc = XDocument.Load(fileName);
                    var Customers = Doc.Descendants("Customer");

                    foreach (XElement Customer in Customers)
                    {
                        Debug.WriteLine("====Initializing Customer====");
                        //Basic values and array setup
                        CustomerClass customer = new CustomerClass
                        {
                            Name = Customer.Element("Name").Value,
                            Category = Customer.Element("Category").Value,
                            Path = Customer.Element("Path").Value
                        };

                        string[] AddressArray = Customer.Element("Address").Value.Split(',');
                        List<Representative> RepArray = new List<Representative> { };
                        List<Job> JobArray = new List<Job> { };

                        //Address
                        customer.Address.AddressLine1 = AddressArray[0];
                        customer.Address.AddressLine2 = AddressArray[1];
                        customer.Address.City = AddressArray[2];
                        customer.Address.State = AddressArray[3];
                        customer.Address.Zip = AddressArray[4];
                        Debug.WriteLine("Name: " + customer.Name + "\nAddress Line 1: " + customer.Address.AddressLine1);

                        //Jobs
                        var XmlJobsArray = Customer.Element("Jobs").Elements();
                        Debug.WriteLine(String.Format("There are {0} job entries", XmlJobsArray.Count()));
                        foreach (XElement JobEntry in XmlJobsArray)
                        {
                            Debug.WriteLine("----Creating Job entry");
                            Job entry = new Job
                            {
                                Name = JobEntry.Element("Name").Value,
                                JobNumber = JobEntry.Element("JobNumber").Value,
                                Path = JobEntry.Element("Path").Value
                            };
                            Debug.WriteLine("Name: " + entry.Name);
                            entry.Representative.Name = JobEntry.Element("Representative").Element("Name").Value;
                            entry.Representative.Phone = JobEntry.Element("Representative").Element("Phone").Value;
                            entry.Representative.Email = JobEntry.Element("Representative").Element("Email").Value;
                            entry.Representative.Title = JobEntry.Element("Representative").Element("Title").Value;
                            Debug.WriteLine("Representative: " + entry.Representative.Name);

                            entry.Address.AddressLine1 = JobEntry.Element("Address").Element("AddressLine1").Value;
                            entry.Address.AddressLine2 = JobEntry.Element("Address").Element("AddressLine2").Value;
                            entry.Address.City = JobEntry.Element("Address").Element("City").Value;
                            entry.Address.State = JobEntry.Element("Address").Element("State").Value;
                            entry.Address.Zip = JobEntry.Element("Address").Element("Zip").Value;
                            Debug.WriteLine("Address: " + entry.Address.AddressLine1);

                            List<BillableItem> billableItems = new List<BillableItem> { };
                            foreach (XElement billItem in JobEntry.Element("BillableItems").Elements())
                            {
                                BillableItem billableItem = new BillableItem
                                {
                                    Name = billItem.Element("Name").Value,
                                    Amount = Convert.ToInt32(billItem.Element("Amount").Value),
                                    Price = Convert.ToInt32(billItem.Element("Price").Value)
                                };
                                billableItems.Add(billableItem);
                            }
                            Debug.WriteLine("Billable Items: " + billableItems.Count.ToString());
                            entry.Items = billableItems;
                            JobArray.Add(entry);
                        }
                        customer.Jobs = JobArray;

                        //Representatives
                        foreach (XElement Rep in Customers.Elements("Representatives").Elements())
                        {
                            Debug.WriteLine("----Adding Representative");
                            Representative RepClass = new Representative
                            {
                                Name = Rep.Element("Name").Value,
                                Phone = Rep.Element("Phone").Value,
                                Email = Rep.Element("Email").Value,
                                Title = Rep.Element("Title").Value
                            };
                            Debug.WriteLine(String.Format("Name: {0}\nTitle: {1}", RepClass.Name, RepClass.Title));
                            RepArray.Add(RepClass);
                        }
                        customer.Representatives = RepArray;

                        //Add Customer to CustomerList
                        PublicVariables.CustomerList.Add(customer);
                        Debug.WriteLine("====Customer Added to list successfully====\n");
                    }
                }
                catch (Exception e)
                {
                    string msgMB = "Error\r\nThere was error compiling the customers from the file. An error report has been generated and" +
                        " saved to the error reports folder. Please send this file to the creator of this program.";
                    string msgEr = msgMB + "\r\n" + e.ToString();
                    MessageBox.Show(msgMB, "CRITICAL ERROR");
                    Common.CreateErrorReport(msgEr);
                }
            }
        }

        public class UILists
        {
            public static bool UpdateCustomerList()
            {
                if (PublicVariables.CustomerList.Count == 0)
                {
                    throw new ArgumentException("The customer list was never populated. (error in Generals.UpdateCustomers?)", "original");
                }
                try
                {
                    var Customers = PublicVariables.CustomerList;
                    var CustomerPanel = PublicVariables.Container.Panel1;
                    if (CustomerPanel.Controls.Count > 0)
                    {
                        CustomerPanel.Controls.Clear();
                    }

                    int i = 0;
                    foreach (CustomerClass customer in Customers)
                    {
                        CustomerInformation UICard = new CustomerInformation();
                        UICard.lblTitle.Text = customer.Name;
                        UICard.Width = CustomerPanel.Width;
                        UICard.Location = new Point(0, (Common.GetPointUnderControl(UICard) * i));
                        UICard.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
                        CustomerPanel.Controls.Add(UICard);

                        i++;
                    }

                    return true;
                }
                catch (Exception e)
                {
                    string msgMB = "Error\r\nThere was error populating the customer list. An error report has been generated and" +
                        " saved to the error reports folder. Please send this file to the creator of this program.";
                    string msgEr = msgMB + "\r\n" + e.ToString();
                    MessageBox.Show(msgMB, "CRITICAL ERROR");
                    Common.CreateErrorReport(msgEr);
                    return false;
                }
            }
        }

        public class Modify
        {
            public static void AddRepToCustomer(Representative representative, CustomerClass customer, Panel panel, bool isModify = false)
            {
                if (isModify && customer.Name != "")
                {
                    //There is already an entry with this information in both the XML and variable. We just need to update it.
                    //Save rep to customer
                    Representative rep = representative;
                    customer.Representatives.Add(rep);

                    //Save the information to the file
                    object WorkDir = Settings.FindSettingValue("General", "Working Directory");
                    string fileName = (string)WorkDir + @"\XMLCustomers.xml";

                    XDocument doc = XDocument.Load(fileName);

                    foreach (XElement customerEntry in doc.Descendants("Customer"))
                    {
                        if (customerEntry.Element("Name").Value == customer.Name)
                        {
                            foreach (XElement oldRep in customerEntry.Elements("Representatives"))
                            {
                                if (oldRep.Element("Name").Value == representative.Name)
                                {
                                    oldRep.Element("Name").Value = representative.Name;
                                    oldRep.Element("Title").Value = representative.Title;
                                    oldRep.Element("Phone").Value = representative.Phone;
                                    oldRep.Element("Email").Value = representative.Email;
                                }

                            }
                        }
                    }

                    doc.Save(fileName);

                    //Update list with rep
                    var newCustomerInfo = PublicVariables.CustomerList.Where(i => i.Name == customer.Name).First();
                    var index = PublicVariables.CustomerList.IndexOf(newCustomerInfo);
                    if (index != -1)
                    {
                        PublicVariables.CustomerList[index] = customer;
                    }
                    UILists.UpdateCustomerList();

                    //Update panel
                    if (panel.Controls.Count > 0)
                    {
                        panel.Controls.Clear();
                    }
                    foreach (Representative repItem in customer.Representatives)
                    {
                        RepresentativeForm form = new RepresentativeForm();
                        form.lblName.Text = repItem.Name;
                        form.lblTitle.Text = repItem.Title;
                        form.Customer = customer;
                        form.Representative = representative;
                        form.Width = panel.Width;
                        form.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
                        form.Location = new Point(0, Common.GetPointUnderControl(form) + 1);
                        panel.Controls.Add(form);
                    }
                }
                else
                {
                    //No XML entry or variable contains this information (handled at a later time).
                    customer.Representatives.Add(representative);
                    //Update panel
                    if (panel.Controls.Count > 0)
                    {
                        panel.Controls.Clear();
                    }
                    int i = 0;
                    foreach (Representative repItem in customer.Representatives)
                    {
                        RepresentativeForm form = new RepresentativeForm();
                        form.lblName.Text = repItem.Name;
                        form.lblTitle.Text = repItem.Title;
                        form.Customer = customer;
                        form.Representative = representative;
                        form.Width = panel.Width;
                        form.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
                        form.Location = new Point(0, Common.GetPointUnderControl(form) * i);
                        panel.Controls.Add(form);
                    }
                }
            }
        }
    }
}