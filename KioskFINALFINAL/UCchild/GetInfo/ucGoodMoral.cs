using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KioskFINALFINAL.UCchild.GetInfo
{
    public partial class ucGoodMoral : UserControl
    {
        public ucGoodMoral()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("ucMainn"))
            {
                ucMainn main = new ucMainn();
                main.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(main);
            }
            Form1.Instance.PnlContainer.Controls["ucMainn"].BringToFront();
        }
    }
}
