namespace KioskFINALFINAL
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.PanelRGBstrip = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.R = new System.Windows.Forms.Timer(this.components);
            this.G = new System.Windows.Forms.Timer(this.components);
            this.B = new System.Windows.Forms.Timer(this.components);
            this.ucMAIN1 = new KioskFINALFINAL.UC.ucMAIN();
            this.ucASTI1 = new KioskFINALFINAL.UC.ucASTI();
            this.ucSP1 = new KioskFINALFINAL.UC.ucSP();
            this.ucC1 = new KioskFINALFINAL.UC.ucC();
            this.ucGI1 = new KioskFINALFINAL.UC.ucGI();
            this.PanelRGBstrip.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelRGBstrip
            // 
            this.PanelRGBstrip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelRGBstrip.Controls.Add(this.label1);
            this.PanelRGBstrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelRGBstrip.Location = new System.Drawing.Point(0, 0);
            this.PanelRGBstrip.Name = "PanelRGBstrip";
            this.PanelRGBstrip.Size = new System.Drawing.Size(1280, 30);
            this.PanelRGBstrip.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(451, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.ucMAIN1);
            this.panelContainer.Controls.Add(this.ucASTI1);
            this.panelContainer.Controls.Add(this.ucSP1);
            this.panelContainer.Controls.Add(this.ucC1);
            this.panelContainer.Controls.Add(this.ucGI1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 30);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1280, 690);
            this.panelContainer.TabIndex = 1;
            // 
            // R
            // 
            this.R.Enabled = true;
            this.R.Interval = 30;
            this.R.Tick += new System.EventHandler(this.R_Tick);
            // 
            // G
            // 
            this.G.Enabled = true;
            this.G.Interval = 30;
            this.G.Tick += new System.EventHandler(this.G_Tick);
            // 
            // B
            // 
            this.B.Enabled = true;
            this.B.Interval = 30;
            this.B.Tick += new System.EventHandler(this.B_Tick);
            // 
            // ucMAIN1
            // 
            this.ucMAIN1.BackColor = System.Drawing.Color.White;
            this.ucMAIN1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMAIN1.Location = new System.Drawing.Point(0, 0);
            this.ucMAIN1.Name = "ucMAIN1";
            this.ucMAIN1.Size = new System.Drawing.Size(1280, 690);
            this.ucMAIN1.TabIndex = 0;
            // 
            // ucASTI1
            // 
            this.ucASTI1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucASTI1.Location = new System.Drawing.Point(0, 0);
            this.ucASTI1.Name = "ucASTI1";
            this.ucASTI1.Size = new System.Drawing.Size(1280, 690);
            this.ucASTI1.TabIndex = 4;
            // 
            // ucSP1
            // 
            this.ucSP1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSP1.Location = new System.Drawing.Point(0, 0);
            this.ucSP1.Name = "ucSP1";
            this.ucSP1.Size = new System.Drawing.Size(1280, 690);
            this.ucSP1.TabIndex = 3;
            // 
            // ucC1
            // 
            this.ucC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucC1.Location = new System.Drawing.Point(0, 0);
            this.ucC1.Name = "ucC1";
            this.ucC1.Size = new System.Drawing.Size(1280, 690);
            this.ucC1.TabIndex = 2;
            // 
            // ucGI1
            // 
            this.ucGI1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucGI1.Location = new System.Drawing.Point(0, 0);
            this.ucGI1.Name = "ucGI1";
            this.ucGI1.Size = new System.Drawing.Size(1280, 690);
            this.ucGI1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.PanelRGBstrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelRGBstrip.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelRGBstrip;
        private System.Windows.Forms.Panel panelContainer;
        private UC.ucMAIN ucMAIN1;
        private UC.ucGI ucGI1;
        private UC.ucC ucC1;
        private UC.ucASTI ucASTI1;
        private UC.ucSP ucSP1;
        private System.Windows.Forms.Timer R;
        private System.Windows.Forms.Timer G;
        private System.Windows.Forms.Timer B;
        private System.Windows.Forms.Label label1;
    }
}

