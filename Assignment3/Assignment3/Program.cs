using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = TowerOfHanoi.GetNumberOfSteps(0);

            Console.WriteLine(steps);
            var snapshots = TowerOfHanoi.SolveTowerOfHanoi(-1);
            
            if (snapshots == null)
            {
                Console.WriteLine("null");
            }
            else
            {
                printSnapshots(snapshots);
            }
            
        }

        private static void printSnapshots(List<List<int>[]> snapshots)
        {
            for (int i = 0; i < snapshots.Count; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine($"Initial State --------------------------------------");
                }
                else
                {
                    Console.WriteLine($"Step {i}. --------------------------------------");
                }

                Console.WriteLine($"Start: [ {string.Join(", ", snapshots[i][0])} ]");
                Console.WriteLine($"Aux: [ {string.Join(", ", snapshots[i][1])} ]");
                Console.WriteLine($"End: [ {string.Join(", ", snapshots[i][2])} ]");
            }
        }

        private static bool isEqual(List<int> actual, List<int> expected)
        {
            if (actual.Count != expected.Count)
            {
                return false;
            }

            for (int i = 0; i < actual.Count; i++)
            {
                if (actual[i] != expected[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}