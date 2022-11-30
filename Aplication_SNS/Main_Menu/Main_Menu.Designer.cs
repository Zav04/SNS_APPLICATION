using System.Resources;
using System.Xml.Linq;

namespace Main_Menu
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
            this.exit_MainMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Hospital_MainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_MainMenu
            // 
            this.exit_MainMenu.Location = new System.Drawing.Point(1479, 954);
            this.exit_MainMenu.Name = "exit_MainMenu";
            this.exit_MainMenu.Size = new System.Drawing.Size(109, 34);
            this.exit_MainMenu.TabIndex = 0;
            this.exit_MainMenu.Text = "EXIT";
            this.exit_MainMenu.UseVisualStyleBackColor = true;
            this.exit_MainMenu.Click += new System.EventHandler(this.button1_Click);
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
            // Hospital_MainMenu
            // 
            this.Hospital_MainMenu.Location = new System.Drawing.Point(51, 396);
            this.Hospital_MainMenu.Name = "Hospital_MainMenu";
            this.Hospital_MainMenu.Size = new System.Drawing.Size(310, 300);
            this.Hospital_MainMenu.TabIndex = 9;
            this.Hospital_MainMenu.Text = "Hospital";
            this.Hospital_MainMenu.UseVisualStyleBackColor = true;
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 1000);
            this.Controls.Add(this.Hospital_MainMenu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exit_MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SNS";
            this.Load += new System.EventHandler(this.Main_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button exit_MainMenu;
        private PictureBox pictureBox1;
        private Button Hospital_MainMenu;
        private Button Staff_MainMenu;
        private Button Pacient_MainMenu;
        private Button Report_MainMenu;
    }
}