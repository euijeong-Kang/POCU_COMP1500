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

            array = new uint[12] { 3, 6, 2, 4, 4, 6, 1, 1, 4, 5, 1, 0 };
            bPass = Lab7.PlayGame(array);

            Debug.Assert(bPass);
            


        }
    }
}
