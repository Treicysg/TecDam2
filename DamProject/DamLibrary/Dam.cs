using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DamProject.DamLibrary
{
    /// <summary>
    /// This class will manage the dam rules and logic, must be singleton because is going to exists only
    /// one instace
    /// </summary>
    public class Dam : IObserver<Turbine>, IObservable<Dam>
    {
        #region Constructors
        private Dam()
        {
            _Observers = new List<IObserver<Dam>>();
            

        }

        /// <summary>
        /// Access the unique instance of this class, singleton pattern
        /// </summary>
        public static Dam Instance
        {
            get
            {
                if (_CurrentDamInstance == null)
                {
                    lock (_LockObj)
                    {
                        if (_CurrentDamInstance==null)
                        {
                            _CurrentDamInstance = new Dam();
                        }
                    }
                    
                }
                return _CurrentDamInstance;
            }
        }
        #endregion 

        #region Properties

        public long TotalPower
        {
            get
            {
                return _TotalPower;
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

        public long Height
        {
            get
            {
                return _Height;
            }

        }

        public long Speed{
            get
            {
                return _Speed;
            }

        }

        public long idTurbine
        {
            get
            {
                return _idTurbine;
            }

        }

        #endregion

        #region observer methods

        public virtual void OnCompleted()
        {
        }

        public virtual void OnError(Exception e)
        {
        }

        public virtual void OnNext(Turbine pValue)
        {
            _TotalPower += pValue.CurrentMegawatts;
            _OutFlow = pValue.CurrentOutFlow;
            _CurrentHeightWater = pValue.CurrentHeightWater;
            _CurrentWaterQuantity = pValue.CurrentWaterQuantity;
            _Height = pValue.HeightWR;
            _Speed = pValue.SpeedFlow;
            _idTurbine = pValue.Identification;


            foreach (IObserver<Dam> observer in _Observers)
            {
                observer.OnNext(this);
            }


        }
        #endregion

        #region observable methods

        public IDisposable Subscribe(IObserver<Dam> pObserver)
        {
            _Observers.Add(pObserver);
            return null;
        }
        #endregion

        #region Methods

        public Turbine createTurbine(int pAmountTurbine, long pOutFlowMin, long pOutFlowMax,
        long pMegaWattsMin,long pMegaWattsMax,long pHeightMinWater,long pHeigtMaxWater) 
        {
            //List<Turbine> turbines = new List<Turbine>();

            //for (int turbine = 1; turbine <= pAmountTurbine; turbine ++ )
            //{
                //instead of 1 = i
                Turbine turb = new Turbine(1, pOutFlowMin, pOutFlowMax, pMegaWattsMin
                    , pMegaWattsMax, pHeightMinWater, pHeigtMaxWater);
                //turbines.Add(turb);
               
            //}

            return turb;
      
        }

        public WaterReservoir createWaterReservoir(long pWaterFlowSpeed,long pHeight,long pLenght,long pWidth) {

            WaterReservoir Reservoir = new WaterReservoir(pWaterFlowSpeed, pHeight, pLenght, pWidth);
            return Reservoir;
        }

        
       
        #endregion

        #region Attributes
        private long _TotalPower;
        private long _OutFlow;
        private static Dam _CurrentDamInstance;
        private static Object _LockObj = new Object();
        private List<IObserver<Dam>> _Observers = null;
        private List<Turbine> _Turbine = null;

        /// <summary>
        /// Attributes that it needs to pass to its observer classes
        /// </summary>
        private long  _CurrentHeightWater;
        private long _CurrentWaterQuantity;
        private long _Height;
        private long _Speed;
        private int _idTurbine;

        #endregion
    }



}

