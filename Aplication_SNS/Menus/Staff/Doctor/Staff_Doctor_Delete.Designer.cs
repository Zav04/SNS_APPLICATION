namespace Menus.StaffDoctorDelete
{
    partial class Staff_Doctor_Delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff_Doctor_Delete));
            this.Staff_label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Doctor_Remove = new System.Windows.Forms.Button();
            this.Doctor_Delete_Table = new System.Windows.Forms.DataGridView();
            this.Back_Doctor_Remove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Doctor_Delete_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // Staff_label
            // 
            this.Staff_label.AutoSize = true;
            this.Staff_label.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Staff_label.Location = new System.Drawing.Point(544, 24);
            this.Staff_label.Name = "Staff_label";
            this.Staff_label.Size = new System.Drawing.Size(640, 74);
            this.Staff_label.TabIndex = 23;
            this.Staff_label.Text = "STAFF DOCTOR DELETE";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(394, 10);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(193, 111);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // Doctor_Remove
            // 
            this.Doctor_Remove.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Doctor_Remove.Location = new System.Drawing.Point(1167, 469);
            this.Doctor_Remove.Name = "Doctor_Remove";
            this.Doctor_Remove.Size = new System.Drawing.Size(392, 56);
            this.Doctor_Remove.TabIndex = 41;
            this.Doctor_Remove.Text = "REMOVE";
            this.Doctor_Remove.UseVisualStyleBackColor = true;
            this.Doctor_Remove.Click += new System.EventHandler(this.Doctor_Remove_Click);
            // 
            // Doctor_Delete_Table
            // 
            this.Doctor_Delete_Table.AllowUserToDeleteRows = false;
            this.Doctor_Delete_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Doctor_Delete_Table.Location = new System.Drawing.Point(12, 141);
            this.Doctor_Delete_Table.Name = "Doctor_Delete_Table";
            this.Doctor_Delete_Table.ReadOnly = true;
            this.Doctor_Delete_Table.RowTemplate.Height = 25;
            this.Doctor_Delete_Table.Size = new System.Drawing.Size(1109, 718);
            this.Doctor_Delete_Table.TabIndex = 40;
            this.Doctor_Delete_Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Doctor_Delete_Table_CellClick);
            // 
            // Back_Doctor_Remove
            // 
            this.Back_Doctor_Remove.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Back_Doctor_Remove.Location = new System.Drawing.Point(1454, 832);
            this.Back_Doctor_Remove.Name = "Back_Doctor_Remove";
            this.Back_Doctor_Remove.Size = new System.Drawing.Size(134, 56);
            this.Back_Doctor_Remove.TabIndex = 44;
            this.Back_Doctor_Remove.Text = "BACK";
            this.Back_Doctor_Remove.UseVisualStyleBackColor = true;
            this.Back_Doctor_Remove.Click += new System.EventHandler(this.Back_Hospital_Remove_Click);
            // 
            // Staff_Doctor_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.Back_Doctor_Remove);
            this.Controls.Add(this.Doctor_Remove);
            this.Controls.Add(this.Doctor_Delete_Table);
            this.Controls.Add(this.Staff_label);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Staff_Doctor_Delete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff_Doctor_Delete";
            this.Load += new System.EventHandler(this.Staff_Doctor_Delete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Doctor_Delete_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Staff_label;
        private PictureBox pictureBox2;
        private Button Doctor_Remove;
        private DataGridView Doctor_Delete_Table;
        private Button Back_Doctor_Remove;
    }
}