using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_21_2
{
    public abstract class AbstractDoubleSquare : IDoubleSquare
    {
        protected double area;

        public abstract void BuildDoubleSquare(ISquare square1, ISquare square2);
        protected abstract double CalculateArea();
        public double GetArea()
        {
            if (this.area == 0)
            {
                area = CalculateArea();
            }
            return CalculateArea();
        }
    }
}
