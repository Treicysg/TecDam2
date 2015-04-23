using DamProject.DamLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DamProject.DamGUI
{
    /// <summary>
    /// Interaction logic for TecDam.xaml
    /// </summary>
    public partial class TecDam : Window, IObserver<Dam>
    {

        delegate void SetTextCallback(string text);

      
        public TecDam()
        {
            InitializeComponent();
          
       }


        #region observer methods

        public virtual void OnCompleted()
        {
        }

        public virtual void OnError(Exception e)
        {
        }

        public virtual void OnNext(Dam pValue)
        {

            
            _TotalKilowatts = convetMwToKw(pValue.TotalPower);
            _WaterHeight = pValue.CurrentHeightWater;
            _WaterQuantity = convertMt3ToCm3(pValue.CurrentWaterQuantity);
            _WaterReservoirHeight = pValue.Height;
            _SpeedInWater = convertMt3ToCm3(pValue.Speed);
            
            updateWindowValues();
           
           
           
            //Obtener valores que necesitan mostrarse en ventana

        }

        #endregion

       

        #region methods

        //This will convert Megawatts of every turbine and dam to KiloWatts 
        public long convetMwToKw(long pMegaWatts)
        {
            long kiloWatts;
            kiloWatts = pMegaWatts * 1000;
            return kiloWatts;
        }

        public long convertMt3ToCm3(long pQuantity)
        {
            long result = 1;
            try
            {
                result = pQuantity * 1000000;
              


            }

            catch (OverflowException)
            {
                // Que pasa si se excede 
            }

            return result;  


        }

        public void updateWindowValues()
        {
            _LblDamKiloWatts.Content=_TotalKilowatts;
            _lblWaterMeter.Content = _WaterHeight;
            _lblWaterLevel.Content = _WaterQuantity;
            _lblHeightReservoir.Content = _WaterReservoirHeight;
            _txtWaterFlowSpeed.Text = _SpeedInWater.ToString();
            _CmbTurbine.Items.Add("Turbine 1");
            this.ShowDialog();
            
        }


       

    


        #endregion

        #region Properties


        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the 
            // calling thread to the thread ID of the creating thread. 
            // If these threads are different, it returns true. 
            if (this._LblDamKiloWatts.Dispatcher.CheckAccess())
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Dispatcher.BeginInvoke(d, new object[] { text });
            }
            else
            {
                this._LblDamKiloWatts.Content = text;
            }
        }

        public long WaterHeight
        {
            get
            {
                return _WaterHeight;
            }
            set
            {
                _WaterHeight = value;
            }
        }

        public long WaterReservoirHeight
        {
            get
            {
                return _WaterReservoirHeight;
            }
            set
            {
                _WaterReservoirHeight = value;
            }
        }

        public long WaterQuantity
        {
            get
            {
                return _WaterQuantity;
            }
            set
            {
                _WaterQuantity = value;
            }
        }

        public long SpeedInWater
        {
            get
            {
                return _SpeedInWater;
            }
            set
            {
                _SpeedInWater = value;
            }
        }

        public long Kilowatts
        {
            get
            {
                return _Kilowatts;
            }
            set
            {
                _Kilowatts = value;
            }
        }

        public long RiverHeight
        {
            get
            {
                return _RiverHeight;
            }
            set
            {
                _RiverHeight = value;
            }
        }

        public long TotalKilowatts
        {
            get
            {
                return _TotalKilowatts;
            }
            set
            {
                _TotalKilowatts = value;
            }
        }



        #endregion

        #region attributes

        private long _WaterHeight;
        private long _WaterReservoirHeight;
        private long _WaterQuantity;
        private long _SpeedInWater;
        private long _Kilowatts;
        private long _RiverHeight;
        private long _TotalKilowatts;
     

        #endregion

        
        private void _chkTurbineEnable_Checked(object sender, RoutedEventArgs e)
        {
            //Change the turbine state
        }

        private void _BtnApply_Click(object sender, RoutedEventArgs e)
        {
            //Change the speed 

        }
    }
}
