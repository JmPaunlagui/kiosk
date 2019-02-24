namespace KioskFINALFINAL.UCchild.AboutSTI
{
    partial class ucStiHymn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucStiHymn));
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.P1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Title.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(46, 42);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(153, 40);
            this.Title.TabIndex = 1;
            this.Title.Text = "STI Hymn";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(782, 427);
            this.label1.TabIndex = 6;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // P1
            // 
            this.P1.BackColor = System.Drawing.Color.Yellow;
            this.P1.Location = new System.Drawing.Point(35, 85);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(883, 5);
            this.P1.TabIndex = 5;
            // 
            // ucStiHymn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.P1);
            this.Controls.Add(this.Title);
            this.Name = "ucStiHymn";
            this.Size = new System.Drawing.Size(953, 693);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel P1;
    }
}
