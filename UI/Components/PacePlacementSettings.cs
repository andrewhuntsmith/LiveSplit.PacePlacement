using System;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.UI.Components
{
    public partial class PacePlacementSettings : UserControl
    {
        public bool Display2Rows { get; set; }
        public bool ShowAllPlaces { get; set; }
        public bool ShowDebugText { get; set; }
        public bool HidePlacementOnSkip { get; set; }
        public string LabelText { get; set; }
        public LayoutMode Mode { get; set; }

        public PacePlacementSettings()
        {
            InitializeComponent();
            Display2Rows = false;
            ShowAllPlaces = true;
            ShowDebugText = false;
            LabelText = "Pace Placement";
        }

        private void PacePlacementSettings_Load(object sender, EventArgs e)
        {
            if (Mode == LayoutMode.Horizontal)
            {
                chkTwoRows.Enabled = false;
                chkTwoRows.DataBindings.Clear();
                chkTwoRows.Checked = true;
            }
            else
            {
                chkTwoRows.Enabled = true;
                chkTwoRows.DataBindings.Clear();
                chkTwoRows.DataBindings.Add("Checked", this, "Display2Rows", false, DataSourceUpdateMode.OnPropertyChanged);
            }

            chkShowTotal.Enabled = true;
            chkShowTotal.DataBindings.Clear();
            chkShowTotal.DataBindings.Add("Checked", this, "ShowAllPlaces", false, DataSourceUpdateMode.OnPropertyChanged);

            chkDebug.Enabled = true;
            chkDebug.DataBindings.Clear();
            chkDebug.DataBindings.Add("Checked", this, "ShowDebugText", false, DataSourceUpdateMode.OnPropertyChanged);

            chkHidePlacement.Enabled = true;
            chkHidePlacement.DataBindings.Clear();
            chkHidePlacement.DataBindings.Add("Checked", this, "HidePlacementOnSkip", false, DataSourceUpdateMode.OnPropertyChanged);

            txtLabelText.Enabled = true;
            txtLabelText.DataBindings.Clear();
            txtLabelText.DataBindings.Add("Text", this, "LabelText", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private int CreateSettingsNode(XmlDocument document, XmlElement parent)
        {
            return SettingsHelper.CreateSetting(document, parent, "Version", "1.0") ^
                SettingsHelper.CreateSetting(document, parent, "ShowAllPlaces", ShowAllPlaces) ^
                SettingsHelper.CreateSetting(document, parent, "Display2Rows", Display2Rows) ^
                SettingsHelper.CreateSetting(document, parent, "HidePlacementOnSkip", HidePlacementOnSkip) ^
                SettingsHelper.CreateSetting(document, parent, "LabelText", LabelText) ^
                SettingsHelper.CreateSetting(document, parent, "ShowDebugText", ShowDebugText);
        }

        public XmlNode GetSettings(XmlDocument document)
        {
            var parent = document.CreateElement("Settings");
            CreateSettingsNode(document, parent);
            return parent;
        }

        public int GetSettingsHashCode()
        {
            return CreateSettingsNode(null, null);
        }

        public void SetSettings(XmlNode node)
        {
            var element = (XmlElement)node;
            ShowAllPlaces = SettingsHelper.ParseBool(element["ShowAllPlaces"], true);
            Display2Rows = SettingsHelper.ParseBool(element["Display2Rows"], false);
            ShowDebugText = SettingsHelper.ParseBool(element["ShowDebugText"], false);
            HidePlacementOnSkip = SettingsHelper.ParseBool(element["HidePlacementOnSkip"], false);
            LabelText = SettingsHelper.ParseString(element["LabelText"], "Pace Placement");
        }
    }
}
