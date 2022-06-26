using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    public static class Extension
    {
        public static bool IsGreaterThan(this int i) {
            return true;
        }

        public static decimal ZeroNull(this decimal? data)
        {
            return data.HasValue ? (decimal)data.Value : 0.00m;
        }

        public static long ZeroNull(this long? data)
        {
            return data.HasValue ? (long)data.Value : 0;
        }

        public static int ZeroNull(this int? data)
        {
            return data.HasValue ? (int)data.Value : 0;
        }

        public static bool IsNumeric(this string s)
        {
            float output;
            return float.TryParse(s, out output);
        }

        public static string TruncateDecimal(this decimal data)
        {
            return string.Format("{0:0,0.00}", Math.Floor(data * 100) / 100);
        }

        public static string CurrencyInWords(this decimal data)
        {
            string[] num = data.ToString("0.00").Split('.');
            int num1 = Convert.ToInt32(num[0]);
            int num2 = Convert.ToInt32(num[1]);

            string result = num1.NumberInWords() + " Pesos";
            if (num2 > 0)
            {
                result += " and " + num2 + "/100";
            }

            return result;
        }

        public static string NumberInWords(this int number)
        {
            if (number == 0) return "Zero";
            long[] num = new long[4];
            int first = 0;
            long u, h, t;

            StringBuilder sb = new StringBuilder();
            if (number < 0)
            {
                sb.Append("Minus ");
                number = -number;
            }

            string[] words0 = { "", "One ", "Two ", "Three ", "Four ", "Five ", "Six ", "Seven ", "Eight ", "Nine " };
            string[] words1 = { "Ten ", "Eleven ", "Twelve ", "Thirteen ", "Fourteen ", "Fifteen ", "Sixteen ", "Seventeen ", "Eighteen ", "Nineteen " };
            string[] words2 = { "Twenty ", "Thirty ", "Forty ", "Fifty ", "Sixty ", "Seventy ", "Eighty ", "Ninety " };
            string[] words3 = { "Thousand ", "Million ", "Billion " };

            num[0] = number % 1000; // units
            num[1] = ((number % 1000000) - num[0]) / 1000;
            num[2] = ((number % 1000000000) - num[1] - num[0]) / 1000000;
            num[3] = ((number % 1000000000000) - num[2] - num[1] - num[0]) / 1000000000;

            Console.WriteLine(num[0]);
            Console.WriteLine(num[1]);
            Console.WriteLine(num[2]);
            Console.WriteLine(num[3]);

            for (int i = 3; i > 0; i--)
            {
                if (num[i] != 0)
                {
                    first = i;
                    break;
                }
            }

            for (int i = first; i >= 0; i--)
            {
                if (num[i] == 0) continue;
                u = num[i] % 10; // ones
                t = num[i] / 10;
                h = num[i] / 100; // hundreds
                t = t - 10 * h; // tens

                if (h > 0) sb.Append(words0[h] + "Hundred ");

                if (u > 0 || t > 0)
                {
                    if (t == 0)
                        sb.Append(words0[u]);
                    else if (t == 1)
                        sb.Append(words1[u]);
                    else
                        sb.Append(words2[t - 2] + words0[u]);
                }

                if (i != 0) sb.Append(words3[i - 1]);
            }

            return sb.ToString().TrimEnd();
        }
    }
}
