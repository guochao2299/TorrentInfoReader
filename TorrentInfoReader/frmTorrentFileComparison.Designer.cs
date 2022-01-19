
namespace TorrentInfoReader
{
    partial class frmTorrentFileComparison
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNotExistLocalFile = new System.Windows.Forms.RadioButton();
            this.rbExistLocalFile = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.btnBrowseFileInfo = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtRemovePostfix = new System.Windows.Forms.TextBox();
            this.txtRemovePrefix = new System.Windows.Forms.TextBox();
            this.cbRemovePostfix = new System.Windows.Forms.CheckBox();
            this.cbRemovePrefix = new System.Windows.Forms.CheckBox();
            this.本地搜索路径 = new System.Windows.Forms.GroupBox();
            this.btnDeletePath = new System.Windows.Forms.Button();
            this.btnNewPath = new System.Windows.Forms.Button();
            this.lstFindPathes = new System.Windows.Forms.ListBox();
            this.btnBrowseAndParse = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.本地搜索路径.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btnBrowseFileInfo);
            this.splitContainer1.Panel1.Controls.Add(this.btnFind);
            this.splitContainer1.Panel1.Controls.Add(this.txtRemovePostfix);
            this.splitContainer1.Panel1.Controls.Add(this.txtRemovePrefix);
            this.splitContainer1.Panel1.Controls.Add(this.cbRemovePostfix);
            this.splitContainer1.Panel1.Controls.Add(this.cbRemovePrefix);
            this.splitContainer1.Panel1.Controls.Add(this.本地搜索路径);
            this.splitContainer1.Panel1.Controls.Add(this.btnBrowseAndParse);
            this.splitContainer1.Panel1.Controls.Add(this.txtFilePath);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvResults);
            this.splitContainer1.Size = new System.Drawing.Size(1058, 666);
            this.splitContainer1.SplitterDistance = 249;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNotExistLocalFile);
            this.groupBox1.Controls.Add(this.rbExistLocalFile);
            this.groupBox1.Controls.Add(this.rbAll);
            this.groupBox1.Location = new System.Drawing.Point(525, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 75);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据查看选项";
            // 
            // rbNotExistLocalFile
            // 
            this.rbNotExistLocalFile.AutoSize = true;
            this.rbNotExistLocalFile.Location = new System.Drawing.Point(312, 27);
            this.rbNotExistLocalFile.Name = "rbNotExistLocalFile";
            this.rbNotExistLocalFile.Size = new System.Drawing.Size(180, 24);
            this.rbNotExistLocalFile.TabIndex = 2;
            this.rbNotExistLocalFile.Text = "不存在本地文件的数据";
            this.rbNotExistLocalFile.UseVisualStyleBackColor = true;
            this.rbNotExistLocalFile.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbExistLocalFile
            // 
            this.rbExistLocalFile.AutoSize = true;
            this.rbExistLocalFile.Location = new System.Drawing.Point(119, 27);
            this.rbExistLocalFile.Name = "rbExistLocalFile";
            this.rbExistLocalFile.Size = new System.Drawing.Size(165, 24);
            this.rbExistLocalFile.TabIndex = 1;
            this.rbExistLocalFile.Text = "存在本地文件的数据";
            this.rbExistLocalFile.UseVisualStyleBackColor = true;
            this.rbExistLocalFile.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Location = new System.Drawing.Point(31, 27);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(60, 24);
            this.rbAll.TabIndex = 0;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "全部";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // btnBrowseFileInfo
            // 
            this.btnBrowseFileInfo.Enabled = false;
            this.btnBrowseFileInfo.Location = new System.Drawing.Point(927, 11);
            this.btnBrowseFileInfo.Name = "btnBrowseFileInfo";
            this.btnBrowseFileInfo.Size = new System.Drawing.Size(119, 29);
            this.btnBrowseFileInfo.TabIndex = 16;
            this.btnBrowseFileInfo.Text = "查看文件内容";
            this.btnBrowseFileInfo.UseVisualStyleBackColor = true;
            this.btnBrowseFileInfo.Click += new System.EventHandler(this.btnBrowseFileInfo_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(927, 64);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(119, 57);
            this.btnFind.TabIndex = 15;
            this.btnFind.Text = "查找文件";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtRemovePostfix
            // 
            this.txtRemovePostfix.Enabled = false;
            this.txtRemovePostfix.Location = new System.Drawing.Point(695, 97);
            this.txtRemovePostfix.Name = "txtRemovePostfix";
            this.txtRemovePostfix.Size = new System.Drawing.Size(226, 27);
            this.txtRemovePostfix.TabIndex = 13;
            // 
            // txtRemovePrefix
            // 
            this.txtRemovePrefix.Enabled = false;
            this.txtRemovePrefix.Location = new System.Drawing.Point(695, 67);
            this.txtRemovePrefix.Name = "txtRemovePrefix";
            this.txtRemovePrefix.Size = new System.Drawing.Size(226, 27);
            this.txtRemovePrefix.TabIndex = 11;
            // 
            // cbRemovePostfix
            // 
            this.cbRemovePostfix.AutoSize = true;
            this.cbRemovePostfix.Location = new System.Drawing.Point(525, 97);
            this.cbRemovePostfix.Name = "cbRemovePostfix";
            this.cbRemovePostfix.Size = new System.Drawing.Size(176, 24);
            this.cbRemovePostfix.TabIndex = 12;
            this.cbRemovePostfix.Text = "Torrent文件去后缀：";
            this.cbRemovePostfix.UseVisualStyleBackColor = true;
            this.cbRemovePostfix.CheckedChanged += new System.EventHandler(this.cbRemovePostfix_CheckedChanged);
            // 
            // cbRemovePrefix
            // 
            this.cbRemovePrefix.AutoSize = true;
            this.cbRemovePrefix.Location = new System.Drawing.Point(525, 67);
            this.cbRemovePrefix.Name = "cbRemovePrefix";
            this.cbRemovePrefix.Size = new System.Drawing.Size(176, 24);
            this.cbRemovePrefix.TabIndex = 10;
            this.cbRemovePrefix.Text = "Torrent文件去前缀：";
            this.cbRemovePrefix.UseVisualStyleBackColor = true;
            this.cbRemovePrefix.CheckedChanged += new System.EventHandler(this.cbRemovePrefix_CheckedChanged);
            // 
            // 本地搜索路径
            // 
            this.本地搜索路径.Controls.Add(this.btnDeletePath);
            this.本地搜索路径.Controls.Add(this.btnNewPath);
            this.本地搜索路径.Controls.Add(this.lstFindPathes);
            this.本地搜索路径.Location = new System.Drawing.Point(15, 54);
            this.本地搜索路径.Name = "本地搜索路径";
            this.本地搜索路径.Size = new System.Drawing.Size(492, 183);
            this.本地搜索路径.TabIndex = 9;
            this.本地搜索路径.TabStop = false;
            this.本地搜索路径.Text = "本地搜索文件夹";
            // 
            // btnDeletePath
            // 
            this.btnDeletePath.Location = new System.Drawing.Point(392, 61);
            this.btnDeletePath.Name = "btnDeletePath";
            this.btnDeletePath.Size = new System.Drawing.Size(94, 29);
            this.btnDeletePath.TabIndex = 11;
            this.btnDeletePath.Text = "删除文件夹";
            this.btnDeletePath.UseVisualStyleBackColor = true;
            this.btnDeletePath.Click += new System.EventHandler(this.btnDeletePath_Click);
            // 
            // btnNewPath
            // 
            this.btnNewPath.Location = new System.Drawing.Point(392, 26);
            this.btnNewPath.Name = "btnNewPath";
            this.btnNewPath.Size = new System.Drawing.Size(94, 29);
            this.btnNewPath.TabIndex = 10;
            this.btnNewPath.Text = "新增文件夹";
            this.btnNewPath.UseVisualStyleBackColor = true;
            this.btnNewPath.Click += new System.EventHandler(this.btnNewPath_Click);
            // 
            // lstFindPathes
            // 
            this.lstFindPathes.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstFindPathes.FormattingEnabled = true;
            this.lstFindPathes.ItemHeight = 20;
            this.lstFindPathes.Location = new System.Drawing.Point(3, 23);
            this.lstFindPathes.Name = "lstFindPathes";
            this.lstFindPathes.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstFindPathes.Size = new System.Drawing.Size(383, 157);
            this.lstFindPathes.TabIndex = 0;
            // 
            // btnBrowseAndParse
            // 
            this.btnBrowseAndParse.Location = new System.Drawing.Point(827, 10);
            this.btnBrowseAndParse.Name = "btnBrowseAndParse";
            this.btnBrowseAndParse.Size = new System.Drawing.Size(94, 29);
            this.btnBrowseAndParse.TabIndex = 8;
            this.btnBrowseAndParse.Text = "浏览解析";
            this.btnBrowseAndParse.UseVisualStyleBackColor = true;
            this.btnBrowseAndParse.Click += new System.EventHandler(this.btnBrowseAndParse_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(145, 12);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(675, 27);
            this.txtFilePath.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Torrent文件地址：";
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResults.Location = new System.Drawing.Point(0, 0);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersWidth = 25;
            this.dgvResults.RowTemplate.Height = 29;
            this.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResults.Size = new System.Drawing.Size(1058, 413);
            this.dgvResults.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "序号";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "文件名称";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "处理后的文件名称";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "本地文件路径";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 500;
            // 
            // frmTorrentFileComparison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 666);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmTorrentFileComparison";
            this.Text = "frmTorrentFileComparison";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.本地搜索路径.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox 本地搜索路径;
        private System.Windows.Forms.Button btnDeletePath;
        private System.Windows.Forms.Button btnNewPath;
        private System.Windows.Forms.ListBox lstFindPathes;
        private System.Windows.Forms.Button btnBrowseAndParse;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtRemovePostfix;
        private System.Windows.Forms.TextBox txtRemovePrefix;
        private System.Windows.Forms.CheckBox cbRemovePostfix;
        private System.Windows.Forms.CheckBox cbRemovePrefix;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnBrowseFileInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNotExistLocalFile;
        private System.Windows.Forms.RadioButton rbExistLocalFile;
        private System.Windows.Forms.RadioButton rbAll;
    }
}