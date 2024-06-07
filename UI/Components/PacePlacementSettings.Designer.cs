namespace LiveSplit.UI.Components
{
    partial class PacePlacementSettings
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.chkDebug = new System.Windows.Forms.CheckBox();
            this.chkTwoRows = new System.Windows.Forms.CheckBox();
            this.chkHidePlacement = new System.Windows.Forms.CheckBox();
            this.chkShowTotal = new System.Windows.Forms.CheckBox();
            this.txtLabelText = new System.Windows.Forms.TextBox();
            this.lblLabelText = new System.Windows.Forms.Label();
            this.clrNameButton = new System.Windows.Forms.Button();
            this.lblLabelColor = new System.Windows.Forms.Label();
            this.clrValueButton = new System.Windows.Forms.Button();
            this.chkDefaultLabelColor = new System.Windows.Forms.CheckBox();
            this.chkDefaultValueColor = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 312F));
            this.tableLayoutPanel1.Controls.Add(this.chkDefaultLabelColor, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.chkTwoRows, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.chkHidePlacement, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkShowTotal, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtLabelText, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblLabelText, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.clrValueButton, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblLabelColor, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.clrNameButton, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.chkDebug, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.chkDefaultValueColor, 0, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(412, 254);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Place Color";
            // 
            // chkDebug
            // 
            this.chkDebug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDebug.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.chkDebug, 2);
            this.chkDebug.Location = new System.Drawing.Point(3, 82);
            this.chkDebug.Name = "chkDebug";
            this.chkDebug.Size = new System.Drawing.Size(406, 17);
            this.chkDebug.TabIndex = 1;
            this.chkDebug.Text = "Show Debug Text";
            this.chkDebug.UseVisualStyleBackColor = true;
            // 
            // chkTwoRows
            // 
            this.chkTwoRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTwoRows.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.chkTwoRows, 2);
            this.chkTwoRows.Location = new System.Drawing.Point(3, 56);
            this.chkTwoRows.Name = "chkTwoRows";
            this.chkTwoRows.Size = new System.Drawing.Size(406, 17);
            this.chkTwoRows.TabIndex = 0;
            this.chkTwoRows.Text = "Display Two  Rows";
            this.chkTwoRows.UseVisualStyleBackColor = true;
            // 
            // chkHidePlacement
            // 
            this.chkHidePlacement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkHidePlacement.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.chkHidePlacement, 2);
            this.chkHidePlacement.Location = new System.Drawing.Point(3, 30);
            this.chkHidePlacement.Name = "chkHidePlacement";
            this.chkHidePlacement.Size = new System.Drawing.Size(406, 17);
            this.chkHidePlacement.TabIndex = 2;
            this.chkHidePlacement.Text = "Hide Placement On Skipped Split";
            this.chkHidePlacement.UseVisualStyleBackColor = true;
            // 
            // chkShowTotal
            // 
            this.chkShowTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShowTotal.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.chkShowTotal, 2);
            this.chkShowTotal.Location = new System.Drawing.Point(3, 4);
            this.chkShowTotal.Name = "chkShowTotal";
            this.chkShowTotal.Size = new System.Drawing.Size(406, 17);
            this.chkShowTotal.TabIndex = 1;
            this.chkShowTotal.Text = "Show Total Places";
            this.chkShowTotal.UseVisualStyleBackColor = true;
            // 
            // txtLabelText
            // 
            this.txtLabelText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtLabelText.Location = new System.Drawing.Point(103, 107);
            this.txtLabelText.Name = "txtLabelText";
            this.txtLabelText.Size = new System.Drawing.Size(306, 20);
            this.txtLabelText.TabIndex = 1;
            this.txtLabelText.Text = "Pace Placement";
            // 
            // lblLabelText
            // 
            this.lblLabelText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLabelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelText.Location = new System.Drawing.Point(25, 109);
            this.lblLabelText.Name = "lblLabelText";
            this.lblLabelText.Size = new System.Drawing.Size(72, 16);
            this.lblLabelText.TabIndex = 1;
            this.lblLabelText.Text = "Label Text";
            this.lblLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // clrNameButton
            // 
            this.clrNameButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.clrNameButton.BackColor = System.Drawing.SystemColors.Control;
            this.clrNameButton.Location = new System.Drawing.Point(103, 159);
            this.clrNameButton.Name = "clrNameButton";
            this.clrNameButton.Size = new System.Drawing.Size(30, 30);
            this.clrNameButton.TabIndex = 3;
            this.clrNameButton.UseVisualStyleBackColor = false;
            this.clrNameButton.Click += new System.EventHandler(this.clrNameButton_Click);
            // 
            // lblLabelColor
            // 
            this.lblLabelColor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLabelColor.AutoSize = true;
            this.lblLabelColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelColor.Location = new System.Drawing.Point(26, 167);
            this.lblLabelColor.Name = "lblLabelColor";
            this.lblLabelColor.Size = new System.Drawing.Size(71, 13);
            this.lblLabelColor.TabIndex = 4;
            this.lblLabelColor.Text = "Label Color";
            // 
            // clrValueButton
            // 
            this.clrValueButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.clrValueButton.BackColor = System.Drawing.SystemColors.Control;
            this.clrValueButton.Location = new System.Drawing.Point(103, 221);
            this.clrValueButton.Name = "clrValueButton";
            this.clrValueButton.Size = new System.Drawing.Size(30, 30);
            this.clrValueButton.TabIndex = 5;
            this.clrValueButton.UseVisualStyleBackColor = false;
            this.clrValueButton.Click += new System.EventHandler(this.clrValueButton_Click);
            // 
            // chkDefaultLabelColor
            // 
            this.chkDefaultLabelColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDefaultLabelColor.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.chkDefaultLabelColor, 2);
            this.chkDefaultLabelColor.Location = new System.Drawing.Point(3, 134);
            this.chkDefaultLabelColor.Name = "chkDefaultLabelColor";
            this.chkDefaultLabelColor.Size = new System.Drawing.Size(406, 17);
            this.chkDefaultLabelColor.TabIndex = 7;
            this.chkDefaultLabelColor.Text = "Use default text color for Label";
            this.chkDefaultLabelColor.UseVisualStyleBackColor = true;
            this.chkDefaultLabelColor.CheckedChanged += new System.EventHandler(this.chkDefaultLabelColor_CheckedChanged);
            // 
            // chkDefaultValueColor
            // 
            this.chkDefaultValueColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDefaultValueColor.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.chkDefaultValueColor, 2);
            this.chkDefaultValueColor.Location = new System.Drawing.Point(3, 196);
            this.chkDefaultValueColor.Name = "chkDefaultValueColor";
            this.chkDefaultValueColor.Size = new System.Drawing.Size(406, 17);
            this.chkDefaultValueColor.TabIndex = 8;
            this.chkDefaultValueColor.Text = "Use default text color for Place";
            this.chkDefaultValueColor.UseVisualStyleBackColor = true;
            this.chkDefaultValueColor.CheckedChanged += new System.EventHandler(this.chkDefaultValueColor_CheckedChanged);
            // 
            // PacePlacementSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PacePlacementSettings";
            this.Size = new System.Drawing.Size(415, 270);
            this.Load += new System.EventHandler(this.PacePlacementSettings_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox chkTwoRows;
        private System.Windows.Forms.CheckBox chkShowTotal;
        private System.Windows.Forms.CheckBox chkDebug;
        private System.Windows.Forms.CheckBox chkHidePlacement;
        private System.Windows.Forms.TextBox txtLabelText;
        private System.Windows.Forms.Label lblLabelText;
        private System.Windows.Forms.Button clrNameButton;
        private System.Windows.Forms.Label lblLabelColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clrValueButton;
        private System.Windows.Forms.CheckBox chkDefaultLabelColor;
        private System.Windows.Forms.CheckBox chkDefaultValueColor;
    }
}
