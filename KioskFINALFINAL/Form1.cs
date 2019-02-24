using System;
using KioskFINALFINAL.UC;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KioskFINALFINAL
{
    public partial class Form1 : Form
    {
        static Form1 _obj;

        public static Form1 Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }
           
        }

        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        } 

        public Form1()
        {
            InitializeComponent();
            ucMAIN1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _obj = this;

            ucMAIN ucMAIN = new ucMAIN();
            ucMAIN.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(ucMAIN);
        }


        //RGB strip Start
        int r = 244;
        int g = 65;
        int b = 65;
        private void R_Tick(object sender, EventArgs e)
        {
            if (b >= 244)
            {
                r -= 1;
                PanelRGBstrip.BackColor = Color.FromArgb(r, g, b);
                
                if (r <= 65)
                {
                    R.Stop();
                    G.Start();

                    label1.Text = "こ ん に ち は";
                }
            }

            if (b <= 65)
            {
                r += 1;
                PanelRGBstrip.BackColor = Color.FromArgb(r, g, b);
               
                if (r >= 244)
                {
                    R.Stop();
                    G.Start();
                    label1.Text = "May I help you?";

                }
            }
        }

        private void G_Tick(object sender, EventArgs e)
        {
            if (r <= 65)
            {
                g += 1;
                PanelRGBstrip.BackColor = Color.FromArgb(r, g, b);
               
                if (g >= 244)
                {
                    G.Stop();
                    B.Start();
                    label1.Text = "Hola";
                }
            }

            if (r >= 244)
            {
                g -= 1;
                PanelRGBstrip.BackColor = Color.FromArgb(r, g, b);

                if (g <= 65)
                {
                    G.Stop();
                    B.Start();
                    label1.Text = "Hello";
                }
            }
        }

        private void B_Tick(object sender, EventArgs e)
        {
            if (g <= 65)
            {
                b += 1;
                PanelRGBstrip.BackColor = Color.FromArgb(r, g, b);
                
                if (b >= 244)
                {
                    B.Stop();
                    R.Start();
                    label1.Text = "안 녕 하 세 요";
                }
            }

            if (g >= 244)
            {
                b -= 1;
                PanelRGBstrip.BackColor = Color.FromArgb(r, g, b);
                
                if (b <= 65)
                {
                    B.Stop();
                    R.Start();
                    label1.Text = "Ciao";
                }
            }
        }
        //RGB strip End
    }
}
