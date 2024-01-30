using AlienDateTime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlienClock
{
    public partial class MainForm : Form
    {
       
        public MainForm()
        {
            InitializeComponent();
            this.clock2.IsAlienClock= true;
            this.clock2.Display = ClockDisplay.DisplayOption.all;
            this.clock2.StartPaint();

            this.clock1.IsAlienClock = false;
            this.clock1.Display = ClockDisplay.DisplayOption.all;
            this.clock1.StartPaint();

            this.Shown += MainForm_Shown;

            btnToAlienClock.Click += BtnToAlienClock_Click;
            btnToEarthClock.Click += BtnToEarthClock_Click;
        }

        private void BtnToEarthClock_Click(object sender, EventArgs e)
        {
            ADateTime curData= new ADateTime();
            try
            {
                curData.Year = int.Parse(txtAYear.Text);
                curData.Month=int.Parse(txtAMonth.Text);
                curData.Day=int.Parse(txtADay.Text);
                curData.Hour=int.Parse(txtAHour.Text);
                curData.Minute=int.Parse(txtAMinute.Text);
                curData.Second=double.Parse(txtASecond.Text);
                lblEarthDtResult.Text = curData.ToEarthTime().ToString("yyyy-MM-dd HH:m:s");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            MessageBox.Show("Finish");
        }

        private void BtnToAlienClock_Click(object sender, EventArgs e)
        {
            AlienDateTime.ADateTime currentAlien = new AlienDateTime.ADateTime();
            try
            {
                string dtString = $"{txtYear.Text}-{txtMonth.Text}-{txtDay.Text} {txtHour.Text}:{txtMinute.Text}:{txtSecond.Text}";
                DateTime curData = DateTime.Parse(dtString);
                currentAlien = currentAlien.ConvertToAlienClock(curData);
                lblAlienResult.Text = currentAlien.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            MessageBox.Show("Finish");
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            DateTime current= DateTime.Now;
            txtYear.Text = current.Year.ToString();
            txtMonth.Text = current.Month.ToString();
            txtDay.Text = current.Day.ToString();
            txtHour.Text = current.Hour.ToString();
            txtMinute.Text = current.Minute.ToString();
            txtSecond.Text = current.Second.ToString();

            AlienDateTime.ADateTime currentAlien = new AlienDateTime.ADateTime();
            currentAlien = currentAlien.ConvertToAlienClock(current);
            txtAYear.Text = currentAlien.Year.ToString();
            txtAMonth.Text = currentAlien.Month.ToString();
            txtADay.Text = currentAlien.Day.ToString();
            txtAHour.Text= currentAlien.Hour.ToString();
            txtAMinute.Text= currentAlien.Minute.ToString();
            txtASecond.Text = currentAlien.Second.ToString();
            
        }
    }
}
