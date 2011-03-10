using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CSC431.CFG
{
    public class VirtRegAlloc
    {
        private static readonly TaskLocal<VirtRegAlloc> instance = new TaskLocal<VirtRegAlloc>(() => new VirtRegAlloc());

        public static VirtRegAlloc Instance
        {
            get
            {
                return instance.Value;
            }
        }

        private int counter = 0;

        private VirtRegAlloc()
        {
        }

        public int Alloc()
        {
            return Interlocked.Increment(ref counter);
        }

        /// <summary>
        /// Slow because it has to go through the task local every time.
        /// </summary>
        /// <returns></returns>
        public static int AllocSlow()
        {
            return instance.Value.Alloc();
        }
    }
}
