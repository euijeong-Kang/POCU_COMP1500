using System.IO;
using System;

namespace Assignment1
{
    public static class Assignment1
    {
        public static void PrintIntegers(StreamReader input, StreamWriter output, int width)
        {
            if (width < 10)
            {
                width = 10;
            }
            string intString = "dec";
            string hexString = "hex";
            string otcString = "oct";
            string boder = "";

            string read1 = int.Parse(input.ReadLine()).ToString();
            string read2 = int.Parse(input.ReadLine()).ToString();
            string read3 = int.Parse(input.ReadLine()).ToString();
            string read4 = int.Parse(input.ReadLine()).ToString();
            string read5 = int.Parse(input.ReadLine()).ToString();

            intString = intString.PadLeft(width, ' ');
            hexString = hexString.PadLeft(width, ' ');
            otcString = otcString.PadLeft(width, ' ');

            output.WriteLine($"{otcString} {intString} {hexString}");

            output.WriteLine($"{boder.PadLeft(width, '-')} {boder.PadLeft(width, '-')} {boder.PadLeft(width, '-')}");

            intString = read1.PadLeft(width, ' ');
            hexString = Convert.ToString(int.Parse(read1), 16).ToUpper().PadLeft(width, ' ');
            otcString = Convert.ToString(int.Parse(read1), 8).PadLeft(width, ' ');

            output.WriteLine($"{otcString} {intString} {hexString}");
            //
            intString = read2.PadLeft(width, ' ');
            hexString = Convert.ToString(int.Parse(read2), 16).ToUpper().PadLeft(width, ' ');
            otcString = Convert.ToString(int.Parse(read2), 8).PadLeft(width, ' ');

            output.WriteLine($"{otcString} {intString} {hexString}");
            //
            intString = read3.PadLeft(width, ' ');
            hexString = Convert.ToString(int.Parse(read3), 16).ToUpper().PadLeft(width, ' ');
            otcString = Convert.ToString(int.Parse(read3), 8).PadLeft(width, ' ');

            output.WriteLine($"{otcString} {intString} {hexString}");
            //
            intString = read4.PadLeft(width, ' ');
            hexString = Convert.ToString(int.Parse(read4), 16).ToUpper().PadLeft(width, ' ');
            otcString = Convert.ToString(int.Parse(read4), 8).PadLeft(width, ' ');

            output.WriteLine($"{otcString} {intString} {hexString}");
            //
            intString = read5.PadLeft(width, ' ');
            hexString = Convert.ToString(int.Parse(read5), 16).ToUpper().PadLeft(width, ' ');
            otcString = Convert.ToString(int.Parse(read5), 8).PadLeft(width, ' ');

            output.WriteLine($"{otcString} {intString} {hexString}");
        }

        public static void PrintStats(StreamReader input, StreamWriter output)
        {
            string num1 = input.ReadLine();
            string num2 = input.ReadLine();
            string num3 = input.ReadLine();
            string num4 = input.ReadLine();
            string num5 = input.ReadLine();

            double[] doubleArray = new double[5] { double.Parse(num1), double.Parse(num2), double.Parse(num3), double.Parse(num4), double.Parse(num5) };
            Array.Sort(doubleArray);
            string sum = (double.Parse(num1) + double.Parse(num2) + double.Parse(num3) + double.Parse(num4) + double.Parse(num5)).ToString();
            sum = string.Format("{0:F3}", double.Parse(sum));
            string average = (double.Parse(sum) / 5).ToString();
            average = string.Format("{0:F3}", double.Parse(average));

            string min = string.Format("{0:F3}", doubleArray[0]);
            string max = string.Format("{0:F3}", doubleArray[4]);

            num1 = string.Format("{0:F3}", double.Parse(num1));
            num2 = string.Format("{0:F3}", double.Parse(num2));
            num3 = string.Format("{0:F3}", double.Parse(num3));
            num4 = string.Format("{0:F3}", double.Parse(num4));
            num5 = string.Format("{0:F3}", double.Parse(num5));

            output.WriteLine(num1.PadLeft(25, ' '));
            output.WriteLine(num2.PadLeft(25, ' '));
            output.WriteLine(num3.PadLeft(25, ' '));
            output.WriteLine(num4.PadLeft(25, ' '));
            output.WriteLine(num5.PadLeft(25, ' '));
            output.WriteLine($"Min{min.PadLeft(22, ' ')}");
            output.WriteLine($"Max{max.PadLeft(22, ' ')}");
            output.WriteLine($"Sum{sum.ToString().PadLeft(22, ' ')}");
            output.WriteLine($"Average{average.ToString().PadLeft(18, ' ')}");




        }
    }
}