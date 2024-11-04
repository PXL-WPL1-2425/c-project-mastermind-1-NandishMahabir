using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Mastermind
{
    public static class Data
    {
        private static Random random = new Random();
        static Dictionary<SolidColorBrush, string> colors = new Dictionary<SolidColorBrush, string>();
        public static Dictionary<SolidColorBrush, string> Colors
        {
            get { return colors; }
        }
        private static Dictionary<SolidColorBrush, string> colorCode = new Dictionary<SolidColorBrush, string>();
        public static Dictionary<SolidColorBrush, string> ColorCode
        {
            get {  return colorCode; }
        }
        public static bool Color1LabelAdded { get; set; }
        public static bool Color2LabelAdded { get; set; }
        public static bool Color3LabelAdded { get; set; }
        public static bool Color4LabelAdded { get; set; }

        static Data()
        {
            colors.Add(Brushes.Red, "Red");
            colors.Add(Brushes.Orange, "Orange");
            colors.Add(Brushes.Yellow, "Yellow");
            colors.Add(Brushes.Green, "Green");
            colors.Add(Brushes.Blue, "Blue");
            colors.Add(Brushes.White, "White");
        }
        public static void GenerateRandomColorCode()
        {
            colorCode.Clear();
            for (int i = 0; i < 4; i++)
            {
                int index = random.Next(0, colors.Count);
                colorCode.Add(colors.ElementAt(index).Key, colors.ElementAt(index).Value);
            }
        }

        public static List<int> ValidateColorCode(string color1, string color2, string color3, string color4)
        {
            List<int> points = new List<int>();

            if (color1.Equals(ColorCode.ElementAt(0).Value))
            {
                points.Add(2);
            }
            else if (ColorCode.ContainsValue(color1))
            {
                points.Add(1);
            }
            else
            {
                points.Add(0);
            }

            if (color2.Equals(ColorCode.ElementAt(1).Value))
            {
                points.Add(2);
            }
            else if (ColorCode.ContainsValue(color2))
            {
                points.Add(1);
            }
            else
            {
                points.Add(0);
            }

            if (color3.Equals(ColorCode.ElementAt(2).Value))
            {
                points.Add(2);
            }
            else if (ColorCode.ContainsValue(color3))
            {
                points.Add(1);
            }
            else
            {
                points.Add(0);
            }

            if (color4.Equals(ColorCode.ElementAt(3).Value))
            {
                points.Add(2);
            }
            else if (ColorCode.ContainsValue(color4))
            {
                points.Add(1);
            }
            else
            {
                points.Add(0);
            }

            ResetBooleans();
            return points;
        }
        private static void ResetBooleans()
        {
            Color1LabelAdded = false;
            Color2LabelAdded = false;
            Color3LabelAdded = false;
            Color4LabelAdded = false;
        }
    }
}
