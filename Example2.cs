using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface
{
    public abstract class BaseColor
    {
        public abstract string ChangeColor();
    }

    public class Tshirt : BaseColor
    {
        public override string ChangeColor()
        {
            return "Tshirt is Blue.";
        }
    }

    public class Short : BaseColor
    {
        public override string ChangeColor()
        {
           return "Short is Red.";
        }
    }
}