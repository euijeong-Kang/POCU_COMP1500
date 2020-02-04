using System;
namespace Lab5
{
    public static class Lab5
    {
        public static bool TryFixData(uint[] usersPerDay, double[] revenuePerDay)
        {
            bool bResult = false;
            double[] correctRevenuePerDay = new double[usersPerDay.Length];

            for (int i = 0; i < usersPerDay.Length; i++)
            {
                uint userCount = usersPerDay[i];
                uint caseNum = 0;

                if (userCount <= 10)
                {
                    caseNum = 1;
                }
                else if (userCount <= 100)
                {
                    caseNum = 2;
                }
                else if (userCount <= 1000)
                {
                    caseNum = 3;
                }
                else if (userCount > 1000)
                {
                    caseNum = 4;
                }

                switch (caseNum)
                {
                    case 1:
                        correctRevenuePerDay[i] = (uint)((double)usersPerDay[i] / 2 * 100 + 0.5) / 100.0;
                        break;
                    case 2:
                        correctRevenuePerDay[i] = (uint)((16 * (double)usersPerDay[i] / 5 - 27) * 100 + 0.5) / 100.0;
                        break;
                    case 3:
                        correctRevenuePerDay[i] = (uint)(((double)usersPerDay[i] * usersPerDay[i] / 4 - 2 * usersPerDay[i] - 2007) * 100 + 0.5) / 100.0;
                        break;
                    case 4:
                        correctRevenuePerDay[i] = (uint)((245743 + (double)usersPerDay[i] / 4) * 100 + 0.5) / 100.0;
                        break;
                    default:
                        Console.WriteLine("Please check user count");
                        break;
                }
            }

            if (usersPerDay.Length != revenuePerDay.Length || revenuePerDay == null || usersPerDay == null)
            {
                bResult = true;
            }
            for (int i = 0; i < correctRevenuePerDay.Length; i++)
            {
                if (correctRevenuePerDay[i] != revenuePerDay[i])
                {
                    bResult = true;
                    revenuePerDay[i] = correctRevenuePerDay[i];
                }
            }
            
            return bResult;
        }

        public static int GetInvalidEntryCount(uint[] usersPerDay, double[] revenuePerDay)
        {
            int invaildCount = 0;
            double[] correctRevenuePerDay = new double[usersPerDay.Length];

            for (int i = 0; i < usersPerDay.Length; i++)
            {
                uint userCount = usersPerDay[i];
                uint caseNum = 0;

                if (userCount <= 10)
                {
                    caseNum = 1;
                }
                else if (userCount <= 100)
                {
                    caseNum = 2;
                }
                else if (userCount <= 1000)
                {
                    caseNum = 3;
                }
                else if (userCount > 1000)
                {
                    caseNum = 4;
                }

                switch (caseNum)
                {
                    case 1:
                        correctRevenuePerDay[i] = (uint)((double)usersPerDay[i] / 2 * 100 + 0.5) / 100.0;
                        break;
                    case 2:
                        correctRevenuePerDay[i] = (uint)((16 * (double)usersPerDay[i] / 5 - 27) * 100 + 0.5) / 100.0;
                        break;
                    case 3:
                        correctRevenuePerDay[i] = (uint)(((double)usersPerDay[i] * usersPerDay[i] / 4 - 2 * usersPerDay[i] - 2007) * 100 + 0.5) / 100.0;
                        break;
                    case 4:
                        correctRevenuePerDay[i] = (uint)((245743 + (double)usersPerDay[i] / 4) * 100 + 0.5) / 100.0;
                        break;
                    default:
                        Console.WriteLine("Please check user count");
                        break;
                }
            }
            if (usersPerDay.Length != revenuePerDay.Length || revenuePerDay.Length == 0 || usersPerDay.Length == 0)
            {
                invaildCount = -1;
            }
            else
            {
                for (int i = 0; i < correctRevenuePerDay.Length; i++)
                {
                    if (correctRevenuePerDay[i] != revenuePerDay[i])
                    {
                        invaildCount++;
                    }
                }
            }
            
            return invaildCount;
        }

        public static double CalculateTotalRevenue(double[] revenuePerDay, uint start, uint end)
        {
            double totalRevenue = 0;
            if (revenuePerDay == null || start > end || start < 0)
            {
                totalRevenue = -1;
            }
            else if (end < 0 || start > revenuePerDay.Length - 1 || end > revenuePerDay.Length - 1)
            {
                totalRevenue = -1;
            }
            else
            {
                for (uint i = start; i < end + 1; i++)
                {
                    totalRevenue += revenuePerDay[i];
                }
            }
            
            return totalRevenue;
        }
    }
}