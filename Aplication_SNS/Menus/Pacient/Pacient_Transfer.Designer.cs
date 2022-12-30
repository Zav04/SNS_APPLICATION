namespace Menus.PacientTransfer
{
    partial class Pacient_Transfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pacient_Transfer));
            this.Pacient_Tranfer_BT = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Hospital_Combo = new System.Windows.Forms.ComboBox();
            this.Back_Hospital_Edit = new System.Windows.Forms.Button();
            this.Pacient_Transfer_Table = new System.Windows.Forms.DataGridView();
            this.Pacient_label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Room_Combo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pacient_Transfer_Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Pacient_Tranfer_BT
            // 
            this.Pacient_Tranfer_BT.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pacient_Tranfer_BT.Location = new System.Drawing.Point(1031, 549);
            this.Pacient_Tranfer_BT.Name = "Pacient_Tranfer_BT";
            this.Pacient_Tranfer_BT.Size = new System.Drawing.Size(392, 56);
            this.Pacient_Tranfer_BT.TabIndex = 67;
            this.Pacient_Tranfer_BT.Text = "TRANSFER";
            this.Pacient_Tranfer_BT.UseVisualStyleBackColor = true;
            this.Pacient_Tranfer_BT.Click += new System.EventHandler(this.Pacient_Tranfer_BT_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(1010, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 30);
            this.label7.TabIndex = 66;
            this.label7.Text = "HOSPITAL";
            // 
            // Hospital_Combo
            // 
            this.Hospital_Combo.FormattingEnabled = true;
            this.Hospital_Combo.Location = new System.Drawing.Point(1137, 371);
            this.Hospital_Combo.Name = "Hospital_Combo";
            this.Hospital_Combo.Size = new System.Drawing.Size(286, 23);
            this.Hospital_Combo.TabIndex = 65;
            this.Hospital_Combo.SelectedValueChanged += new System.EventHandler(this.HospitalComboIndexChange);
            // 
            // Back_Hospital_Edit
            // 
            this.Back_Hospital_Edit.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Back_Hospital_Edit.Location = new System.Drawing.Point(1454, 832);
            this.Back_Hospital_Edit.Name = "Back_Hospital_Edit";
            this.Back_Hospital_Edit.Size = new System.Drawing.Size(134, 56);
            this.Back_Hospital_Edit.TabIndex = 62;
            this.Back_Hospital_Edit.Text = "BACK";
            this.Back_Hospital_Edit.UseVisualStyleBackColor = true;
            this.Back_Hospital_Edit.Click += new System.EventHandler(this.Back_Hospital_Edit_Click);
            // 
            // Pacient_Transfer_Table
            // 
            this.Pacient_Transfer_Table.AllowUserToDeleteRows = false;
            this.Pacient_Transfer_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Pacient_Transfer_Table.Location = new System.Drawing.Point(12, 112);
            this.Pacient_Transfer_Table.Name = "Pacient_Transfer_Table";
            this.Pacient_Transfer_Table.ReadOnly = true;
            this.Pacient_Transfer_Table.RowTemplate.Height = 25;
            this.Pacient_Transfer_Table.Size = new System.Drawing.Size(850, 718);
            this.Pacient_Transfer_Table.TabIndex = 61;
            this.Pacient_Transfer_Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Pacient_Transfer_Table_CellClick);
            // 
            // Pacient_label
            // 
            this.Pacient_label.AutoSize = true;
            this.Pacient_label.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pacient_label.Location = new System.Drawing.Point(546, 6);
            this.Pacient_label.Name = "Pacient_label";
            this.Pacient_label.Size = new System.Drawing.Size(556, 74);
            this.Pacient_label.TabIndex = 59;
            this.Pacient_label.Text = "PACIENT TRANSFER";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(415, 6);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 60;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1040, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 30);
            this.label1.TabIndex = 69;
            this.label1.Text = "ROOM";
            // 
            // Room_Combo
            // 
            this.Room_Combo.FormattingEnabled = true;
            this.Room_Combo.Location = new System.Drawing.Point(1137, 424);
            this.Room_Combo.Name = "Room_Combo";
            this.Room_Combo.Size = new System.Drawing.Size(286, 23);
            this.Room_Combo.TabIndex = 68;
            // 
            // Pacient_Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Room_Combo);
            this.Controls.Add(this.Pacient_Tranfer_BT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Hospital_Combo);
            this.Controls.Add(this.Back_Hospital_Edit);
            this.Controls.Add(this.Pacient_Transfer_Table);
            this.Controls.Add(this.Pacient_label);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pacient_Transfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacient_Transfer";
            this.Load += new System.EventHandler(this.Pacient_Transfer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pacient_Transfer_Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Pacient_Tranfer_BT;
        private Label label7;
        private ComboBox Hospital_Combo;
        private Button Back_Hospital_Edit;
        private DataGridView Pacient_Transfer_Table;
        private Label Pacient_label;
        private PictureBox pictureBox2;
        private Label label1;
        private ComboBox Room_Combo;
    }
}