using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTest0611
{
    class SingleTest
    {
        private static SingleTest inst;
        private int data;

        public SingleTest(Random r)
        {
            data = r.Next(1, 100);
        }

        public int getData()
        {
            return data;
        }

        public static SingleTest getInstance(Random r)
        {
            if (inst == null)
            {
                inst = new SingleTest(r);
            }    
            return inst;
        }
    }
}
