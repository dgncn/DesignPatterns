using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDP
{
    public class DisplayCardChip
    {
        private static DisplayCardChip instance;
        private DisplayCardChip()
        {

        }
        public static DisplayCardChip GetInstance()
        {
            if (instance == null)
                instance = new DisplayCardChip();

            return instance;
        }
    }
}
