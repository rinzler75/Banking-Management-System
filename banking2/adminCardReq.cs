using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banking2
{
    public partial class adminCardReq : UserControl
    {
        public adminCardReq()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu.Instance.PnlContainer.Controls.RemoveByKey("visaReq");
            visaReq v = new visaReq();
            menu.Instance.PnlContainer.Controls.Add(v);
            menu.Instance.PnlContainer.Controls["visaReq"].BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menu.Instance.PnlContainer.Controls.RemoveByKey("mCreq");
            mCreq v = new mCreq();
            menu.Instance.PnlContainer.Controls.Add(v);
            menu.Instance.PnlContainer.Controls["mCreq"].BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu.Instance.PnlContainer.Controls.RemoveByKey("ruPay");
            ruPay v = new ruPay();
            menu.Instance.PnlContainer.Controls.Add(v);
            menu.Instance.PnlContainer.Controls["ruPay"].BringToFront();
        }
    }
}
