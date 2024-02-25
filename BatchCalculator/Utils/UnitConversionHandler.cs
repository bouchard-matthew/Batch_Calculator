using System.Diagnostics;
using BatchCalculator.Models;
using static BatchCalculator.Enums.Enums;

namespace BatchCalculator.Utils
{
    public static class UnitConversionHandler
    {
        public static string Convert(double tspEquivalent)
        {
            string outputText = "";
            double cups = (int)(tspEquivalent / 48);
            double remainingTsp = tspEquivalent % 48;
            int tbsps = (int)(remainingTsp / 3);
            double tsps = (remainingTsp % 3);

            ConvertTbspToCup(ref cups, ref tbsps);

            if (cups > 0) outputText += $"{cups} {Unit.Cup}";
            if (tbsps > 0)
            {
                AddSeparator(ref outputText);
                outputText += $"{tbsps} {Unit.Tbsp}";
            }
            if (tsps > 0)
            {
                AddSeparator(ref outputText);
                outputText += $"{tsps} {Unit.Tsp}";
            }

            return outputText;
        }

        private static void ConvertTbspToCup(ref double cups, ref int tbsps)
        {
            switch (tbsps)
            {
                case >= 4 and < 8:
                    UpdateCupsAndTbsps(ref cups, ref tbsps, 0.25, 4);
                    break;
                case >= 8 and < 12:
                    UpdateCupsAndTbsps(ref cups, ref tbsps, 0.5, 8);
                    break;
                case >= 12 and < 16:
                    UpdateCupsAndTbsps(ref cups, ref tbsps, 0.75, 12);
                    break;
            }
        }

        private static void UpdateCupsAndTbsps(ref double cups, ref int tbsps, double cupsToAdd, int tbspsToRemove)
        {
            cups = (cups > 0) ? cups + cupsToAdd : cupsToAdd;
            tbsps -= tbspsToRemove;
        }

        private static void AddSeparator(ref string outputText)
        {
            if (!string.IsNullOrEmpty(outputText)) outputText += " + ";
        }
    }
}
