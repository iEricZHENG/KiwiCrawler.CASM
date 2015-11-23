﻿namespace FormKiwiCrawler
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvTaskCapture = new System.Windows.Forms.DataGridView();
            this.kId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kPageTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kCaptureType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kDetailPattern = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kDetailPatternType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kNextPagePattern = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kNextPagePatternType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kComplateDegree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kAddressBusinessType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kKeyWords = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kBtnCapture = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnComplate = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnAccessDB = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskCapture)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1229, 554);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1221, 528);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "任务抓取";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnDelete);
            this.splitContainer2.Panel1.Controls.Add(this.btnUpdate);
            this.splitContainer2.Panel1.Controls.Add(this.button2);
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            this.splitContainer2.Panel1.Controls.Add(this.btnRun);
            this.splitContainer2.Panel1.Controls.Add(this.btnAdd);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvTaskCapture);
            this.splitContainer2.Size = new System.Drawing.Size(1215, 522);
            this.splitContainer2.SplitterDistance = 33;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(139, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(55, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(78, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(55, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(410, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "导出";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "导入";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(649, 5);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "批量抓取";
            this.btnRun.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(17, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvTaskCapture
            // 
            this.dgvTaskCapture.AllowUserToAddRows = false;
            this.dgvTaskCapture.AllowUserToDeleteRows = false;
            this.dgvTaskCapture.AllowUserToOrderColumns = true;
            this.dgvTaskCapture.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaskCapture.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kId,
            this.kUrl,
            this.kPageTotal,
            this.kCaptureType,
            this.kDetailPattern,
            this.kDetailPatternType,
            this.kNextPagePattern,
            this.kNextPagePatternType,
            this.kComplateDegree,
            this.kAddressBusinessType,
            this.kKeyWords,
            this.kBtnCapture});
            this.dgvTaskCapture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTaskCapture.Location = new System.Drawing.Point(0, 0);
            this.dgvTaskCapture.MultiSelect = false;
            this.dgvTaskCapture.Name = "dgvTaskCapture";
            this.dgvTaskCapture.ReadOnly = true;
            this.dgvTaskCapture.RowTemplate.Height = 23;
            this.dgvTaskCapture.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaskCapture.Size = new System.Drawing.Size(1215, 485);
            this.dgvTaskCapture.TabIndex = 4;
            this.dgvTaskCapture.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaskCapture_CellClick);
            // 
            // kId
            // 
            this.kId.FillWeight = 103.934F;
            this.kId.HeaderText = "Id";
            this.kId.Name = "kId";
            this.kId.ReadOnly = true;
            this.kId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // kUrl
            // 
            this.kUrl.FillWeight = 103.934F;
            this.kUrl.HeaderText = "网址";
            this.kUrl.Name = "kUrl";
            this.kUrl.ReadOnly = true;
            // 
            // kPageTotal
            // 
            this.kPageTotal.FillWeight = 103.934F;
            this.kPageTotal.HeaderText = "总页数";
            this.kPageTotal.Name = "kPageTotal";
            this.kPageTotal.ReadOnly = true;
            // 
            // kCaptureType
            // 
            this.kCaptureType.FillWeight = 103.934F;
            this.kCaptureType.HeaderText = "抓取类型";
            this.kCaptureType.Name = "kCaptureType";
            this.kCaptureType.ReadOnly = true;
            // 
            // kDetailPattern
            // 
            this.kDetailPattern.FillWeight = 103.934F;
            this.kDetailPattern.HeaderText = "详细页模板";
            this.kDetailPattern.Name = "kDetailPattern";
            this.kDetailPattern.ReadOnly = true;
            // 
            // kDetailPatternType
            // 
            this.kDetailPatternType.FillWeight = 103.934F;
            this.kDetailPatternType.HeaderText = "详细页模板类型";
            this.kDetailPatternType.Name = "kDetailPatternType";
            this.kDetailPatternType.ReadOnly = true;
            // 
            // kNextPagePattern
            // 
            this.kNextPagePattern.FillWeight = 103.934F;
            this.kNextPagePattern.HeaderText = "下一页模板";
            this.kNextPagePattern.Name = "kNextPagePattern";
            this.kNextPagePattern.ReadOnly = true;
            // 
            // kNextPagePatternType
            // 
            this.kNextPagePatternType.FillWeight = 103.934F;
            this.kNextPagePatternType.HeaderText = "下一页模板类型";
            this.kNextPagePatternType.Name = "kNextPagePatternType";
            this.kNextPagePatternType.ReadOnly = true;
            // 
            // kComplateDegree
            // 
            this.kComplateDegree.FillWeight = 103.934F;
            this.kComplateDegree.HeaderText = "完成度";
            this.kComplateDegree.Name = "kComplateDegree";
            this.kComplateDegree.ReadOnly = true;
            // 
            // kAddressBusinessType
            // 
            this.kAddressBusinessType.FillWeight = 103.934F;
            this.kAddressBusinessType.HeaderText = "业务类型";
            this.kAddressBusinessType.Name = "kAddressBusinessType";
            this.kAddressBusinessType.ReadOnly = true;
            // 
            // kKeyWords
            // 
            this.kKeyWords.FillWeight = 103.934F;
            this.kKeyWords.HeaderText = "关键字";
            this.kKeyWords.Name = "kKeyWords";
            this.kKeyWords.ReadOnly = true;
            // 
            // kBtnCapture
            // 
            this.kBtnCapture.FillWeight = 103.934F;
            this.kBtnCapture.HeaderText = "抓取";
            this.kBtnCapture.Name = "kBtnCapture";
            this.kBtnCapture.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1221, 528);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "爬虫配置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnComplate);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1221, 528);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "完成度计算";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnComplate
            // 
            this.btnComplate.Location = new System.Drawing.Point(687, 24);
            this.btnComplate.Name = "btnComplate";
            this.btnComplate.Size = new System.Drawing.Size(81, 23);
            this.btnComplate.TabIndex = 3;
            this.btnComplate.Text = "计算完成度";
            this.btnComplate.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnAccessDB);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1221, 528);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "开发测试";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnAccessDB
            // 
            this.btnAccessDB.Location = new System.Drawing.Point(378, 14);
            this.btnAccessDB.Name = "btnAccessDB";
            this.btnAccessDB.Size = new System.Drawing.Size(81, 23);
            this.btnAccessDB.TabIndex = 2;
            this.btnAccessDB.Text = "测试连接";
            this.btnAccessDB.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.listView1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1221, 528);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "开发测试2";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1215, 522);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 554);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "KiwiCrawler-1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskCapture)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnComplate;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnAccessDB;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DataGridView dgvTaskCapture;
        private System.Windows.Forms.DataGridViewTextBoxColumn kId;
        private System.Windows.Forms.DataGridViewTextBoxColumn kUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn kPageTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn kCaptureType;
        private System.Windows.Forms.DataGridViewTextBoxColumn kDetailPattern;
        private System.Windows.Forms.DataGridViewTextBoxColumn kDetailPatternType;
        private System.Windows.Forms.DataGridViewTextBoxColumn kNextPagePattern;
        private System.Windows.Forms.DataGridViewTextBoxColumn kNextPagePatternType;
        private System.Windows.Forms.DataGridViewTextBoxColumn kComplateDegree;
        private System.Windows.Forms.DataGridViewTextBoxColumn kAddressBusinessType;
        private System.Windows.Forms.DataGridViewTextBoxColumn kKeyWords;
        private System.Windows.Forms.DataGridViewButtonColumn kBtnCapture;

    }
}

