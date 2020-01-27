namespace Lab4
{
    public static class Calendar
    {
        public static bool IsLeapYear(uint year)
        {
            bool bResult = false;

            if (year % 4 == 0 && year % 100 != 0)
            {
                bResult = true;
            }
            else if (year % 100 == 0 && year % 400 == 0)
            {
                bResult = true;
            }
            
            return bResult;
        }

        public static int GetDaysInMonth(uint year, uint month)
        {
            int result = 0;
            int[] monthPerDay = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (year > 9999 || month == 0 || month > monthPerDay.Length)
            {
                result = -1;
            }
            else
            {
                if (IsLeapYear(year) == false)
                {
                    result = monthPerDay[month - 1];
                }
                else if (IsLeapYear(year) == true)
                {
                    monthPerDay[1] += 1;
                    result = monthPerDay[month - 1];
                }
            }
            return result;
        }
    }
}
