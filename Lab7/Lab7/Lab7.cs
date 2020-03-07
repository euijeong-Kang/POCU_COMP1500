namespace Lab7
{
    public static class Lab7
    {

        public static bool PlayGame(uint[] array)
        {
            bool bResult = false;
            if (array.Length > 1 && array[0] < array.Length)
            {
                uint location = array[0];

                if (MoveRecursive(location, array) == 0)
                {
                    bResult = true;
                }
                if (MoveRecursive(location, array) == uint.MaxValue)
                {
                    bResult = false;
                }

            }
            else
            {
                bResult = false;
            }

            return bResult;
        }
        public static uint MoveRecursive(uint location, uint[] array)
        {
            if (array[location] == 0)
            {
                return 0;
            }
            if ((int)location - array[location] > 0 && array[location + array[location]] != 0)
            {
                location -= array[location];
                if ((int)location - array[location] <= 0 && array[location] == array[location + array[location]])
                {
                    location += array[location];
                    if (location + array[location] > array.Length)
                    {
                        return uint.MaxValue;
                    }
                    else
                    {
                        location += array[location];
                    }
                }
            }
            else
            {
                if (location + array[location] > array.Length)
                {
                    return uint.MaxValue;
                }
                location += array[location];

            }
            return MoveRecursive(location, array);

        }


    }
}