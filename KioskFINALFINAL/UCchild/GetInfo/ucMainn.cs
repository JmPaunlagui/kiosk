using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KioskFINALFINAL.UC;

namespace KioskFINALFINAL.UCchild.GetInfo
{
    public partial class ucMainn : UserControl
    {
        public ucMainn()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (!ucGI.Instance.PnlContainer.Controls.ContainsKey("ucPromissory"))
            {
                ucPromissory promissory = new ucPromissory();
                promissory.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(promissory);
            }
            Form1.Instance.PnlContainer.Controls["ucPromissory"].BringToFront();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            if (!ucGI.Instance.PnlContainer.Controls.ContainsKey("ucID"))
            {
                ucID iD = new ucID();
                iD.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(iD);
            }
            Form1.Instance.PnlContainer.Controls["ucID"].BringToFront();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            if (!ucGI.Instance.PnlContainer.Controls.ContainsKey("ucSOA"))
            {
                ucSOA soa = new ucSOA();
                soa.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(soa);
            }
            Form1.Instance.PnlContainer.Controls["ucSOA"].BringToFront();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            if (!ucGI.Instance.PnlContainer.Controls.ContainsKey("ucClearance"))
            {
                ucClearance cl = new ucClearance();
                cl.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(cl);
            }
            Form1.Instance.PnlContainer.Controls["ucClearance"].BringToFront();
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            if (!ucGI.Instance.PnlContainer.Controls.ContainsKey("ucGoodMoral"))
            {
                ucGoodMoral gm = new ucGoodMoral();
                gm.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(gm);
            }
            Form1.Instance.PnlContainer.Controls["ucGoodMoral"].BringToFront();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            if (!ucGI.Instance.PnlContainer.Controls.ContainsKey("ucExamPermit"))
            {
                ucExamPermit ep = new ucExamPermit();
                ep.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(ep);
            }
            Form1.Instance.PnlContainer.Controls["ucExamPermit"].BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("ucMain"))
            {
                ucGI gmain = new ucGI();
                gmain.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(gmain);
            }
            Form1.Instance.PnlContainer.Controls["ucMain"].BringToFront();
        }
    }
}
