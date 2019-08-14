using ClassesDeExemploParaBDD;
using Shouldly;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowTests.Step.NumerosRomanos
{
    [Binding]
    public class ConversionRomanNumberToIntegerNumbersSteps
    {
        private RomanToArabic romanToArabic;
        private string romanValue;
        private int arabicNumber = 0;

        [Given(@"I'm using the ConvertToArabic method")]
        public void GivenIMUsingTheConvertToArabicMethod()
        {
            romanToArabic = new RomanToArabic();
        }

        [Given(@"I have entered '(.*)' into the program")]
        public void GivenIHaveEnteredIntoTheProgram(string romanTestValue)
        {
            romanValue = romanTestValue;
        }

        [When(@"I process the program")]
        public void WhenIProcessTheProgram()
        {
            arabicNumber = romanToArabic.Convert(romanValue);
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            arabicNumber.ShouldBe(expectedResult);
        }
    }
}
