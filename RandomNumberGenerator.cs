using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labss
{
    public class RandomNumberGenerator
    {
        private Random random = new Random();
        public int GenerateRandomNumber()
        {
            return random.Next(1, 701);
        }
    }
}
