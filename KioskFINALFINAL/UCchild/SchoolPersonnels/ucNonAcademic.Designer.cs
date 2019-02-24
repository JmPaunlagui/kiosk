namespace KioskFINALFINAL.UCchild.SchoolPersonnels
{
    partial class ucNonAcademic
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.P2 = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // P2
            // 
            this.P2.BackColor = System.Drawing.Color.Yellow;
            this.P2.Location = new System.Drawing.Point(33, 85);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(883, 5);
            this.P2.TabIndex = 7;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Title.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(46, 42);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(261, 40);
            this.Title.TabIndex = 6;
            this.Title.Text = "Non Academic";
            // 
            // ucNonAcademic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.P2);
            this.Controls.Add(this.Title);
            this.Name = "ucNonAcademic";
            this.Size = new System.Drawing.Size(953, 693);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel P2;
        private System.Windows.Forms.Label Title;
    }
}
