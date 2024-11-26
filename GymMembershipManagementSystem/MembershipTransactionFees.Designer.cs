namespace GymMembershipManagementSystem
{
    partial class MembershipTransactionFees
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.labelTotalMembershipFee = new System.Windows.Forms.Label();
            this.dataGridStudentFeeTotal = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.chartMembershipFees = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudentFeeTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMembershipFees)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.chartMembershipFees);
            this.panelContainer.Controls.Add(this.labelTotalMembershipFee);
            this.panelContainer.Controls.Add(this.dataGridStudentFeeTotal);
            this.panelContainer.Controls.Add(this.label2);
            this.panelContainer.Controls.Add(this.panel2);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1428, 1055);
            this.panelContainer.TabIndex = 0;
            // 
            // labelTotalMembershipFee
            // 
            this.labelTotalMembershipFee.AutoSize = true;
            this.labelTotalMembershipFee.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalMembershipFee.Location = new System.Drawing.Point(16, 89);
            this.labelTotalMembershipFee.Name = "labelTotalMembershipFee";
            this.labelTotalMembershipFee.Size = new System.Drawing.Size(122, 27);
            this.labelTotalMembershipFee.TabIndex = 16;
            this.labelTotalMembershipFee.Text = "labelTotal";
            // 
            // dataGridStudentFeeTotal
            // 
            this.dataGridStudentFeeTotal.AllowUserToAddRows = false;
            this.dataGridStudentFeeTotal.AllowUserToDeleteRows = false;
            this.dataGridStudentFeeTotal.AllowUserToResizeColumns = false;
            this.dataGridStudentFeeTotal.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.dataGridStudentFeeTotal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridStudentFeeTotal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridStudentFeeTotal.BackgroundColor = System.Drawing.Color.White;
            this.dataGridStudentFeeTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridStudentFeeTotal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridStudentFeeTotal.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridStudentFeeTotal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridStudentFeeTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridStudentFeeTotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridStudentFeeTotal.EnableHeadersVisualStyles = false;
            this.dataGridStudentFeeTotal.Location = new System.Drawing.Point(19, 126);
            this.dataGridStudentFeeTotal.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridStudentFeeTotal.MultiSelect = false;
            this.dataGridStudentFeeTotal.Name = "dataGridStudentFeeTotal";
            this.dataGridStudentFeeTotal.ReadOnly = true;
            this.dataGridStudentFeeTotal.RowHeadersVisible = false;
            this.dataGridStudentFeeTotal.RowHeadersWidth = 51;
            this.dataGridStudentFeeTotal.RowTemplate.Height = 80;
            this.dataGridStudentFeeTotal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridStudentFeeTotal.Size = new System.Drawing.Size(1292, 288);
            this.dataGridStudentFeeTotal.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(500, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 39);
            this.label2.TabIndex = 14;
            this.label2.Text = "Transaction History";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(3, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 901);
            this.panel2.TabIndex = 13;
            // 
            // chartMembershipFees
            // 
            this.chartMembershipFees.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartMembershipFees.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMembershipFees.Legends.Add(legend1);
            this.chartMembershipFees.Location = new System.Drawing.Point(21, 427);
            this.chartMembershipFees.Name = "chartMembershipFees";
            this.chartMembershipFees.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartMembershipFees.Series.Add(series1);
            this.chartMembershipFees.Size = new System.Drawing.Size(1290, 300);
            this.chartMembershipFees.TabIndex = 17;
            this.chartMembershipFees.Text = "chart1";
            // 
            // MembershipTransactionFees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1428, 1055);
            this.Controls.Add(this.panelContainer);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MembershipTransactionFees";
            this.Text = "MembershipTransactionFees";
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudentFeeTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMembershipFees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridStudentFeeTotal;
        private System.Windows.Forms.Label labelTotalMembershipFee;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMembershipFees;
    }
}