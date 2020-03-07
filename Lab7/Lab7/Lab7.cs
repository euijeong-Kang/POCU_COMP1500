namespace Lab7
{
    public static class Lab7
    {
        public static bool PlayGame(uint[] array)
        {
            bool bResult = false;
            if (array.Length > 1 && array[0] < array.Length)
            {
                int[] locations = new int[1];
                locations[0] = array.Length - 1;

                if (MoveRcursive(locations, array) == 0)
                {
                    bResult = true;
                }
                if (MoveRcursive(locations, array) == uint.MaxValue)
                {
                    bResult = false;
                }
            }
            return bResult;
        }
        public static uint MoveRcursive(int[] locations, uint[] array)
        {
            if (locations[0] == 0)
            {
                return 0;
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (i + array[i] == locations[0] || i - array[i] == locations[0])
                {
                    locations[0] = i;
                    break;
                }
                if (i == array.Length - 2)
                {
                    return uint.MaxValue;
                }
            }
            return MoveRcursive(locations, array);
        }
    }
}