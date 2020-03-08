namespace Lab7
{
    public static class Lab7
    {
        public static bool PlayGame(uint[] array)
        {
            bool bResult = false;
            if (array.Length > 1 && array[0] > 0 && array[0] < array.Length)
            {
                uint location = 0;
                uint[] visitArray = new uint[array.Length];
                visitArray[0] = 1;

                if (MoveRecursive(location, array, visitArray) == 0)
                {
                    bResult = true;
                }
                else if (MoveRecursive(location, array, visitArray) == uint.MaxValue)
                {
                    return false;
                }
            }
            return bResult;
        }
        public static uint MoveRecursive(uint location, uint[] array, uint[] visitArray)
        {
            if (array[location] == 0)
            {
                return 0;
            }
            if (location + array[location] < array.Length && visitArray[location + array[location]] != 1)
            {
                visitArray[location] = 1;
                location += array[location];
            }
            else if ((int)location - array[location] > 0 && visitArray[location - array[location]] != 1)
            {
                visitArray[location] = 1;
                location -= array[location];
            }
            else
            {
                visitArray[location] = 1;
                for (uint i = 1; i < array.Length; i++)
                {
                    if ((int)i - array[i] > 0 && visitArray[i] == 1 && visitArray[i - array[i]] != 1)
                    {
                        location = i;
                        break;
                    }
                    if (i == array.Length - 1)
                    {
                        return uint.MaxValue;
                    }
                }
            }
            return MoveRecursive(location, array, visitArray);
        }
    }
}