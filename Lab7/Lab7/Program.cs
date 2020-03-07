using System.Diagnostics;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            uint[] array = new uint[0];
            bool bPass = Lab7.PlayGame(array);

            Debug.Assert(!bPass);

            

            array = new uint[] { 5, 4, 1, 2, 1, 2, 0 };
            bPass = Lab7.PlayGame(array);

            Debug.Assert(!bPass);

            array = new uint[] { 7, 4, 1, 2, 1, 2, 1, 2, 0 };
            bPass = Lab7.PlayGame(array);

            Debug.Assert(!bPass);

            array = new uint[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0 };
            bPass = Lab7.PlayGame(array); // true

            Debug.Assert(bPass);



        }
    }
}
