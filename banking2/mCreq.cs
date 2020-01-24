﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace banking2
{
    public partial class mCreq : UserControl
    {
        public mCreq()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu.Instance.PnlContainer.Controls.RemoveByKey("adminCardReq");
            adminCardReq c = new adminCardReq();
            c.Dock = DockStyle.Fill;
            menu.Instance.PnlContainer.Controls.Add(c);
            menu.Instance.PnlContainer.Controls["adminCardReq"].BringToFront();
        }

        private void mCreq_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Navnit Kumar\\source\\repos\\banking2\\banking2\\bankingDB.mdf;Integrated Security=True");

            using (con)
            {
                SqlDataAdapter sda = new SqlDataAdapter("select ac_no\"A/C No\",toc\"Type Of Card\",dor\"Request Date\",c_name\"Customer Name\" from CRDREQ where provider='Master Card'", con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                dtgv.DataSource = dtbl;
                dtgv.Refresh();
                dtgv.Update();
                info.Text = "Total No of MASTER CARD's CARD requests: " + dtbl.Rows.Count.ToString();
            }
        }
    }
}
