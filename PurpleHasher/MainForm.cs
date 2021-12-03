using PurpleHasher.EncodingHandlers;
using PurpleHasher.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PurpleHasher
{
    public partial class MainForm : Form
    {

        private ContentHandler contentHandler;


        public MainForm()
        {
            InitializeComponent();
            contentHandler = new ContentHandler();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    contentHandler.ReadFile(openFileDialog.FileName);
                    txtBxBytes.Text = contentHandler.GetRawString((ByteRep)cmbBxRep.SelectedIndex);
                    EnableControls(true);
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            contentHandler.ReadString(txtBoxString.Text, cmbBxStringFormat.SelectedIndex + 1);
            txtBxBytes.Text = contentHandler.GetRawString((ByteRep)cmbBxRep.SelectedIndex);
            EnableControls(true);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cmbBxStringFormat.SelectedIndex = cmbBxHashCodings.SelectedIndex = cmbBoxHashes.SelectedIndex = cmbBxRep.SelectedIndex = 0;
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            contentHandler.HashTo((Hashings)cmbBoxHashes.SelectedIndex);
            btnRefresh_Click(sender,e);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtBoxHash.Text = contentHandler.GetHashedString((Codings)cmbBxHashCodings.SelectedIndex);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtBoxHash.Text);
        }

        private void btnRefreshRaw_Click(object sender, EventArgs e)
        {
            txtBxBytes.Text = contentHandler.GetRawString((ByteRep)cmbBxRep.SelectedIndex);
        }

        private void txtBoxHash_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtBoxHash.Text = String.Concat(txtBoxHash.Text.Where(c => !Char.IsWhiteSpace(c)));
        }

        #region FORM_METHODS

        private void EnableControls(bool switchTo) 
        {
            if (switchTo) 
            {
                if (!grpBxHashing.Enabled) grpBxHashing.Enabled = btnRefreshRaw.Enabled = true;
            }
            else 
            {
                if (grpBxHashing.Enabled) grpBxHashing.Enabled = btnRefreshRaw.Enabled = false;
            }
        }

        #endregion

    }
}
