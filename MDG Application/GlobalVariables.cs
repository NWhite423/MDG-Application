using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MDG_Application.CreateDialogs;

namespace MDG_Application
{
    class ScopeOfWorkEntry
    {
        public string Entry { get; set; }
        public string Title { get; set; }
    }

    class ExspenseEntry
    {
        public string Entry { get; set; }
        public string Title { get; set; }
    }

    class PublicVariables
    {
        public static List<ScopeOfWorkEntry> SoWItems = new List<ScopeOfWorkEntry> { };
        public static List<ExspenseEntry> ExpenseItems = new List<ExspenseEntry> { };
    }

    class Functions
    {
        public static bool PopulateExpenseList(Panel panel, List<ExspenseEntry> Entries)
        {
            try
            {
                panel.Controls.Clear();
                int spacing = 151;
                int index = 0;
                foreach (ExspenseEntry Entry in Entries)
                {
                    EntryItem SoWItem = new EntryItem();
                    SoWItem.Title = Entry.Title;
                    SoWItem.Item = Entry.Entry;
                    SoWItem.Index = index;
                    SoWItem.Concern = 1;
                    SoWItem.Location = new Point(0, (spacing * index));
                    panel.Controls.Add(SoWItem);
                    if (index == 0)
                    {
                        SoWItem.UpArrowEnabled = false;
                    }
                    if (index == Entries.Count - 1)
                    {
                        SoWItem.DownArrowEnabled = false;
                    }
                    index++;
                }

                return true;
            }
            catch (Exception ex)
            {
                if (!Directory.Exists("Error reports"))
                {
                    Directory.CreateDirectory("Error reports");
                }
                string errorDate = DateTime.Now.ToString("MM-dd-yyyy H-mm-ss");

                File.WriteAllText(@"Error reports\Report " + errorDate + ".txt", ex.ToString());
                MessageBox.Show("ERROR:\nAn issue has occured when populating the SoW list. An error report has been created.");
                return false;
            }
        }

        public static bool PopulateSoWList(Panel panel, List<ScopeOfWorkEntry> Entries)
        {
            try
            {
                if (panel == CreateContractAgreement.PanelSoW)
                {
                    panel.Controls.Clear();
                    int spacing = 151;
                    int index = 0;
                    foreach (ScopeOfWorkEntry Entry in Entries)
                    {
                        EntryItem SoWItem = new EntryItem();
                        SoWItem.Title = Entry.Title;
                        SoWItem.Item = Entry.Entry;
                        SoWItem.Index = index;
                        SoWItem.Concern = 0;
                        SoWItem.Location = new Point(0, (spacing * index));
                        panel.Controls.Add(SoWItem);
                        if (index == 0)
                        {
                            SoWItem.UpArrowEnabled = false;
                        }
                        if (index == Entries.Count - 1)
                        {
                            SoWItem.DownArrowEnabled = false;
                        }
                        index++;
                    }
                } else
                {
                    panel.Controls.Clear();
                    int spacing = 151;
                    int index = 0;
                    foreach (ScopeOfWorkEntry Entry in Entries)
                    {
                        EntryItem SoWItem = new EntryItem();
                        SoWItem.Title = Entry.Title;
                        SoWItem.Item = Entry.Entry;
                        SoWItem.Index = index;
                        SoWItem.Concern = 1;
                        SoWItem.Location = new Point(0, (spacing * index));
                        panel.Controls.Add(SoWItem);
                        if (index == 0)
                        {
                            SoWItem.UpArrowEnabled = false;
                        }
                        if (index == Entries.Count - 1)
                        {
                            SoWItem.DownArrowEnabled = false;
                        }
                        index++;
                    }
                }
                
                return true;
            }
            catch (Exception ex)
            {
                if (!Directory.Exists("Error reports"))
                {
                    Directory.CreateDirectory("Error reports");
                }
                string errorDate = DateTime.Now.ToString("MM-dd-yyyy H-mm-ss");

                File.WriteAllText(@"Error reports\Report " + errorDate + ".txt", ex.ToString());
                MessageBox.Show("ERROR:\nAn issue has occured when populating the SoW list. An error report has been created.");
                return false;
            }
        }
    }
}
