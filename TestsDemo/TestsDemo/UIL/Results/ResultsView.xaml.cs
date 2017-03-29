using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestsDemo.UIL
{
    /// <summary>
    /// Interaction logic for ResultsView.xaml
    /// </summary>
    public partial class ResultsView : UserControl
    {
        public ResultsView()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            List<Results> result = new List<Results>();
            for (int i = 0; i <     50; i++)
            {
                Results r = new Results();

                r.number = i;

                result.Add(r);
            }
            
            GridControlResults.ItemsSource = result;





        }
        public class Results
        {
            public int number { get; set; }
        }
    }
}

