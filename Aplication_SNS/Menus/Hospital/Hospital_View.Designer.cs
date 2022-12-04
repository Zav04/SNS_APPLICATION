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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Hospital_View_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // Hospital_View_Table
            // 
            this.Hospital_View_Table.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Hospital_View_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Hospital_View_Table.Location = new System.Drawing.Point(12, 31);
            this.Hospital_View_Table.Name = "Hospital_View_Table";
            this.Hospital_View_Table.RowTemplate.Height = 25;
            this.Hospital_View_Table.Size = new System.Drawing.Size(1547, 799);
            this.Hospital_View_Table.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1067, 858);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Hospital_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1584, 961);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Hospital_View_Table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hospital_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital_View";
            this.Load += new System.EventHandler(this.Hospital_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Hospital_View_Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView Hospital_View_Table;
        private Button button1;
    }
}