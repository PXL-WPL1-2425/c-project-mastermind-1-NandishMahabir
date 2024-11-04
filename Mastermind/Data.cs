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
        static Dictionary<SolidColorBrush, string> colors = new Dictionary<SolidColorBrush, string>();
        private static Random random = new Random();
        private static Dictionary<SolidColorBrush, string> colorCode = new Dictionary<SolidColorBrush, string>();
        public static Dictionary<SolidColorBrush, string> ColorCode
        {
            get {  return colorCode; }
        }

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
                random.Next(0, colors.Count);
                colorCode.Add(colors.ElementAt(i).Key, colors.ElementAt(i).Value);
            }
        }
    }
}
