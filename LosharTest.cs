using System;

namespace loshar_symbols
{
    public class LosharTest
    {
        public static int Test(int a, int b)
        {
            if (a % 2 == 0)
            {
                return a + b;
            }
            else
            {
                return a - b;
            }
        }
    }
}
