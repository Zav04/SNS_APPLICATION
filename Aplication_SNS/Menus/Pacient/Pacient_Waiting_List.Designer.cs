namespace Menus.PacientWaitingList
{
    partial class Pacient_Waiting_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pacient_Waiting_List));
            this.Pacient_Try_Admit = new System.Windows.Forms.Button();
            this.Back_Hospital_Edit = new System.Windows.Forms.Button();
            this.Pacient_Waiting_List_Table = new System.Windows.Forms.DataGridView();
            this.Pacient_label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Pacient_Demiss_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pacient_Waiting_List_Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Pacient_Try_Admit
            // 
            this.Pacient_Try_Admit.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pacient_Try_Admit.Location = new System.Drawing.Point(609, 790);
            this.Pacient_Try_Admit.Name = "Pacient_Try_Admit";
            this.Pacient_Try_Admit.Size = new System.Drawing.Size(392, 56);
            this.Pacient_Try_Admit.TabIndex = 67;
            this.Pacient_Try_Admit.Text = "TRY ADMIT";
            this.Pacient_Try_Admit.UseVisualStyleBackColor = true;
            this.Pacient_Try_Admit.Click += new System.EventHandler(this.Pacient_Try_Admit_Click);
            // 
            // Back_Hospital_Edit
            // 
            this.Back_Hospital_Edit.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Back_Hospital_Edit.Location = new System.Drawing.Point(1452, 934);
            this.Back_Hospital_Edit.Name = "Back_Hospital_Edit";
            this.Back_Hospital_Edit.Size = new System.Drawing.Size(134, 56);
            this.Back_Hospital_Edit.TabIndex = 62;
            this.Back_Hospital_Edit.Text = "BACK";
            this.Back_Hospital_Edit.UseVisualStyleBackColor = true;
            // 
            // Pacient_Waiting_List_Table
            // 
            this.Pacient_Waiting_List_Table.AllowUserToDeleteRows = false;
            this.Pacient_Waiting_List_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Pacient_Waiting_List_Table.Location = new System.Drawing.Point(10, 115);
            this.Pacient_Waiting_List_Table.Name = "Pacient_Waiting_List_Table";
            this.Pacient_Waiting_List_Table.ReadOnly = true;
            this.Pacient_Waiting_List_Table.RowTemplate.Height = 25;
            this.Pacient_Waiting_List_Table.Size = new System.Drawing.Size(1578, 602);
            this.Pacient_Waiting_List_Table.TabIndex = 61;
            this.Pacient_Waiting_List_Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Pacient_Waiting_List_Table_CellClick);
            // 
            // Pacient_label
            // 
            this.Pacient_label.AutoSize = true;
            this.Pacient_label.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pacient_label.Location = new System.Drawing.Point(544, 9);
            this.Pacient_label.Name = "Pacient_label";
            this.Pacient_label.Size = new System.Drawing.Size(648, 74);
            this.Pacient_label.TabIndex = 59;
            this.Pacient_label.Text = "PACIENT WAITING LIST";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(413, 9);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 60;
            this.pictureBox2.TabStop = false;
            // 
            // Pacient_Demiss_Back
            // 
            this.Pacient_Demiss_Back.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pacient_Demiss_Back.Location = new System.Drawing.Point(1454, 832);
            this.Pacient_Demiss_Back.Name = "Pacient_Demiss_Back";
            this.Pacient_Demiss_Back.Size = new System.Drawing.Size(134, 56);
            this.Pacient_Demiss_Back.TabIndex = 75;
            this.Pacient_Demiss_Back.Text = "BACK";
            this.Pacient_Demiss_Back.UseVisualStyleBackColor = true;
            this.Pacient_Demiss_Back.Click += new System.EventHandler(this.Pacient_Demiss_Back_Click);
            // 
            // Pacient_Waiting_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.Pacient_Demiss_Back);
            this.Controls.Add(this.Pacient_Try_Admit);
            this.Controls.Add(this.Back_Hospital_Edit);
            this.Controls.Add(this.Pacient_Waiting_List_Table);
            this.Controls.Add(this.Pacient_label);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pacient_Waiting_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacient_Waiting_List";
            this.Load += new System.EventHandler(this.Pacient_Waiting_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pacient_Waiting_List_Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Pacient_Try_Admit;
        private Button Back_Hospital_Edit;
        private DataGridView Pacient_Waiting_List_Table;
        private Label Pacient_label;
        private PictureBox pictureBox2;
        private Button Pacient_Demiss_Back;
    }
}