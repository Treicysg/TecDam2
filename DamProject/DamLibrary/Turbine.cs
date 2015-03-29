﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamProject.DamLibrary
{
    public class Turbine : IObserver<WaterReservoir>, IObservable<Turbine>
    {
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

        #region Properties

        public long OutFlowMin
        {
            get {
                return _OutFlowMin;
            }
            set {
                _OutFlowMin = value;
            }
        }

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

        public long MegaWattsMin
        {
            get
            {
                return _MegaWattsMin;
            }
            set
            {
                _MegaWattsMin = value;
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
            //  hago los calculos para modificar mi OutFlow y mis Megavatios segun esa altura

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
        public long getMegaWatts() 
        {
            long currentMegawatts;
            currentMegawatts = (_CurrentHeightWater * _MegaWattsMax) / _HeigtMaxWater;
            return currentMegawatts;
         
        }

        public long getOutFlow() 
        {
            long currentOutFlow;
            currentOutFlow= (_CurrentHeightWater * _OutFlowMax) / _HeigtMaxWater;
            return currentOutFlow;
          
        }


        //This will convert Megawatts of every turbine and dam to KiloWatts 
        private int convetMwToKw(int pMegaWatts) 
        {
            int kiloWatts;
            kiloWatts = pMegaWatts * 1000;
            return kiloWatts;
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

        private long _OutFlowMin;
        private long _OutFlowMax;
        private long _MegaWattsMin;
        private long _MegaWattsMax;
        private long _HeightMinWater;
        private long _HeigtMaxWater;
        private List<IObserver<Turbine>> _Observers = null;
        private int _Identification;
        private Boolean _Enable;
        private long _CurrentHeightWater;
       
        #endregion
    }
}
