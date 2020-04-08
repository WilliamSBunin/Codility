using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    //Count minimal number of jumps from position X to Y.
    class FrogJmp
    {
        public static int GetHops(int startingPosition, int endingPosition, int hopDistance)
        {
            return (int)Math.Ceiling((endingPosition - startingPosition) / (decimal)hopDistance);
        }
    }
}
