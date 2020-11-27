using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace duPiesanieJuandreDecisionInc
{
    class ScheduleEngine
    {
        //Current Boat inside the perimeter

        private Boat currBoatInPerimeter;
        private FrmBoatSimulation liveForm;
        private WindDetails currWindDetails;
        private Thread boatThread, simulationThread;
        private Queue<Boat> boatQueue; //outside 10km perimeter
        private List<Boat> myBoats = new List<Boat>()
        {
            new Sailboat(),
            new Speedboat(),
            new CargoShip()
        };
        bool activeBoats;
        bool simulateBoats = true;
        int travelTime = 0;
        string myString = "";

        private int windSpeed;
        public int WindSpeed { get => windSpeed; set => windSpeed = value; }
        public ScheduleEngine()
        {
            boatQueue = new Queue<Boat>();
            currWindDetails = new WindDetails();
            boatThread = new Thread(GenerateThreadRandomBoat);
            boatThread.Start();
            simulationThread = new Thread(BoatSimulation);
            simulationThread.Start();
        }
        public ScheduleEngine(FrmBoatSimulation myForm) : this() 
        {
            liveForm = myForm;
        }

        public void GenerateThreadRandomBoat()
        {
            activeBoats = true;
            while (activeBoats)
            {
                boatQueue.Enqueue(myBoats[new Random().Next(0, 3)]);
                Thread.Sleep(200);
                if (boatQueue.Count == 1)
                {
                    liveForm.UpdateNextInLine(boatQueue.Peek().ToString());
                }
                Thread.Sleep(2000);
                //Thread.Sleep(1000*rnd.Next(3,6));
            }
        }
        public void BoatSimulation()
        {
            while (simulateBoats)
            {
                if (currBoatInPerimeter == null)
                {
                    if (boatQueue.Count != 0)
                    {
                        UnQueueBoat();
                        if (boatQueue.Count != 0)
                        {
                            liveForm.UpdateNextInLine(boatQueue.Peek().ToString());
                        }
                        else
                        {
                            liveForm.UpdateNextInLine("Queue Empty");
                        }

                        travelTime = CalcTravelTime(currBoatInPerimeter.Speed, 10);
                        myString = currBoatInPerimeter.ToString();
                        liveForm.UpdateRichTextData(myString);
                        //Start with no boats in perimeter
                        Thread.Sleep((travelTime / 4)*1000);
                        myString = "DOCK [][][][*] Perimeter " + currBoatInPerimeter.ToString() + " traveling at " + currBoatInPerimeter.Speed + " km/h";
                        liveForm.UpdateRichTextData(myString);

                        //Boat is 1/4 inside perimeter
                        Thread.Sleep((travelTime / 4) * 1000);
                        myString = "DOCK [][][*][] Perimeter " + currBoatInPerimeter.ToString() + " traveling at " + currBoatInPerimeter.Speed + " km/h";
                        liveForm.UpdateRichTextData(myString);

                        //Boat is 2/4 inside perimeter
                        Thread.Sleep((travelTime / 4) * 1000);
                        myString = "DOCK [][*][][] Perimeter " + currBoatInPerimeter.ToString() + " traveling at " + currBoatInPerimeter.Speed + " km/h";
                        liveForm.UpdateRichTextData(myString);

                        //Boat is 3/4 inside perimeter
                        Thread.Sleep((travelTime / 4) * 1000);
                        myString = "DOCK [*][][][] Perimeter " + currBoatInPerimeter.ToString() + " has arrived at the dock";
                        liveForm.UpdateRichTextData(myString);

                        //Boat arrived at the dock                        
                        currBoatInPerimeter = null;
                        Thread.Sleep(2000); //Delays the time it takes Harbor Control to signal another boat to enter the perimeter
                    }
                    else
                    {
                        Thread.Sleep(500);
                    }
                }
                else
                {
                    Thread.Sleep(500);
                }                
            }            
        }
        public void UnQueueBoat()
        {
            currWindDetails.PopulateWindDetails();
            UpdateWindSpeed();
            if (boatQueue.Peek().GetType() == typeof(Sailboat))
            {
                if (currWindDetails.WindSpeed < 10 || currWindDetails.WindSpeed > 30)
                {
                    boatQueue.Enqueue(boatQueue.Dequeue());
                    UnQueueBoat();
                }
                else
                {
                    currBoatInPerimeter = boatQueue.Dequeue();
                }
            }
            else
            {
                currBoatInPerimeter = boatQueue.Dequeue();
            }
        }

        public void UpdateWindSpeed()
        {
            liveForm.UpdateCurrentWindSpeed(currWindDetails.WindSpeed.ToString());
        }
        public int CalcTravelTime(double speed, double distance)
        {
            return (int)((distance / speed) * 60);
        }
        public void StopQueue()
        {
            activeBoats = false;
        }
        public void StopSimulation()
        {
            simulateBoats = false;
        }
    }
}
