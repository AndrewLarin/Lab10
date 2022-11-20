using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Angle
    {
        private int gradus;
        private int min;
        private int sec;

        public int Gradus
        {
            get { return gradus; }
            set
            {
                if (value < 0)
                    Console.WriteLine("MISTAKE!");
                else gradus = value;
            }
        }
        public int Min
        {
            get { return min; }
            set
            {
                if (value < 0)
                    Console.WriteLine("MISTAKE!");
                else min = value;
            }
        }
        public int Sec
        {
            get { return sec; }
            set
            {
                if (value < 0)
                    Console.WriteLine("MISTAKE!");
                else sec = value;
            }
        }
        public Angle(int gradus, int min, int sec)
        {
            this.Gradus = gradus;
            this.Min = min;
            this.Sec = sec;
        }
        public Angle()
        {
            this.Gradus = 0;
            this.Min = 0;
            this.Sec = 0;
        }
        public double ToRadians()
        {
            return ((gradus +(min + sec/60.0)/60.0)*Math.PI)/180.0;
        }
    }
}
