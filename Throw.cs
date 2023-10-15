using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiuiu.iipb_22_2.MilyayevVD.Bowling
{
    public class Throw
    {
        private int pinsKnockedDown;  // Количество сбитых кеглей
        public int PinsKnockedDown
        {
            get { return pinsKnockedDown; }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("Количество сбитых кеглей должно быть больше или равно 0 и меньше или равно 10.");
                }
                pinsKnockedDown = value;
            }
        }

        public Throw(int knockedPins)
        {
            PinsKnockedDown = knockedPins;
        }
    }

}
