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
    public partial class ucSP : UserControl
    {
        public ucSP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("ucMain"))
            {
                ucMAIN main = new ucMAIN();
                main.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(main);
            }
            Form1.Instance.PnlContainer.Controls["ucMain"].BringToFront();

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ucAcademic1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ucNonAcademic1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ucAdmin1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ucPrincipal1.BringToFront();
        }
    }
}
