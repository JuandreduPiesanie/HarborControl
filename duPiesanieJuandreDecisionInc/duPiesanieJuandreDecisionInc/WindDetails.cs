using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duPiesanieJuandreDecisionInc
{
    class WindDetails
    {
        private int weatherID;
        private float windSpeed;
        private DateTime loggedTime;

        public int WeatherID { get => weatherID; set => weatherID = value; }
        public float WindSpeed { get => windSpeed; set => windSpeed = value; }
        public DateTime LoggedTime { get => loggedTime; set => loggedTime = value; }

        public WindDetails(int weatherID, float windSpeed, DateTime loggedTime)
        {
            WeatherID = weatherID;
            WindSpeed = windSpeed;
            LoggedTime = loggedTime;
        }

        public WindDetails()
        {

        }

        public void PopulateWindDetails()
        {
            DBAccess db = new DBAccess();
            DataSet ds = db.getLastRow("WindDetails");
            foreach (DataRow item in ds.Tables["WindDetails"].Rows)
            {
                weatherID = int.Parse(item["weatherID"].ToString());
                windSpeed = float.Parse(item["WindSpeed"].ToString());
                loggedTime = DateTime.Parse(item["Time"].ToString());
            }
        }
        public void InsertWindInformation(float windSpeed, DateTime loggedTime)
        {
            new DBAccess().InsertWindDetails(windSpeed, loggedTime);
        }
    }
}
