using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KioskFINALFINAL.UC
{
    public partial class ucMAIN : UserControl
    {
        public ucMAIN()
        {
            InitializeComponent();
        }
        //GI click start
        private void panelGI_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("ucGI"))
            {
                ucGI info = new ucGI();
                info.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(info);
            }
            Form1.Instance.PnlContainer.Controls["ucGI"].BringToFront();
        }
        //GI click end

        //C click start
        private void panelC_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("ucC"))
            {
                ucC ucC = new ucC();
                ucC.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(ucC);
            }
            Form1.Instance.PnlContainer.Controls["ucC"].BringToFront();
        }
        //C click end

        //SP click start
        private void panelSP_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("ucSP"))
            {
                ucSP SP = new ucSP();
                SP.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(SP);
            }
            Form1.Instance.PnlContainer.Controls["ucSP"].BringToFront();
        }
        //SP click end

        //ASTI click start
        private void panelASTI_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("ucASTI"))
            {
                ucASTI STI = new ucASTI();
                STI.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(STI);
            }
            Form1.Instance.PnlContainer.Controls["ucASTI"].BringToFront();
        }
        //ASTI click end

        //RGB strip Start
        int r = 244;
        int g = 65;
        int b = 65;
        private void R_Tick(object sender, EventArgs e)
        {
            if (b >= 244)
            {
                r -= 1;
                pRGB1.BackColor = Color.FromArgb(r, g, b);
                pRGB2.BackColor = Color.FromArgb(r, g, b);
                pRGB3.BackColor = Color.FromArgb(r, g, b);
                pRGB4.BackColor = Color.FromArgb(r, g, b);

                if (r <= 65)
                {
                    R.Stop();
                    G.Start();

                }
            }

            if (b <= 65)
            {
                r += 1;
                pRGB1.BackColor = Color.FromArgb(r, g, b);
                pRGB2.BackColor = Color.FromArgb(r, g, b);
                pRGB3.BackColor = Color.FromArgb(r, g, b);
                pRGB4.BackColor = Color.FromArgb(r, g, b);

                if (r >= 244)
                {
                    R.Stop();
                    G.Start();


                }
            }
        }

        private void G_Tick(object sender, EventArgs e)
        {
            if (r <= 65)
            {
                g += 1;
                pRGB1.BackColor = Color.FromArgb(r, g, b);
                pRGB2.BackColor = Color.FromArgb(r, g, b);
                pRGB3.BackColor = Color.FromArgb(r, g, b);
                pRGB4.BackColor = Color.FromArgb(r, g, b);

                if (g >= 244)
                {
                    G.Stop();
                    B.Start();

                }
            }

            if (r >= 244)
            {
                g -= 1;
                pRGB1.BackColor = Color.FromArgb(r, g, b);
                pRGB2.BackColor = Color.FromArgb(r, g, b);
                pRGB3.BackColor = Color.FromArgb(r, g, b);
                pRGB4.BackColor = Color.FromArgb(r, g, b);

                if (g <= 65)
                {
                    G.Stop();
                    B.Start();

                }
            }
        }

        private void B_Tick(object sender, EventArgs e)
        {
            if (g <= 65)
            {
                b += 1;
                pRGB1.BackColor = Color.FromArgb(r, g, b);
                pRGB2.BackColor = Color.FromArgb(r, g, b);
                pRGB3.BackColor = Color.FromArgb(r, g, b);
                pRGB4.BackColor = Color.FromArgb(r, g, b);

                if (b >= 244)
                {
                    B.Stop();
                    R.Start();

                }
            }

            if (g >= 244)
            {
                b -= 1;
                pRGB1.BackColor = Color.FromArgb(r, g, b);
                pRGB2.BackColor = Color.FromArgb(r, g, b);
                pRGB3.BackColor = Color.FromArgb(r, g, b);
                pRGB4.BackColor = Color.FromArgb(r, g, b);

                if (b <= 65)
                {
                    B.Stop();
                    R.Start();

                }
            }
        }

        //RGB strip End
    }
}