namespace Menus.ReceptionStats
{
    partial class Reception_Statistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reception_Statistics));
            this.Recption_Stats = new System.Windows.Forms.DataGridView();
            this.BACK_Reception_Menu = new System.Windows.Forms.Button();
            this.Hospital_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Recption_Stats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Recption_Stats
            // 
            this.Recption_Stats.AllowUserToDeleteRows = false;
            this.Recption_Stats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Recption_Stats.Location = new System.Drawing.Point(23, 126);
            this.Recption_Stats.Name = "Recption_Stats";
            this.Recption_Stats.ReadOnly = true;
            this.Recption_Stats.RowTemplate.Height = 25;
            this.Recption_Stats.Size = new System.Drawing.Size(1553, 650);
            this.Recption_Stats.TabIndex = 48;
            // 
            // BACK_Reception_Menu
            // 
            this.BACK_Reception_Menu.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BACK_Reception_Menu.Location = new System.Drawing.Point(1442, 833);
            this.BACK_Reception_Menu.Name = "BACK_Reception_Menu";
            this.BACK_Reception_Menu.Size = new System.Drawing.Size(134, 56);
            this.BACK_Reception_Menu.TabIndex = 47;
            this.BACK_Reception_Menu.Text = "BACK";
            this.BACK_Reception_Menu.UseVisualStyleBackColor = true;
            this.BACK_Reception_Menu.Click += new System.EventHandler(this.BACK_Reception_Menu_Click);
            // 
            // Hospital_label
            // 
            this.Hospital_label.AutoSize = true;
            this.Hospital_label.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Hospital_label.Location = new System.Drawing.Point(530, 12);
            this.Hospital_label.Name = "Hospital_label";
            this.Hospital_label.Size = new System.Drawing.Size(644, 74);
            this.Hospital_label.TabIndex = 45;
            this.Hospital_label.Text = "RECEPTION STATISTICS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1443, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(399, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // Reception_Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.Recption_Stats);
            this.Controls.Add(this.BACK_Reception_Menu);
            this.Controls.Add(this.Hospital_label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reception_Statistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reception_Statistics";
            this.Load += new System.EventHandler(this.Reception_Statistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Recption_Stats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView Recption_Stats;
        private Button BACK_Reception_Menu;
        private Label Hospital_label;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}