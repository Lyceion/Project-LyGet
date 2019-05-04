#region Libs
using System;
using System.Diagnostics;
using CoreAudioApi;
#endregion
namespace Project_LyGet
{
    #region Form
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        #region Globals
        int vol = 0;
        MMDeviceEnumerator volumeter = new MMDeviceEnumerator();
        PerformanceCounter cpuCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
        PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available MBytes");
        PerformanceCounter upTime = new PerformanceCounter("System","System Up Time");
        #endregion
        #region Main
        public Main()
        {
            InitializeComponent();
        }
        #endregion
        #region Processes
        private void Form1_Load(object sender, EventArgs e)
        {
            startCommands();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void startCommands()
        {
            this.SetDesktopLocation(0, 598);
            clockLabel.Text = DateTime.Now.ToString();
            cpuProg.Value = (int)(cpuCounter.NextValue());
            memProg.Value = (int)(ramCounter.NextValue() / 100);
            hourLabel.Text = "" + (int)upTime.NextValue() / 60 / 60 + " Hr";
            volProg.Value = getVol();
            volLabel.Text = getVol() + "%";
        }
        private int getVol()
        {
            int MasterMin = 0;
            MMDeviceEnumerator DevEnum = new MMDeviceEnumerator();
            MMDevice device = DevEnum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia);
            int Vol = 0;
            Vol = Convert.ToInt32((device.AudioEndpointVolume.MasterVolumeLevelScalar * 100));
            if ((Vol < MasterMin))
            {
                Vol = (MasterMin / 100);
            }

            return Vol;
        }
        //private int setVolume()
        //{
        //    MMDeviceEnumerator test = new MMDeviceEnumerator();
        //    MMDevice device = test.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia);
        //    device.AudioEndpointVolume.MasterVolumeLevelScalar = vol / 100.0f;
        //    return vol;
        //}
        #endregion
        #region Timers
        private void counTimer_Tick(object sender, EventArgs e)
        {
            cpuProg.Value = (int)(cpuCounter.NextValue());
            memProg.Value = (int)(100 - (ramCounter.NextValue() / 100));
            hourLabel.Text = "" + (int)upTime.NextValue() / 60 /60 + " Hr";
            volProg.Value = getVol();
            volLabel.Text = volProg.Value + "%";
            cpuLabel.Text = cpuProg.Value + "%";
            memLabel.Text = memProg.Value + "%";
            if (volLabel.Text == "100%")
            {
                volLabel.Left = 185;
            }
            else
            {
                volLabel.Left = 188;
            }
        }
        private void clockTimer_Tick(object sender, EventArgs e)
        {
            clockLabel.Text = DateTime.Now.ToString();
        }
        #endregion
    }
    #endregion
}
