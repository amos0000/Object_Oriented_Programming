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

        public string Make { get; set; }

        private int maxSpeed;
        public int MaxSpeed {
            get
            {
                return maxSpeed;
            }
            set
            {
                if ((value > 0) && (value < 500))
                {
                    maxSpeed = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Antamasi arvo on liian suuri tai liian pieni!");
                }
            }
        }

        public int GetMaxSpeed()
        {
            return maxSpeed;
        }

        public void StartEngine()
        {
        }

        public void StopEngine()
        {
        }

        internal void SetMaxSpeed(int max)
        {
            MaxSpeed = max;
        }
    }
}
