using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_21_2
{
    public interface IDoubleSquare : IFigure
    {
        void BuildDoubleSquare(ISquare square1, ISquare square2);
    }
}
