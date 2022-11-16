using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

namespace DNS_Bypasser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            populateAdapterCombobox();
            populateIPtextBoxes();
        }
        private void populateAdapterCombobox()
        {
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                comboboxNetworkAdapter.Items.Add(nic.Name);
            }
            comboboxNetworkAdapter.SelectedItem = comboboxNetworkAdapter.Items[0];
        }
        private void populateIPtextBoxes()
        {
            if (radioProvider1.Checked)
            {
                textBoxIPv4a.Text = "84.200.69.80";
                textBoxIPv4b.Text = "84.200.70.40";
                textBoxIPv6a.Text = "2001:1608:10:25::1c04:b12f";
                textBoxIPv6b.Text = "2001:1608:10:25::9249:d69b";
            } else if (radioProvider2.Checked)
            {
                textBoxIPv4a.Text = "8.8.8.8";
                textBoxIPv4b.Text = "8.8.4.4";
                textBoxIPv6a.Text = "2001:4860:4860::8888";
                textBoxIPv6b.Text = "2001:4860:4860::8844";
            } else if (radioProvider3.Checked)
            {
                textBoxIPv4a.Text = "76.76.2.0";
                textBoxIPv4b.Text = "76.76.10.0";
                textBoxIPv6a.Text = "2606:1a40::";
                textBoxIPv6b.Text = "2606:1a40:1::";
            } else if (radioProvider4.Checked)
            {
                textBoxIPv4a.Text = "1.1.1.1";
                textBoxIPv4b.Text = "1.0.0.1";
                textBoxIPv6a.Text = "2606:4700:4700::1111";
                textBoxIPv6b.Text = "2606:4700:4700::1001";
            }
            // enable/disable custom addresses
            if (radioProviderCustom.Checked)
            {
                panelAddresses.Enabled = true;
            } else
            {
                panelAddresses.Enabled = false;
            }
        }

        private void radioProvider1_CheckedChanged(object sender, EventArgs e)
        {
            populateIPtextBoxes();
        }

        private void radioProvider2_CheckedChanged(object sender, EventArgs e)
        {
            populateIPtextBoxes();
        }

        private void radioProvider3_CheckedChanged(object sender, EventArgs e)
        {
            populateIPtextBoxes();
        }

        private void radioProvider4_CheckedChanged(object sender, EventArgs e)
        {
            populateIPtextBoxes();
        }

        private void radioProviderCustom_CheckedChanged(object sender, EventArgs e)
        {
            populateIPtextBoxes();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.Verb = "runas";
            cmd.Start();
            cmd.StandardInput.WriteLine("netsh interface ipv4 set dns name=\"" + comboboxNetworkAdapter.SelectedItem + "\" static addr=\"" + textBoxIPv4a.Text + "\" validate=\"no\"");
            Thread.Sleep(50);
            cmd.StandardInput.WriteLine("netsh interface ipv4 add dns name=\"" + comboboxNetworkAdapter.SelectedItem + "\" addr=\"" + textBoxIPv4b.Text + "\" index=2 validate=\"no\"");
            Thread.Sleep(50);
            cmd.StandardInput.WriteLine("netsh interface ipv6 set dns name=\"" + comboboxNetworkAdapter.SelectedItem + "\" static addr=\"" + textBoxIPv6a.Text + "\" validate=\"no\"");
            Thread.Sleep(50);
            cmd.StandardInput.WriteLine("netsh interface ipv6 add dns name=\"" + comboboxNetworkAdapter.SelectedItem + "\" addr=\"" + textBoxIPv6b.Text + "\" index=2 validate=\"no\"");
            Thread.Sleep(50);
            cmd.StandardInput.WriteLine("ipconfig /flushdns");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            //textBoxDebug.Text = cmd.StandardOutput.ReadToEnd();
            MessageBox.Show("Operation has been successful.", "DNS Bypasser");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/anonwins/DNS-Bypasser");
        }
    }

}
