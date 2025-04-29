using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCAD_17_Project_4_1_2
{
    public class Calculator : ICalculator
    {
        public double Add(double x, double y) 
        { 
            return x + y;
        }

        public double Subtract(double x, double y) 
        { 
            return x - y; 
        }

        public double Multiply(double x, double y) 
        { 
            return x * y; 
        }
        public double Divide(double x, double y) 
        { 
            return (x / y); 
        }
    }
}
