namespace Menus.Reception
{
    partial class Reception_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reception_Menu));
            this.BACK_Reception_Menu = new System.Windows.Forms.Button();
            this.Hospital_Stats = new System.Windows.Forms.Button();
            this.Hospital_label = new System.Windows.Forms.Label();
            this.Reception_Concierge = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BACK_Reception_Menu
            // 
            this.BACK_Reception_Menu.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BACK_Reception_Menu.Location = new System.Drawing.Point(1454, 832);
            this.BACK_Reception_Menu.Name = "BACK_Reception_Menu";
            this.BACK_Reception_Menu.Size = new System.Drawing.Size(134, 56);
            this.BACK_Reception_Menu.TabIndex = 35;
            this.BACK_Reception_Menu.Text = "BACK";
            this.BACK_Reception_Menu.UseVisualStyleBackColor = true;
            this.BACK_Reception_Menu.Click += new System.EventHandler(this.BACK_Reception_Menu_Click);
            // 
            // Hospital_Stats
            // 
            this.Hospital_Stats.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Hospital_Stats.Location = new System.Drawing.Point(571, 338);
            this.Hospital_Stats.Name = "Hospital_Stats";
            this.Hospital_Stats.Size = new System.Drawing.Size(480, 90);
            this.Hospital_Stats.TabIndex = 32;
            this.Hospital_Stats.Text = "HOSPITAL STATISTICS";
            this.Hospital_Stats.UseVisualStyleBackColor = true;
            this.Hospital_Stats.Click += new System.EventHandler(this.Hospital_Stats_Click);
            // 
            // Hospital_label
            // 
            this.Hospital_label.AutoSize = true;
            this.Hospital_label.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Hospital_label.Location = new System.Drawing.Point(571, 11);
            this.Hospital_label.Name = "Hospital_label";
            this.Hospital_label.Size = new System.Drawing.Size(518, 74);
            this.Hospital_label.TabIndex = 29;
            this.Hospital_label.Text = "RECEPTION MENU";
            // 
            // Reception_Concierge
            // 
            this.Reception_Concierge.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Reception_Concierge.Location = new System.Drawing.Point(571, 178);
            this.Reception_Concierge.Name = "Reception_Concierge";
            this.Reception_Concierge.Size = new System.Drawing.Size(480, 90);
            this.Reception_Concierge.TabIndex = 30;
            this.Reception_Concierge.Text = "HOSPITAL CONCIERGE";
            this.Reception_Concierge.UseVisualStyleBackColor = true;
            this.Reception_Concierge.Click += new System.EventHandler(this.Reception_Concierge_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1455, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(440, 11);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // Reception_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.BACK_Reception_Menu);
            this.Controls.Add(this.Hospital_Stats);
            this.Controls.Add(this.Hospital_label);
            this.Controls.Add(this.Reception_Concierge);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reception_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reception_Menu";
            this.Load += new System.EventHandler(this.Reception_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BACK_Reception_Menu;
        private Button Hospital_Stats;
        private Label Hospital_label;
        private Button Reception_Concierge;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}