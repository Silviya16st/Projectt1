using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha3
{
    internal class PersonGrades
    {
        private string name = "";
        private double gradeBel = 0;
        private double gradeMat = 0;

        public string Name { get; set; }
        public double GradeBel { get; set; }
        public double GradeMat { get; set; }

        public PersonGrades (string name, double bel, double mat)
        {
            this.Name = name;
            this.GradeBel = bel;
            this.gradeMat = mat;
        }
    }
}
