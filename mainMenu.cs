using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace Squashids
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        public bool done = false;
        private void hidsBtn_Click(object sender, EventArgs e)
        {
            hidsPanel.Visible = true;
            mainPanel.Visible = false;
            this.Text = "HIDS Menu";
            Thread cpuThread = new Thread(new ThreadStart(cpuMonitoring));
            cpuThread.Start();
            Thread ramThread = new Thread(new ThreadStart(ramMonitoring));
            ramThread.Start();
        }

        private void exitBtn_Click(object sender, EventArgs e) // exit_button Test
        {
            loginForm ss = new loginForm();
            this.Close();
            ss.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Text = "Main Menu";
            hidsPanel.Visible = false;
            nidsPanel.Visible = false;
            mainPanel.Visible = true;
        }

        private void DoneUpdate(object sender, EventArgs e)
        {
            done = true;
        }
        private void cpuMonitoring()
        {
            PerformanceCounter cpuCounter = new PerformanceCounter();
            cpuCounter.CategoryName = "Processor";
            cpuCounter.CounterName = "% Processor Time";
            cpuCounter.InstanceName = "_Total";

            backBtn.Click += DoneUpdate;
            done = false;
            while (!done)
            {
                var unused = cpuCounter.NextValue(); // first call will always return 0
                Thread.Sleep(1000); // wait a second, then try again

                cpuUsageTxt.Invoke((Action)delegate
                {
                    cpuUsageTxt.Text = cpuCounter.NextValue() + "%";
                });
            }
        }

        private void ramMonitoring()
        {
            PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available MBytes");
            while (!done)
            {
                ramMonitorTxt.Invoke((Action)delegate
                {
                    ramMonitorTxt.Text = ramCounter.NextValue() + "MB";
                });
            }
        }

        private void nidsBtn_Click(object sender, EventArgs e)
        {
            this.Text = "NIDS Menu";
            mainPanel.Visible = false;
            nidsPanel.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            backBtn_Click(sender, e);
        }
    }
}
