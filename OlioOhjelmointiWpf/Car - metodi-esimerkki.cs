using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlioOhjelmointiWpf
{
    public class Car
    {
        public string Color { get; set; }
        public string Model { get; set; }
        private int MaxSpeed { get; set; }

        public void StartEngine()
        {
        }

        public void StopEngine()
        {
        }

        internal void SetMaxSpeed(int max)
        {
            if ((max > 0) && (max < 500))
            {
                MaxSpeed = max;
            }
            else
            {
                throw new ArgumentOutOfRangeException("max");
            }
        }

        internal int GetMaxSpeed()
        {
            return MaxSpeed;
        }
    }
}
