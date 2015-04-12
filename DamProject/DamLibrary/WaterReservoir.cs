using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamProject.DamLibrary
{
    public class WaterReservoir : IObservable<WaterReservoir>
    {
        #region Constructors
        public WaterReservoir(long pWaterFlowSpeed, long pHeight, long pLenght, long pWidth)
        {
            _Observers = new List<IObserver<WaterReservoir>>();
            _WaterFlowSpeed = pWaterFlowSpeed;
            _Height = pHeight;
            _Lenght = pLenght;
            _Width = pWidth;
        }
        #endregion

        #region Properties
        public long CurrentHeight
        {
            get 
            { 
                return _CurrentHeight; 
            }
        }

        public long WaterQuantity
        {
            get
            {
                return _WaterQuantity;
            }

        }

        public long WaterFlowSpeed
        {
            get
            {
                return _WaterFlowSpeed;
            }

            set
            {
                _WaterFlowSpeed = value;
            }
        }

        public long Height
        {
            get
            {
                return _Height;
            }

        }

        public long Lenght
        {
            get
            {
                return _Lenght;
            }

            set
            {
                _Lenght = value;
            }
        }

        public long Width
        {
            get
            {
                return _Width;
            }

            set
            {
                _Width = value;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// The method will start the simulation, it'll assign the initials values.
        /// </summary>
        public void startSimulation()
        {
           

            increaseWaterLevel(_WaterFlowSpeed);
            _CurrentHeight = getWaterHeight();
            foreach (IObserver<WaterReservoir> observer in _Observers)
            {
                observer.OnNext(this);
            }
        }

        public void updateWaterLevel(long pOutWaterFlowSpeed)
        {
            long waterIncome;

            waterIncome = _WaterFlowSpeed - pOutWaterFlowSpeed;
            long lastHeight = getWaterHeight();
            increaseWaterLevel(waterIncome);

            if (!isFull())
            {
                long change = getWaterHeight() - lastHeight;


                // velocidadEntra el agua - velocidad a la que sale
                // lo anterior es por segundo
                // calculo cuantos segundos han pasado
                // ya se cuanta aguan entro, entonces calculo cuanto se modifica la altura



                if (Math.Abs(change) > 1)
                {
                    foreach (IObserver<WaterReservoir> observer in _Observers)
                    {
                        observer.OnNext(this);
                    }
                }
            }

            else { 
                  //Deberia detener el programa
                //return;
            
            }

        }

        private long getVolume()
        {
            long volume;
            volume = _Lenght * _Height * _Width;
            return volume;
        }


        public void increaseWaterLevel(long pWater) {

            try
            {
                _WaterQuantity += pWater;
            }
            catch (OverflowException)
            {
                //Que pasa Si excede tamaño de un long
            }
        
        
        }

        public void decreaseWaterLevel(long pWater) {

            try
            {
                _WaterQuantity -= pWater;
            }
            catch (OverflowException)
            {
                //Que pasa si tamaño de long es superado
            }
        }

        public Boolean isFull()
        {
            Boolean full = false;

            if (_WaterQuantity == getVolume())
            {
                full = true;
            }
            return full;


        }

        /// <summary>
        /// The water reservoir starts half full. 
        /// </summary>
        public void startWaterLevel() {


            _WaterQuantity = getVolume() / 2 ; 

        }

        public long getWaterHeight() {

            _CurrentHeight = _WaterQuantity /(_Width*_Lenght);
            return _CurrentHeight;
          
        
        }

        #endregion

        #region IObservable methods
        public IDisposable Subscribe(IObserver<WaterReservoir> pObserver)
        {
            _Observers.Add(pObserver);
            return null;
        }
        #endregion

        #region Attributes

        private long _CurrentHeight;
        private long _WaterFlowSpeed;
        private List<IObserver<WaterReservoir>> _Observers = null;
        private long _Height;
        private long _Lenght;
        private long _Width;
        private long _WaterQuantity;
        private long _Volume;
        private int _LastTime;

        #endregion
    }
}

