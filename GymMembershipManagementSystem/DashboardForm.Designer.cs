﻿namespace GymMembershipManagementSystem
{
    partial class DashboardForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.monthCalendarMemberCheckedIn = new System.Windows.Forms.MonthCalendar();
            this.chartMembershipFees = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewRecentlyAdded = new System.Windows.Forms.DataGridView();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearchMember = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chartDetails = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTotalMembers = new System.Windows.Forms.Label();
            this.panelRegularGroup = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelNotStudentMemberCount = new System.Windows.Forms.Label();
            this.buttonViewRegularMember = new System.Windows.Forms.Button();
            this.panelStudentGroup = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelStudentCount = new System.Windows.Forms.Label();
            this.buttonViewMember = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.countRefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.timerRecentMember = new System.Windows.Forms.Timer(this.components);
            this.button4Months = new System.Windows.Forms.Button();
            this.button1year = new System.Windows.Forms.Button();
            this.button7Months = new System.Windows.Forms.Button();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMembershipFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecentlyAdded)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDetails)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panelRegularGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelStudentGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.AutoScroll = true;
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Controls.Add(this.dataGridViewResult);
            this.panelContainer.Controls.Add(this.button7Months);
            this.panelContainer.Controls.Add(this.button1year);
            this.panelContainer.Controls.Add(this.button4Months);
            this.panelContainer.Controls.Add(this.dataGridViewRecentlyAdded);
            this.panelContainer.Controls.Add(this.monthCalendarMemberCheckedIn);
            this.panelContainer.Controls.Add(this.chartMembershipFees);
            this.panelContainer.Controls.Add(this.panel3);
            this.panelContainer.Controls.Add(this.label2);
            this.panelContainer.Controls.Add(this.panel1);
            this.panelContainer.Controls.Add(this.chartDetails);
            this.panelContainer.Controls.Add(this.panel4);
            this.panelContainer.Controls.Add(this.panel2);
            this.panelContainer.Controls.Add(this.panelRegularGroup);
            this.panelContainer.Controls.Add(this.buttonViewRegularMember);
            this.panelContainer.Controls.Add(this.panelStudentGroup);
            this.panelContainer.Controls.Add(this.buttonViewMember);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1428, 1055);
            this.panelContainer.TabIndex = 0;
            // 
            // monthCalendarMemberCheckedIn
            // 
            this.monthCalendarMemberCheckedIn.BackColor = System.Drawing.Color.Black;
            this.monthCalendarMemberCheckedIn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendarMemberCheckedIn.ForeColor = System.Drawing.Color.White;
            this.monthCalendarMemberCheckedIn.Location = new System.Drawing.Point(1007, 59);
            this.monthCalendarMemberCheckedIn.Name = "monthCalendarMemberCheckedIn";
            this.monthCalendarMemberCheckedIn.TabIndex = 11;
            this.monthCalendarMemberCheckedIn.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarMemberCheckedIn_DateSelected);
            // 
            // chartMembershipFees
            // 
            this.chartMembershipFees.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chartMembershipFees.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartMembershipFees.Legends.Add(legend3);
            this.chartMembershipFees.Location = new System.Drawing.Point(24, 294);
            this.chartMembershipFees.Name = "chartMembershipFees";
            this.chartMembershipFees.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartMembershipFees.Series.Add(series3);
            this.chartMembershipFees.Size = new System.Drawing.Size(870, 190);
            this.chartMembershipFees.TabIndex = 13;
            this.chartMembershipFees.Text = "chart1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(3, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 1071);
            this.panel3.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(910, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "Recently Added Member";
            // 
            // dataGridViewRecentlyAdded
            // 
            this.dataGridViewRecentlyAdded.AllowUserToAddRows = false;
            this.dataGridViewRecentlyAdded.AllowUserToDeleteRows = false;
            this.dataGridViewRecentlyAdded.AllowUserToResizeColumns = false;
            this.dataGridViewRecentlyAdded.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewRecentlyAdded.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewRecentlyAdded.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRecentlyAdded.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRecentlyAdded.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewRecentlyAdded.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRecentlyAdded.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewRecentlyAdded.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRecentlyAdded.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewRecentlyAdded.EnableHeadersVisualStyles = false;
            this.dataGridViewRecentlyAdded.GridColor = System.Drawing.Color.White;
            this.dataGridViewRecentlyAdded.Location = new System.Drawing.Point(907, 319);
            this.dataGridViewRecentlyAdded.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridViewRecentlyAdded.MultiSelect = false;
            this.dataGridViewRecentlyAdded.Name = "dataGridViewRecentlyAdded";
            this.dataGridViewRecentlyAdded.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRecentlyAdded.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewRecentlyAdded.RowHeadersVisible = false;
            this.dataGridViewRecentlyAdded.RowHeadersWidth = 51;
            this.dataGridViewRecentlyAdded.RowTemplate.Height = 80;
            this.dataGridViewRecentlyAdded.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRecentlyAdded.Size = new System.Drawing.Size(385, 335);
            this.dataGridViewRecentlyAdded.TabIndex = 6;
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.AllowUserToAddRows = false;
            this.dataGridViewResult.AllowUserToDeleteRows = false;
            this.dataGridViewResult.AllowUserToResizeColumns = false;
            this.dataGridViewResult.AllowUserToResizeRows = false;
            this.dataGridViewResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResult.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewResult.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewResult.Location = new System.Drawing.Point(74, 69);
            this.dataGridViewResult.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewResult.MultiSelect = false;
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.ReadOnly = true;
            this.dataGridViewResult.RowHeadersVisible = false;
            this.dataGridViewResult.RowHeadersWidth = 51;
            this.dataGridViewResult.RowTemplate.Height = 24;
            this.dataGridViewResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewResult.Size = new System.Drawing.Size(850, 136);
            this.dataGridViewResult.TabIndex = 1;
            this.dataGridViewResult.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewResult_CellContentDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxSearchMember);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 64);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search Member";
            // 
            // textBoxSearchMember
            // 
            this.textBoxSearchMember.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearchMember.Location = new System.Drawing.Point(62, 30);
            this.textBoxSearchMember.Name = "textBoxSearchMember";
            this.textBoxSearchMember.Size = new System.Drawing.Size(845, 28);
            this.textBoxSearchMember.TabIndex = 0;
            this.textBoxSearchMember.Click += new System.EventHandler(this.textBoxSearchMember_Click);
            this.textBoxSearchMember.TextChanged += new System.EventHandler(this.textBoxSearchMember_TextChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 28);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // chartDetails
            // 
            this.chartDetails.BackSecondaryColor = System.Drawing.Color.Black;
            chartArea4.Name = "ChartArea1";
            this.chartDetails.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartDetails.Legends.Add(legend4);
            this.chartDetails.Location = new System.Drawing.Point(24, 531);
            this.chartDetails.Name = "chartDetails";
            this.chartDetails.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartDetails.Series.Add(series4);
            this.chartDetails.Size = new System.Drawing.Size(870, 190);
            this.chartDetails.TabIndex = 12;
            this.chartDetails.Text = "chartDetails";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(988, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(230, 172);
            this.panel4.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(215)))), ((int)(((byte)(195)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.labelTotalMembers);
            this.panel2.Location = new System.Drawing.Point(593, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 132);
            this.panel2.TabIndex = 22;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(16, 10);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 39);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Members";
            // 
            // labelTotalMembers
            // 
            this.labelTotalMembers.AutoSize = true;
            this.labelTotalMembers.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalMembers.Location = new System.Drawing.Point(9, 57);
            this.labelTotalMembers.Name = "labelTotalMembers";
            this.labelTotalMembers.Size = new System.Drawing.Size(30, 37);
            this.labelTotalMembers.TabIndex = 1;
            this.labelTotalMembers.Text = "T";
            // 
            // panelRegularGroup
            // 
            this.panelRegularGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.panelRegularGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRegularGroup.Controls.Add(this.pictureBox3);
            this.panelRegularGroup.Controls.Add(this.label5);
            this.panelRegularGroup.Controls.Add(this.labelNotStudentMemberCount);
            this.panelRegularGroup.Location = new System.Drawing.Point(333, 73);
            this.panelRegularGroup.Name = "panelRegularGroup";
            this.panelRegularGroup.Size = new System.Drawing.Size(241, 132);
            this.panelRegularGroup.TabIndex = 21;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(16, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Total Regular Member";
            // 
            // labelNotStudentMemberCount
            // 
            this.labelNotStudentMemberCount.AutoSize = true;
            this.labelNotStudentMemberCount.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotStudentMemberCount.Location = new System.Drawing.Point(9, 57);
            this.labelNotStudentMemberCount.Name = "labelNotStudentMemberCount";
            this.labelNotStudentMemberCount.Size = new System.Drawing.Size(44, 37);
            this.labelNotStudentMemberCount.TabIndex = 1;
            this.labelNotStudentMemberCount.Text = "M";
            // 
            // buttonViewRegularMember
            // 
            this.buttonViewRegularMember.Location = new System.Drawing.Point(333, 210);
            this.buttonViewRegularMember.Name = "buttonViewRegularMember";
            this.buttonViewRegularMember.Size = new System.Drawing.Size(241, 51);
            this.buttonViewRegularMember.TabIndex = 6;
            this.buttonViewRegularMember.Text = "View Regular Members";
            this.buttonViewRegularMember.UseVisualStyleBackColor = true;
            this.buttonViewRegularMember.Click += new System.EventHandler(this.buttonViewRegularMember_Click);
            // 
            // panelStudentGroup
            // 
            this.panelStudentGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(217)))));
            this.panelStudentGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStudentGroup.Controls.Add(this.pictureBox2);
            this.panelStudentGroup.Controls.Add(this.label3);
            this.panelStudentGroup.Controls.Add(this.labelStudentCount);
            this.panelStudentGroup.Location = new System.Drawing.Point(74, 73);
            this.panelStudentGroup.Name = "panelStudentGroup";
            this.panelStudentGroup.Size = new System.Drawing.Size(241, 132);
            this.panelStudentGroup.TabIndex = 19;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total Student Member";
            // 
            // labelStudentCount
            // 
            this.labelStudentCount.AutoSize = true;
            this.labelStudentCount.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentCount.Location = new System.Drawing.Point(9, 57);
            this.labelStudentCount.Name = "labelStudentCount";
            this.labelStudentCount.Size = new System.Drawing.Size(39, 37);
            this.labelStudentCount.TabIndex = 0;
            this.labelStudentCount.Text = "N";
            // 
            // buttonViewMember
            // 
            this.buttonViewMember.Location = new System.Drawing.Point(74, 211);
            this.buttonViewMember.Name = "buttonViewMember";
            this.buttonViewMember.Size = new System.Drawing.Size(241, 51);
            this.buttonViewMember.TabIndex = 5;
            this.buttonViewMember.Text = "View Student Members";
            this.buttonViewMember.UseVisualStyleBackColor = true;
            this.buttonViewMember.Click += new System.EventHandler(this.buttonViewMember_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // countRefreshTimer
            // 
            this.countRefreshTimer.Tick += new System.EventHandler(this.countRefreshTimer_Tick);
            // 
            // timerRecentMember
            // 
            this.timerRecentMember.Tick += new System.EventHandler(this.timerRecentMember_Tick);
            // 
            // button4Months
            // 
            this.button4Months.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(217)))));
            this.button4Months.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4Months.Location = new System.Drawing.Point(633, 276);
            this.button4Months.Name = "button4Months";
            this.button4Months.Size = new System.Drawing.Size(75, 23);
            this.button4Months.TabIndex = 24;
            this.button4Months.Text = "4 months";
            this.button4Months.UseVisualStyleBackColor = false;
            this.button4Months.Click += new System.EventHandler(this.button4Months_Click);
            // 
            // button1year
            // 
            this.button1year.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(215)))), ((int)(((byte)(195)))));
            this.button1year.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1year.Location = new System.Drawing.Point(795, 276);
            this.button1year.Name = "button1year";
            this.button1year.Size = new System.Drawing.Size(75, 23);
            this.button1year.TabIndex = 25;
            this.button1year.Text = "1 year";
            this.button1year.UseVisualStyleBackColor = false;
            this.button1year.Click += new System.EventHandler(this.button1year_Click);
            // 
            // button7Months
            // 
            this.button7Months.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.button7Months.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7Months.Location = new System.Drawing.Point(714, 276);
            this.button7Months.Name = "button7Months";
            this.button7Months.Size = new System.Drawing.Size(75, 23);
            this.button7Months.TabIndex = 26;
            this.button7Months.Text = "7 months";
            this.button7Months.UseVisualStyleBackColor = false;
            this.button7Months.Click += new System.EventHandler(this.button7Months_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1428, 1055);
            this.Controls.Add(this.panelContainer);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMembershipFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecentlyAdded)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDetails)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panelRegularGroup.ResumeLayout(false);
            this.panelRegularGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelStudentGroup.ResumeLayout(false);
            this.panelStudentGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxSearchMember;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.Label labelStudentCount;
        private System.Windows.Forms.Button buttonViewMember;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNotStudentMemberCount;
        private System.Windows.Forms.Timer countRefreshTimer;
        private System.Windows.Forms.Button buttonViewRegularMember;
        private System.Windows.Forms.DataGridView dataGridViewRecentlyAdded;
        private System.Windows.Forms.Timer timerRecentMember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDetails;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMembershipFees;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelStudentGroup;
        private System.Windows.Forms.Panel panelRegularGroup;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTotalMembers;
        private System.Windows.Forms.MonthCalendar monthCalendarMemberCheckedIn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button7Months;
        private System.Windows.Forms.Button button1year;
        private System.Windows.Forms.Button button4Months;
    }
}