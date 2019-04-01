using Zentropy.Model;
using Zentropy.ViewModel;
using Microsoft.VisualBasic;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Zentropy.View
{
    public partial class FormEngineManagement : Form
    {
        #region Fields

        private EngineList _engineList;
        #endregion

        #region Events

        public event Action EngineSelected;

        #endregion

        #region Constructors

        public FormEngineManagement(EngineList engineList)
        {
            InitializeComponent();
            LoadInfo();
            _listBoxSettings.SetDoubleBuffered();
            _engineList = engineList;
            UpdateUI(_engineList.SelectedIndex);
        }

        #endregion

        #region Event Methods
        private void OnButtonApplyClick(object sender, EventArgs e)
        {
            if (_engineList.SettingAvailable)
            {
                EngineSetting setting = _engineList.Settings[_listBoxSettings.SelectedIndex];
                string name = _textBoxName.Text;

                if (string.IsNullOrWhiteSpace(name))
                {
                    return;
                }

                bool nameChanged = name != setting.Name;

                if (nameChanged && _listBoxSettings.Items.Contains(name))
                {
                    MessageBox.Show(this, "Setting with this name already exists.", "Zentropy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (nameChanged)
                {
                    setting.Name = name;
                }

                setting.ExecutablePath = _comboBoxExePath.Text;
                setting.LogoPath = _comboBoxLogoPath.Text;
                setting.UciOptions = _textBoxUciOptions.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

                _engineList.TryAddExePath(setting.ExecutablePath);
                _engineList.TryAddLogoPath(setting.LogoPath);
                EngineSelected?.Invoke();
                UpdateUI(_listBoxSettings.SelectedIndex);
            }
        }
				
        private void OnButtonOkClick(object sender, EventArgs e)
        {
            if (_engineList.SettingAvailable)
            {
                EngineSetting setting = _engineList.Settings[_listBoxSettings.SelectedIndex];
                string name = _textBoxName.Text;

                if (string.IsNullOrWhiteSpace(name))
                {
                    return;
                }

                bool nameChanged = name != setting.Name;

                if (nameChanged && _listBoxSettings.Items.Contains(name))
                {
                    MessageBox.Show(this, "Setting with this name already exists.", "Zentropy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (nameChanged)
                {
                    setting.Name = name;
                }

            setting.ExecutablePath = _comboBoxExePath.Text;
            setting.LogoPath = _comboBoxLogoPath.Text;
            setting.UciOptions = _textBoxUciOptions.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            _engineList.TryAddExePath(setting.ExecutablePath);
            _engineList.TryAddLogoPath(setting.LogoPath);
            EngineSelected?.Invoke();
            UpdateUI(_listBoxSettings.SelectedIndex);
            Close();				
            }
        }

        private void OnButtonCancelClick(object sender, EventArgs e)
        {
            Close();
        }

        private void OnButtonAddNewClick(object sender, EventArgs e)
        {
            EngineSetting setting = new EngineSetting();
            string name = _textBoxName.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                return;
            }

            bool warn = false;

            while (_listBoxSettings.Items.Contains(name))
            {
                if (warn)
                {
                    MessageBox.Show(this, "Setting with this name already exists.", "Zentropy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    warn = true;
                }

                string input = Interaction.InputBox("Enter new name for setting:", "Zentropy - Setting name");

                if (string.IsNullOrWhiteSpace(input))
                {
                    return;
                }
                else
                {
                    name = input;
                }
            }

            setting.Name = name;
            setting.ExecutablePath = _comboBoxExePath.Text;
            setting.LogoPath = _comboBoxLogoPath.Text;
            setting.UciOptions = _textBoxUciOptions.Text.Split('\n');

            _engineList.TryAddExePath(setting.ExecutablePath);
            _engineList.TryAddLogoPath(setting.LogoPath);
            _engineList.Settings.Add(setting);

            UpdateUI(_listBoxSettings.SelectedIndex);

            _listBoxSettings.SelectedIndex = _listBoxSettings.Items.Count - 1;
        }

        private void OnButtonRemoveClick(object sender, EventArgs e)
        {
            if (!_engineList.SettingAvailable)
            {
                return;
            }

            int selected = _listBoxSettings.SelectedIndex;

            _engineList.Settings.RemoveAt(selected);

            if (_engineList.SelectedIndex == selected)
            {
                _engineList.SelectedIndex = 0;
            }

            if (_engineList.SelectedOpponentIndex == selected)
            {
                _engineList.SelectedOpponentIndex = 0;
            }

            EngineSelected?.Invoke();

            UpdateUI(_listBoxSettings.SelectedIndex);

            if (selected - 1 >= 0)
            {
                _listBoxSettings.SelectedIndex = selected - 1;
            }
        }

        private void OnListBoxSettingsSelectedIndexChanged(object sender, EventArgs e)
        {
            if (_listBoxSettings.SelectedIndex != -1)
            {
                OpenEngineConfig(_listBoxSettings.SelectedIndex);
            }
        }

        private void OnComboBoxEngine1SelectedIndexChanged(object sender, EventArgs e)
        {
            _engineList.SelectedIndex = _comboBoxEngine1.SelectedIndex;
            EngineSelected?.Invoke();
        }

        private void OnComboBoxEngine2SelectedIndexChanged(object sender, EventArgs e)
        {
            _engineList.SelectedOpponentIndex = _comboBoxEngine2.SelectedIndex;
            EngineSelected?.Invoke();
        }

        private void OnButtonExePathDialogClick(object sender, EventArgs e)
        {
            string initialDirectory = null;

            for (int i = 0; i < SerializedInfo.Instance.EngineList.LastExePaths.Count; i++)
            {
                string path = SerializedInfo.Instance.EngineList.LastExePaths[i];

                if (File.Exists(path))
                {
                    FileInfo fileInfo = new FileInfo(path);
                    initialDirectory = fileInfo.Directory.FullName;
                    break;
                }
                else if (Directory.Exists(path))
                {
                    initialDirectory = path;
                    break;
                }
            }

            OpenFileDialog fileDialog = new OpenFileDialog();

            if (initialDirectory != null)
            {
                fileDialog.InitialDirectory = initialDirectory;
            }

            fileDialog.Filter = "Executable files (*.exe)|*.exe|All files (*.*)|*.*";
            fileDialog.Multiselect = false;
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                _comboBoxExePath.Text = fileDialog.FileName;
            }
        }
        private void OnButtonLogoPathDialogClick(object sender, EventArgs e)
        {
            string initialDirectory = null;

            for (int i = 0; i < SerializedInfo.Instance.EngineList.LastLogoPaths.Count; i++)
            {
                string path = SerializedInfo.Instance.EngineList.LastLogoPaths[i];

                if (File.Exists(path))
                {
                    FileInfo fileInfo = new FileInfo(path);
                    initialDirectory = fileInfo.Directory.FullName;
                    break;
                }
                else if (Directory.Exists(path))
                {
                    initialDirectory = path;
                    break;
                }
            }

            OpenFileDialog fileDialog = new OpenFileDialog();

            if (initialDirectory != null)
            {
                fileDialog.InitialDirectory = initialDirectory;
            }

            fileDialog.Filter = "Bitmap files (*.bmp)|*.bmp|All files (*.*)|*.*";
            fileDialog.Multiselect = false;
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                _comboBoxLogoPath.Text = fileDialog.FileName;
            }
        }
        #endregion

        #region Other Methods

        private void OpenEngineConfig(int index)
        {
            EngineSetting setting = _engineList.Settings[index];

            _textBoxName.Text = setting.Name;
            _textBoxUciOptions.Text = string.Join(Environment.NewLine, setting.UciOptions);
            _comboBoxExePath.Text = setting.ExecutablePath;
            _comboBoxLogoPath.Text = setting.LogoPath;
        }

        private void UpdateUI(int initialSelect)
        {
            _listBoxSettings.Items.Clear();
            _comboBoxEngine1.Items.Clear();
            _comboBoxEngine2.Items.Clear();
            _comboBoxExePath.Items.Clear();
            _comboBoxLogoPath.Items.Clear();

            for (int i = 0; i < _engineList.LastExePaths.Count; i++)
            {
                _comboBoxExePath.Items.Insert(0, _engineList.LastExePaths[i]);
            }

            for (int i = 0; i < _engineList.LastLogoPaths.Count; i++)
            {
                _comboBoxLogoPath.Items.Insert(0, _engineList.LastLogoPaths[i]);
            }

            for (int i = 0; i < _engineList.Settings.Count; i++)
            {
                _listBoxSettings.Items.Add(_engineList.Settings[i].Name);

                _comboBoxEngine1.Items.Add(_engineList.Settings[i].Name);
                _comboBoxEngine2.Items.Add(_engineList.Settings[i].Name);
            }

            if (initialSelect != -1 && _listBoxSettings.Items.Count > 0)
            {
                if(initialSelect >= _listBoxSettings.Items.Count)
                {
                    initialSelect = _listBoxSettings.Items.Count - 1;
                }

                _listBoxSettings.SelectedIndex = initialSelect;
                OpenEngineConfig(initialSelect);
            }

            TrySelect(_comboBoxEngine1, _engineList.SelectedIndex);
            TrySelect(_comboBoxEngine2, _engineList.SelectedOpponentIndex);
        }

        private void TrySelect(ComboBox comboBox, int selectedIndex)
        {
            if (comboBox.Items.Count > 0)
            {
                if (selectedIndex < comboBox.Items.Count && selectedIndex >= 0)
                {
                    comboBox.SelectedIndex = selectedIndex;
                }
                else
                {
                    comboBox.SelectedIndex = 0;
                }
            }
        }

        private void OnFormEngineManagementClosing(object sender, FormClosingEventArgs e)
        {
            SerializeInfo();
        }

        private void SerializeInfo()
        {
            try
            {
                Int32.TryParse(_textBoxMultiPv.Text, out int x);
                SerializedInfo.Instance.MultiPv = x;
                XmlSerializer serializer = new XmlSerializer(typeof(SerializedInfo));
                FileStream fileStream = new FileStream(FormMainViewModel.ConfigurationFileName, FileMode.Create);
                serializer.Serialize(fileStream, SerializedInfo.Instance);
                fileStream.Dispose();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
        }

        private void LoadInfo()
        {
            _textBoxMultiPv.Text = SerializedInfo.Instance.MultiPv.ToString();
        }
        #endregion
    }
}
