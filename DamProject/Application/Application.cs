using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DamProject.DamGUI;
using DamProject.DamLibrary;
using System.Timers;

namespace DamProject.Application
{
    class Application 
    {



        [STAThread]
        public static void Main()
        {
            /**TecDam tecdam = new TecDam();



            var DamSimulation = Dam.Instance;

            _Turb = new Turbine(1, 100,
            200, 100, 500, 20,
            30);

            _Reservoir = new WaterReservoir(200, 30,
            10, 15);

            _Reservoir.Subscribe(_Turb);
            _Turb.Subscribe(DamSimulation);
            DamSimulation.Subscribe(tecdam);

         

            _Reservoir.startWaterLevel();
            _Reservoir.startSimulation();

            Timer myTimer = new Timer();
            myTimer.Elapsed += new ElapsedEventHandler(DisplayTimeEvent);
            myTimer.Interval = 500; // 1000 ms is one second
            myTimer.Start();*/


            MainWindow mw = new MainWindow();


            TecDam tecdam = new TecDam();
          


            var DamSimulation = Dam.Instance;

            Turbine _Turb = new Turbine (mw.TurbineQuantityInput, mw.OutFlowMinInput,
            mw.OutFlowMaxInput, mw.MegawattsMinInput, mw.MegaWattsMaxInput, mw.HeightwaterMinInput,
            mw.HeightWaterMaxInput);

            WaterReservoir _Reservoir = new WaterReservoir(mw.SpeedMetInput,mw.HeightInput, 
            mw.LenghtInput, mw.WidthInput);

            _Reservoir.Subscribe(_Turb);
            _Turb.Subscribe(DamSimulation);
            DamSimulation.Subscribe(tecdam);

            _Reservoir.startWaterLevel();
            _Reservoir.startSimulation();

            

            Timer myTimer = new Timer();
            myTimer.Elapsed += new ElapsedEventHandler(DisplayTimeEvent);
            myTimer.Interval = 1000; // 1000 ms is one second
            myTimer.Start();

        }


        public static void DisplayTimeEvent(object source, ElapsedEventArgs e)
        {
            
                _Reservoir.updateWaterLevel(_Turb.CurrentOutFlow);
           





        }

        private static WaterReservoir _Reservoir;
        private static Turbine _Turb;
       

    }
}
