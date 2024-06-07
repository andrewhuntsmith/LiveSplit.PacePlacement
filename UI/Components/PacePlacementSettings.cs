using System;
using System.Drawing;
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
        public bool UseDefaultColorForName { get; set; }
        public Color NameColor { get; set; }
        public bool UseDefaultColorForValue { get; set; }
        public Color ValueColor { get; set; }

        public PacePlacementSettings()
        {
            InitializeComponent();
            Display2Rows = false;
            ShowAllPlaces = true;
            ShowDebugText = false;
            LabelText = "Pace Placement";
            NameColor = Color.White;
            ValueColor = Color.White;
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

            clrNameButton.Enabled = true;
            clrNameButton.DataBindings.Clear();
            clrNameButton.DataBindings.Add("BackColor", this, "NameColor", false, DataSourceUpdateMode.OnPropertyChanged);

            clrValueButton.Enabled = true;
            clrValueButton.DataBindings.Clear();
            clrValueButton.DataBindings.Add("BackColor", this, "ValueColor", false, DataSourceUpdateMode.OnPropertyChanged);

            chkDefaultLabelColor.Enabled = true;
            chkDefaultLabelColor.DataBindings.Clear();
            chkDefaultLabelColor.DataBindings.Add("Checked", this, "UseDefaultColorForName", false, DataSourceUpdateMode.OnPropertyChanged);

            chkDefaultValueColor.Enabled = true;
            chkDefaultValueColor.DataBindings.Clear();
            chkDefaultValueColor.DataBindings.Add("Checked", this, "UseDefaultColorForValue", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private int CreateSettingsNode(XmlDocument document, XmlElement parent)
        {
            return SettingsHelper.CreateSetting(document, parent, "Version", "1.0") ^
                SettingsHelper.CreateSetting(document, parent, "ShowAllPlaces", ShowAllPlaces) ^
                SettingsHelper.CreateSetting(document, parent, "Display2Rows", Display2Rows) ^
                SettingsHelper.CreateSetting(document, parent, "HidePlacementOnSkip", HidePlacementOnSkip) ^
                SettingsHelper.CreateSetting(document, parent, "LabelText", LabelText) ^
                SettingsHelper.CreateSetting(document, parent, "ShowDebugText", ShowDebugText) ^
                SettingsHelper.CreateSetting(document, parent, "UseDefaultColorForName", UseDefaultColorForName) ^
                SettingsHelper.CreateSetting(document, parent, "NameColor", NameColor) ^
                SettingsHelper.CreateSetting(document, parent, "UseDefaultColorForValue", UseDefaultColorForValue) ^
                SettingsHelper.CreateSetting(document, parent, "ValueColor", ValueColor);
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
            UseDefaultColorForName = SettingsHelper.ParseBool(element["UseDefaultColorForName"], true);
            NameColor = SettingsHelper.ParseColor(element["NameColor"], Color.White);
            UseDefaultColorForValue = SettingsHelper.ParseBool(element["UseDefaultColorForValue"], true);
            ValueColor = SettingsHelper.ParseColor(element["ValueColor"], Color.White);
        }

        private void clrNameButton_Click(object sender, EventArgs e)
        {
            var colorDlg = new ColorDialog();
            colorDlg.AnyColor = true;
            colorDlg.SolidColorOnly = false;
            colorDlg.Color = clrNameButton.BackColor;
            colorDlg.AllowFullOpen = true;
            
            if (colorDlg.ShowDialog() == DialogResult.OK)
                clrNameButton.BackColor = colorDlg.Color;
        }

        private void clrValueButton_Click(object sender, EventArgs e)
        {
            var colorDlg = new ColorDialog();
            colorDlg.AnyColor = true;
            colorDlg.SolidColorOnly = false;
            colorDlg.Color = clrValueButton.BackColor;
            colorDlg.AllowFullOpen = true;

            if (colorDlg.ShowDialog() == DialogResult.OK)
                clrValueButton.BackColor = colorDlg.Color;
        }

        private void chkDefaultLabelColor_CheckedChanged(object sender, EventArgs e)
        {
            clrNameButton.Enabled = !chkDefaultLabelColor.Checked;
        }

        private void chkDefaultValueColor_CheckedChanged(object sender, EventArgs e)
        {
            clrValueButton.Enabled = !chkDefaultValueColor.Checked;
        }
    }
}
