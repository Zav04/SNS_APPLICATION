namespace Menus.StaffDoctorHire
{
    partial class Staff_Doctor_Hire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff_Doctor_Hire));
            this.Doctor_label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Hospital_Hire_Table = new System.Windows.Forms.DataGridView();
            this.Doctor_Hire_Table = new System.Windows.Forms.DataGridView();
            this.BACK_Hospital_Menu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hospital_Hire_Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Doctor_Hire_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // Doctor_label
            // 
            this.Doctor_label.AutoSize = true;
            this.Doctor_label.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Doctor_label.Location = new System.Drawing.Point(566, 9);
            this.Doctor_label.Name = "Doctor_label";
            this.Doctor_label.Size = new System.Drawing.Size(403, 74);
            this.Doctor_label.TabIndex = 35;
            this.Doctor_label.Text = "DOCTOR HIRE";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(411, 9);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(204, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // Hospital_Hire_Table
            // 
            this.Hospital_Hire_Table.AllowUserToDeleteRows = false;
            this.Hospital_Hire_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Hospital_Hire_Table.Location = new System.Drawing.Point(20, 120);
            this.Hospital_Hire_Table.Name = "Hospital_Hire_Table";
            this.Hospital_Hire_Table.ReadOnly = true;
            this.Hospital_Hire_Table.RowTemplate.Height = 25;
            this.Hospital_Hire_Table.Size = new System.Drawing.Size(750, 650);
            this.Hospital_Hire_Table.TabIndex = 37;
            this.Hospital_Hire_Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Hospital_Hire_Table_CellClick);
            // 
            // Doctor_Hire_Table
            // 
            this.Doctor_Hire_Table.AllowUserToDeleteRows = false;
            this.Doctor_Hire_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Doctor_Hire_Table.Location = new System.Drawing.Point(800, 120);
            this.Doctor_Hire_Table.Name = "Doctor_Hire_Table";
            this.Doctor_Hire_Table.ReadOnly = true;
            this.Doctor_Hire_Table.RowTemplate.Height = 25;
            this.Doctor_Hire_Table.Size = new System.Drawing.Size(750, 650);
            this.Doctor_Hire_Table.TabIndex = 38;
            this.Doctor_Hire_Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Doctor_Hire_Table_CellClick);
            // 
            // BACK_Hospital_Menu
            // 
            this.BACK_Hospital_Menu.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BACK_Hospital_Menu.Location = new System.Drawing.Point(1454, 832);
            this.BACK_Hospital_Menu.Name = "BACK_Hospital_Menu";
            this.BACK_Hospital_Menu.Size = new System.Drawing.Size(134, 56);
            this.BACK_Hospital_Menu.TabIndex = 39;
            this.BACK_Hospital_Menu.Text = "BACK";
            this.BACK_Hospital_Menu.UseVisualStyleBackColor = true;
            this.BACK_Hospital_Menu.Click += new System.EventHandler(this.BACK_Hospital_Menu_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(535, 804);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(464, 56);
            this.button1.TabIndex = 40;
            this.button1.Text = "HIRE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Staff_Doctor_Hire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BACK_Hospital_Menu);
            this.Controls.Add(this.Doctor_Hire_Table);
            this.Controls.Add(this.Hospital_Hire_Table);
            this.Controls.Add(this.Doctor_label);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Staff_Doctor_Hire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff_Doctor_Hire";
            this.Load += new System.EventHandler(this.Staff_Doctor_Hire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hospital_Hire_Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Doctor_Hire_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Doctor_label;
        private PictureBox pictureBox2;
        private DataGridView Hospital_Hire_Table;
        private DataGridView Doctor_Hire_Table;
        private Button BACK_Hospital_Menu;
        private Button button1;
    }
}