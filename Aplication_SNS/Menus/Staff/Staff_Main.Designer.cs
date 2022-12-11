namespace Menus.StaffMain
{
    partial class Staff_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff_Main));
            this.Staff_label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Staff_Nurse = new System.Windows.Forms.Button();
            this.Staff_Doctor = new System.Windows.Forms.Button();
            this.BACK_Hospital_Menu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Staff_label
            // 
            this.Staff_label.AutoSize = true;
            this.Staff_label.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Staff_label.Location = new System.Drawing.Point(654, 21);
            this.Staff_label.Name = "Staff_label";
            this.Staff_label.Size = new System.Drawing.Size(372, 74);
            this.Staff_label.TabIndex = 13;
            this.Staff_label.Text = "STAFF MENU";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(509, 6);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(193, 111);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // Staff_Nurse
            // 
            this.Staff_Nurse.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Staff_Nurse.Location = new System.Drawing.Point(889, 193);
            this.Staff_Nurse.Name = "Staff_Nurse";
            this.Staff_Nurse.Size = new System.Drawing.Size(629, 590);
            this.Staff_Nurse.TabIndex = 15;
            this.Staff_Nurse.Text = "NURSES";
            this.Staff_Nurse.UseVisualStyleBackColor = true;
            this.Staff_Nurse.Click += new System.EventHandler(this.Staff_Nurse_Click);
            // 
            // Staff_Doctor
            // 
            this.Staff_Doctor.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Staff_Doctor.Location = new System.Drawing.Point(73, 193);
            this.Staff_Doctor.Name = "Staff_Doctor";
            this.Staff_Doctor.Size = new System.Drawing.Size(629, 590);
            this.Staff_Doctor.TabIndex = 16;
            this.Staff_Doctor.Text = "DOCTORS";
            this.Staff_Doctor.UseVisualStyleBackColor = true;
            this.Staff_Doctor.Click += new System.EventHandler(this.Staff_Doctor_Click);
            // 
            // BACK_Hospital_Menu
            // 
            this.BACK_Hospital_Menu.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BACK_Hospital_Menu.Location = new System.Drawing.Point(1455, 932);
            this.BACK_Hospital_Menu.Name = "BACK_Hospital_Menu";
            this.BACK_Hospital_Menu.Size = new System.Drawing.Size(134, 56);
            this.BACK_Hospital_Menu.TabIndex = 17;
            this.BACK_Hospital_Menu.Text = "BACK";
            this.BACK_Hospital_Menu.UseVisualStyleBackColor = true;
            this.BACK_Hospital_Menu.Click += new System.EventHandler(this.BACK_Hospital_Menu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1455, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Staff_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 1000);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BACK_Hospital_Menu);
            this.Controls.Add(this.Staff_Doctor);
            this.Controls.Add(this.Staff_Nurse);
            this.Controls.Add(this.Staff_label);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Staff_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff_Main";
            this.Load += new System.EventHandler(this.Staff_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Staff_label;
        private PictureBox pictureBox2;
        private Button Staff_Nurse;
        private Button Staff_Doctor;
        private Button BACK_Hospital_Menu;
        private PictureBox pictureBox1;
    }
}