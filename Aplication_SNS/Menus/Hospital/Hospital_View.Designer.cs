namespace Menus.HospitalView
{
    partial class Hospital_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hospital_View));
            this.Hospital_View_Table = new System.Windows.Forms.DataGridView();
            this.Back_Hospital_View = new System.Windows.Forms.Button();
            this.Hospital_label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Hospital_View_Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Hospital_View_Table
            // 
            this.Hospital_View_Table.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Hospital_View_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Hospital_View_Table.Location = new System.Drawing.Point(12, 134);
            this.Hospital_View_Table.Name = "Hospital_View_Table";
            this.Hospital_View_Table.RowTemplate.Height = 25;
            this.Hospital_View_Table.Size = new System.Drawing.Size(1576, 696);
            this.Hospital_View_Table.TabIndex = 0;
            // 
            // Back_Hospital_View
            // 
            this.Back_Hospital_View.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Back_Hospital_View.Location = new System.Drawing.Point(1454, 892);
            this.Back_Hospital_View.Name = "Back_Hospital_View";
            this.Back_Hospital_View.Size = new System.Drawing.Size(134, 56);
            this.Back_Hospital_View.TabIndex = 1;
            this.Back_Hospital_View.Text = "BACK";
            this.Back_Hospital_View.UseVisualStyleBackColor = true;
            this.Back_Hospital_View.Click += new System.EventHandler(this.button1_Click);
            // 
            // Hospital_label
            // 
            this.Hospital_label.AutoSize = true;
            this.Hospital_label.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Hospital_label.Location = new System.Drawing.Point(581, 9);
            this.Hospital_label.Name = "Hospital_label";
            this.Hospital_label.Size = new System.Drawing.Size(480, 74);
            this.Hospital_label.TabIndex = 13;
            this.Hospital_label.Text = "HOSPITAL LIST";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(450, 9);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // Hospital_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 1000);
            this.Controls.Add(this.Hospital_label);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Back_Hospital_View);
            this.Controls.Add(this.Hospital_View_Table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hospital_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital_View";
            this.Load += new System.EventHandler(this.Hospital_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Hospital_View_Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView Hospital_View_Table;
        private Button Back_Hospital_View;
        private Label Hospital_label;
        private PictureBox pictureBox2;
    }
}