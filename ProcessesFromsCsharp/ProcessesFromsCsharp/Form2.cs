using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ProcessesFromsCsharp
{
    public partial class Form2 : Form
    {
        public bool toggle = true;
        public Form2()
        {
            InitializeComponent();
            TopMost = true;
            ShowInTaskbar = false;
            ControlBox = false;
            Text = "";
            FormBorderStyle = FormBorderStyle.None;
            int width = (int)(Screen.PrimaryScreen.Bounds.Width * 0.1);
            int height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.1);
            Location = new Point(width, height);
            
            Time.Font = new Font("Arial", 12);
            Time.BackColor = Color.Transparent;
            Size = Time.Size;
            Opacity = 0.75;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // USED FOR TRANSPARENT BACKGROUND
            //SetStyle(ControlStyles.UserPaint, true);
            //SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            //SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.DarkGray;
            //TransparencyKey = Color.Blue;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PowerStatus status = SystemInformation.PowerStatus;
            float percent = status.BatteryLifePercent;
            string battery = "Battery: " + (percent*100).ToString() + "%";
            if (status.PowerLineStatus == PowerLineStatus.Online)
            { battery += ", Charging"; }
            else { battery += ", Discharging"; }
            string date = "Date: " + DateTime.Now.ToString("dd/MM/yyyy") + "\n";
            string time = "Time: " + DateTime.Now.ToString("HH:mm:ss") + "\n";
            Time.Text = date + time + battery;
        }

    }
}
