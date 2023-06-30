using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExample
{
    public struct KMConverter
    {
        private float km;
        private float miles;

        public KMConverter(float km)
        {
            this.km = km;
        }
        public float Km
        {
            get { return km; }
            set { km = value; }
        }

        public float Miles
        {
            get { return miles; }
            set { miles = value; }
        }

        public void CalculateMiles()
        {
            Miles = km * 1.6f;
        }
    }
}
