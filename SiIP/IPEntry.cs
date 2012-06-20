using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SiIP
{

    public partial class IPEntry : UserControl
    {
        private string m_ipAddress = "";
        private bool m_status;

        public IPEntry()
        {
            InitializeComponent();
        }

        public string ipAddress
        {
            get
            {
                getIP();
                return m_ipAddress;
            }
            set
            {
                m_ipAddress = value;
                setIP(value);
            }
        }

        public bool status
        {
            get { return m_status; }
            set
            {
                m_status = value;
                setStatus(value);
            }
        }

        private void setIP(string ip)
        {
            if (!string.IsNullOrEmpty(ip))
            {
                string[] potong = ip.Split(new Char[] { '.' });
                tbIP1.Text = potong[0];
                tbIP2.Text = potong[1];
                tbIP3.Text = potong[2];
                tbIP4.Text = potong[3];
            }
        }

        private void getIP()
        {
            string ip = "";

            if (tbIP1.Text != "")
                ip += tbIP1.Text + ".";
            else
                ip += "0" + ".";

            if (tbIP2.Text != "")
                ip += tbIP2.Text + ".";
            else
                ip += "0" + ".";

            if (tbIP3.Text != "")
                ip += tbIP3.Text + ".";
            else
                ip += "0" + ".";

            if (tbIP4.Text != "")
                ip += tbIP4.Text;
            else
                ip += "0";

            m_ipAddress = ip;
        }

        private void setStatus(bool b)
        {
            // sateacan di paehan, ganti warna heula
            if (b)
            {
                tbMain.BackColor = SystemColors.Window;
                lblDot1.BackColor = SystemColors.Window;
                lblDot2.BackColor = SystemColors.Window;
                lblDot3.BackColor = SystemColors.Window;
            }
            else
            {
                tbMain.BackColor = SystemColors.Control;
                lblDot1.BackColor = SystemColors.Control;
                lblDot2.BackColor = SystemColors.Control;
                lblDot3.BackColor = SystemColors.Control;
            }

            // paehan kebah kontrol
            tbMain.Enabled = b;
            tbIP1.Enabled = b;
            tbIP2.Enabled = b;
            tbIP3.Enabled = b;
            tbIP4.Enabled = b;
            lblDot1.Enabled = b;
            lblDot2.Enabled = b;
            lblDot3.Enabled = b;


        }

        private void tbIP1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys.Right == e.KeyCode) & (tbIP1.SelectionStart == tbIP1.TextLength))
                tbIP2.Focus();
        }

        private void tbIP2_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys.Right == e.KeyCode) & (tbIP2.SelectionStart == tbIP2.TextLength))
                tbIP3.Focus();
            else if ((Keys.Left == e.KeyCode) & (tbIP2.SelectionStart == 0))
                tbIP1.Focus();

        }

        private void tbIP3_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys.Right == e.KeyCode) & (tbIP3.SelectionStart == tbIP3.TextLength))
                tbIP4.Focus();
            else if ((Keys.Left == e.KeyCode) & (tbIP3.SelectionStart == 0))
                tbIP2.Focus();
        }

        private void tbIP4_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys.Left == e.KeyCode) & (tbIP4.SelectionStart == 0))
                tbIP3.Focus();
        }
    }

}
