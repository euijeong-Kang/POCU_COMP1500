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
            List<List<int>[]> result = new List<List<int>[]>();

            List<int>[] resultListArray = new List<int>[3] { new List<int>(), new List<int>(), new List<int>() };
            for (int i = 0; i < numDiscs; i++)
            {
                resultListArray[0].Add(numDiscs - i);
            }
            result.Add(SolveTowerOfHanoiRecursive(numDiscs, resultListArray));
            return result;
        }
        public static int GetMoveCountRecursive(int numDiscs)
        {
            if(numDiscs == 0)
            {
                return 1;
            }
            return 2 * GetMoveCountRecursive(numDiscs - 1);
        }

        public static List<int>[] SolveTowerOfHanoiRecursive(int numDiscs, List<int>[] result)
        {
            int towerNum = 0;
            if (result[2].Count == numDiscs)
            {
                return result;
            }
            while (towerNum < 3)
            {
                if (result[towerNum].Count % 2 != 0)
                {
                    if ((towerNum == 2 && result[towerNum].Count == 0) || towerNum == 3)
                    {
                        break;
                    }
                    if (result[towerNum].Count == 0)
                    {
                        towerNum++;
                        continue;
                    }
                    if (result[towerNum].Count != 0 && towerNum == 0 && (result[2].Count == 0 || result[0][result[0].Count - 1] < result[2][result[2].Count - 1]))
                    {
                        result[2].Add(result[towerNum][result[towerNum].Count - 1]);
                        result[towerNum].Remove(result[towerNum][result[towerNum].Count - 1]);
                        continue;
                    }
                    else if (result[towerNum].Count != 0 && towerNum == 1 && result[towerNum][result[towerNum].Count - 1] < result[2][result[2].Count - 1])
                    {
                        result[2].Add(result[towerNum][result[towerNum].Count - 1]);
                        result[towerNum].Remove(result[towerNum][result[towerNum].Count - 1]);
                        continue;
                    }
                    else if (result[towerNum].Count != 0 &&  towerNum == 2 && result[towerNum][result[towerNum].Count - 1] < result[1][result[1].Count - 1])
                    {
                        result[1].Add(result[towerNum][result[towerNum].Count - 1]);
                        result[towerNum].Remove(result[towerNum][result[towerNum].Count - 1]);
                        continue;
                    }
                    else
                    {
                        towerNum++;
                    }
                    
                }
                else if (result[towerNum].Count % 2 == 0)
                {
                    if ((towerNum == 2 && result[towerNum].Count == 0) || towerNum == 3)
                    {
                        break;
                    }
                    if (result[towerNum].Count == 0)
                    {
                        towerNum++;
                    }
                    if (result[towerNum].Count == 0)
                    {
                        towerNum++;
                    }
                    if (result[towerNum].Count != 0 &&  towerNum == 0)
                    {
                        result[1].Add(result[towerNum][result[towerNum].Count - 1]);
                        result[towerNum].Remove(result[towerNum][result[towerNum].Count - 1]);
                        continue;
                    }
                    else if (result[towerNum].Count != 0 &&  towerNum == 1)
                    {
                        result[0].Add(result[towerNum][result[towerNum].Count - 1]);
                        result[towerNum].Remove(result[towerNum][result[towerNum].Count - 1]);
                        continue;
                    }
                    else if (result[towerNum].Count != 0 &&  towerNum == 2)
                    {
                        result[0].Add(result[towerNum][result[towerNum].Count - 1]);
                        result[towerNum].Remove(result[towerNum][result[towerNum].Count - 1]);
                        continue;
                    }
                    else
                    {
                        towerNum++;
                    }
                }

            }
            return SolveTowerOfHanoiRecursive(numDiscs, result);
            
            
        }
    }
}