using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCollatzConjecture
{
    public class Calc
    {
        private int _int;

        public Calc(int int1)
        {
            _int = int1;
        }
        
        public int CollatzCalc()
        {
            int steps = 0;
            while(_int != 1)
            {
                IsEven();
                steps++;
            }
            return steps;
        }

        private void IsEven()
        {
            if (_int % 2 == 0) _int = _int / 2;
            else _int = _int * 3 + 1;
        }
    }
}
