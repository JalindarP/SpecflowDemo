using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using CalculatorLibrary;
using Shouldly;

namespace Service.Tests
{
    [Binding]
    public class AdditionTest
    {
        private double a, b, result;
        private readonly Calculator _object;

        public AdditionTest()
        {
            _object = new Calculator();
        }

        [Given(@"(.*) is first number")]
        public void GivenIsFirstNumber(double x)
        {
            a = x;
        }

        [Given(@"(.*) is second number")]
        public void GivenIsSecondNumber(double y)
        {
            b = y;
        }

        [When(@"asked for addition")]
        public void WhenAskedForAddition()
        {
            result = _object.Add(a, b);
        }

        [Then(@"result should be (.*)")]
        public void ThenResultShouldBe(double expected)
        {
            result.ShouldBe(expected);
        }
    }
}
