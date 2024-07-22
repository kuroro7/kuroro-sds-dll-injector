namespace KuroroDLLInjector {
    partial class fMAIN {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            panel1 = new Panel();
            grid = new DataGridView();
            ColumnDll = new DataGridViewTextBoxColumn();
            ColumnFunction = new DataGridViewTextBoxColumn();
            ColumnIAT = new DataGridViewTextBoxColumn();
            topPanel = new Panel();
            btSelectDll = new Button();
            btSelectFile = new Button();
            lbDllFile = new Label();
            edtDllPath = new TextBox();
            lbFilename = new Label();
            edtFilename = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btInject = new Button();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            topPanel.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(833, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // statusStrip
            // 
            statusStrip.Location = new Point(0, 532);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(833, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "statusStrip1";
            // 
            // panel1
            // 
            panel1.Controls.Add(grid);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 140);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(833, 392);
            panel1.TabIndex = 3;
            // 
            // grid
            // 
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.Columns.AddRange(new DataGridViewColumn[] { ColumnDll, ColumnFunction, ColumnIAT });
            grid.Dock = DockStyle.Fill;
            grid.Location = new Point(5, 5);
            grid.Name = "grid";
            grid.ReadOnly = true;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.Size = new Size(823, 382);
            grid.TabIndex = 0;
            // 
            // ColumnDll
            // 
            ColumnDll.HeaderText = "DLL";
            ColumnDll.Name = "ColumnDll";
            ColumnDll.ReadOnly = true;
            // 
            // ColumnFunction
            // 
            ColumnFunction.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnFunction.HeaderText = "Function";
            ColumnFunction.Name = "ColumnFunction";
            ColumnFunction.ReadOnly = true;
            // 
            // ColumnIAT
            // 
            ColumnIAT.HeaderText = "IAT";
            ColumnIAT.Name = "ColumnIAT";
            ColumnIAT.ReadOnly = true;
            // 
            // topPanel
            // 
            topPanel.Controls.Add(btSelectDll);
            topPanel.Controls.Add(btSelectFile);
            topPanel.Controls.Add(lbDllFile);
            topPanel.Controls.Add(edtDllPath);
            topPanel.Controls.Add(lbFilename);
            topPanel.Controls.Add(edtFilename);
            topPanel.Controls.Add(flowLayoutPanel1);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 24);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(833, 116);
            topPanel.TabIndex = 4;
            // 
            // btSelectDll
            // 
            btSelectDll.Location = new Point(419, 77);
            btSelectDll.Name = "btSelectDll";
            btSelectDll.Size = new Size(70, 23);
            btSelectDll.TabIndex = 6;
            btSelectDll.Text = "Select";
            btSelectDll.UseVisualStyleBackColor = true;
            btSelectDll.Click += btSelectDll_Click;
            // 
            // btSelectFile
            // 
            btSelectFile.Location = new Point(419, 27);
            btSelectFile.Name = "btSelectFile";
            btSelectFile.Size = new Size(70, 23);
            btSelectFile.TabIndex = 5;
            btSelectFile.Text = "Select";
            btSelectFile.UseVisualStyleBackColor = true;
            btSelectFile.Click += btSelectFile_Click;
            // 
            // lbDllFile
            // 
            lbDllFile.AutoSize = true;
            lbDllFile.Location = new Point(12, 59);
            lbDllFile.Name = "lbDllFile";
            lbDllFile.Size = new Size(27, 15);
            lbDllFile.TabIndex = 4;
            lbDllFile.Text = "DLL";
            // 
            // edtDllPath
            // 
            edtDllPath.Location = new Point(12, 77);
            edtDllPath.Name = "edtDllPath";
            edtDllPath.ReadOnly = true;
            edtDllPath.Size = new Size(401, 23);
            edtDllPath.TabIndex = 3;
            // 
            // lbFilename
            // 
            lbFilename.AutoSize = true;
            lbFilename.Location = new Point(12, 9);
            lbFilename.Name = "lbFilename";
            lbFilename.Size = new Size(64, 15);
            lbFilename.TabIndex = 2;
            lbFilename.Text = "Executable";
            // 
            // edtFilename
            // 
            edtFilename.Location = new Point(12, 27);
            edtFilename.Name = "edtFilename";
            edtFilename.ReadOnly = true;
            edtFilename.Size = new Size(401, 23);
            edtFilename.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btInject);
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(737, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(96, 116);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btInject
            // 
            btInject.Enabled = false;
            btInject.Image = Properties.Resources.FIRE;
            btInject.Location = new Point(11, 10);
            btInject.Margin = new Padding(10);
            btInject.Name = "btInject";
            btInject.Size = new Size(75, 90);
            btInject.TabIndex = 8;
            btInject.Text = "Inject";
            btInject.TextImageRelation = TextImageRelation.ImageAboveText;
            btInject.UseVisualStyleBackColor = true;
            btInject.Click += btInject_Click;
            // 
            // fMAIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 554);
            Controls.Add(panel1);
            Controls.Add(topPanel);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "fMAIN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kuroro DLL Injector";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private StatusStrip statusStrip;
        private Panel panel1;
        private Panel topPanel;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView grid;
        private Button btSelectDll;
        private Button btSelectFile;
        private Label lbDllFile;
        private TextBox edtDllPath;
        private Label lbFilename;
        private TextBox edtFilename;
        private Button btInject;
        private DataGridViewTextBoxColumn ColumnDll;
        private DataGridViewTextBoxColumn ColumnFunction;
        private DataGridViewTextBoxColumn ColumnIAT;
    }
}
