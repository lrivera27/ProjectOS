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
using System.IO;

namespace Squashids
{
    public partial class mainMenu : Form
    {
        public bool done = false;
        public float _cpuCounter;
        public float _ramCounter;
        public string _warnings = "No Warnings";
        public float highestCPU = 0;
        public float lowestCPU = 0;
        public float totalCPU;
        public float averageCPU;
        public float counter;

        public mainMenu()
        {
            InitializeComponent();
        }
                
        private void hidsBtn_Click(object sender, EventArgs e)
        {
            hidsPanel.Visible = true;
            mainPanel.Visible = false;
            this.Text = "HIDS Menu";
            
            Thread cpuThread = new Thread(new ThreadStart(cpuMonitoring));
            Thread ramThread = new Thread(new ThreadStart(ramMonitoring));
            cpuThread.Start();
            ramThread.Start();
        }

        private void outputBtn_Click(object sender, EventArgs e)
        {
            string dataToExport =
                "Hosted Intrusion Detection Data" + Environment.NewLine +
                "-----------------------------------" + Environment.NewLine +
                "Current CPU Usage: " + _cpuCounter + "%" + Environment.NewLine +
                "Current RAM Usage: " + _ramCounter + "MB" + Environment.NewLine +
                "Highest CPU Usage: " + highestCPU + "%" + Environment.NewLine +
                "Lowest CPU Usage: " + lowestCPU + "%" + Environment.NewLine +
                "Average CPU Usage: " + averageCPU + "%" + Environment.NewLine +
                "Warnings: " + Environment.NewLine + _warnings + Environment.NewLine +
                "-----------------------------------";
         
            string fileName = "Output";

            string path = @"C:\Users\HerpDerp\Desktop\"+fileName +".txt";
            File.WriteAllText(path, dataToExport);

            string test = File.ReadAllText(path);
            MessageBox.Show(test);
        }

        private void nidsBtn_Click(object sender, EventArgs e)
        {
            this.Text = "NIDS Menu";
            mainPanel.Visible = false;
            nidsPanel.Visible = true;
        }

        private void exitBtn_Click(object sender, EventArgs e) // exit_button Test
        {
            loginForm ss = new loginForm();
            this.Close();
            ss.Show();
        }

        private void backBtn_Click(object sender, EventArgs e) //Back Button in HIDS panel
        {
            //Changing back to Main Menu, need to change the text
            this.Text = "Main Menu";

            //Just to make sure every panel is not visible
            hidsPanel.Visible = false;
            nidsPanel.Visible = false;

            mainPanel.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e) // Back Button in NIDS panel
        {
            backBtn_Click(sender, e);
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
                    _cpuCounter = cpuCounter.NextValue();
                    cpuUsageTxt.Text = _cpuCounter + "%";
                    anomalyCPU(_cpuCounter);
                });

                if (highestCPU < _cpuCounter)
                    highestCPU = _cpuCounter;

                if (lowestCPU > _cpuCounter)
                    lowestCPU = _cpuCounter;

                counter++;
                totalCPU += _cpuCounter;
                averageCPU = (totalCPU / counter);
            }
        }

        private void anomalyCPU(float percentageCPU)
        {
            if(percentageCPU > 40)
            {
                if(proWarTxt.Text.Length == 0)
                {
                    proWarTxt.Text = "Warning! CPU Usage: " + percentageCPU;
                } else
                {
                    proWarTxt.AppendText("\r\n" + "Warning! CPU Usage: " + percentageCPU);
                }
                _warnings = proWarTxt.Text;
            }
        }
        private void ramMonitoring()
        {
            PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available MBytes");
            while (!done)
            {
                Thread.Sleep(1000); // wait a second, then try again
                ramMonitorTxt.Invoke((Action)delegate
                {
                    _ramCounter = ramCounter.NextValue();
                    ramMonitorTxt.Text = _ramCounter+ "MB";
                });
            }
        }
    }
}
