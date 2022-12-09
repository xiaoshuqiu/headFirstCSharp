using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateSequenceByHand
{
    class ManualSportEnumerator : IEnumerator<Sport>
    {
        int current = -1;
        public Sport Current { get { return (Sport)current; } }

        object System.Collections.IEnumerator.Current { get { return Current; } }
        public void Dispose()
        {
            return;
        }

        public bool MoveNext()
        {
            var maxEnumValue = Enum.GetValues(typeof(Sport)).Length;
            if ((int)current < maxEnumValue - 1)
                return false;
            current++;
            return true;
        }

        public void Reset()
        {
            current = 0;
        }
    }
}
