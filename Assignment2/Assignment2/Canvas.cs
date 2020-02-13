namespace Assignment2
{
    public static class Canvas
    {
        public static char[,] Draw(uint width, uint height, EShape shape)
        {
            char[,] result = GetCanvas(width, height);
            uint centerNum = (width + 4) / 2;
            uint radius = centerNum - 2;
            if (width == 0 || height == 0)
            {
                result = new char[0, 0];
            }
            else
            {
                for (uint i = 2; i < height + 2; i++)
                {
                    for (uint j = 2; j < width + 2; j++)
                    {
                        if (shape == EShape.Rectangle)
                        {
                            result[i, j] = '*';
                        }
                        else if (shape == EShape.IsoscelesTriangle)
                        {
                            if (width == height * 2 - 1)
                            {
                                if (centerNum + i - 2 >= j && centerNum + 2 - i <= j)
                                {
                                    result[i, j] = '*';
                                }
                            }
                            else
                            {
                                result = new char[0, 0];
                            }
                        }
                        else if (shape == EShape.IsoscelesRightTriangle)
                        {
                            if (width == height)
                            {
                                if (i >= j)
                                {
                                    result[i, j] = '*';
                                }
                            }
                            else
                            {
                                result = new char[0, 0];
                            }
                        }
                        else if (shape == EShape.Circle)
                        {
                            if (width % 2 != 0)
                            {
                                if ((centerNum - i) * (centerNum - i) + (centerNum - j) * (centerNum - j) <= radius * radius)
                                {
                                    result[i, j] = '*';
                                }
                            }
                            else
                            {
                                result = new char[0, 0];
                            }

                        }
                    }
                }
            }
            return result;
        }
        public static bool IsShape(char[,] canvas, EShape shape)
        {
            bool bResult = false;

            if (shape == GetEShape(canvas))
            {
                bResult = true;
            }

            return bResult;
        }

        public static char[,] GetCanvas(uint width, uint height)
        {
            uint canvasWidth = width + 4;
            uint canvasHeight = height + 4;
            char[,] result = new char[canvasHeight, canvasWidth];

            for (uint i = 0; i < canvasHeight; i++)
            {
                for (uint j = 0; j < canvasWidth; j++)
                {
                    if (i == 0 || i == canvasHeight - 1)
                    {
                        result[i, j] = '-';
                    }
                    else
                    {
                        if (j == 0 || j == canvasWidth - 1)
                        {
                            result[i, j] = '|';
                        }
                        else
                        {
                            result[i, j] = ' ';
                        }
                    }

                }
            }
            return result;
        }
        public static EShape GetEShape(char[,] canvas)
        {
            int height = canvas.GetLength(0) - 4;
            int width = canvas.GetLength(1) - 4;
            int centerNum = (width + 4) / 2;
            int radius = centerNum - 2;

            EShape shapeOfCanvas = EShape.Rectangle;

            for (int i = 2; i < canvas.GetLength(0) - 2; i++)
            {
                for (int j = 2; j < canvas.GetLength(1) - 2; j++)
                {
                    if (canvas[i, j] != '*')
                    {
                        break;
                    }
                    else
                    {
                        shapeOfCanvas = EShape.Rectangle;
                    }
                    if (i >= j)
                    {
                        if (canvas[i, j] != '*')
                        {
                            break;
                        }
                        else
                        {
                            shapeOfCanvas = EShape.IsoscelesRightTriangle;
                        }
                    }
                    else if (width == height * 2 - 1)
                    {
                        if (centerNum + i - 2 >= j && centerNum + 2 - i <= j)
                        {
                            if (canvas[i, j] != '*')
                            {
                                break;
                            }
                            else
                            {
                                shapeOfCanvas = EShape.IsoscelesTriangle;
                            }
                        }
                    }
                    else if (width % 2 != 0)
                    {
                        if ((centerNum - i) * (centerNum - i) + (centerNum - j) * (centerNum - j) <= radius * radius)
                        {
                            if (canvas[i, j] != '*')
                            {
                                break;
                            }
                            else
                            {
                                shapeOfCanvas = EShape.Circle;
                            }
                        }
                    }
                }
            }
            return shapeOfCanvas;
        }
    }
}
