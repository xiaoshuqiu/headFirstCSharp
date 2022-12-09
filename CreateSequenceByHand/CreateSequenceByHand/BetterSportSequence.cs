using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateSequenceByHand
{
    class BetterSportSequence : IEnumerable<Sport> 
    {
        public IEnumerable<Sport> GetEnumerator()
        {
            int maxEnumValue = Enum.GetValues(typeof(Sport)).Length - 1;
            for (int i = 0; i< maxEnumValue; i++)
            {
                yield return (Sport)i;
            }
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
