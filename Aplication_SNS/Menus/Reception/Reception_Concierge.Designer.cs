namespace Menus.ReceptionConcierge
{
    partial class Reception_Concierge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reception_Concierge));
            this.BACK_Reception_Menu = new System.Windows.Forms.Button();
            this.Hospital_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Recption_Visitor = new System.Windows.Forms.DataGridView();
            this.Recption_Pacients = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Recption_Visitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Recption_Pacients)).BeginInit();
            this.SuspendLayout();
            // 
            // BACK_Reception_Menu
            // 
            this.BACK_Reception_Menu.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BACK_Reception_Menu.Location = new System.Drawing.Point(1454, 832);
            this.BACK_Reception_Menu.Name = "BACK_Reception_Menu";
            this.BACK_Reception_Menu.Size = new System.Drawing.Size(134, 56);
            this.BACK_Reception_Menu.TabIndex = 41;
            this.BACK_Reception_Menu.Text = "BACK";
            this.BACK_Reception_Menu.UseVisualStyleBackColor = true;
            this.BACK_Reception_Menu.Click += new System.EventHandler(this.BACK_Reception_Menu_Click);
            // 
            // Hospital_label
            // 
            this.Hospital_label.AutoSize = true;
            this.Hospital_label.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Hospital_label.Location = new System.Drawing.Point(542, 11);
            this.Hospital_label.Name = "Hospital_label";
            this.Hospital_label.Size = new System.Drawing.Size(659, 74);
            this.Hospital_label.TabIndex = 37;
            this.Hospital_label.Text = "RECEPTION CONCIERGE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1455, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(411, 11);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // Recption_Visitor
            // 
            this.Recption_Visitor.AllowUserToDeleteRows = false;
            this.Recption_Visitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Recption_Visitor.Location = new System.Drawing.Point(815, 125);
            this.Recption_Visitor.Name = "Recption_Visitor";
            this.Recption_Visitor.ReadOnly = true;
            this.Recption_Visitor.RowTemplate.Height = 25;
            this.Recption_Visitor.Size = new System.Drawing.Size(750, 650);
            this.Recption_Visitor.TabIndex = 43;
            // 
            // Recption_Pacients
            // 
            this.Recption_Pacients.AllowUserToDeleteRows = false;
            this.Recption_Pacients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Recption_Pacients.Location = new System.Drawing.Point(35, 125);
            this.Recption_Pacients.Name = "Recption_Pacients";
            this.Recption_Pacients.ReadOnly = true;
            this.Recption_Pacients.RowTemplate.Height = 25;
            this.Recption_Pacients.Size = new System.Drawing.Size(750, 650);
            this.Recption_Pacients.TabIndex = 42;
            this.Recption_Pacients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Recption_Pacients_CellClick);
            // 
            // Reception_Concierge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.Recption_Visitor);
            this.Controls.Add(this.Recption_Pacients);
            this.Controls.Add(this.BACK_Reception_Menu);
            this.Controls.Add(this.Hospital_label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reception_Concierge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reception_Concierge";
            this.Load += new System.EventHandler(this.Reception_Concierge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Recption_Visitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Recption_Pacients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BACK_Reception_Menu;
        private Label Hospital_label;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private DataGridView Recption_Visitor;
        private DataGridView Recption_Pacients;
    }
}