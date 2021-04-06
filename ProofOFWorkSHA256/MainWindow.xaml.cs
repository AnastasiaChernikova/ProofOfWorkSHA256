using System;
using System.Collections.Generic;
using System.IO;
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

namespace ProofOFWorkSHA256
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int numberOfSolutionsFound = 0;
            var storage = new StorageOfData();
            var proofOfWork = new ProofOfWork();
            storage.Time = 0;
            // Get startingZeros from checkboxes
            // 8 by default
            var startingZeros = 2;
            if (eightCheckBox.IsChecked.Value)
            {
                // 8 zero bits
                startingZeros = 2;
            }
            if (sixteenCheckBox.IsChecked.Value)
            {
                // 16 zero bits
                startingZeros = 4;
            }
            if (thirtyTwoCheckBox.IsChecked.Value)
            {
                // 32 zero bits
                startingZeros = 8;
            }
            
            while (storage.Time < Int32.Parse(timeForProcessTxt.Text))
            {
                var result = ProofOfWork.StartProofOfWork("Alice", startingZeros);
                storage.Time += result.Time;
                numberOfSolutionsFound++;
                // store data in bin\Debug
                StreamWriter sw = File.AppendText(Environment.CurrentDirectory + @"\dataStorage.txt");
                using (sw)
                {
                    sw.WriteLine($"Numbers of iteration: {result.NumberOfIterations}, String: {result.Data}, Hash: {result.HashData}");
                }

            }
            MessageBox.Show($"Check your file:D");

        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            string path = Environment.CurrentDirectory + @"\dataStorage.txt";
            File.WriteAllText(path, String.Empty);
        }
    }
}
