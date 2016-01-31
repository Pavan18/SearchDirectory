namespace Search_Directory
{
    partial class SearchDirectory
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchDirectory));
            this.lblExtension = new System.Windows.Forms.Label();
            this.txtFoler = new System.Windows.Forms.TextBox();
            this.lblDirectory = new System.Windows.Forms.Label();
            this.cboDirectory = new System.Windows.Forms.ComboBox();
            this.lstFoundFiles = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.chkLookinAll = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.Location = new System.Drawing.Point(14, 18);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(91, 13);
            this.lblExtension.TabIndex = 0;
            this.lblExtension.Text = "Search for folder :";
            // 
            // txtFoler
            // 
            this.txtFoler.Location = new System.Drawing.Point(17, 43);
            this.txtFoler.Name = "txtFoler";
            this.txtFoler.Size = new System.Drawing.Size(166, 20);
            this.txtFoler.TabIndex = 1;
            this.txtFoler.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtExtension_KeyDown);
            // 
            // lblDirectory
            // 
            this.lblDirectory.AutoSize = true;
            this.lblDirectory.Location = new System.Drawing.Point(14, 122);
            this.lblDirectory.Name = "lblDirectory";
            this.lblDirectory.Size = new System.Drawing.Size(113, 13);
            this.lblDirectory.TabIndex = 2;
            this.lblDirectory.Text = "Look in Logical Drive :";
            // 
            // cboDirectory
            // 
            this.cboDirectory.FormattingEnabled = true;
            this.cboDirectory.Location = new System.Drawing.Point(13, 148);
            this.cboDirectory.Name = "cboDirectory";
            this.cboDirectory.Size = new System.Drawing.Size(170, 21);
            this.cboDirectory.TabIndex = 3;
            this.cboDirectory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboDirectory_KeyDown);
            // 
            // lstFoundFiles
            // 
            this.lstFoundFiles.FormattingEnabled = true;
            this.lstFoundFiles.Location = new System.Drawing.Point(256, 18);
            this.lstFoundFiles.Name = "lstFoundFiles";
            this.lstFoundFiles.Size = new System.Drawing.Size(546, 251);
            this.lstFoundFiles.TabIndex = 5;
            this.lstFoundFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstFoundFiles_KeyDoubleClick);
            this.lstFoundFiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstFoundFiles_MouseDoubleClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(727, 293);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // chkLookinAll
            // 
            this.chkLookinAll.AutoSize = true;
            this.chkLookinAll.Location = new System.Drawing.Point(13, 175);
            this.chkLookinAll.Name = "chkLookinAll";
            this.chkLookinAll.Size = new System.Drawing.Size(160, 17);
            this.chkLookinAll.TabIndex = 4;
            this.chkLookinAll.Text = "Look in all Active Directories";
            this.chkLookinAll.UseVisualStyleBackColor = true;
            this.chkLookinAll.CheckedChanged += new System.EventHandler(this.chkLookinAll_CheckedChanged);
            this.chkLookinAll.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkLookinAll_KeyDown);
            // 
            // SearchDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 338);
            this.Controls.Add(this.chkLookinAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lstFoundFiles);
            this.Controls.Add(this.cboDirectory);
            this.Controls.Add(this.lblDirectory);
            this.Controls.Add(this.txtFoler);
            this.Controls.Add(this.lblExtension);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchDirectory";
            this.Text = "Search Directory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExtension;
        private System.Windows.Forms.TextBox txtFoler;
        private System.Windows.Forms.Label lblDirectory;
        private System.Windows.Forms.ComboBox cboDirectory;
        private System.Windows.Forms.ListBox lstFoundFiles;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox chkLookinAll;
    }
}

