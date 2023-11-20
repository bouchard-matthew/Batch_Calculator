using Units = BatchCalculator.Enums.Enums.Units;
internal static class ConversionUtility
    {
        public static double ConvertToTsp(Units unit, double quantity)
        {
            return unit switch
            {
                Units.Cup => quantity * 48,
                Units.Tbsp => quantity * 3,
                _ => quantity
            };
    }

        public static double[] ConvertTspToCupsTbspsTsps(double tspEquivalent)
        {
            double cups = (int)(tspEquivalent / 48);
            double remainingTsp = tspEquivalent % 48;
            int tbsps = (int)(remainingTsp / 3);
            double tsps = (remainingTsp % 3);

            ConvertTbspToCup(ref cups, ref tbsps);

            return new double[] { cups, tbsps, tsps };
        }

        private static void ConvertTbspToCup(ref double cups, ref int tbsps)
        {
            switch (tbsps)
            {
                case 4:
                    cups = (cups > 0) ? cups + 0.25 : 0.25;
                    tbsps -= 4;
                    break;
                case 8:
                    cups = (cups > 0) ? cups + 0.5 : 0.5;
                    tbsps -= 8;
                    break;
                case 12:
                    cups = (cups > 0) ? cups + 0.75 : 0.75;
                    tbsps -= 12;
                    break;
            }
        }
    }