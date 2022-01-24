using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonLock
{
    public class DisplayCardChip
    {
        private static DisplayCardChip chip;
        private static Object _lockObject = new Object();
        private DisplayCardChip()
        {

        }

        public static DisplayCardChip GetChip()
        {
            if (chip == null)
            {
                lock (_lockObject)
                {
                    if (chip == null)
                        chip = new DisplayCardChip();

                }
            }

            return chip;
        }
    }
}
