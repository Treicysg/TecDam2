using DamProject.DamLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamProject.DamGUI
{
    public partial class TecDAM : Form, IObserver<Dam>
    {

        public TecDAM()
        {
            InitializeComponent();
            draw(10, 190, 180, 350, 600, 215);
            

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
            _LblDamKiloWatts.Text = Convert.ToString(_TotalKilowatts);
            _lblWaterMeter.Text = Convert.ToString(_WaterHeight);
            _lblWaterLevel.Text = Convert.ToString(_WaterQuantity);
            _lblHeightReservoir.Text = Convert.ToString(_WaterReservoirHeight);
            _txtWaterFlowSpeed.Text = _SpeedInWater.ToString();
            this.ShowDialog();
        }

        public void draw(int a,int b, int c,int d,int e,int f) 
        {
            
            Bitmap drawPicture;

            drawPicture = new Bitmap(_imgDamPicture.Width, _imgDamPicture.Height);

            _imgDamPicture.Image = (Image)drawPicture;

            Graphics g = Graphics.FromImage(drawPicture);
            Graphics h = Graphics.FromImage(drawPicture);

            for (int i = a; i < b; i++)
            {
                int aux = Convert.ToInt32(Math.Round(Math.Sin(i / 4) * 3)) + 100; 
                Brush aBrush = (Brush)Brushes.Cyan;
                g.FillRectangle(aBrush, i, aux, 1, 1);

                for (int j = aux + 2 + 1; j < c; j++)
                {
                    Brush bBrush = (Brush)Brushes.Blue;
                    h.FillRectangle(bBrush, i, j, 1, 1);
                }

            }

            for (int i = d; i < e; i++)
            {
                int aux = Convert.ToInt32(Math.Round(Math.Sin(i / 4) * 3)) + 100;
                Brush aBrush = (Brush)Brushes.Cyan;
                g.FillRectangle(aBrush, i, aux, 1, 1);

                for (int j = aux + 2 + 1; j < f; j++)
                {
                    Brush bBrush = (Brush)Brushes.Blue;
                    h.FillRectangle(bBrush, i, j, 1, 1);
                }

            }
        }
        #endregion

        #region Properties

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

        private void TecDAM_Load(object sender, EventArgs e)
        {

        }

        private void _BtnApply_Click(object sender, EventArgs e)
        {
            
        }

       
    }
}
