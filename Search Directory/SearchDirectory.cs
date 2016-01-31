using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Search_Directory
{
    public partial class SearchDirectory : Form
    {
        private string formName = "Search Directory";
        private string formNameLoading = "Search Directory.. (Please Wait !!!...)";

        public string SearchDirectoryName { get; set; }
 
        public SearchDirectory()
        {
            InitializeComponent();
            PopulateActiveDirectories();
        }

        private void PopulateActiveDirectories()
        {
            cboDirectory.Items.Clear();
            foreach(string directory in Directory.GetLogicalDrives())
            {
                cboDirectory.Items.Add(directory);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            SearchDirectoryName = cboDirectory.Text;
            lstFoundFiles.Items.Clear();
            txtFoler.Enabled = false;
            cboDirectory.Enabled = false;
            chkLookinAll.Enabled = false;
            this.Cursor = Cursors.WaitCursor;
            this.Text = formNameLoading;
            Application.DoEvents();

            if (chkLookinAll.Checked)
                SearchInAllDirectiries();
            else
                SearchInDirectory(SearchDirectoryName);

            lstFoundFiles.Focus();
            this.Cursor = Cursors.Default;
            this.Text = formName;
            txtFoler.Enabled = true;
            cboDirectory.Enabled = true;
            chkLookinAll.Enabled = true;
        }

        private bool ValidateForm()
        {
            if(String.IsNullOrEmpty(txtFoler.Text))
            {
                MessageBox.Show("Enter Directory name to search", "Search Directory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFoler.Focus();
                return false;
            }

            if(String.IsNullOrEmpty(cboDirectory.Text) && !chkLookinAll.Checked)
            {
                MessageBox.Show("Select a Logical Drive", "Invalid Drive", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboDirectory.Focus();
                return false;
            }

            if (!Directory.Exists(cboDirectory.Text) && !chkLookinAll.Checked)
            {
                MessageBox.Show("Logical Drive does not Exist.", "Invalid Drive", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboDirectory.Focus();
                return false;
            }

            return true;
        }

        private void SearchInAllDirectiries()
        {
            DialogResult dialogResult = MessageBox.Show("Searching in all Drives will take several minutes. Do you want to continue?", "Search Directory", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == System.Windows.Forms.DialogResult.No)
            {
                chkLookinAll.Focus();
                return;
            }

            foreach(string logicalDrive in Directory.GetLogicalDrives())
            {
                SearchInDirectory(logicalDrive);
            }
        }

        private void SearchInDirectory(string SearchDirectoryName)
        {
            
                if(!Directory.Exists(SearchDirectoryName))
                    return;

                DirectoryInfo directoryInfo = new DirectoryInfo(SearchDirectoryName);
                List<DirectoryInfo> directoryNames = directoryInfo.EnumerateDirectories().ToList();
                foreach (DirectoryInfo directory in directoryNames)
                {
                    try
                    {
                        SearchInDirectory(directory.FullName);
                        if (directory.Name.IndexOf(txtFoler.Text, 0, StringComparison.CurrentCultureIgnoreCase) != -1)
                            lstFoundFiles.Items.Add(directory.FullName);
                    }
                    catch(UnauthorizedAccessException)
                    {
                        // Do Nothing.
                        continue;
                    }
                }
        }

        private void lstFoundFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = lstFoundFiles.Text,
                UseShellExecute = true,
                Verb = "open"
            });
        }

        private void chkLookinAll_CheckedChanged(object sender, EventArgs e)
        {
            if(!chkLookinAll.Checked)
            {
                cboDirectory.Enabled = true;
                return;
            }
            
            cboDirectory.Enabled = false;            
        }

        private void txtExtension_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void chkLookinAll_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void cboDirectory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void lstFoundFiles_KeyDoubleClick(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(lstFoundFiles.Text) || e.KeyCode != Keys.Enter)
                return;

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = lstFoundFiles.Text,
                UseShellExecute = true,
                Verb = "open"
            });
        }
        
    }
}
