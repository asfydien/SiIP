using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Globalization;
using System.Threading;

namespace SiIP
{
    public partial class frmMain : Form
    {
        WMIHelper.infoNIC[] nicNames;
        Config.Profile[] profiles; 
        Config cfg = new Config();

        string[] NetConStatusString = {"Disconnected","Connecting",
                                       "Connected",
                                       "Disconnecting","Hardware not present",
                                       "Hardware disabled","Hardware malfunction","Media disconnected","Authenticating",
                                       "Authentication succeeded","Authentication failed","Invalid address","Credentials required"};

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("id-ID");
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CurrentCulture;

            // controls
            foreach (Control ctlr in this.Controls)
                ctlr.Text = Lang.ResourceManager.GetString(ctlr.Name);
            
            // menustrip
            foreach (ToolStripItem strip in contextMenuStrip1.Items)
                strip.Text = Lang.ResourceManager.GetString(strip.Name);

        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            lblStatus.Text = "Collecting NIC information ...";
            progressBar1.Style = ProgressBarStyle.Marquee;
            chkShowDetail.Checked = true;

            if (bkWorkerLoadNic.IsBusy == false)
                bkWorkerLoadNic.RunWorkerAsync();
        }

        void loadProfils()
        {
            profiles = cfg.getProfiles(Application.StartupPath + "\\Profiles.xml");

            Console.WriteLine("profiles: " + profiles.Length.ToString());

            for (int i = 0; i < profiles.Length; i++)
                cboxProfile.Items.Add(profiles[i].Name);

            cboxProfile.Text = profiles[0].Name;
        }

        void showCurrentConfig(int iNic)
        {
            string[] ipAdresses, subnets, gateways, dnses;

            // ambil lagi profil yang sudah terpasang
            WMIHelper.GetIP(nicNames[cboxNetCard.SelectedIndex].Caption,
                            out ipAdresses, out subnets, out gateways, out dnses);

            tbCurIP.Text = gabungArrayIP(ipAdresses);
            tbCurSubnet.Text = gabungArrayIP(subnets);
            tbCurGateway.Text = gabungArrayIP(gateways);
            tbCurDNS.Text = gabungArrayIP(dnses);
        }

        void showProfilConfig(int iProfil)
        {
            tbIP.Text = profiles[iProfil].IP;
            tbSubnet.Text = profiles[iProfil].Subnet;
            tbGateway.Text = profiles[iProfil].Gateway;
            tbDNS.Text = profiles[iProfil].DNS;
        }

        string gabungArrayIP(string[] ip)
        {
            string sGabung = "";

            if (ip != null)
                for (int n = 0; n < ip.Length; n++)
                    sGabung += ip[n] + ",";

            return sGabung.Trim(',');
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Height = 400;

            chkShowDetail.Checked = true;

            progressBar1.Value = 1;
            progressBar1.Style = ProgressBarStyle.Marquee;

            btnActivate.Enabled = false;

            lblStatus.Text = "Memasang profil '" + cboxProfile.Text + "' ...";

            int iNic = cboxNetCard.SelectedIndex;
            int iProfil = cboxProfile.SelectedIndex;

            if (bkWorker.IsBusy == false)
                bkWorker.RunWorkerAsync(iNic + "|" + iProfil);

        }

        static bool ArraysEqual<T>(T[] a1, T[] a2)
        {
            if (ReferenceEquals(a1, a2))
                return true;

            if (a1 == null || a2 == null)
                return false;

            if (a1.Length != a2.Length)
                return false;

            EqualityComparer<T> comparer = EqualityComparer<T>.Default;

            for (int i = 0; i < a1.Length; i++)
                if (!comparer.Equals(a1[i], a2[i])) return false;

            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmManage().Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(cboxNetCard, cboxNetCard.Text + "\n" +
                                NetConStatusString[nicNames[cboxNetCard.SelectedIndex].NetConnectionStatus]);

            pictureBox1.Invalidate();

            showCurrentConfig(cboxNetCard.SelectedIndex);

            if (chkShowDetail.Checked == false) this.Height = 200;

            progressBar1.Value = 0;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                if (nicNames[cboxNetCard.SelectedIndex].NetConnectionStatus != 2)
                {
                    e.Graphics.DrawImage(Properties.Resources.disconect, new Point(0, 0));
                    cboxProfile.Enabled = false;
                    btnActivate.Enabled = false;
                    panel2.Enabled = false;
                }
                else
                {
                    cboxProfile.Enabled = true;
                    btnActivate.Enabled = true;
                    panel2.Enabled = true;
                }

                switch (nicNames[cboxNetCard.SelectedIndex].AdapterTypeId)
                {
                    case 9:
                        e.Graphics.DrawImage(Properties.Resources.wireles, new Point(0, 0));
                        break;
                    default:
                        e.Graphics.DrawImage(Properties.Resources.net2, new Point(0, 0));
                        break;
                }
            }
            catch { }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(cboxProfile, cboxProfile.Text);

            if (chkShowDetail.Checked == false) this.Height = 200;
            showProfilConfig(cboxProfile.SelectedIndex);

            progressBar1.Value = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] ipAdresses, subnets, gateways, dnses;

            // ambil lagi profil yang sudah terpasang
            WMIHelper.GetIP(nicNames[cboxNetCard.SelectedIndex].Caption,
                            out ipAdresses, out subnets, out gateways, out dnses);

            Console.WriteLine(dnses[0]);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowDetail.Checked)
                this.Height = 400;
            else
                this.Height = 200;
        }

        private void btnAdvanced_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(btnAdvanced, new Point(0, btnAdvanced.Height));
        }

        #region Flush DNS

        private void tsmiFlushDNS_Click(object sender, EventArgs e)
        {
            uint i = SiIP.NetUtil.FlushDNSCache();

            if (i==1)
                MessageBox.Show("Successfully flushed the DNS Resolver Cache", "Flush DNS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("eng ing eng ...");
        }

        #endregion

        #region thread apply profil

        private void bkWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // pasang profil

            string[] ipAdresses, subnets, gateways, dnses;

            string[] sArg = e.Argument.ToString().Split('|');
            int iNic = int.Parse(sArg[0]);
            int iProf = int.Parse(sArg[1]);

            WMIHelper.SetIP(nicNames[iNic].Caption,
                            profiles[iProf].IP,
                            profiles[iProf].Subnet,
                            profiles[iProf].Gateway,
                            profiles[iProf].DNS);

            // ambil profil yang sudah terpasang
            WMIHelper.GetIP(nicNames[iNic].Caption,
                            out ipAdresses, out subnets, out gateways, out dnses);

            // periksa apakah profil sudah terpasang?
            if (ArraysEqual(profiles[iProf].DNS.Split(','), dnses))
                e.Result = 1;
            else
                e.Result = 0;

        }

        private void bkWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((int)e.Result == 1)
                lblStatus.Text = "Berhasil ...";
            else
                lblStatus.Text = "Gagal ...";


            progressBar1.Value = 100;
            progressBar1.Style = ProgressBarStyle.Continuous;

            showCurrentConfig(cboxNetCard.SelectedIndex);

            btnActivate.Enabled = true;
        }

        #endregion

        #region thread ambil info NICs

        private void bkWorkerLoadNic_DoWork(object sender, DoWorkEventArgs e)
        {
            // get the NIC names
            e.Result = WMIHelper.GetNICNames();
        }

        private void bkWorkerLoadNic_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            nicNames = (WMIHelper.infoNIC[])e.Result;

            // populate the NIC list
            cboxNetCard.Items.Clear();
            foreach (WMIHelper.infoNIC info in nicNames)
            {
                cboxNetCard.Items.Add(info.Name);
                if (info.NetConnectionStatus == 2) cboxNetCard.Text = info.Name;
            }

            // if NIC found, select the first one
            if (cboxNetCard.Text == "" & cboxNetCard.Items.Count > 0)
            {
                cboxNetCard.SelectedIndex = 0;
                cboxNetCard.Enabled = true;
            }

            lblStatus.Text = "Load Profils ...";
            loadProfils();

            lblStatus.Text = "Ready ...";
            progressBar1.Value = 0;
            progressBar1.Style = ProgressBarStyle.Continuous;

            chkShowDetail.Checked = false;
            btnActivate.Enabled = true;
            btnAdvanced.Enabled = true;
            cboxNetCard.Enabled = true;
            cboxProfile.Enabled = true;
            panel2.Enabled = true;

        }

        #endregion
    }

}
