﻿namespace Leveling
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            文件ToolStripMenuItem = new ToolStripMenuItem();
            打开水准观测文件ToolStripMenuItem = new ToolStripMenuItem();
            另存为ToolStripMenuItem = new ToolStripMenuItem();
            高差闭合差计算ToolStripMenuItem = new ToolStripMenuItem();
            闭合差计算ToolStripMenuItem = new ToolStripMenuItem();
            近似点高程计算ToolStripMenuItem = new ToolStripMenuItem();
            数据库ToolStripMenuItem = new ToolStripMenuItem();
            平差报告ToolStripMenuItem = new ToolStripMenuItem();
            导入数据库ToolStripMenuItem = new ToolStripMenuItem();
            帮助ToolStripMenuItem = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            dataGridView2 = new DataGridView();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            richTextBox1 = new RichTextBox();
            tabPage4 = new TabPage();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 文件ToolStripMenuItem, 高差闭合差计算ToolStripMenuItem, 数据库ToolStripMenuItem, 帮助ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(629, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            文件ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 打开水准观测文件ToolStripMenuItem, 另存为ToolStripMenuItem });
            文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            文件ToolStripMenuItem.Size = new Size(44, 21);
            文件ToolStripMenuItem.Text = "文件";
            // 
            // 打开水准观测文件ToolStripMenuItem
            // 
            打开水准观测文件ToolStripMenuItem.Name = "打开水准观测文件ToolStripMenuItem";
            打开水准观测文件ToolStripMenuItem.Size = new Size(172, 22);
            打开水准观测文件ToolStripMenuItem.Text = "打开水准观测文件";
            打开水准观测文件ToolStripMenuItem.Click += 打开水准观测文件ToolStripMenuItem_Click;
            // 
            // 另存为ToolStripMenuItem
            // 
            另存为ToolStripMenuItem.Name = "另存为ToolStripMenuItem";
            另存为ToolStripMenuItem.Size = new Size(172, 22);
            另存为ToolStripMenuItem.Text = "另存为";
            // 
            // 高差闭合差计算ToolStripMenuItem
            // 
            高差闭合差计算ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 闭合差计算ToolStripMenuItem, 近似点高程计算ToolStripMenuItem });
            高差闭合差计算ToolStripMenuItem.Name = "高差闭合差计算ToolStripMenuItem";
            高差闭合差计算ToolStripMenuItem.Size = new Size(44, 21);
            高差闭合差计算ToolStripMenuItem.Text = "计算";
            // 
            // 闭合差计算ToolStripMenuItem
            // 
            闭合差计算ToolStripMenuItem.Name = "闭合差计算ToolStripMenuItem";
            闭合差计算ToolStripMenuItem.Size = new Size(180, 22);
            闭合差计算ToolStripMenuItem.Text = "闭合差计算";
            闭合差计算ToolStripMenuItem.Click += 闭合差计算ToolStripMenuItem_Click;
            // 
            // 近似点高程计算ToolStripMenuItem
            // 
            近似点高程计算ToolStripMenuItem.Name = "近似点高程计算ToolStripMenuItem";
            近似点高程计算ToolStripMenuItem.Size = new Size(180, 22);
            近似点高程计算ToolStripMenuItem.Text = "近似点高程计算";
            近似点高程计算ToolStripMenuItem.Click += 近似点高程计算ToolStripMenuItem_Click;
            // 
            // 数据库ToolStripMenuItem
            // 
            数据库ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 平差报告ToolStripMenuItem, 导入数据库ToolStripMenuItem });
            数据库ToolStripMenuItem.Name = "数据库ToolStripMenuItem";
            数据库ToolStripMenuItem.Size = new Size(44, 21);
            数据库ToolStripMenuItem.Text = "成果";
            // 
            // 平差报告ToolStripMenuItem
            // 
            平差报告ToolStripMenuItem.Name = "平差报告ToolStripMenuItem";
            平差报告ToolStripMenuItem.Size = new Size(124, 22);
            平差报告ToolStripMenuItem.Text = "平差报告";
            // 
            // 导入数据库ToolStripMenuItem
            // 
            导入数据库ToolStripMenuItem.Name = "导入数据库ToolStripMenuItem";
            导入数据库ToolStripMenuItem.Size = new Size(124, 22);
            导入数据库ToolStripMenuItem.Text = "数据库";
            // 
            // 帮助ToolStripMenuItem
            // 
            帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            帮助ToolStripMenuItem.Size = new Size(44, 21);
            帮助ToolStripMenuItem.Text = "帮助";
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Bottom;
            tabControl1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(0, 23);
            tabControl1.Margin = new Padding(2, 3, 2, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(622, 337);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 4);
            tabPage1.Margin = new Padding(2, 3, 2, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 3, 2, 3);
            tabPage1.Size = new Size(614, 307);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "水准点高程";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column9 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(2, 3);
            dataGridView1.Margin = new Padding(2, 3, 2, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(610, 301);
            dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "序号";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "点名";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "高程";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column9
            // 
            Column9.HeaderText = "点属性";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 125;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 4);
            tabPage2.Margin = new Padding(2, 3, 2, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2, 3, 2, 3);
            tabPage2.Size = new Size(614, 307);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "水准线路";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column4, Column5, Column6, Column7, Column8 });
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(2, 3);
            dataGridView2.Margin = new Padding(2, 3, 2, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(610, 301);
            dataGridView2.TabIndex = 0;
            // 
            // Column4
            // 
            Column4.HeaderText = "序号";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "起点";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "终点";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "高差";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.HeaderText = "距离";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 125;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(richTextBox1);
            tabPage3.Location = new Point(4, 4);
            tabPage3.Margin = new Padding(2, 3, 2, 3);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(614, 307);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "平差报告";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(614, 307);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 4);
            tabPage4.Margin = new Padding(2, 3, 2, 3);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(614, 307);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "数据库管理";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 358);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 3, 2, 3);
            Name = "Form1";
            Text = "水准网平差程序设计";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 文件ToolStripMenuItem;
        private ToolStripMenuItem 打开水准观测文件ToolStripMenuItem;
        private ToolStripMenuItem 另存为ToolStripMenuItem;
        private ToolStripMenuItem 高差闭合差计算ToolStripMenuItem;
        private ToolStripMenuItem 闭合差计算ToolStripMenuItem;
        private ToolStripMenuItem 近似点高程计算ToolStripMenuItem;
        private ToolStripMenuItem 数据库ToolStripMenuItem;
        private ToolStripMenuItem 平差报告ToolStripMenuItem;
        private ToolStripMenuItem 导入数据库ToolStripMenuItem;
        private ToolStripMenuItem 帮助ToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column9;
        private RichTextBox richTextBox1;
    }
}
