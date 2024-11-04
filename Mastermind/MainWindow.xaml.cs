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

namespace Mastermind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ChangeTitle();
        }

        private void BtnValidateCode_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ChangeTitle()
        {
            Data.GenerateRandomColorCode();
            StringBuilder stringBuilder = new StringBuilder();
            foreach(var color in Data.ColorCode)
            {
                stringBuilder.Append($"{color.Value} ");
            }
            this.Title = stringBuilder.ToString();
        }
    }
}
