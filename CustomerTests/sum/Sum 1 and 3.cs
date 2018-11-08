using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using CustomerTestsExcel;
using System.Linq.Expressions;
using CustomerTests;

using CustomerTests.IgnoreOnGeneration;

namespace CustomerTests.Sum
{
    [TestFixture]
    public class Sum_1_and_3 : SpecificationBase<SpecificationSpecificCalculator>, ISpecification<SpecificationSpecificCalculator>
    {
        public override string Description()
        {
            return "Sum 1 and 3";
        }

        // arrange
        public override SpecificationSpecificCalculator Given()
        {
            var calculator = new SpecificationSpecificCalculator();
            calculator.X_of(1);
            calculator.Y_of(3);

            return calculator;
        }

        // act
        public override string When(SpecificationSpecificCalculator calculator)
        {
            calculator.Sum();
            return "Sum";
        }

        public override IEnumerable<IAssertion<SpecificationSpecificCalculator>> Assertions()
        {
            return new List<IAssertion<SpecificationSpecificCalculator>>
            {
                 new EqualityAssertion<SpecificationSpecificCalculator>(calculator => calculator.Result , 4)
            };
        }
        protected override string AssertionClassPrefixAddedByGenerator => "I";
    }
}
