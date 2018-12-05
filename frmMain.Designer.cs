namespace ArenaGameTool
{
    partial class frmMain
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOutXls = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.outTB = new System.Windows.Forms.TextBox();
            this.dataShow = new System.Windows.Forms.DataGridView();
            this.btnQuery = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.outClose = new System.Windows.Forms.Button();
            this.outOpen = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.outPath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.lable19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.whereInfo = new System.Windows.Forms.TextBox();
            this.selectTable = new System.Windows.Forms.TextBox();
            this.selectInfo = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.inOutCol = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnInXls = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.passwd = new System.Windows.Forms.TextBox();
            this.ip = new System.Windows.Forms.TextBox();
            this.link = new System.Windows.Forms.Button();
            this.tableList = new System.Windows.Forms.ComboBox();
            this.DBlist = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.col = new System.Windows.Forms.ComboBox();
            this.tableListT = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataShow)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOutXls
            // 
            this.btnOutXls.Location = new System.Drawing.Point(97, 20);
            this.btnOutXls.Name = "btnOutXls";
            this.btnOutXls.Size = new System.Drawing.Size(102, 23);
            this.btnOutXls.TabIndex = 0;
            this.btnOutXls.Text = "执行";
            this.btnOutXls.UseVisualStyleBackColor = true;
            this.btnOutXls.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "表：";
            // 
            // outTB
            // 
            this.outTB.Location = new System.Drawing.Point(96, 153);
            this.outTB.Name = "outTB";
            this.outTB.Size = new System.Drawing.Size(186, 21);
            this.outTB.TabIndex = 4;
            // 
            // dataShow
            // 
            this.dataShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataShow.Location = new System.Drawing.Point(20, 125);
            this.dataShow.Name = "dataShow";
            this.dataShow.RowTemplate.Height = 23;
            this.dataShow.Size = new System.Drawing.Size(797, 346);
            this.dataShow.TabIndex = 10;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(674, 88);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(102, 23);
            this.btnQuery.TabIndex = 11;
            this.btnQuery.Text = "执行";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOutXls);
            this.groupBox1.Location = new System.Drawing.Point(44, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 57);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "导出";
            // 
            // outClose
            // 
            this.outClose.Location = new System.Drawing.Point(189, 40);
            this.outClose.Name = "outClose";
            this.outClose.Size = new System.Drawing.Size(150, 23);
            this.outClose.TabIndex = 6;
            this.outClose.Text = "禁用xp_cmdshell组件";
            this.outClose.UseVisualStyleBackColor = true;
            this.outClose.Click += new System.EventHandler(this.outClose_Click);
            // 
            // outOpen
            // 
            this.outOpen.Location = new System.Drawing.Point(31, 40);
            this.outOpen.Name = "outOpen";
            this.outOpen.Size = new System.Drawing.Size(136, 23);
            this.outOpen.TabIndex = 5;
            this.outOpen.Text = "启用xp_cmdshell组件";
            this.outOpen.UseVisualStyleBackColor = true;
            this.outOpen.Click += new System.EventHandler(this.outOpen_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "服务器磁盘位置：";
            // 
            // outPath
            // 
            this.outPath.Location = new System.Drawing.Point(141, 110);
            this.outPath.Name = "outPath";
            this.outPath.Size = new System.Drawing.Size(186, 21);
            this.outPath.TabIndex = 4;
            this.outPath.Text = "D:\\JSDB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "服务器：";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(25, 123);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(846, 515);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.lable19);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.whereInfo);
            this.tabPage2.Controls.Add(this.selectTable);
            this.tabPage2.Controls.Add(this.selectInfo);
            this.tabPage2.Controls.Add(this.dataShow);
            this.tabPage2.Controls.Add(this.btnQuery);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(838, 489);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "信息查询";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(27, 93);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 35;
            this.label18.Text = "查询条件：";
            // 
            // lable19
            // 
            this.lable19.AutoSize = true;
            this.lable19.Location = new System.Drawing.Point(27, 63);
            this.lable19.Name = "lable19";
            this.lable19.Size = new System.Drawing.Size(53, 12);
            this.lable19.TabIndex = 35;
            this.lable19.Text = "查询表：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(27, 36);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 35;
            this.label17.Text = "查询内容：";
            // 
            // whereInfo
            // 
            this.whereInfo.Location = new System.Drawing.Point(101, 90);
            this.whereInfo.Name = "whereInfo";
            this.whereInfo.Size = new System.Drawing.Size(535, 21);
            this.whereInfo.TabIndex = 30;
            // 
            // selectTable
            // 
            this.selectTable.Location = new System.Drawing.Point(101, 60);
            this.selectTable.Name = "selectTable";
            this.selectTable.Size = new System.Drawing.Size(535, 21);
            this.selectTable.TabIndex = 30;
            // 
            // selectInfo
            // 
            this.selectInfo.Location = new System.Drawing.Point(101, 33);
            this.selectInfo.Name = "selectInfo";
            this.selectInfo.Size = new System.Drawing.Size(535, 21);
            this.selectInfo.TabIndex = 30;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.outClose);
            this.tabPage1.Controls.Add(this.outOpen);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.outTB);
            this.tabPage1.Controls.Add(this.inOutCol);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.outPath);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(838, 489);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "数据导入导出";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "字段：";
            // 
            // inOutCol
            // 
            this.inOutCol.Location = new System.Drawing.Point(96, 194);
            this.inOutCol.Name = "inOutCol";
            this.inOutCol.Size = new System.Drawing.Size(651, 21);
            this.inOutCol.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnInXls);
            this.groupBox3.Location = new System.Drawing.Point(418, 235);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(325, 57);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "导入";
            // 
            // btnInXls
            // 
            this.btnInXls.Location = new System.Drawing.Point(86, 20);
            this.btnInXls.Name = "btnInXls";
            this.btnInXls.Size = new System.Drawing.Size(102, 23);
            this.btnInXls.TabIndex = 0;
            this.btnInXls.Text = "执行";
            this.btnInXls.UseVisualStyleBackColor = true;
            this.btnInXls.Click += new System.EventHandler(this.btnInXls_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(252, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 17;
            this.label12.Text = "用户：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(453, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 17;
            this.label14.Text = "密码：";
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(293, 14);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(142, 21);
            this.user.TabIndex = 26;
            this.user.Text = "sa";
            // 
            // passwd
            // 
            this.passwd.Location = new System.Drawing.Point(493, 14);
            this.passwd.Name = "passwd";
            this.passwd.Size = new System.Drawing.Size(142, 21);
            this.passwd.TabIndex = 27;
            this.passwd.Text = "weile_1234";
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(84, 14);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(142, 21);
            this.ip.TabIndex = 28;
            this.ip.Text = "59.110.170.57";
            // 
            // link
            // 
            this.link.Location = new System.Drawing.Point(670, 13);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(102, 23);
            this.link.TabIndex = 24;
            this.link.Text = "连接";
            this.link.UseVisualStyleBackColor = true;
            this.link.Click += new System.EventHandler(this.link_Click);
            // 
            // tableList
            // 
            this.tableList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tableList.FormattingEnabled = true;
            this.tableList.Location = new System.Drawing.Point(253, 25);
            this.tableList.Name = "tableList";
            this.tableList.Size = new System.Drawing.Size(141, 20);
            this.tableList.TabIndex = 29;
            this.tableList.SelectedIndexChanged += new System.EventHandler(this.tableList_SelectedIndexChanged);
            // 
            // DBlist
            // 
            this.DBlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DBlist.FormattingEnabled = true;
            this.DBlist.Location = new System.Drawing.Point(76, 24);
            this.DBlist.Name = "DBlist";
            this.DBlist.Size = new System.Drawing.Size(121, 20);
            this.DBlist.TabIndex = 30;
            this.DBlist.SelectedIndexChanged += new System.EventHandler(this.DBlist_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.col);
            this.groupBox2.Controls.Add(this.tableListT);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.tableList);
            this.groupBox2.Controls.Add(this.DBlist);
            this.groupBox2.Location = new System.Drawing.Point(25, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(748, 65);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据库信息";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(420, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 34;
            this.label16.Text = "列：";
            // 
            // col
            // 
            this.col.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.col.FormattingEnabled = true;
            this.col.Location = new System.Drawing.Point(455, 28);
            this.col.Name = "col";
            this.col.Size = new System.Drawing.Size(141, 20);
            this.col.TabIndex = 33;
            // 
            // tableListT
            // 
            this.tableListT.AutoSize = true;
            this.tableListT.Location = new System.Drawing.Point(218, 27);
            this.tableListT.Name = "tableListT";
            this.tableListT.Size = new System.Drawing.Size(29, 12);
            this.tableListT.TabIndex = 32;
            this.tableListT.Text = "表：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 31;
            this.label15.Text = "数据库：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "注：默认使用数据库信息选择的表";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 650);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.link);
            this.Controls.Add(this.ip);
            this.Controls.Add(this.passwd);
            this.Controls.Add(this.user);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Name = "frmMain";
            this.Text = "数据库工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataShow)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOutXls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outTB;
        private System.Windows.Forms.DataGridView dataShow;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox outPath;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox passwd;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.Button link;
        private System.Windows.Forms.ComboBox tableList;
        private System.Windows.Forms.ComboBox DBlist;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox col;
        private System.Windows.Forms.Label tableListT;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox selectInfo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox whereInfo;
        private System.Windows.Forms.Label lable19;
        private System.Windows.Forms.TextBox selectTable;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnInXls;
        private System.Windows.Forms.Button outOpen;
        private System.Windows.Forms.Button outClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inOutCol;
        private System.Windows.Forms.Label label2;
    }
}

