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
    public partial class ucC : UserControl
    {
        public ucC()
        {
            InitializeComponent();
            ucExam1.BringToFront();
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
            ucExam1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ucActivities1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ucUPCOMINGE1.BringToFront();
        }
    }
}
