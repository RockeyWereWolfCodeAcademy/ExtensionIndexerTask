using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExtensionTask
{
    internal static class ExtensionMethods
    {
        public static bool IsPrime(this int number)
        {
            if (number <= 1)
                return false;
            if (number <= 3)
                return true;

            if (number % 2 == 0 || number % 3 == 0)
                return false;

            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
            }

            return true;
        }

        public static bool IsPowOfTwo(this int number)
        {
            if (number == 0)
                return false;

            while (number != 1)
            {
                if (number % 2 != 0)
                    return false;

                number = number / 2;
            }
            return true;
        }
    }
}
