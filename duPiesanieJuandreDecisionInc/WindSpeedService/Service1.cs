using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;



namespace WindSpeedService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            string zipCode = "4052";
            string url = string.Format("https://api.openweathermap.org/data/2.5/weather?zip={0},za&units=imperial&APPID=ae1c30692930f8b20fabfcbb02d07fbe", zipCode);
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                // Usage
                HttpResponseMessage response = client.GetAsync("api/importresults/1").Result;
                if (response.IsSuccessStatusCode)
                {
                    var dto = response.Content.ReadAsAsync<ImportResultDTO>().Result;
                }
                else
                {
                    Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                }
            }
        }

        protected override void OnStop()
        {
        }

    }
}
