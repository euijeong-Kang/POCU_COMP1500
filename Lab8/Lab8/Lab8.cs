using System.Text;
using System;
namespace Lab8
{
    public static class Lab8
    {
        public static string PrettifyList(string s)
        {
            
            if (s == null)
            {
                return null;
            }
            bool bEmptyString = true;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    bEmptyString = false;
                    break;
                }
            }
            if (bEmptyString == true)
            {
                return null;
            }
            StringBuilder result = new StringBuilder(2048);

            string[] splitedStringLevel1 = s.Split('|');
            if (splitedStringLevel1.Length > 0)
            {
                int numCount = splitedStringLevel1.Length;
                for (int i = splitedStringLevel1.Length - 1; i >= 0; i--)
                {
                    string[] splitedStringLevel2 = splitedStringLevel1[i].Split('_');
                    if (splitedStringLevel2.Length > 0)
                    {
                        int count = 95 + splitedStringLevel2.Length;
                        for (int j = splitedStringLevel2.Length - 1; j > 0; j--)
                        {
                            string[] splitedStringLevel3 = splitedStringLevel2[j].Split('/');
                            if (splitedStringLevel3.Length > 0)
                            {
                                for (int k = splitedStringLevel3.Length - 1; k > 0; k--)
                                {
                                    result.Insert(0, $"        - {splitedStringLevel3[k]}{Environment.NewLine}");
                                }
                            }
                            char a = (char)count;
                            if (splitedStringLevel2[j].Contains('/'))
                            {
                                splitedStringLevel2[j] = splitedStringLevel2[j].Split('/')[0];
                            }
                            result.Insert(0, $"    {a}) {splitedStringLevel2[j]}{Environment.NewLine}");
                            count--;
                        }
                    }
                    if (splitedStringLevel1[i].Contains('_'))
                    {
                        splitedStringLevel1[i] = splitedStringLevel1[i].Split('_')[0];
                    }
                    result.Insert(0, $"{numCount}) {splitedStringLevel1[i]}{Environment.NewLine}");
                    numCount--;
                }
            }
            result.Remove(result.Length - 1, 0);
            return result.ToString(); ;
        }
    }
}