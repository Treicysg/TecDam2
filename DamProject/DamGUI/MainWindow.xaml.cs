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
using System.Windows.Navigation;
using System.Windows.Shapes;
using DamProject.DamLibrary;
using System.Timers;


namespace DamProject.DamGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

       
        public MainWindow()
        {
            InitializeComponent();
            this.ShowDialog();
            
           
        }

        
        private void _BtnCreateDam_Click(object sender, RoutedEventArgs e)
        {
            String heightText = _TxtHeight.Text;
            String lenghtText = _TxtLenght.Text;
            String widthText = _TxtWidth.Text;
            String turbineQuantityText = _TxtTurbineQuantity.Text;
            String outFlowMinText = _TxtOtFlowMin.Text;
            String outFlowMaxText = _TxtOutFlowMax.Text;
            String heightwaterMinText = _TxtWaterHeightMin.Text;
            String heightWaterMaxText = _TxtWaterHeightMax.Text;
            String megawattsMinText = _TxtMWmin.Text;
            String megaWattsMaxText = _TxtMWMax.Text;
            String speedMetText = _TxtSpeedMet.Text;

            if (heightText == "" || lenghtText == "" || widthText == "" || turbineQuantityText == ""
                || outFlowMinText == "" || outFlowMaxText == "" || heightwaterMinText == "" ||
                heightWaterMaxText == "" || megawattsMinText == "" || megaWattsMaxText == "" || speedMetText == "")
            {
                MessageBox.Show("Debe ingresar todos los datos");
            }

            else if (Convert.ToInt64(heightWaterMaxText) > Convert.ToInt64(heightText))
            {
                MessageBox.Show("Datos no consistentes");
            }

            else
            {
                try
                {

                    _HeightInput = Convert.ToInt64(heightText);
                    _LenghtInput = Convert.ToInt64(lenghtText);
                    _WidthInput = Convert.ToInt64(widthText);
                    _TurbineQuantityInput = Convert.ToInt32(turbineQuantityText);
                    _OutFlowMinInput = Convert.ToInt64(outFlowMinText);
                    _OutFlowMaxInput = Convert.ToInt64(outFlowMaxText);
                    _HeightwaterMinInput = Convert.ToInt64(heightwaterMinText);
                    _HeightWaterMaxInput = Convert.ToInt64(heightWaterMaxText);
                    _MegawattsMinInput = Convert.ToInt64(megawattsMinText);
                    _MegaWattsMaxInput = Convert.ToInt64(megaWattsMaxText);
                    _SpeedMetInput = Convert.ToInt64(speedMetText);
                    this.Hide();
                   
                }

                catch (OverflowException)
                {

                    MessageBox.Show("Datos no válidos");
                }

        }




         }

            
        

        #region Properties

        public long HeightInput
        {
            get
            {
                return _HeightInput;
            }

        }

        public long LenghtInput
        {
            get
            {
                return _LenghtInput;
            }

        }

        public long WidthInput
        {
            get
            {
                return _WidthInput;
            }

        }

        public int TurbineQuantityInput
        {
            get
            {
                return _TurbineQuantityInput;
            }

        }

        public long OutFlowMinInput
        {
            get
            {
                return _OutFlowMinInput;
            }

        }

        public long OutFlowMaxInput
        {
            get
            {
                return _OutFlowMaxInput;
            }

        }

        public long HeightwaterMinInput
        {
            get
            {
                return _HeightwaterMinInput;
            }

        }

        public long HeightWaterMaxInput
        {
            get
            {
                return _HeightWaterMaxInput;
            }

        }

        public long MegawattsMinInput
        {
            get
            {
                return _MegawattsMinInput;
            }

        }

        public long MegaWattsMaxInput
        {
            get
            {
                return _MegaWattsMaxInput;
            }

        }

        public long SpeedMetInput
        {
            get
            {
                return _SpeedMetInput;
            }

        }

      

       
        

        #endregion

        #region Atributtes

        private long _HeightInput;
        private long _LenghtInput;
        private long _WidthInput;
        private int _TurbineQuantityInput;
        private long _OutFlowMinInput;
        private long _OutFlowMaxInput;
        private long _HeightwaterMinInput;
        private long _HeightWaterMaxInput;
        private long _MegawattsMinInput;
        private long _MegaWattsMaxInput;
        private long _SpeedMetInput;
        


        #endregion

       

    }
}

