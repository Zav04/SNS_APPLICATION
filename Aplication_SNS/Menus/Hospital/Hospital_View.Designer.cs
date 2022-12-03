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
            this.Hospital_View_Table = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Hospital_View_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // Hospital_View_Table
            // 
            this.Hospital_View_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Hospital_View_Table.Location = new System.Drawing.Point(12, 31);
            this.Hospital_View_Table.Name = "Hospital_View_Table";
            this.Hospital_View_Table.RowTemplate.Height = 25;
            this.Hospital_View_Table.Size = new System.Drawing.Size(776, 395);
            this.Hospital_View_Table.TabIndex = 0;
            // 
            // Hospital_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Hospital_View_Table);
            this.Name = "Hospital_View";
            this.Text = "Hospital_View";
            this.Load += new System.EventHandler(this.Hospital_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Hospital_View_Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView Hospital_View_Table;
    }
}