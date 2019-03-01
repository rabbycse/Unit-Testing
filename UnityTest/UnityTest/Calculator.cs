using System;
using System.Collections.Generic;
using System.Text;

namespace UnityTest
{
    public interface ICalulator
    {
        double Sum(double num1, double num2);
        
    }

    public class Calculator:ICalulator
    {

        public double Sum(double num1, double num2) 
        {
            return num1 - num2;
        }
    }
}
