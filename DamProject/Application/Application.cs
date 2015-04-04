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

        public static void Main()
        {
            MainWindow mw = new MainWindow();
            TecDam tecdam = new TecDam();
            Turbine _Turb;
            WaterReservoir _Reservoir;
             
           

            var DamSimulation = Dam.Instance;

           /* _Turb = DamSimulation.createTurbine(turbineQuantity, outFlowMin, outFlowMax,
            megawattsMin, megaWattsMax, heightwaterMin, heightWaterMax);

            _Reservoir = DamSimulation.createWaterReservoir(speddMet, height, lenght, width);

            _Reservoir.Subscribe(_Turb);
            _Turb.Subscribe(DamSimulation);
            DamSimulation.Subscribe(tecdam);

            _Reservoir.startWaterLevel();
            _Reservoir.startSimulation();*/



            Timer myTimer = new Timer();
            myTimer.Elapsed += new ElapsedEventHandler(DisplayTimeEvent);
            myTimer.Interval = 500; // 1000 ms is one second
            myTimer.Start();

        }


        public static void DisplayTimeEvent(object source, ElapsedEventArgs e)
        {

            ///_Reservoir.updateWaterLevel(_Turb.CurrentOutFlow);





        }

    }
}
