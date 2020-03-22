using System.Collections.Generic;
using System;

namespace Assignment3
{
    public static class TowerOfHanoi
    {

        public static int GetNumberOfSteps(int numDiscs)
        {
            if (numDiscs < 1)
            {
                return -1;
            }

            return GetMoveCountRecursive(numDiscs) - 1;
        }

        public static List<List<int>[]> SolveTowerOfHanoi(int numDiscs)
        {
            if (numDiscs < 1)
            {
                return null;
            }
            List<List<int>[]> result = new List<List<int>[]>();
            List<int>[] towerList = new List<int>[3] { new List<int>(), new List<int>(), new List<int>() };
            for (int i = 0; i < numDiscs; i++)
            {
                towerList[0].Add(numDiscs - i);
            }
            result.Add(towerList);
            List<int>[] copy = new List<int>[3] { new List<int>(), new List<int>(), new List<int>() };
            for (int i = 0; i < 3; i++)
            {
                if (towerList[i] == null)
                {
                    continue;
                }
                for (int j = 0; j < towerList[i].Count; j++)
                {
                    copy[i].Add(towerList[i][j]);
                }
            }
            SolveTowerOfHanoiRecursives(numDiscs, 0, 2, 1, copy, result);
            return result;

        }

        public static void SolveTowerOfHanoiRecursives(int numDicsc, int from, int to, int by, List<int>[] towerList, List<List<int>[]> result)
        {
            if (numDicsc == 1)
            {
                towerList[to].Add(towerList[from][towerList[from].Count - 1]);
                towerList[from].Remove(towerList[from][towerList[from].Count - 1]);
                List<int>[] copy = new List<int>[3] { new List<int>(), new List<int>(), new List<int>() };
                for (int i = 0; i < 3; i++)
                {
                    if (towerList[i] == null)
                    {
                        continue;
                    }
                    for (int j = 0; j < towerList[i].Count; j++)
                    {
                        copy[i].Add(towerList[i][j]);
                    }
                }
                result.Add(copy);
                
            }
            else
            {
                SolveTowerOfHanoiRecursives(numDicsc - 1, from, by, to, towerList, result);
                SolveTowerOfHanoiRecursives(1, from, to, by, towerList, result);
                SolveTowerOfHanoiRecursives(numDicsc - 1, by, to, from, towerList, result);
            }

        }
        
        public static int GetMoveCountRecursive(int numDiscs)
        {
            if(numDiscs == 0)
            {
                return 1;
            }
            return 2 * GetMoveCountRecursive(numDiscs - 1);
        }

        
    }
}