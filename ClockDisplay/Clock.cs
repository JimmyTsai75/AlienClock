using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlienDateTime;

namespace ClockDisplay
{
    public partial class Clock : UserControl
    {
        private Timer timer;
        private Timer txtTimer;
        private Bitmap buffer; // Bitmap used for double buffering
        private int radix = 60;
        private bool isAlienClock = false;

        private DisplayOption display = DisplayOption.all;
        public DisplayOption Display { get { return display; } 
            set {
                display=value;
                switch (display)
                {
                    case DisplayOption.text:
                        splitContainer1.Panel1Collapsed= true;
                        splitContainer1.Panel2Collapsed = false;
                        break;
                    case DisplayOption.graphics:
                        splitContainer1.Panel1Collapsed = false;
                        splitContainer1.Panel2Collapsed = true;
                        break;
                    case DisplayOption.all:
                        splitContainer1.Panel1Collapsed = false;
                        splitContainer1.Panel2Collapsed = false;
                        break;
                   
                }
            }
        }
        /// <summary>
        /// if display alien clock default=false
        /// </summary>
        public bool IsAlienClock { 
            get { return isAlienClock; }
            set { isAlienClock = value;radix = isAlienClock ? 90 : 60; }
        }
        public Clock()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            // Initialize Double Buffered Bitmap
            buffer = new Bitmap(this.splitContainer1.Panel1.Width, this.splitContainer1.Panel1.Height);
            
            txtTimer = new Timer();
            txtTimer.Interval= 100;
            txtTimer.Tick += TxtTimer_Tick;
        }

        private void TxtTimer_Tick(object sender, EventArgs e)
        {
            
            if (IsAlienClock)
            {
                ADateTime ad = new ADateTime();
                ad = ad.ConvertToAlienClock(DateTime.Now);
                lblCurrentDt.Text = ad.ToString();
                lblTitle.Text = "AlienClock";
            }
            else
            {
                lblCurrentDt.Text = DateTime.Now.ToString("yyyy-MM-dd h:m:s");
                lblTitle.Text = "EarthClock";
            }
        }

        public void StartPaint()
        {
            switch (Display)
            {
                case DisplayOption.text:
                    txtTimer.Start();
                    break;
                case DisplayOption.graphics:
                    timer.Start();
                    break;
                case DisplayOption.all:
                    txtTimer.Start();
                    timer.Start();
                    break;              
            }     
        }
        private void RedrawClock()
        {
            
            using (Graphics gBuffer = Graphics.FromImage(buffer))
            {
                gBuffer.Clear(BackColor);
                // Draw the appearance of the clock on a double buffered bitmap
                DrawClock(gBuffer);
            }

            // Draw a double buffered bitmap onto the screen at once
            using (Graphics g = this.splitContainer1.Panel1.CreateGraphics())
            {
                g.DrawImage(buffer, 0, 0);
            }
           
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            RedrawClock();
        }

        private void DrawClock(Graphics g)
        {
            // Get the center coordinates of the form
            int centerX = this.splitContainer1.Panel1.ClientSize.Width / 2;
            int centerY = this.splitContainer1.Panel1.ClientSize.Height / 2;

            // Obtain clock radius
            int clockRadius = Math.Min(centerX, centerY) - 10;

            // Draw a clock circular border
            g.DrawEllipse(Pens.Black, centerX - clockRadius, centerY - clockRadius, 2 * clockRadius, 2 * clockRadius);
            int numOfScale = radix / 5;//5 minutes per scale
            float angleOfScale = 360 / numOfScale;//The angle of each scale
            // Draw clock scale
            for (int i = 0; i < numOfScale; i++)
            {

                double angle = (i * angleOfScale + 270) * Math.PI / 180; 
                int startX = (int)(centerX + (clockRadius - 10) * Math.Cos(angle));
                int startY = (int)(centerY + (clockRadius - 10) * Math.Sin(angle));
                int endX = (int)(centerX + clockRadius * Math.Cos(angle));
                int endY = (int)(centerY + clockRadius * Math.Sin(angle));

                g.DrawLine(Pens.Black, startX, startY, endX, endY);

                // Draw numbers
                string number = (i == 0 ? numOfScale : i).ToString();
                SizeF numberSize = g.MeasureString(number, Font);
                float numberX = centerX + (clockRadius - 30) * (float)Math.Cos(angle) - numberSize.Width / 2;
                float numberY = centerY + (clockRadius - 30) * (float)Math.Sin(angle) - numberSize.Height / 2;
                g.DrawString(number, Font, Brushes.Black, numberX, numberY);
            }
            float hourAngle, minuteAngle, secondAngle;
            if (IsAlienClock) {
                // Get current time
                AlienDateTime.ADateTime now = new ADateTime();
                now = now.ConvertToAlienClock(DateTime.Now);
                // Calculate the angles of the hour hand, minute hand, and second hand
                hourAngle = ((now.Hour % numOfScale + now.Minute / (float)radix) * angleOfScale) - 90;
                minuteAngle = (now.Minute * 360f / radix) - 90;
                secondAngle = ((float)now.Second * 360f / radix) - 90;
            }
            else
            {
                // Get current time
                DateTime now = DateTime.Now;
                // Calculate the angles of the hour hand, minute hand, and second hand
                hourAngle = ((now.Hour % numOfScale + now.Minute / (float)radix) * angleOfScale) - 90;
                minuteAngle = (now.Minute * 360f / radix) - 90;
                secondAngle = (now.Second * 360f / radix) - 90;
            } 

            

            // Draw hour hand
            DrawHand(g, centerX, centerY, hourAngle, clockRadius - 40, Pens.Black, 6);

            // Draw the minute hand
            DrawHand(g, centerX, centerY, minuteAngle, clockRadius - 20, Pens.Blue, 4);

            // Draw a second hand
            DrawHand(g, centerX, centerY, secondAngle, clockRadius - 10, Pens.Red, 2);
        }
        private void DrawHand(Graphics g, int centerX, int centerY, float angle, int length, Pen pen, int thickness)
        {
            // Calculate endpoint coordinates
            float endX = centerX + length * (float)Math.Cos(Math.PI * angle / 180.0);
            float endY = centerY + length * (float)Math.Sin(Math.PI * angle / 180.0);

            // Draw lines
            g.DrawLine(new Pen(pen.Color, thickness), centerX, centerY, endX, endY);
        }
    }

    public enum DisplayOption
    {
        text=0,
        graphics=1,
        all=2
    }
}
