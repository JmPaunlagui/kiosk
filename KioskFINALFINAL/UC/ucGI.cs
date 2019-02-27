using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KioskFINALFINAL.UCchild.GetInfo;

namespace KioskFINALFINAL.UC
{
    public partial class ucGI : UserControl
    {

        static ucGI _obj;

        public ucGI()
        {
            InitializeComponent();
            ucMainn1.BringToFront();
        }
        public static ucGI Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new ucGI();
                }
                return _obj;
            }

        }
        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
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

        private void panelContainer_Leave(object sender, EventArgs e)
        {
            
        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Click(object sender, EventArgs e)
        {

        }

        private void ucMainn1_Load(object sender, EventArgs e)
        {
            _obj = this;

            ucMainn ucmainn = new ucMainn();
            ucmainn.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(ucmainn);
        }
    }
}
