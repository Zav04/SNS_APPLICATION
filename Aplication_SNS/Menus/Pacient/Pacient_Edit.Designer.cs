namespace Menus.PacientEdit
{
    partial class Pacient_Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pacient_Edit));
            this.Hospital_Edit_Edit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Status_Combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OBS_Text = new System.Windows.Forms.TextBox();
            this.Back_Hospital_Edit = new System.Windows.Forms.Button();
            this.Pacient_Edit_Table = new System.Windows.Forms.DataGridView();
            this.Hospital_label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pacient_Edit_Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Hospital_Edit_Edit
            // 
            this.Hospital_Edit_Edit.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Hospital_Edit_Edit.Location = new System.Drawing.Point(1031, 552);
            this.Hospital_Edit_Edit.Name = "Hospital_Edit_Edit";
            this.Hospital_Edit_Edit.Size = new System.Drawing.Size(392, 56);
            this.Hospital_Edit_Edit.TabIndex = 58;
            this.Hospital_Edit_Edit.Text = "EDIT";
            this.Hospital_Edit_Edit.UseVisualStyleBackColor = true;
            this.Hospital_Edit_Edit.Click += new System.EventHandler(this.Hospital_Edit_Edit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(914, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 30);
            this.label7.TabIndex = 57;
            this.label7.Text = "STATUS OF PACIENT";
            // 
            // Status_Combo
            // 
            this.Status_Combo.FormattingEnabled = true;
            this.Status_Combo.Location = new System.Drawing.Point(1141, 305);
            this.Status_Combo.Name = "Status_Combo";
            this.Status_Combo.Size = new System.Drawing.Size(286, 23);
            this.Status_Combo.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(949, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 30);
            this.label1.TabIndex = 50;
            this.label1.Text = "OBSERVATIONS";
            // 
            // OBS_Text
            // 
            this.OBS_Text.Location = new System.Drawing.Point(1141, 352);
            this.OBS_Text.Multiline = true;
            this.OBS_Text.Name = "OBS_Text";
            this.OBS_Text.Size = new System.Drawing.Size(408, 163);
            this.OBS_Text.TabIndex = 44;
            // 
            // Back_Hospital_Edit
            // 
            this.Back_Hospital_Edit.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Back_Hospital_Edit.Location = new System.Drawing.Point(1454, 934);
            this.Back_Hospital_Edit.Name = "Back_Hospital_Edit";
            this.Back_Hospital_Edit.Size = new System.Drawing.Size(134, 56);
            this.Back_Hospital_Edit.TabIndex = 43;
            this.Back_Hospital_Edit.Text = "BACK";
            this.Back_Hospital_Edit.UseVisualStyleBackColor = true;
            this.Back_Hospital_Edit.Click += new System.EventHandler(this.Back_Hospital_Edit_Click);
            // 
            // Pacient_Edit_Table
            // 
            this.Pacient_Edit_Table.AllowUserToDeleteRows = false;
            this.Pacient_Edit_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Pacient_Edit_Table.Location = new System.Drawing.Point(12, 115);
            this.Pacient_Edit_Table.Name = "Pacient_Edit_Table";
            this.Pacient_Edit_Table.ReadOnly = true;
            this.Pacient_Edit_Table.RowTemplate.Height = 25;
            this.Pacient_Edit_Table.Size = new System.Drawing.Size(850, 718);
            this.Pacient_Edit_Table.TabIndex = 42;
            this.Pacient_Edit_Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Pacient_Edit_Table_CellClick);
            // 
            // Hospital_label
            // 
            this.Hospital_label.AutoSize = true;
            this.Hospital_label.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Hospital_label.Location = new System.Drawing.Point(546, 9);
            this.Hospital_label.Name = "Hospital_label";
            this.Hospital_label.Size = new System.Drawing.Size(698, 74);
            this.Hospital_label.TabIndex = 40;
            this.Hospital_label.Text = "EDIT STATUS OF PACIENT";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(415, 9);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // Pacient_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 1000);
            this.Controls.Add(this.Hospital_Edit_Edit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Status_Combo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OBS_Text);
            this.Controls.Add(this.Back_Hospital_Edit);
            this.Controls.Add(this.Pacient_Edit_Table);
            this.Controls.Add(this.Hospital_label);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pacient_Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacient_Edit";
            this.Load += new System.EventHandler(this.Pacient_Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pacient_Edit_Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Hospital_Edit_Edit;
        private Label label7;
        private ComboBox Status_Combo;
        private Label label1;
        private TextBox OBS_Text;
        private Button Back_Hospital_Edit;
        private DataGridView Pacient_Edit_Table;
        private Label Hospital_label;
        private PictureBox pictureBox2;
    }
}