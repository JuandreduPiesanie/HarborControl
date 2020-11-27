using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using RestSharp;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using Newtonsoft.Json;
using static duPiesanieJuandreDecisionInc.WeatherObject;
using System.Threading;

namespace duPiesanieJuandreDecisionInc
{
    class WeatherAPI
    {
        private Thread myThread;
        private bool myBool = true;

        public WeatherAPI()
        {
            myThread = new Thread(Run);
            myThread.Start();
        }

        public void Run()
        {
            string url = "https://api.openweathermap.org/data/2.5/weather?zip=4052,ZA&units=metric&APPID=ae1c30692930f8b20fabfcbb02d07fbe";
            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);

            while (myBool)
            {
                IRestResponse response = client.Execute(request);
                var weatherInfo = JsonConvert.DeserializeObject<WeatherInfo>(response.Content);
                new WindDetails().InsertWindInformation(weatherInfo.wind.speed, DateTime.Now);
                Thread.Sleep(300000);
            }
        }

        public void StopThread()
        {
            myBool = false;
        }
    }
}
