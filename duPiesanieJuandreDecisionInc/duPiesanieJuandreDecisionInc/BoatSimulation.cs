using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace duPiesanieJuandreDecisionInc
{
    public partial class FrmBoatSimulation : Form
    {
        public FrmBoatSimulation()
        {
            InitializeComponent();
        }
        WeatherAPI myWeather;
        ScheduleEngine schedule;
        private delegate void BoatDelegate();
        string testString = "";

        private void FrmBoatSimulation_Load(object sender, EventArgs e)
        {
            myWeather = new WeatherAPI();           
        }

        public void UpdateRichTextData(string perimeterResult) 
        {
            testString = perimeterResult;
            UpdateRichPerameterText();
        }

        private void UpdateRichPerameterText()
        {
            if (RtbPerimeter.InvokeRequired)
            {
                BoatDelegate bd = new BoatDelegate(UpdateRichPerameterText);
                RtbPerimeter.Invoke(bd);
            }
            else
            {
                RtbPerimeter.Text = testString;
            }
        }

        public void UpdateNextInLine(string perimeterResult)
        {
            testString = perimeterResult;
            UpdateNextInLineText();
        }

        private void UpdateNextInLineText()
        {
            if (TxtNextInLine.InvokeRequired)
            {
                BoatDelegate bd = new BoatDelegate(UpdateNextInLineText);
                TxtNextInLine.Invoke(bd);
            }
            else
            {
                TxtNextInLine.Text = testString;
            }
        }

        public void UpdateCurrentWindSpeed(string perimeterResult)
        {
            testString = perimeterResult;
            UpdateCurrentWindSpeedText();
        }

        private void UpdateCurrentWindSpeedText()
        {
            if (LblCurrWindSpeed.InvokeRequired)
            {
                BoatDelegate bd = new BoatDelegate(UpdateCurrentWindSpeedText);
                LblCurrWindSpeed.Invoke(bd);
            }
            else
            {
                LblCurrWindSpeed.Text = testString + "km/h";
            }
        }

        private void BtnStartSimulation_Click(object sender, EventArgs e)
        {
            schedule = new ScheduleEngine(this);
        }

        private void BtnEndSimulation_Click(object sender, EventArgs e)
        {
            schedule.StopQueue();
            schedule.StopSimulation();
        }
    }
}
