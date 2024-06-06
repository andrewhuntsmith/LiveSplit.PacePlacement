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
            this.chkDebug = new System.Windows.Forms.CheckBox();
            this.chkTwoRows = new System.Windows.Forms.CheckBox();
            this.chkHidePlacement = new System.Windows.Forms.CheckBox();
            this.chkShowTotal = new System.Windows.Forms.CheckBox();
            this.txtLabelText = new System.Windows.Forms.TextBox();
            this.lblLabelText = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 312F));
            this.tableLayoutPanel1.Controls.Add(this.chkDebug, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.chkTwoRows, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.chkHidePlacement, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkShowTotal, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtLabelText, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblLabelText, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(412, 199);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // chkDebug
            // 
            this.chkDebug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDebug.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.chkDebug, 2);
            this.chkDebug.Location = new System.Drawing.Point(3, 128);
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
            this.chkTwoRows.Location = new System.Drawing.Point(3, 89);
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
            this.chkHidePlacement.Location = new System.Drawing.Point(3, 50);
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
            this.chkShowTotal.Location = new System.Drawing.Point(3, 11);
            this.chkShowTotal.Name = "chkShowTotal";
            this.chkShowTotal.Size = new System.Drawing.Size(406, 17);
            this.chkShowTotal.TabIndex = 1;
            this.chkShowTotal.Text = "Show Total Places";
            this.chkShowTotal.UseVisualStyleBackColor = true;
            // 
            // txtLabelText
            // 
            this.txtLabelText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtLabelText.Location = new System.Drawing.Point(103, 167);
            this.txtLabelText.Name = "txtLabelText";
            this.txtLabelText.Size = new System.Drawing.Size(306, 20);
            this.txtLabelText.TabIndex = 1;
            this.txtLabelText.Text = "Pace Placement";
            // 
            // lblLabelText
            // 
            this.lblLabelText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLabelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelText.Location = new System.Drawing.Point(25, 167);
            this.lblLabelText.Name = "lblLabelText";
            this.lblLabelText.Size = new System.Drawing.Size(72, 20);
            this.lblLabelText.TabIndex = 1;
            this.lblLabelText.Text = "Label Text";
            this.lblLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PacePlacementSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PacePlacementSettings";
            this.Size = new System.Drawing.Size(415, 232);
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
    }
}
