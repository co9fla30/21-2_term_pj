
namespace _21_2_term_pj
{
    partial class Form4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rA1DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rA2DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rA3DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rB1DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rB2DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rB3DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.uIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reservationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1058, 668);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "예약정보 확인";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rNoDataGridViewTextBoxColumn,
            this.mNameDataGridViewTextBoxColumn,
            this.rPriceDataGridViewTextBoxColumn,
            this.rA1DataGridViewCheckBoxColumn,
            this.rA2DataGridViewCheckBoxColumn,
            this.rA3DataGridViewCheckBoxColumn,
            this.rB1DataGridViewCheckBoxColumn,
            this.rB2DataGridViewCheckBoxColumn,
            this.rB3DataGridViewCheckBoxColumn,
            this.uIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reservationBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(7, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1045, 354);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            // 
            // rNoDataGridViewTextBoxColumn
            // 
            this.rNoDataGridViewTextBoxColumn.DataPropertyName = "RNo";
            this.rNoDataGridViewTextBoxColumn.HeaderText = "RNo";
            this.rNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rNoDataGridViewTextBoxColumn.Name = "rNoDataGridViewTextBoxColumn";
            this.rNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // mNameDataGridViewTextBoxColumn
            // 
            this.mNameDataGridViewTextBoxColumn.DataPropertyName = "MName";
            this.mNameDataGridViewTextBoxColumn.HeaderText = "MName";
            this.mNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mNameDataGridViewTextBoxColumn.Name = "mNameDataGridViewTextBoxColumn";
            this.mNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // rPriceDataGridViewTextBoxColumn
            // 
            this.rPriceDataGridViewTextBoxColumn.DataPropertyName = "RPrice";
            this.rPriceDataGridViewTextBoxColumn.HeaderText = "RPrice";
            this.rPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rPriceDataGridViewTextBoxColumn.Name = "rPriceDataGridViewTextBoxColumn";
            this.rPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // rA1DataGridViewCheckBoxColumn
            // 
            this.rA1DataGridViewCheckBoxColumn.DataPropertyName = "RA1";
            this.rA1DataGridViewCheckBoxColumn.HeaderText = "RA1";
            this.rA1DataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.rA1DataGridViewCheckBoxColumn.Name = "rA1DataGridViewCheckBoxColumn";
            this.rA1DataGridViewCheckBoxColumn.Width = 125;
            // 
            // rA2DataGridViewCheckBoxColumn
            // 
            this.rA2DataGridViewCheckBoxColumn.DataPropertyName = "RA2";
            this.rA2DataGridViewCheckBoxColumn.HeaderText = "RA2";
            this.rA2DataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.rA2DataGridViewCheckBoxColumn.Name = "rA2DataGridViewCheckBoxColumn";
            this.rA2DataGridViewCheckBoxColumn.Width = 125;
            // 
            // rA3DataGridViewCheckBoxColumn
            // 
            this.rA3DataGridViewCheckBoxColumn.DataPropertyName = "RA3";
            this.rA3DataGridViewCheckBoxColumn.HeaderText = "RA3";
            this.rA3DataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.rA3DataGridViewCheckBoxColumn.Name = "rA3DataGridViewCheckBoxColumn";
            this.rA3DataGridViewCheckBoxColumn.Width = 125;
            // 
            // rB1DataGridViewCheckBoxColumn
            // 
            this.rB1DataGridViewCheckBoxColumn.DataPropertyName = "RB1";
            this.rB1DataGridViewCheckBoxColumn.HeaderText = "RB1";
            this.rB1DataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.rB1DataGridViewCheckBoxColumn.Name = "rB1DataGridViewCheckBoxColumn";
            this.rB1DataGridViewCheckBoxColumn.Width = 125;
            // 
            // rB2DataGridViewCheckBoxColumn
            // 
            this.rB2DataGridViewCheckBoxColumn.DataPropertyName = "RB2";
            this.rB2DataGridViewCheckBoxColumn.HeaderText = "RB2";
            this.rB2DataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.rB2DataGridViewCheckBoxColumn.Name = "rB2DataGridViewCheckBoxColumn";
            this.rB2DataGridViewCheckBoxColumn.Width = 125;
            // 
            // rB3DataGridViewCheckBoxColumn
            // 
            this.rB3DataGridViewCheckBoxColumn.DataPropertyName = "RB3";
            this.rB3DataGridViewCheckBoxColumn.HeaderText = "RB3";
            this.rB3DataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.rB3DataGridViewCheckBoxColumn.Name = "rB3DataGridViewCheckBoxColumn";
            this.rB3DataGridViewCheckBoxColumn.Width = 125;
            // 
            // uIdDataGridViewTextBoxColumn
            // 
            this.uIdDataGridViewTextBoxColumn.DataPropertyName = "UId";
            this.uIdDataGridViewTextBoxColumn.HeaderText = "UId";
            this.uIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uIdDataGridViewTextBoxColumn.Name = "uIdDataGridViewTextBoxColumn";
            this.uIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // reservationBindingSource2
            // 
            this.reservationBindingSource2.DataSource = typeof(_21_2_term_pj.Reservation);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 9F);
            this.label8.Location = new System.Drawing.Point(545, 524);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "UserID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 9F);
            this.label9.Location = new System.Drawing.Point(545, 492);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "좌석";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("굴림", 9F);
            this.label13.Location = new System.Drawing.Point(535, 462);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 15);
            this.label13.TabIndex = 15;
            this.label13.Text = "예매번호";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("굴림", 9F);
            this.label14.Location = new System.Drawing.Point(525, 428);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 15);
            this.label14.TabIndex = 14;
            this.label14.Text = "<뮤지컬>";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 11F);
            this.label6.Location = new System.Drawing.Point(419, 524);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "예매한 ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 11F);
            this.label7.Location = new System.Drawing.Point(435, 490);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "좌석";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("굴림", 15F);
            this.button2.Location = new System.Drawing.Point(447, 578);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 40);
            this.button2.TabIndex = 9;
            this.button2.Text = "예약취소\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 11F);
            this.label2.Location = new System.Drawing.Point(419, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "예매번호";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 11F);
            this.label1.Location = new System.Drawing.Point(409, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "<뮤지컬>";
            // 
            // reservationBindingSource1
            // 
            this.reservationBindingSource1.DataSource = typeof(_21_2_term_pj.Reservation);
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataSource = typeof(_21_2_term_pj.Reservation);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 753);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.BindingSource reservationBindingSource;
        private System.Windows.Forms.BindingSource reservationBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rA1DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rA2DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rA3DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rB1DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rB2DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rB3DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource reservationBindingSource2;
    }
}