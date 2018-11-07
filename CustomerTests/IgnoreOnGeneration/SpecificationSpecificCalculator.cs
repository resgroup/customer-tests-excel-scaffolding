using CustomerTestsExcel;
using System;

namespace SutTests.IgnoreOnGeneration
{
    public class SpecificationSpecificCalculator : ReportsSpecificationSetup
    {
        public int Result { get; private set; }
        int x;
        int y;

        public SpecificationSpecificCalculator() {}

        public void X_of(int x)
        {
            _valueProperties.Add(System.Reflection.MethodBase.GetCurrentMethod().Name, x);

            this.x = x;
        }

        public void Y_of(int y)
        {
            _valueProperties.Add(System.Reflection.MethodBase.GetCurrentMethod().Name, y);

            this.y = y;
        }

        public void Sum() => 
            Result = 3;

    }
}