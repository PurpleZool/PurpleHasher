namespace PurpleHasher
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBxBytes = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.grpBxStrings = new System.Windows.Forms.GroupBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtBoxString = new System.Windows.Forms.TextBox();
            this.cmbBxStringFormat = new System.Windows.Forms.ComboBox();
            this.grpBxHashing = new System.Windows.Forms.GroupBox();
            this.txtBoxHash = new System.Windows.Forms.RichTextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnHash = new System.Windows.Forms.Button();
            this.cmbBxHashCodings = new System.Windows.Forms.ComboBox();
            this.cmbBoxHashes = new System.Windows.Forms.ComboBox();
            this.cmbBxRep = new System.Windows.Forms.ComboBox();
            this.btnRefreshRaw = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grpBxStrings.SuspendLayout();
            this.grpBxHashing.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            resources.ApplyResources(this.quitToolStripMenuItem, "quitToolStripMenuItem");
            this.quitToolStripMenuItem.Tag = "Close application";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // txtBxBytes
            // 
            this.txtBxBytes.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.txtBxBytes, "txtBxBytes");
            this.txtBxBytes.Name = "txtBxBytes";
            this.txtBxBytes.ReadOnly = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Select a file...";
            resources.ApplyResources(this.openFileDialog, "openFileDialog");
            this.openFileDialog.Tag = "Open File";
            // 
            // grpBxStrings
            // 
            this.grpBxStrings.Controls.Add(this.btnInsert);
            this.grpBxStrings.Controls.Add(this.txtBoxString);
            this.grpBxStrings.Controls.Add(this.cmbBxStringFormat);
            resources.ApplyResources(this.grpBxStrings, "grpBxStrings");
            this.grpBxStrings.Name = "grpBxStrings";
            this.grpBxStrings.TabStop = false;
            // 
            // btnInsert
            // 
            resources.ApplyResources(this.btnInsert, "btnInsert");
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtBoxString
            // 
            resources.ApplyResources(this.txtBoxString, "txtBoxString");
            this.txtBoxString.Name = "txtBoxString";
            // 
            // cmbBxStringFormat
            // 
            this.cmbBxStringFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxStringFormat.FormattingEnabled = true;
            this.cmbBxStringFormat.Items.AddRange(new object[] {
            resources.GetString("cmbBxStringFormat.Items"),
            resources.GetString("cmbBxStringFormat.Items1"),
            resources.GetString("cmbBxStringFormat.Items2")});
            resources.ApplyResources(this.cmbBxStringFormat, "cmbBxStringFormat");
            this.cmbBxStringFormat.Name = "cmbBxStringFormat";
            // 
            // grpBxHashing
            // 
            this.grpBxHashing.Controls.Add(this.txtBoxHash);
            this.grpBxHashing.Controls.Add(this.btnRefresh);
            this.grpBxHashing.Controls.Add(this.btnCopy);
            this.grpBxHashing.Controls.Add(this.btnHash);
            this.grpBxHashing.Controls.Add(this.cmbBxHashCodings);
            this.grpBxHashing.Controls.Add(this.cmbBoxHashes);
            resources.ApplyResources(this.grpBxHashing, "grpBxHashing");
            this.grpBxHashing.Name = "grpBxHashing";
            this.grpBxHashing.TabStop = false;
            // 
            // txtBoxHash
            // 
            resources.ApplyResources(this.txtBoxHash, "txtBoxHash");
            this.txtBoxHash.Name = "txtBoxHash";
            this.txtBoxHash.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtBoxHash_MouseDoubleClick);
            // 
            // btnRefresh
            // 
            resources.ApplyResources(this.btnRefresh, "btnRefresh");
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCopy
            // 
            resources.ApplyResources(this.btnCopy, "btnCopy");
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnHash
            // 
            resources.ApplyResources(this.btnHash, "btnHash");
            this.btnHash.Name = "btnHash";
            this.btnHash.UseVisualStyleBackColor = true;
            this.btnHash.Click += new System.EventHandler(this.btnHash_Click);
            // 
            // cmbBxHashCodings
            // 
            this.cmbBxHashCodings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxHashCodings.FormattingEnabled = true;
            this.cmbBxHashCodings.Items.AddRange(new object[] {
            resources.GetString("cmbBxHashCodings.Items"),
            resources.GetString("cmbBxHashCodings.Items1"),
            resources.GetString("cmbBxHashCodings.Items2"),
            resources.GetString("cmbBxHashCodings.Items3"),
            resources.GetString("cmbBxHashCodings.Items4")});
            resources.ApplyResources(this.cmbBxHashCodings, "cmbBxHashCodings");
            this.cmbBxHashCodings.Name = "cmbBxHashCodings";
            // 
            // cmbBoxHashes
            // 
            this.cmbBoxHashes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxHashes.FormattingEnabled = true;
            this.cmbBoxHashes.Items.AddRange(new object[] {
            resources.GetString("cmbBoxHashes.Items"),
            resources.GetString("cmbBoxHashes.Items1"),
            resources.GetString("cmbBoxHashes.Items2")});
            resources.ApplyResources(this.cmbBoxHashes, "cmbBoxHashes");
            this.cmbBoxHashes.Name = "cmbBoxHashes";
            // 
            // cmbBxRep
            // 
            this.cmbBxRep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxRep.FormattingEnabled = true;
            this.cmbBxRep.Items.AddRange(new object[] {
            resources.GetString("cmbBxRep.Items"),
            resources.GetString("cmbBxRep.Items1")});
            resources.ApplyResources(this.cmbBxRep, "cmbBxRep");
            this.cmbBxRep.Name = "cmbBxRep";
            // 
            // btnRefreshRaw
            // 
            resources.ApplyResources(this.btnRefreshRaw, "btnRefreshRaw");
            this.btnRefreshRaw.Name = "btnRefreshRaw";
            this.btnRefreshRaw.UseVisualStyleBackColor = true;
            this.btnRefreshRaw.Click += new System.EventHandler(this.btnRefreshRaw_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefreshRaw);
            this.Controls.Add(this.cmbBxRep);
            this.Controls.Add(this.grpBxHashing);
            this.Controls.Add(this.grpBxStrings);
            this.Controls.Add(this.txtBxBytes);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpBxStrings.ResumeLayout(false);
            this.grpBxStrings.PerformLayout();
            this.grpBxHashing.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.TextBox txtBxBytes;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox grpBxStrings;
        private System.Windows.Forms.GroupBox grpBxHashing;
        private System.Windows.Forms.ComboBox cmbBoxHashes;
        private System.Windows.Forms.Button btnHash;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.ComboBox cmbBxHashCodings;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtBoxString;
        private System.Windows.Forms.ComboBox cmbBxStringFormat;
        private System.Windows.Forms.RichTextBox txtBoxHash;
        private System.Windows.Forms.ComboBox cmbBxRep;
        private System.Windows.Forms.Button btnRefreshRaw;
    }
}

