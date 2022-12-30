namespace Menus.PacientView
{
    partial class Pacient_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pacient_View));
            this.Pacient_Demiss_Back = new System.Windows.Forms.Button();
            this.Back_Hospital_Edit = new System.Windows.Forms.Button();
            this.Pacient_View_Table = new System.Windows.Forms.DataGridView();
            this.Pacient_label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pacient_View_Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Pacient_Demiss_Back
            // 
            this.Pacient_Demiss_Back.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pacient_Demiss_Back.Location = new System.Drawing.Point(1453, 832);
            this.Pacient_Demiss_Back.Name = "Pacient_Demiss_Back";
            this.Pacient_Demiss_Back.Size = new System.Drawing.Size(134, 56);
            this.Pacient_Demiss_Back.TabIndex = 74;
            this.Pacient_Demiss_Back.Text = "BACK";
            this.Pacient_Demiss_Back.UseVisualStyleBackColor = true;
            this.Pacient_Demiss_Back.Click += new System.EventHandler(this.Pacient_Demiss_Back_Click);
            // 
            // Back_Hospital_Edit
            // 
            this.Back_Hospital_Edit.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Back_Hospital_Edit.Location = new System.Drawing.Point(1500, 934);
            this.Back_Hospital_Edit.Name = "Back_Hospital_Edit";
            this.Back_Hospital_Edit.Size = new System.Drawing.Size(134, 56);
            this.Back_Hospital_Edit.TabIndex = 72;
            this.Back_Hospital_Edit.Text = "BACK";
            this.Back_Hospital_Edit.UseVisualStyleBackColor = true;
            // 
            // Pacient_View_Table
            // 
            this.Pacient_View_Table.AllowUserToDeleteRows = false;
            this.Pacient_View_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Pacient_View_Table.Location = new System.Drawing.Point(37, 119);
            this.Pacient_View_Table.Name = "Pacient_View_Table";
            this.Pacient_View_Table.ReadOnly = true;
            this.Pacient_View_Table.RowTemplate.Height = 25;
            this.Pacient_View_Table.Size = new System.Drawing.Size(1525, 593);
            this.Pacient_View_Table.TabIndex = 71;
            // 
            // Pacient_label
            // 
            this.Pacient_label.AutoSize = true;
            this.Pacient_label.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pacient_label.Location = new System.Drawing.Point(592, 9);
            this.Pacient_label.Name = "Pacient_label";
            this.Pacient_label.Size = new System.Drawing.Size(418, 74);
            this.Pacient_label.TabIndex = 69;
            this.Pacient_label.Text = "PACIENT VIEW";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(461, 9);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 70;
            this.pictureBox2.TabStop = false;
            // 
            // Pacient_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.Pacient_Demiss_Back);
            this.Controls.Add(this.Back_Hospital_Edit);
            this.Controls.Add(this.Pacient_View_Table);
            this.Controls.Add(this.Pacient_label);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pacient_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacient_View";
            this.Load += new System.EventHandler(this.Pacient_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pacient_View_Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Pacient_Demiss_Back;
        private Button Back_Hospital_Edit;
        private DataGridView Pacient_View_Table;
        private Label Pacient_label;
        private PictureBox pictureBox2;
    }
}