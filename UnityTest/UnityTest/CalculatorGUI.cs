using System;
using System.Collections.Generic;
using System.Text;

namespace UnityTest
{
    class CalculatorGUI
    {
        public static void Main(string[] args)
        { 
            //Display d = new Display();
            //d.PerformSum(2, 2);
            //Console.WriteLine(d.Result);

            TestPerformSum();
            Console.ReadLine();
        }

        public static void TestPerformSum()
        {
            FakeCalculator f = new FakeCalculator();
            Display d = new Display(f);
            d.PerformSum(2, 2);

            if(d.Result == "Sum = 4")
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }
        
    }

    public class FakeCalculator : ICalulator
    {
        public double Sum(double num1, double num2)
        {
            return num1 + num2;
           /* if (num1 == 2 && num2 == 2)
                return 4;
            else if (num1 == 3 && num2 == 2)
                return 5;
            else
                return 0;
                */
        }
    }
    

    public class Display
    {
        public string Result { get; set; }
        private ICalulator calculator; 

        public Display()
        {
            this.calculator = new Calculator();
        }

        public Display(ICalulator calulator)
        {
            this.calculator = calulator;
        }
        
        public void PerformSum(double num1, double num2)
        {
            //Calculator c = new Calculator();
            //double r = c.Sum(num1, num2);
            double r = calculator.Sum(num1, num2); 

            Result = "Sum = " + r;
        }
    }
}
