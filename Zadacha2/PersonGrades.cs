using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    internal class PersonGrades
    {
        private double gradeBel = 0;
        private double gradeMat = 0;

        public double GradeBel { get; set; }
        public double GradeMat { get; set; }

        public PersonGrades(double bel, double mat)
        {
            this.GradeBel = bel;
            this.GradeMat = mat;
        }

    }
}
