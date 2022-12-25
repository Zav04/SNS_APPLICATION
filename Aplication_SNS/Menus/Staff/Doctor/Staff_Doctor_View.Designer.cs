namespace Menus.StaffDoctorView
{
    partial class Staff_Doctor_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff_Doctor_View));
            this.Back_Doctor_View = new System.Windows.Forms.Button();
            this.Doctor_View_Table = new System.Windows.Forms.DataGridView();
            this.Staff_label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Doctor_View_Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Back_Doctor_View
            // 
            this.Back_Doctor_View.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Back_Doctor_View.Location = new System.Drawing.Point(1446, 793);
            this.Back_Doctor_View.Name = "Back_Doctor_View";
            this.Back_Doctor_View.Size = new System.Drawing.Size(134, 56);
            this.Back_Doctor_View.TabIndex = 3;
            this.Back_Doctor_View.Text = "BACK";
            this.Back_Doctor_View.UseVisualStyleBackColor = true;
            this.Back_Doctor_View.Click += new System.EventHandler(this.Back_Doctor_View_Click);
            // 
            // Doctor_View_Table
            // 
            this.Doctor_View_Table.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Doctor_View_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Doctor_View_Table.Location = new System.Drawing.Point(4, 147);
            this.Doctor_View_Table.Name = "Doctor_View_Table";
            this.Doctor_View_Table.RowTemplate.Height = 25;
            this.Doctor_View_Table.Size = new System.Drawing.Size(1576, 572);
            this.Doctor_View_Table.TabIndex = 2;
            // 
            // Staff_label
            // 
            this.Staff_label.AutoSize = true;
            this.Staff_label.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Staff_label.Location = new System.Drawing.Point(571, 25);
            this.Staff_label.Name = "Staff_label";
            this.Staff_label.Size = new System.Drawing.Size(589, 74);
            this.Staff_label.TabIndex = 25;
            this.Staff_label.Text = "STAFF DOCTOR VIEW";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(421, 11);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(193, 111);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // Staff_Doctor_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.Staff_label);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Back_Doctor_View);
            this.Controls.Add(this.Doctor_View_Table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Staff_Doctor_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff_Doctor_View";
            this.Load += new System.EventHandler(this.Staff_Doctor_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Doctor_View_Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Back_Doctor_View;
        private DataGridView Doctor_View_Table;
        private Label Staff_label;
        private PictureBox pictureBox2;
    }
}