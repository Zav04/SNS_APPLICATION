using System.Resources;
using System.Xml.Linq;

namespace Menus
{
    partial class Main_Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hospital_MainMenu = new System.Windows.Forms.Button();
            this.staff_MainMenu = new System.Windows.Forms.Button();
            this.pacient_MainMenu = new System.Windows.Forms.Button();
            this.report_MainMenu = new System.Windows.Forms.Button();
            this.logout_MainMenu = new System.Windows.Forms.Button();
            this.infoVersion_MainMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(513, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(494, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // hospital_MainMenu
            // 
            this.hospital_MainMenu.Image = ((System.Drawing.Image)(resources.GetObject("hospital_MainMenu.Image")));
            this.hospital_MainMenu.Location = new System.Drawing.Point(50, 300);
            this.hospital_MainMenu.Name = "hospital_MainMenu";
            this.hospital_MainMenu.Size = new System.Drawing.Size(300, 350);
            this.hospital_MainMenu.TabIndex = 9;
            this.hospital_MainMenu.UseVisualStyleBackColor = true;
            // 
            // staff_MainMenu
            // 
            this.staff_MainMenu.Image = ((System.Drawing.Image)(resources.GetObject("staff_MainMenu.Image")));
            this.staff_MainMenu.Location = new System.Drawing.Point(450, 300);
            this.staff_MainMenu.Name = "staff_MainMenu";
            this.staff_MainMenu.Size = new System.Drawing.Size(300, 350);
            this.staff_MainMenu.TabIndex = 10;
            this.staff_MainMenu.UseVisualStyleBackColor = true;
            // 
            // pacient_MainMenu
            // 
            this.pacient_MainMenu.Image = ((System.Drawing.Image)(resources.GetObject("pacient_MainMenu.Image")));
            this.pacient_MainMenu.Location = new System.Drawing.Point(850, 300);
            this.pacient_MainMenu.Name = "pacient_MainMenu";
            this.pacient_MainMenu.Size = new System.Drawing.Size(300, 350);
            this.pacient_MainMenu.TabIndex = 11;
            this.pacient_MainMenu.UseVisualStyleBackColor = true;
            this.pacient_MainMenu.Click += new System.EventHandler(this.pacient_MainMenu_Click);
            // 
            // report_MainMenu
            // 
            this.report_MainMenu.Image = ((System.Drawing.Image)(resources.GetObject("report_MainMenu.Image")));
            this.report_MainMenu.Location = new System.Drawing.Point(1250, 300);
            this.report_MainMenu.Name = "report_MainMenu";
            this.report_MainMenu.Size = new System.Drawing.Size(300, 350);
            this.report_MainMenu.TabIndex = 12;
            this.report_MainMenu.UseVisualStyleBackColor = true;
            this.report_MainMenu.Click += new System.EventHandler(this.report_MainMenu_Click);
            // 
            // logout_MainMenu
            // 
            this.logout_MainMenu.Image = ((System.Drawing.Image)(resources.GetObject("logout_MainMenu.Image")));
            this.logout_MainMenu.Location = new System.Drawing.Point(1492, 1);
            this.logout_MainMenu.Name = "logout_MainMenu";
            this.logout_MainMenu.Size = new System.Drawing.Size(45, 45);
            this.logout_MainMenu.TabIndex = 13;
            this.logout_MainMenu.UseVisualStyleBackColor = true;
            this.logout_MainMenu.Click += new System.EventHandler(this.logout_MainMenu_Click);
            // 
            // infoVersion_MainMenu
            // 
            this.infoVersion_MainMenu.Image = ((System.Drawing.Image)(resources.GetObject("infoVersion_MainMenu.Image")));
            this.infoVersion_MainMenu.Location = new System.Drawing.Point(1441, 1);
            this.infoVersion_MainMenu.Name = "infoVersion_MainMenu";
            this.infoVersion_MainMenu.Size = new System.Drawing.Size(45, 45);
            this.infoVersion_MainMenu.TabIndex = 14;
            this.infoVersion_MainMenu.UseVisualStyleBackColor = true;
            this.infoVersion_MainMenu.Click += new System.EventHandler(this.infoVersion_MainMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(53, 653);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 74);
            this.label1.TabIndex = 15;
            this.label1.Text = "HOSPITAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(513, 653);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 74);
            this.label2.TabIndex = 16;
            this.label2.Text = "STAFF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(872, 653);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 74);
            this.label3.TabIndex = 17;
            this.label3.Text = "PACIENT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1266, 653);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 74);
            this.label4.TabIndex = 18;
            this.label4.Text = "REPORTS";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1543, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 1000);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.infoVersion_MainMenu);
            this.Controls.Add(this.logout_MainMenu);
            this.Controls.Add(this.report_MainMenu);
            this.Controls.Add(this.pacient_MainMenu);
            this.Controls.Add(this.staff_MainMenu);
            this.Controls.Add(this.hospital_MainMenu);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SNS";
            this.Load += new System.EventHandler(this.Main_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button hospital_MainMenu;
        private Button staff_MainMenu;
        private Button pacient_MainMenu;
        private Button report_MainMenu;
        private Button logout_MainMenu;
        private Button infoVersion_MainMenu;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}