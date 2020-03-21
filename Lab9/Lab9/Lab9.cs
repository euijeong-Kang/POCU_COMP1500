﻿using System.Collections.Generic;
using System;

namespace Lab9
{
    public static class Lab9
    {
        public static List<int> MergeLists(List<int> sortedList1, List<int> sortedList2)
        {
            int temp;
            List<int> result = new List<int>();
            result.AddRange(sortedList1);
            result.AddRange(sortedList2);
            for (int i = 0; i < result.Count; i++)
            {
                int count = i;
                for (int j = i + 1; j < result.Count; j++)
                {
                    if (result[j] < result[count])
                    {
                        count = j;
                    }
                }
                temp = result[count];
                result[count] = result[i]; 
                result[i] = temp;
            }
            return result;
        }

        public static Dictionary<string, int> CombineListsToDictionary(List<string> keys, List<int> values)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();

            List<string> removedDuplicationKeys = new List<string>();
            removedDuplicationKeys.AddRange(RemoveDuplication(keys));
            int count;
            if (removedDuplicationKeys.Count <= values.Count)
            {
                count = removedDuplicationKeys.Count;
                for (int i = 0; i < count; i++)
                {
                    result.Add(removedDuplicationKeys[i], values[i]);
                }
            }
            else if (removedDuplicationKeys.Count > values.Count)
            {
                count = values.Count;
                for (int i = 0; i < count; i++)
                {
                    result.Add(removedDuplicationKeys[i], values[i]);
                }
            }

            return result;
        }

        public static Dictionary<string, decimal> MergeDictionaries(Dictionary<string, int> numerators, Dictionary<string, int> denominators)
        {
            Dictionary<string, decimal> result = new Dictionary<string, decimal>();
            if (numerators == null || denominators == null)
            {
                return result;
            }
            foreach (KeyValuePair<string, int> pair in numerators)
            {
                if (denominators.ContainsKey(pair.Key))
                {
                    int value;
                    denominators.TryGetValue(pair.Key, out value);
                    if (value == 0)
                    {
                        continue;
                    }
                    result.Add(pair.Key, Math.Abs((decimal)pair.Value / value));
                }
            }
            return result;
        }
        public static HashSet<string> RemoveDuplication(List<string> keys)
        {
            HashSet<string> result = new HashSet<string>();
            foreach (string key in keys)
            {
                result.Add(key);
            }
            
            return result;
        }
    }
}