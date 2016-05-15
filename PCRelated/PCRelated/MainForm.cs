using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCRelated.CurrentClasses;
using PCRelated.WorkClasses;

namespace PCRelated
{
    public partial class MainForm : Form
    {
        private List<IAddingList> _addingList;
        private IAddingList NewAddingRelated { get; set; }
        public RelatedCommon NewRelated { get; set; }
        public List<RelatedCommon> RelatedList = new List<RelatedCommon>(); 

        public MainForm()
        {
            InitializeComponent();

            _addingList = new List<IAddingList>
            {
                new AddKeyboard(),
                new AddMouse(),
                new AddPrinter(),
                new AddMfp(),
                new AddMonitor(),
                new AddKit()
            };
        }



        private void RelatedBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RelatedBox.SelectedIndex != -1)
            {
                AddButton.Enabled = true;
            }
            NewAddingRelated = _addingList[RelatedBox.SelectedIndex];
            NewRelated = NewAddingRelated.AddList();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            RelatedList.Add(NewRelated);
            ListSwitcher.Value = RelatedList.Count;
            if (RelatedList.Count != 0)
            {
                DeleteButton.Enabled = true;
            }
            if (RelatedList.Count > 1)
            {
                ListSwitcher.Enabled = true;
            }
        }

        private void ListSwitcher_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                PropertyDataGrid.SelectedObject = RelatedList[(int) (ListSwitcher.Value - 1)];
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show(@"Выход за пределы значения списка");
                if (((ListSwitcher.Value) != RelatedList.Count))
                {
                    ListSwitcher.Value = RelatedList.Count;
                }
                else
                {
                    if (ListSwitcher.Value != 0)
                    {
                        ListSwitcher.Value--;
                    }
                    else
                    {
                        ListSwitcher.Value++;
                    }
                }
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            RelatedList.RemoveAt((int) ListSwitcher.Value - 1);
            switch ((int) ListSwitcher.Value)
            {
                case 1:
                {
                    if (RelatedList.Count == 0)
                    {
                        PropertyDataGrid.SelectedObject = null; 
                        
                        DeleteButton.Enabled = false; 
                    }
                    else
                    {
                        PropertyDataGrid.SelectedObject = RelatedList[0];
                        ListSwitcher.Enabled = false;
                    }   
                    
                    break;
                }
                default:
                {
                    if ((ListSwitcher.Value - 1) <= RelatedList.Count)
                    {
                        ListSwitcher.Value--;
                    }
                    break;
                }

                   
            } 
          
        }  


    }
}
