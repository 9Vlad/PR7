using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR7
{
    public class Rivercls
    {
        public string Name { get; set;}
        public double Depth { get; set; }
        public double Length { get; set; }
        public bool RiverSpeed { get; set; }
        public int Speed { get; set; }
        public string Region { get; set; }
        public string Pool { get; set; }
        public string Vityk { get; set; }
        public string DetermineRiverSize()
        {
            if (Length > 1000)
            {
                return "Велика";
            }
            else if (Length >= 500)
            {
                return "Середня";
            }
            else
            {
                return "Маленька";
            }
        }

        public Rivercls()
        {

        }

        public Rivercls(string name, double depth, double length, bool riverspeed, int speed, string region, string pool, string vityk)
        {
            Name = name;
            Depth = depth;
            Length = length;
            RiverSpeed = riverspeed;
            Speed = speed;
            Region = region;
            Pool = pool;
            Vityk = vityk;
        }
    }
}
