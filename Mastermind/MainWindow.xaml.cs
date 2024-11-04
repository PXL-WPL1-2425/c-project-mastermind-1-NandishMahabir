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
            FillComboBoxes();
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

        private void FillComboBoxes()
        {
            foreach(var color in Data.Colors)
            {
                CboColor1.Items.Add(color.Value);
                CboColor2.Items.Add(color.Value);
                CboColor3.Items.Add(color.Value);
                CboColor4.Items.Add(color.Value);
            }
        }

        private void CboColor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cbo = sender as ComboBox;

            if (cbo.Name.Equals("CboColor1"))
            {
                AddOrChangeLabel(StackColor1, cbo, Data.Color1LabelAdded);
                Data.Color1LabelAdded = true;
            }
            else if (cbo.Name.Equals("CboColor2"))
            {
                AddOrChangeLabel(StackColor2, cbo, Data.Color2LabelAdded);
                Data.Color2LabelAdded = true;
            }
            else if (cbo.Name.Equals("CboColor3"))
            {
                AddOrChangeLabel(StackColor3, cbo, Data.Color3LabelAdded);
                Data.Color3LabelAdded = true;
            }
            else if (cbo.Name.Equals("CboColor4"))
            {
                AddOrChangeLabel(StackColor4, cbo, Data.Color4LabelAdded);
                Data.Color4LabelAdded = true;
            }
        }
        private void AddOrChangeLabel(StackPanel stackPanel,ComboBox comboBox, bool labelAdded)
        {
            if (!labelAdded)
            {
                Label label = new Label();
                label.Height = 35;
                label.Width = 35;

                label.Background = GetColorBrush(comboBox);

                stackPanel.Children.Add(label);
            }
            else
            {
                Label label = (Label)stackPanel.Children[stackPanel.Children.Count - 1];
                label.Background = GetColorBrush(comboBox);
            }

        }
        private SolidColorBrush GetColorBrush(ComboBox comboBox)
        {
            SolidColorBrush brush = Data.Colors.Where(x => x.Value.Equals(comboBox.SelectedValue))
                                   .Select(x => x.Key).First();
            return brush;
        }
    }
}
