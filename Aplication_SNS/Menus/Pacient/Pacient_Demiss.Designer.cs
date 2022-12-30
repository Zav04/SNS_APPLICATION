namespace Menus.PacientDemiss
{
    partial class Pacient_Demiss
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pacient_Demiss));
            this.Pacient_Demiss_BT = new System.Windows.Forms.Button();
            this.Pacient_Demiss_Table = new System.Windows.Forms.DataGridView();
            this.Pacient_label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Pacient_Demiss_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pacient_Demiss_Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Pacient_Demiss_BT
            // 
            this.Pacient_Demiss_BT.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pacient_Demiss_BT.Location = new System.Drawing.Point(711, 736);
            this.Pacient_Demiss_BT.Name = "Pacient_Demiss_BT";
            this.Pacient_Demiss_BT.Size = new System.Drawing.Size(392, 57);
            this.Pacient_Demiss_BT.TabIndex = 67;
            this.Pacient_Demiss_BT.Text = "DEMISS";
            this.Pacient_Demiss_BT.UseVisualStyleBackColor = true;
            this.Pacient_Demiss_BT.Click += new System.EventHandler(this.Pacient_Demiss_Click);
            // 
            // Pacient_Demiss_Table
            // 
            this.Pacient_Demiss_Table.AllowUserToDeleteRows = false;
            this.Pacient_Demiss_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Pacient_Demiss_Table.Location = new System.Drawing.Point(28, 112);
            this.Pacient_Demiss_Table.Name = "Pacient_Demiss_Table";
            this.Pacient_Demiss_Table.ReadOnly = true;
            this.Pacient_Demiss_Table.RowTemplate.Height = 25;
            this.Pacient_Demiss_Table.Size = new System.Drawing.Size(1525, 594);
            this.Pacient_Demiss_Table.TabIndex = 61;
            this.Pacient_Demiss_Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Pacient_Edit_Table_CellClick);
            // 
            // Pacient_label
            // 
            this.Pacient_label.AutoSize = true;
            this.Pacient_label.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pacient_label.Location = new System.Drawing.Point(558, 9);
            this.Pacient_label.Name = "Pacient_label";
            this.Pacient_label.Size = new System.Drawing.Size(481, 74);
            this.Pacient_label.TabIndex = 59;
            this.Pacient_label.Text = "PACIENT DEMISS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(427, 8);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 60;
            this.pictureBox2.TabStop = false;
            // 
            // Pacient_Demiss_Back
            // 
            this.Pacient_Demiss_Back.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pacient_Demiss_Back.Location = new System.Drawing.Point(1454, 831);
            this.Pacient_Demiss_Back.Name = "Pacient_Demiss_Back";
            this.Pacient_Demiss_Back.Size = new System.Drawing.Size(134, 57);
            this.Pacient_Demiss_Back.TabIndex = 68;
            this.Pacient_Demiss_Back.Text = "BACK";
            this.Pacient_Demiss_Back.UseVisualStyleBackColor = true;
            this.Pacient_Demiss_Back.Click += new System.EventHandler(this.Pacient_Demiss_Back_Click);
            // 
            // Pacient_Demiss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.Pacient_Demiss_Back);
            this.Controls.Add(this.Pacient_Demiss_BT);
            this.Controls.Add(this.Pacient_Demiss_Table);
            this.Controls.Add(this.Pacient_label);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pacient_Demiss";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacient_Demiss";
            this.Load += new System.EventHandler(this.Pacient_Demiss_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pacient_Demiss_Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Pacient_Demiss_BT;
        private DataGridView Pacient_Demiss_Table;
        private Label Pacient_label;
        private PictureBox pictureBox2;
        private Button Pacient_Demiss_Back;
    }
}