namespace Lab6
{
    public static class Lab6
    {
        public static int[,] Rotate90Degrees(int[,] data)
        {
            int rowCount = data.GetLength(0);
            int columnCount = data.GetLength(1);

            int[,] result = new int[columnCount, rowCount];

            for (int i = 0; i < columnCount; i++)
            {
                for (int j = 0; j < rowCount; j++)
                {
                    result[i, j] = data[rowCount - 1 - j, i];
                }
            }

            return result;
        }

        public static void TransformArray(int[,] data, EMode mode)
        {
            int columnCount = data.GetLength(0);
            int rowCount = data.GetLength(1);

            int[,] cloneData = (int[,])data.Clone();

            for (int i = 0; i < columnCount; i++)
            {
                for (int j = 0; j < rowCount; j++)
                {
                    if (mode == EMode.HorizontalMirror)
                    {
                        data[i, j] = cloneData[i, rowCount - 1 - j];
                    }
                    else if (mode == EMode.VerticalMirror)
                    {
                        data[i, j] = cloneData[columnCount - 1 - i, j];
                    }
                    else if (mode == EMode.DiagonalShift)
                    {
                        int column = i - 1;
                        int row = j - 1;
                        if (column < 0)
                        {
                            column = columnCount - 1;
                        }
                        if (row < 0)
                        {
                            row = rowCount - 1;
                        }

                        data[i, j] = cloneData[column, row];
                    }
                }
            }
        }

    }
}