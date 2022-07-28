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
            this.chkShowTotal = new System.Windows.Forms.CheckBox();
            this.chkHidePlacement = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Controls.Add(this.chkDebug, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.chkTwoRows, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.chkHidePlacement, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkShowTotal, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 136);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // chkDebug
            // 
            this.chkDebug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDebug.AutoSize = true;
            this.chkDebug.Location = new System.Drawing.Point(3, 111);
            this.chkDebug.Name = "chkDebug";
            this.chkDebug.Size = new System.Drawing.Size(194, 17);
            this.chkDebug.TabIndex = 1;
            this.chkDebug.Text = "Show Debug Text";
            this.chkDebug.UseVisualStyleBackColor = true;
            // 
            // chkTwoRows
            // 
            this.chkTwoRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTwoRows.AutoSize = true;
            this.chkTwoRows.Location = new System.Drawing.Point(3, 78);
            this.chkTwoRows.Name = "chkTwoRows";
            this.chkTwoRows.Size = new System.Drawing.Size(194, 17);
            this.chkTwoRows.TabIndex = 0;
            this.chkTwoRows.Text = "Display Two  Rows";
            this.chkTwoRows.UseVisualStyleBackColor = true;
            // 
            // chkShowTotal
            // 
            this.chkShowTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShowTotal.AutoSize = true;
            this.chkShowTotal.Location = new System.Drawing.Point(3, 9);
            this.chkShowTotal.Name = "chkShowTotal";
            this.chkShowTotal.Size = new System.Drawing.Size(194, 17);
            this.chkShowTotal.TabIndex = 1;
            this.chkShowTotal.Text = "Show Total Places";
            this.chkShowTotal.UseVisualStyleBackColor = true;
            // 
            // chkHidePlacement
            // 
            this.chkHidePlacement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkHidePlacement.AutoSize = true;
            this.chkHidePlacement.Location = new System.Drawing.Point(3, 44);
            this.chkHidePlacement.Name = "chkHidePlacement";
            this.chkHidePlacement.Size = new System.Drawing.Size(194, 17);
            this.chkHidePlacement.TabIndex = 2;
            this.chkHidePlacement.Text = "Hide Placement On Skipped Split";
            this.chkHidePlacement.UseVisualStyleBackColor = true;
            // 
            // PacePlacementSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PacePlacementSettings";
            this.Size = new System.Drawing.Size(259, 145);
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
    }
}
