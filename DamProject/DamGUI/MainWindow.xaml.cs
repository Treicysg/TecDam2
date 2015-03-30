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
            
            var DamSimulation = Dam.Instance;
            DamSimulation.createTurbine(turbineQuantity, outFlowMin, outFlowMax, megawattsMin, megaWattsMax,
             heightwaterMin, heightWaterMax);
            DamSimulation.createWaterReservoir(speddMet, height, lenght, width);

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
            else
            {

                height = Convert.ToInt64(heightText);
                lenght = Convert.ToInt64(lenghtText);
                width = Convert.ToInt64(widthText);
                turbineQuantity = Convert.ToInt32(turbineQuantityText);
                outFlowMin = Convert.ToInt64(outFlowMinText);
                outFlowMax = Convert.ToInt64(outFlowMaxText);
                heightwaterMin = Convert.ToInt64(heightwaterMinText);
                heightWaterMax = Convert.ToInt64(heightWaterMaxText);
                megawattsMin = Convert.ToInt64(megawattsMinText);
                megaWattsMax = Convert.ToInt64(megaWattsMaxText);
                speddMet = Convert.ToInt64(speedMetText);

                TecDam tecdam = new TecDam();
                tecdam.ShowDialog();
               

            }

         
            
        }

        #region Atributtes

        private static long height;
        private static long lenght;
        private static long width;
        private static int turbineQuantity;
        private static long outFlowMin;
        private static long outFlowMax;
        private static long heightwaterMin;
        private static long heightWaterMax;
        private static long megawattsMin;
        private static long megaWattsMax;
        private static long speddMet;



        #endregion


      






    }
}
