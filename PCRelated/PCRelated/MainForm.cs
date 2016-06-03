using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
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
        private bool IsCrypt {get; set; }
        List<DllList> DllList = new List<DllList>();
        private List<string> _decryptFilter;
        public List<PluginInterface.IPlugin> PluginsList;

        public MainForm()
        {

            InitializeComponent();
          /* string path = Directory.GetCurrentDirectory();
            string dllPath = path.Substring(0, path.Length - 10) + ("\\dll");
            string[] currentDlls = Directory.GetFiles(dllPath, "*.dll",SearchOption.AllDirectories);
            uint currentCountList = 1;
            while (currentCountList < currentDlls.Length)
            {
                DllList.Add(new DllList(currentDlls[currentCountList],Path.GetFileName(currentDlls[currentCountList])));
                DllItems.Items.Add(DllList[DllList.Count - 1].DllName.Remove(DllList[DllList.Count- 1].DllName.Length - 4));
                currentCountList += 2;
            }*/
            PluginsList = new List<PluginInterface.IPlugin>();
            string path = Directory.GetCurrentDirectory() + "\\plugins\\";
            PluginsList = LoadPlugins(path);
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

            _decryptFilter = new List<string>
            {
                "AES Files (*.aescrypt)|*.aescrypt|All Files(*.*)|*.*",
                "DES Files (*.descrypt)|*.descrypt|All Files(*.*)|*.*"
            };

            
        }

        private List<PluginInterface.IPlugin> LoadPlugins(string dir)
        {
            List<PluginInterface.IPlugin> PluginList = new List<PluginInterface.IPlugin>();
            PluginInterface.IPlugin plugin = null;
            try
            {
                foreach (var file in Directory.EnumerateFiles(dir, "*.dll", SearchOption.AllDirectories))
                {
                    Assembly asm = Assembly.LoadFrom(file);

                    foreach (Type t in asm.GetExportedTypes())
                    {
                        if (typeof(PluginInterface.IPlugin).IsAssignableFrom(t))
                        {
                            plugin = (PluginInterface.IPlugin)asm.CreateInstance(t.FullName);
                            PluginList.Add(plugin);
                            DllItems.Items.Add(plugin.GetType().Name);
                        }
                    }
                }
                return PluginList;
            }
            catch
            {
                MessageBox.Show(@"Ошибка при загрузке плагинов");
                return null;
            }
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
                if (SerializableBox.SelectedIndex != -1)
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
            ISerializable newSerializer = _serializableList[SerializableBox.SelectedIndex];
            _saveDialog = new SaveFileDialog();
            _saveDialog.Filter = _filterList[SerializableBox.SelectedIndex];
            if (_saveDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream newFileStream = new FileStream(_saveDialog.FileName, FileMode.Create, FileAccess.ReadWrite);
                if ((DllItems.SelectedIndex != -1) && (IsCrypt))
                {
                    foreach (PluginInterface.IPlugin plugin in PluginsList)
                    {
                        if (plugin.GetType().Name == DllItems.Text)
                        {
                            newSerializer = new Adapter(plugin);
                            newSerializer.Serialize(RelatedList, _saveDialog.FileName, newFileStream);
                            break;
                        }
                    }

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
            ISerializable newSerializer = _serializableList[SerializableBox.SelectedIndex];
            _openDialog = new OpenFileDialog();
            _openDialog.Filter = _filterList[SerializableBox.SelectedIndex];
            FileStream newFileStream;
            if (_openDialog.ShowDialog() == DialogResult.OK)
            {
                newFileStream = new FileStream(_openDialog.FileName, FileMode.Open, FileAccess.Read);
                if ((IsCrypt) && (DllItems.SelectedIndex != -1))
                {                  
                        foreach (PluginInterface.IPlugin plugin in PluginsList)
                        {
                            if (plugin.GetType().Name == DllItems.Text)
                            {
                            newSerializer = new Adapter(plugin);
                            RelatedList = (List<RelatedCommon>) newSerializer.Deserialize(newFileStream);
                            break;
                            }
                        }                                      
                }
                else
                {
                    try
                    { 
                        RelatedList = (List<RelatedCommon>) newSerializer.Deserialize(newFileStream);
                    }
                    finally
                    {
                        if (newFileStream != null)
                        {
                            newFileStream.Close();
                        }
                    }
                }


            }
            ListSwitcher.Enabled = true;
            ListSwitcher.Value = RelatedList.Count;
            DeleteButton.Enabled = true;
            SerialazebleButton.Enabled = true;
        }


        private void SerialazableBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((RelatedList.Count != 0) && SerializableBox.SelectedIndex != -1)
            {
                SerialazebleButton.Enabled = true; 
            }

            if (SerializableBox.SelectedIndex != -1)
            {
                DeserialazebleButton.Enabled = true;
                if (IsCrypt)
                {
                    DecryptButton.Enabled = true;
                    DllItems.Enabled = true;
                }
            }
        }


        private void CryptographyEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (!IsCrypt)
            {
                IsCrypt = true;
                if (SerializableBox.SelectedIndex != -1)
                {
                    DecryptButton.Enabled = true;
                    DllItems.Enabled = true;
                }
                
            }
            else
            {
                IsCrypt = false;
                DecryptButton.Enabled = false;
                DllItems.Enabled = false;
            }
        }


        private void DecryptButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog decryptFileDialog = new OpenFileDialog();
            decryptFileDialog.Filter = _decryptFilter[DllItems.SelectedIndex];
            PluginInterface.IPlugin necessaryPlugin = null;
            if ((decryptFileDialog.ShowDialog() == DialogResult.OK) && (DllItems.SelectedIndex != -1) && (IsCrypt))
            {
                foreach (PluginInterface.IPlugin plugin in PluginsList)
                {
                    if (plugin.GetType().Name == DllItems.Text)
                    {
                        necessaryPlugin = plugin;
                        break;
                    }
                }
                if (necessaryPlugin != null)
                {
                    necessaryPlugin.Decrypt(decryptFileDialog.FileName, SerializableBox.SelectedIndex);
                }
            }
        }
    }
}
