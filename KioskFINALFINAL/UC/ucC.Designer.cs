﻿namespace KioskFINALFINAL.UC
{
    partial class ucC
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ucActivities1 = new KioskFINALFINAL.UCchild.Calendar.ucActivities();
            this.ucExam1 = new KioskFINALFINAL.UCchild.Calendar.ucExam();
            this.ucUPCOMINGE1 = new KioskFINALFINAL.UCchild.Calendar.ucUPCOMINGE();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ucUPCOMINGE1);
            this.panel3.Controls.Add(this.ucExam1);
            this.panel3.Controls.Add(this.ucActivities1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(327, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(953, 693);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 693);
            this.panel2.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::KioskFINALFINAL.Properties.Resources.icons8_Event_48px;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(11, 198);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(306, 52);
            this.button4.TabIndex = 4;
            this.button4.Text = "Exam";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::KioskFINALFINAL.Properties.Resources.icons8_Event_Accepted_48px;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(11, 314);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(306, 67);
            this.button3.TabIndex = 3;
            this.button3.Text = "Upcoming";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::KioskFINALFINAL.Properties.Resources.icons8_Planner_48px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(11, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(306, 52);
            this.button2.TabIndex = 2;
            this.button2.Text = "Activities";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calendar";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::KioskFINALFINAL.Properties.Resources.icons8_Home_48px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(11, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(306, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ucActivities1
            // 
            this.ucActivities1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucActivities1.Location = new System.Drawing.Point(0, 0);
            this.ucActivities1.Name = "ucActivities1";
            this.ucActivities1.Size = new System.Drawing.Size(953, 693);
            this.ucActivities1.TabIndex = 0;
            // 
            // ucExam1
            // 
            this.ucExam1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucExam1.Location = new System.Drawing.Point(0, 0);
            this.ucExam1.Name = "ucExam1";
            this.ucExam1.Size = new System.Drawing.Size(953, 693);
            this.ucExam1.TabIndex = 1;
            // 
            // ucUPCOMINGE1
            // 
            this.ucUPCOMINGE1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucUPCOMINGE1.Location = new System.Drawing.Point(0, 0);
            this.ucUPCOMINGE1.Name = "ucUPCOMINGE1";
            this.ucUPCOMINGE1.Size = new System.Drawing.Size(953, 693);
            this.ucUPCOMINGE1.TabIndex = 2;
            // 
            // ucC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "ucC";
            this.Size = new System.Drawing.Size(1280, 693);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private UCchild.Calendar.ucUPCOMINGE ucUPCOMINGE1;
        private UCchild.Calendar.ucExam ucExam1;
        private UCchild.Calendar.ucActivities ucActivities1;
    }
}
