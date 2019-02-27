namespace KioskFINALFINAL.UC
{
    partial class ucGI
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.ucMainn1 = new KioskFINALFINAL.UCchild.GetInfo.ucMainn();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Controls.Add(this.ucMainn1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1280, 693);
            this.panelContainer.TabIndex = 1;
            this.panelContainer.Leave += new System.EventHandler(this.panelContainer_Leave);
            // 
            // ucMainn1
            // 
            this.ucMainn1.BackColor = System.Drawing.Color.White;
            this.ucMainn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMainn1.Location = new System.Drawing.Point(0, 0);
            this.ucMainn1.Name = "ucMainn1";
            this.ucMainn1.Size = new System.Drawing.Size(1280, 693);
            this.ucMainn1.TabIndex = 0;
            this.ucMainn1.Load += new System.EventHandler(this.ucMainn1_Load);
            // 
            // ucGI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContainer);
            this.Name = "ucGI";
            this.Size = new System.Drawing.Size(1280, 693);
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContainer;
        private UCchild.GetInfo.ucMainn ucMainn1;
    }
}
