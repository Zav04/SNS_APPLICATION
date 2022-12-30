namespace Menus.HospitalDelete
{
    partial class Hospital_Delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hospital_Delete));
            this.Hospital_Remove_Remove = new System.Windows.Forms.Button();
            this.Back_Hospital_Remove = new System.Windows.Forms.Button();
            this.Hospital_Remove_Table = new System.Windows.Forms.DataGridView();
            this.Hospital_label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Hospital_Remove_Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Hospital_Remove_Remove
            // 
            this.Hospital_Remove_Remove.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Hospital_Remove_Remove.Location = new System.Drawing.Point(1150, 430);
            this.Hospital_Remove_Remove.Name = "Hospital_Remove_Remove";
            this.Hospital_Remove_Remove.Size = new System.Drawing.Size(392, 56);
            this.Hospital_Remove_Remove.TabIndex = 58;
            this.Hospital_Remove_Remove.Text = "REMOVE";
            this.Hospital_Remove_Remove.UseVisualStyleBackColor = true;
            this.Hospital_Remove_Remove.Click += new System.EventHandler(this.Hospital_Remove_Click);
            // 
            // Back_Hospital_Remove
            // 
            this.Back_Hospital_Remove.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Back_Hospital_Remove.Location = new System.Drawing.Point(1454, 934);
            this.Back_Hospital_Remove.Name = "Back_Hospital_Remove";
            this.Back_Hospital_Remove.Size = new System.Drawing.Size(134, 56);
            this.Back_Hospital_Remove.TabIndex = 43;
            this.Back_Hospital_Remove.Text = "BACK";
            this.Back_Hospital_Remove.UseVisualStyleBackColor = true;
            this.Back_Hospital_Remove.Click += new System.EventHandler(this.Back_Hospital_Click);
            // 
            // Hospital_Remove_Table
            // 
            this.Hospital_Remove_Table.AllowUserToDeleteRows = false;
            this.Hospital_Remove_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Hospital_Remove_Table.Location = new System.Drawing.Point(12, 115);
            this.Hospital_Remove_Table.Name = "Hospital_Remove_Table";
            this.Hospital_Remove_Table.ReadOnly = true;
            this.Hospital_Remove_Table.RowTemplate.Height = 25;
            this.Hospital_Remove_Table.Size = new System.Drawing.Size(1000, 718);
            this.Hospital_Remove_Table.TabIndex = 42;
            this.Hospital_Remove_Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Hospital_Remove_Cell_Click);
            // 
            // Hospital_label
            // 
            this.Hospital_label.AutoSize = true;
            this.Hospital_label.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Hospital_label.Location = new System.Drawing.Point(631, 11);
            this.Hospital_label.Name = "Hospital_label";
            this.Hospital_label.Size = new System.Drawing.Size(542, 74);
            this.Hospital_label.TabIndex = 40;
            this.Hospital_label.Text = "HOSPITAL REMOVE";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(500, 11);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // Hospital_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 1000);
            this.Controls.Add(this.Hospital_Remove_Remove);
            this.Controls.Add(this.Back_Hospital_Remove);
            this.Controls.Add(this.Hospital_Remove_Table);
            this.Controls.Add(this.Hospital_label);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hospital_Delete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital_Delete";
            this.Load += new System.EventHandler(this.Hospital_Delete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Hospital_Remove_Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Hospital_Remove_Remove;
        private Button Back_Hospital_Remove;
        private DataGridView Hospital_Remove_Table;
        private Label Hospital_label;
        private PictureBox pictureBox2;
    }
}