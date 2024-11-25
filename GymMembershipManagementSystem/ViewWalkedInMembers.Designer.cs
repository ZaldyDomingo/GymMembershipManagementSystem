﻿namespace GymMembershipManagementSystem
{
    partial class ViewWalkedInMembers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewNewWalkin = new System.Windows.Forms.DataGridView();
            this.dataGridViewOldWalkedin = new System.Windows.Forms.DataGridView();
            this.labelTotalMembershipFee = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.labelTotalWalkedInMember = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNewWalkin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOldWalkedin)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(500, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 39);
            this.label2.TabIndex = 15;
            this.label2.Text = "Walked-In Members\r\n";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(3, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 901);
            this.panel2.TabIndex = 16;
            // 
            // dataGridViewNewWalkin
            // 
            this.dataGridViewNewWalkin.AllowUserToAddRows = false;
            this.dataGridViewNewWalkin.AllowUserToDeleteRows = false;
            this.dataGridViewNewWalkin.AllowUserToResizeColumns = false;
            this.dataGridViewNewWalkin.AllowUserToResizeRows = false;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewNewWalkin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle37;
            this.dataGridViewNewWalkin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNewWalkin.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewNewWalkin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewNewWalkin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNewWalkin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle38;
            this.dataGridViewNewWalkin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle39.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewNewWalkin.DefaultCellStyle = dataGridViewCellStyle39;
            this.dataGridViewNewWalkin.EnableHeadersVisualStyles = false;
            this.dataGridViewNewWalkin.GridColor = System.Drawing.Color.White;
            this.dataGridViewNewWalkin.Location = new System.Drawing.Point(19, 126);
            this.dataGridViewNewWalkin.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridViewNewWalkin.MultiSelect = false;
            this.dataGridViewNewWalkin.Name = "dataGridViewNewWalkin";
            this.dataGridViewNewWalkin.ReadOnly = true;
            this.dataGridViewNewWalkin.RowHeadersVisible = false;
            this.dataGridViewNewWalkin.RowHeadersWidth = 51;
            this.dataGridViewNewWalkin.RowTemplate.Height = 80;
            this.dataGridViewNewWalkin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNewWalkin.Size = new System.Drawing.Size(492, 377);
            this.dataGridViewNewWalkin.TabIndex = 17;
            // 
            // dataGridViewOldWalkedin
            // 
            this.dataGridViewOldWalkedin.AllowUserToAddRows = false;
            this.dataGridViewOldWalkedin.AllowUserToDeleteRows = false;
            this.dataGridViewOldWalkedin.AllowUserToResizeColumns = false;
            this.dataGridViewOldWalkedin.AllowUserToResizeRows = false;
            dataGridViewCellStyle40.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewOldWalkedin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle40;
            this.dataGridViewOldWalkedin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOldWalkedin.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOldWalkedin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewOldWalkedin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle41.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle41.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle41.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOldWalkedin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle41;
            this.dataGridViewOldWalkedin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle42.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle42.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOldWalkedin.DefaultCellStyle = dataGridViewCellStyle42;
            this.dataGridViewOldWalkedin.EnableHeadersVisualStyles = false;
            this.dataGridViewOldWalkedin.GridColor = System.Drawing.Color.White;
            this.dataGridViewOldWalkedin.Location = new System.Drawing.Point(536, 126);
            this.dataGridViewOldWalkedin.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridViewOldWalkedin.MultiSelect = false;
            this.dataGridViewOldWalkedin.Name = "dataGridViewOldWalkedin";
            this.dataGridViewOldWalkedin.ReadOnly = true;
            this.dataGridViewOldWalkedin.RowHeadersVisible = false;
            this.dataGridViewOldWalkedin.RowHeadersWidth = 51;
            this.dataGridViewOldWalkedin.RowTemplate.Height = 80;
            this.dataGridViewOldWalkedin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOldWalkedin.Size = new System.Drawing.Size(492, 377);
            this.dataGridViewOldWalkedin.TabIndex = 18;
            // 
            // labelTotalMembershipFee
            // 
            this.labelTotalMembershipFee.AutoSize = true;
            this.labelTotalMembershipFee.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalMembershipFee.Location = new System.Drawing.Point(531, 89);
            this.labelTotalMembershipFee.Name = "labelTotalMembershipFee";
            this.labelTotalMembershipFee.Size = new System.Drawing.Size(311, 27);
            this.labelTotalMembershipFee.TabIndex = 19;
            this.labelTotalMembershipFee.Text = "Added Walked-in Member";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 27);
            this.label1.TabIndex = 20;
            this.label1.Text = "Newly added Walk-in Member";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Location = new System.Drawing.Point(1224, 15);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(98, 47);
            this.buttonRefresh.TabIndex = 22;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // labelTotalWalkedInMember
            // 
            this.labelTotalWalkedInMember.AutoSize = true;
            this.labelTotalWalkedInMember.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalWalkedInMember.Location = new System.Drawing.Point(1165, 265);
            this.labelTotalWalkedInMember.Name = "labelTotalWalkedInMember";
            this.labelTotalWalkedInMember.Size = new System.Drawing.Size(82, 27);
            this.labelTotalWalkedInMember.TabIndex = 23;
            this.labelTotalWalkedInMember.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1113, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 38);
            this.label4.TabIndex = 24;
            this.label4.Text = "      Total Added \r\nWalked-in Member";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(1084, 301);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 3);
            this.panel1.TabIndex = 17;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(1055, 126);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(127, 61);
            this.buttonDelete.TabIndex = 25;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // ViewWalkedInMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1428, 1055);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelTotalWalkedInMember);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTotalMembershipFee);
            this.Controls.Add(this.dataGridViewOldWalkedin);
            this.Controls.Add(this.dataGridViewNewWalkin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewWalkedInMembers";
            this.Text = "ViewWalkedInMembers";
            this.Load += new System.EventHandler(this.ViewWalkedInMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNewWalkin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOldWalkedin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewNewWalkin;
        private System.Windows.Forms.DataGridView dataGridViewOldWalkedin;
        private System.Windows.Forms.Label labelTotalMembershipFee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.Label labelTotalWalkedInMember;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonDelete;
    }
}