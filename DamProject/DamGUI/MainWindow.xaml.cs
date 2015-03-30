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
            String speddMetText = _TxtSpeddMet.Text;

            if (heightText == "" || lenghtText == "" || widthText == "" || turbineQuantityText == ""
                || outFlowMinText == "" || outFlowMaxText == "" || heightwaterMinText == "" ||
                heightWaterMaxText == "" || megawattsMinText == "" || megaWattsMaxText == "" || speddMetText == "")
            {
                MessageBox.Show("Debe ingresar todos los datos");
            }
            else
            {
                long height = convertToLong(heightText);
                long lenght = convertToLong(lenghtText);
                long width = convertToLong(widthText);
                long turbineQuantity = convertToLong(turbineQuantityText);
                long outFlowMin = convertToLong(outFlowMinText);
                long outFlowMax = convertToLong(outFlowMaxText);
                long heightwaterMin = convertToLong(heightwaterMinText);
                long heightWaterMax = convertToLong(heightWaterMaxText);
                long megawattsMin = convertToLong(megawattsMinText);
                long megaWattsMax = convertToLong(megaWattsMaxText);
                long speddMet = convertToLong(speddMetText);

            }

         
            
        }

        #region methods

        private long convertToLong(String pString) {
            long newNumber;

            newNumber = Convert.ToInt64(pString);
            return newNumber;
        }

       
       

        #endregion






    }
}
