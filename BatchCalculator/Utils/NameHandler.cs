namespace BatchCalculator.Utils
{
    public static class NameHandler
    {
        public static string FormatName(string camelCase)
        {
            if (string.IsNullOrEmpty(camelCase))
            {
                return camelCase;
            }

            string readable = char.ToUpper(camelCase[0]).ToString();

            for (int i = 1; i < camelCase.Length; i++)
            {
                if (char.IsUpper(camelCase[i]))
                {
                    readable += " " + camelCase[i];
                }
                else
                {
                    readable += camelCase[i];
                }
            }

            return readable;
        }
    }
}
