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

            set
            {
                _WaterQuantity = value;
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

            set
            {
                _Height = value;
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

        public void updateWaterLevel(long pOutWaterFlowSpeed)
        {
            long waterIncome;

            waterIncome = _WaterFlowSpeed - pOutWaterFlowSpeed;
            long lastHeight = getWaterHeight();
            increaseWaterLevel(waterIncome);
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

        public long getVolume()
        {
            long volume;
            volume = _Lenght * _Height * _Width;
            return volume;
        }


        public void increaseWaterLevel(long pWater) {

            _WaterQuantity +=pWater;
        
        
        }

        public void decreaseWaterLevel(long pWater) {

            _WaterQuantity -= pWater;
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

