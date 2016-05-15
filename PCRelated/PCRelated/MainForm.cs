using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
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
        private List<ISerializable> _serializableList;
        private List<string> _filterList;
        private SaveFileDialog _saveDialog;
        private OpenFileDialog _openDialog;  

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

            _serializableList = new List<ISerializable>
            {
                new XmlSerialize(),
                new BinarySerialize(),
                new TextSerializer()
            };

            _filterList = new List<string>
            {
                "XML Files (*.xml)|*.xml|All Files(*.*)|*.*",
                "Binary Files (*.bin)|*bin|All Files (*.*)|*.*",
                "Text Files (*txt)|*.txt|All Files (*.*)|*.*"
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
                if (SerialazableBox.SelectedIndex != -1)
                {
                    SerialazebleButton.Enabled = true;
                }
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

        private void SerialazebleButton_Click(object sender, EventArgs e)
        {
            ISerializable newSerializer = _serializableList[SerialazableBox.SelectedIndex];
            _saveDialog = new SaveFileDialog();
            _saveDialog.Filter = _filterList[SerialazableBox.SelectedIndex];
            if (_saveDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream newFileStream = new FileStream(_saveDialog.FileName,FileMode.Create,FileAccess.ReadWrite);
                if (SerialazableBox.SelectedIndex == 0)
                {
                    XmlSerializableClass currentClass = new XmlSerializableClass();
                    currentClass.List = RelatedList;
                    newSerializer.Serialize(currentClass, _saveDialog.FileName, newFileStream);
                }
                else
                {
                    newSerializer.Serialize(RelatedList, _saveDialog.FileName, newFileStream);
                }
                newFileStream.Close();
            }
        }

        private void DeserialazebleButton_Click(object sender, EventArgs e)
        {
            ISerializable newSerializer = _serializableList[SerialazableBox.SelectedIndex];
            _openDialog = new OpenFileDialog();
            _openDialog.Filter = _filterList[SerialazableBox.SelectedIndex];
            if (_openDialog.ShowDialog() == DialogResult.OK)
            {   FileStream newFileStream = new FileStream(_openDialog.FileName,FileMode.Open,FileAccess.Read);
                if (SerialazableBox.SelectedIndex == 0)
                {
                    XmlSerializableClass newCurrentClass = new XmlSerializableClass();
                    newCurrentClass = (XmlSerializableClass) newSerializer.Deserialize(newFileStream);
                    RelatedList = newCurrentClass.List;
                }
                else
                {
                    RelatedList = (List<RelatedCommon>) newSerializer.Deserialize(newFileStream);
                }
                newFileStream.Close();
            }
            ListSwitcher.Enabled = true;
            ListSwitcher.Value = RelatedList.Count;
            DeleteButton.Enabled = true;
            SerialazebleButton.Enabled = true;
        }

        private void SerialazableBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((RelatedList.Count != 0) && SerialazableBox.SelectedIndex != -1)
            {
                SerialazebleButton.Enabled = true;
            }

            if (SerialazableBox.SelectedIndex != -1)
            {
                DeserialazebleButton.Enabled = true;
            }
        }
    }
}
