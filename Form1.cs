using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class MaxCPU : Form
    {
        private int NumberofProcessors = 0;
        private int NumberOfCores = 0;
        Thread[] cpuLoadThread;
        int LoadLevel = 0;
        int numberOfThreads = 0;

        public MaxCPU()
        {
            InitializeComponent();
        }

        private void MaxCPU_Load(object sender, EventArgs e)
        {
            foreach (var item in new System.Management.ManagementObjectSearcher("Select * from Win32_ComputerSystem").Get())
            {
                NumberofProcessors += int.Parse(item["NumberOfProcessors"].ToString());
            }
            
            foreach (var item in new System.Management.ManagementObjectSearcher("Select * from Win32_Processor").Get())
            {
                NumberOfCores += int.Parse(item["NumberOfLogicalProcessors"].ToString());
            }
            NumberOfProcessors.Text = NumberofProcessors.ToString();
            NumberofCores.Text = NumberOfCores.ToString();

        }

        private void Go_Click(object sender, EventArgs e)
        {
            Stop.Enabled = true;
            Go.Enabled = false;
            CPULevel.Enabled = false;
            numberOfThreads = NumberOfCores; // NumberofProcessors * NumberOfCores;
            cpuLoadThread = new Thread[numberOfThreads];
            LoadLevel = Convert.ToInt16(CPULevel.Value);
            for (int x = 0; x < numberOfThreads; x++)
            {
                cpuLoadThread[x] = new Thread(new ThreadStart(cpuLoadProc));
                cpuLoadThread[x].IsBackground = true;
                cpuLoadThread[x].Name = "CPU Load Thread";
                cpuLoadThread[x].Start();
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            Stop.Enabled = false;
            Go.Enabled = true;
            CPULevel.Enabled = true;
            for (int x = 0; x < numberOfThreads; x++)
            {
                cpuLoadThread[x].Abort();
            }
        }
                    
        
        void cpuLoadProc()
        {
            System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();
            stopWatch.Start();

            while (true)
            {
                if (stopWatch.ElapsedMilliseconds > LoadLevel)
                {
                    Thread.Sleep(100 - LoadLevel);
                    stopWatch.Reset();
                    stopWatch.Start();
                }
            }
        }

        private void CPULevel_Scroll(object sender, EventArgs e)
        {
            DisplayLoadLevel.Text = CPULevel.Value.ToString();
        }


    }
}
