using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_11_2
{
    internal class Airplane : IFlyable
    {
        public int MaxAttitude { get; }
        public int CountPassengers { get; set; }

        public Airplane(int maxAttitude, int countPassengers)
        {
            MaxAttitude = maxAttitude;
            CountPassengers = countPassengers;
        }

        public void Fly()
        {
            Console.WriteLine($"Лечу на высоте {MaxAttitude} метров. Везу {CountPassengers} пассажиров.");

        }
    }
}
