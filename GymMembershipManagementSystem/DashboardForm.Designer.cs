namespace GymMembershipManagementSystem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewRecentlyAdded = new System.Windows.Forms.DataGridView();
            this.panelContainerCount = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonViewRegularMember = new System.Windows.Forms.Button();
            this.buttonViewMember = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNotStudentMemberCount = new System.Windows.Forms.Label();
            this.labelStudentCount = new System.Windows.Forms.Label();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearchMember = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.countRefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.timerRecentMember = new System.Windows.Forms.Timer(this.components);
            this.panelContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecentlyAdded)).BeginInit();
            this.panelContainerCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.AutoScroll = true;
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Controls.Add(this.panel3);
            this.panelContainer.Controls.Add(this.panel2);
            this.panelContainer.Controls.Add(this.label2);
            this.panelContainer.Controls.Add(this.dataGridViewRecentlyAdded);
            this.panelContainer.Controls.Add(this.panelContainerCount);
            this.panelContainer.Controls.Add(this.dataGridViewResult);
            this.panelContainer.Controls.Add(this.panel1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1428, 1055);
            this.panelContainer.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(3, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 1071);
            this.panel3.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(81, 262);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 218);
            this.panel2.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(31, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(181, 163);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(935, 217);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4);
            this.dataGridViewRecentlyAdded.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRecentlyAdded.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRecentlyAdded.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRecentlyAdded.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRecentlyAdded.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewRecentlyAdded.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRecentlyAdded.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRecentlyAdded.Location = new System.Drawing.Point(932, 264);
            this.dataGridViewRecentlyAdded.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridViewRecentlyAdded.MultiSelect = false;
            this.dataGridViewRecentlyAdded.Name = "dataGridViewRecentlyAdded";
            this.dataGridViewRecentlyAdded.ReadOnly = true;
            this.dataGridViewRecentlyAdded.RowHeadersVisible = false;
            this.dataGridViewRecentlyAdded.RowHeadersWidth = 51;
            this.dataGridViewRecentlyAdded.RowTemplate.Height = 80;
            this.dataGridViewRecentlyAdded.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRecentlyAdded.Size = new System.Drawing.Size(385, 216);
            this.dataGridViewRecentlyAdded.TabIndex = 6;
            // 
            // panelContainerCount
            // 
            this.panelContainerCount.Controls.Add(this.panel4);
            this.panelContainerCount.Controls.Add(this.panel5);
            this.panelContainerCount.Controls.Add(this.buttonViewRegularMember);
            this.panelContainerCount.Controls.Add(this.buttonViewMember);
            this.panelContainerCount.Controls.Add(this.label4);
            this.panelContainerCount.Controls.Add(this.label3);
            this.panelContainerCount.Controls.Add(this.labelNotStudentMemberCount);
            this.panelContainerCount.Controls.Add(this.labelStudentCount);
            this.panelContainerCount.Location = new System.Drawing.Point(932, 33);
            this.panelContainerCount.Name = "panelContainerCount";
            this.panelContainerCount.Size = new System.Drawing.Size(385, 181);
            this.panelContainerCount.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Location = new System.Drawing.Point(223, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(132, 3);
            this.panel4.TabIndex = 19;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.Location = new System.Drawing.Point(15, 100);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(132, 3);
            this.panel5.TabIndex = 18;
            // 
            // buttonViewRegularMember
            // 
            this.buttonViewRegularMember.Location = new System.Drawing.Point(200, 119);
            this.buttonViewRegularMember.Name = "buttonViewRegularMember";
            this.buttonViewRegularMember.Size = new System.Drawing.Size(182, 51);
            this.buttonViewRegularMember.TabIndex = 6;
            this.buttonViewRegularMember.Text = "View Regular Members";
            this.buttonViewRegularMember.UseVisualStyleBackColor = true;
            this.buttonViewRegularMember.Click += new System.EventHandler(this.buttonViewRegularMember_Click);
            // 
            // buttonViewMember
            // 
            this.buttonViewMember.Location = new System.Drawing.Point(3, 119);
            this.buttonViewMember.Name = "buttonViewMember";
            this.buttonViewMember.Size = new System.Drawing.Size(182, 51);
            this.buttonViewMember.TabIndex = 5;
            this.buttonViewMember.Text = "View Student Members";
            this.buttonViewMember.UseVisualStyleBackColor = true;
            this.buttonViewMember.Click += new System.EventHandler(this.buttonViewMember_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(229, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 38);
            this.label4.TabIndex = 4;
            this.label4.Text = "Current Regular\r\n    Members";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "Current Student \r\n   Members";
            // 
            // labelNotStudentMemberCount
            // 
            this.labelNotStudentMemberCount.AutoSize = true;
            this.labelNotStudentMemberCount.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotStudentMemberCount.Location = new System.Drawing.Point(274, 62);
            this.labelNotStudentMemberCount.Name = "labelNotStudentMemberCount";
            this.labelNotStudentMemberCount.Size = new System.Drawing.Size(44, 37);
            this.labelNotStudentMemberCount.TabIndex = 1;
            this.labelNotStudentMemberCount.Text = "M";
            // 
            // labelStudentCount
            // 
            this.labelStudentCount.AutoSize = true;
            this.labelStudentCount.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentCount.Location = new System.Drawing.Point(66, 62);
            this.labelStudentCount.Name = "labelStudentCount";
            this.labelStudentCount.Size = new System.Drawing.Size(39, 37);
            this.labelStudentCount.TabIndex = 0;
            this.labelStudentCount.Text = "N";
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.AllowUserToAddRows = false;
            this.dataGridViewResult.AllowUserToDeleteRows = false;
            this.dataGridViewResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResult.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewResult.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewResult.Location = new System.Drawing.Point(72, 62);
            this.dataGridViewResult.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewResult.MultiSelect = false;
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.RowHeadersVisible = false;
            this.dataGridViewResult.RowHeadersWidth = 51;
            this.dataGridViewResult.RowTemplate.Height = 24;
            this.dataGridViewResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewResult.Size = new System.Drawing.Size(850, 141);
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
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecentlyAdded)).EndInit();
            this.panelContainerCount.ResumeLayout(false);
            this.panelContainerCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel panelContainerCount;
        private System.Windows.Forms.Label labelStudentCount;
        private System.Windows.Forms.Button buttonViewMember;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNotStudentMemberCount;
        private System.Windows.Forms.Timer countRefreshTimer;
        private System.Windows.Forms.Button buttonViewRegularMember;
        private System.Windows.Forms.DataGridView dataGridViewRecentlyAdded;
        private System.Windows.Forms.Timer timerRecentMember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}