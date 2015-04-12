using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamProject.DamLibrary
{
    public class Turbine : IObserver<WaterReservoir>, IObservable<Turbine>
    {
        #region constructor
        public Turbine(int pIdentifier, long pOutFlowMin, long pOutFlowMax,
        long pMegaWattsMin, long pMegaWattsMax, long pHeightMinWater, long pHeigtMaxWater)
        {
            _Observers = new List<IObserver<Turbine>>();
            _Identification = pIdentifier;
            _OutFlowMin = pOutFlowMin;
            _OutFlowMax = pOutFlowMax;
            _HeightMinWater = pHeightMinWater;
            _HeigtMaxWater = pHeigtMaxWater;
            _MegaWattsMin = pMegaWattsMin;
            _MegaWattsMax = pMegaWattsMax;

        }
        #endregion


        #region Properties


        public long OutFlowMax
        {
            get
            {
                return _OutFlowMax;
            }
            set
            {
                _OutFlowMax = value;
            }
        }

       
        public long MegaWattsMax
        {
            get
            {
                return _MegaWattsMax;
            }
            set
            {
                _MegaWattsMax = value;
            }
        }

        public long HeightMinWater
        {
            get
            {
                return _HeightMinWater;
            }
            set
            {
                _HeightMinWater = value;
            }
        }

        public long HeigtMaxWater
        {
            get
            {
                return _HeigtMaxWater;
            }
            set
            {
                _HeigtMaxWater = value;
            }
        }

        public int Identification
        {
            get
            {
                return _Identification;
            }
            set
            {
                _Identification = value;
            }
        }

        public long CurrentMegawatts
        {
            get
            {
                return _CurrentMegawatts;
            }
           
        }

        public long CurrentOutFlow
        {
            get
            {
                return _CurrentOutFlow;
            }

        }

        public long CurrentHeightWater
        {
            get
            {
                return _CurrentHeightWater;
            }

        }

        public long CurrentWaterQuantity
        {
            get
            {
                return _CurrentWaterQuantity;
            }

        }

        public long HeightWR
        {
            get
            {
                return _HeightWR;
            }

        }

        public long SpeedFlow
        {
            get
            {
                return _SpeedFlow;
            }

        }





       

        #endregion

        #region ObserverMethods

        public virtual void OnCompleted()
        {
        }

        public virtual void OnError(Exception e)
        {
        }

        public virtual void OnNext(WaterReservoir pValue)
        {
            _CurrentHeightWater= pValue.CurrentHeight;
            _CurrentWaterQuantity = pValue.WaterQuantity;
            _HeightWR = pValue.Height;
            _SpeedFlow = pValue.WaterFlowSpeed;
            //  hago los calculos para modificar mi OutFlow y mis Megavatios segun esa altura
            updateValues();

        }
        #endregion

        #region observableMethods

        public IDisposable Subscribe(IObserver<Turbine> pObserver)
        {
            _Observers.Add(pObserver);
            return null;
        }

        #endregion

        #region Methods 
        //Parameters will be check in Dam class
        

        public void updateValues()
        {
           _CurrentMegawatts = (_CurrentHeightWater * _MegaWattsMax) / _HeigtMaxWater;
           _CurrentOutFlow= (_CurrentHeightWater * _OutFlowMax) / _HeigtMaxWater;
           foreach (IObserver<Turbine> observer in _Observers)
           {
               observer.OnNext(this);
           }



        }


        private void changeTurbineState(Turbine pTurbineName) 
        {
            if (pTurbineName._Enable == true)
            {
                pTurbineName._Enable = false;
            }
            else
            {
                pTurbineName._Enable = true;
            }
            
        }
       
        #endregion

        #region Attributes

        private long _CurrentMegawatts;
        private long _CurrentOutFlow;
        private long _OutFlowMin;
        private long _OutFlowMax;
        private long _MegaWattsMin;
        private long _MegaWattsMax;
        private long _HeightMinWater;
        private long _HeigtMaxWater;
        private List<IObserver<Turbine>> _Observers = null;
        private int _Identification;
        private Boolean _Enable;
       
        /// <summary>
        /// Attributes that i need to pass to the other observer classes. 
        /// </summary>
        
        private long _CurrentHeightWater;
        private long _CurrentWaterQuantity;
        private long _HeightWR;
        private long _SpeedFlow;
       
        #endregion
    }
}
