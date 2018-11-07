using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using CustomerTestsExcel;
using System.Linq.Expressions;
using SutTests;

using SutTests.IgnoreOnGeneration;

namespace SutTests.Sum
{
    [TestFixture]
    public class Sum_1_and_2 : SpecificationBase<SpecificationSpecificCalculator>, ISpecification<SpecificationSpecificCalculator>
    {
        public override string Description()
        {
            return "Sum 1 and 2";
        }

        // arrange
        public override SpecificationSpecificCalculator Given()
        {
            var calculator = new SpecificationSpecificCalculator();
            calculator.X_of(1);
            calculator.Y_of(2);

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
                 new EqualityAssertion<SpecificationSpecificCalculator>(calculator => calculator.Result , 3)
            };
        }
        protected override string AssertionClassPrefixAddedByGenerator => "I";
    }
}
