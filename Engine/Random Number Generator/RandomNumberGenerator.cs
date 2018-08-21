using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class RandomNumberGenerator
    {
        private static Random random = new Random();

        public static int RandomNumberBetween (int minimumValue, int maximumValue)
        {
            return random.Next(minimumValue, maximumValue + 1);
        }
    }
}
