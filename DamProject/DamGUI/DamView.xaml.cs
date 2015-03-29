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
    /// Interaction logic for DamView.xaml
    /// </summary>
    public partial class DamView : Window, IObserver<Dam>
    {
        public DamView()
        {
            InitializeComponent();
        }


        #region Observer methods

         public virtual void OnCompleted()
        {
        }

        public virtual void OnError(Exception e)
        {
        }

        public virtual void OnNext(Dam pValue)
        {
            /// se le pasan metricas que seran actualizadas en ventana
        }


        #endregion
    }
}
