﻿using System;
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
            done = false;
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
            float _cpuCounter;
            backBtn.Click += DoneUpdate;
            done = false;
            while (!done)
            {
                var unused = cpuCounter.NextValue(); // first call will always return 0
                Thread.Sleep(1000); // wait a second, then try again
                
                cpuUsageTxt.Invoke((Action)delegate
                {
                    _cpuCounter = cpuCounter.NextValue();
                    cpuUsageTxt.Text = _cpuCounter + "%";
                    anomalyCPU(_cpuCounter);
                });
            }
        }

        private void anomalyCPU(float percentageCPU)
        {
            if(percentageCPU > 30)
            {
                if(proWarTxt.Text.Length == 0)
                {
                    proWarTxt.Text = "Warning! CPU Usage: " + percentageCPU;
                } else
                {
                    proWarTxt.AppendText("\r\n" + "Warning! CPU Usage: " + percentageCPU);
                }
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
        private static void ShowNetworkTraffic()
        {
            PerformanceCounterCategory performanceCounterCategory = new PerformanceCounterCategory("Network Interface");
            string instance = performanceCounterCategory.GetInstanceNames()[0]; // 1st NIC !
            PerformanceCounter performanceCounterSent = new PerformanceCounter("Network Interface", "Bytes Sent/sec", instance);
            PerformanceCounter performanceCounterReceived = new PerformanceCounter("Network Interface", "Bytes Received/sec", instance);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("bytes sent: {0}k\tbytes received: {1}k", performanceCounterSent.NextValue() / 1024, performanceCounterReceived.NextValue() / 1024);
                Thread.Sleep(500);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            backBtn_Click(sender, e);
        }


    }
}
