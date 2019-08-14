using ClassesDeExemploParaBDD;
using Shouldly;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowTests.Step.CalculoHoras
{
    [Binding]
    public class ExtraHourCalculationSteps
    {
        private CalculoHora calculoHora;
        private double quantidade;
        private Decimal valor;

        [Given(@"I'm using the CalculaHoraExtraNormal method")]
        public void GivenIMUsingTheCalculaHoraExtraNormal()
        {
            calculoHora = new CalculoHora();
        }

        [Given(@"I have entered (.*) in the field quantidade")]
        public void GivenIHaveEnteredInTheFieldQuantidade(int p0)
        {
            quantidade = p0;
        }

        [When(@"I execute the application")]
        public void WhenIExecuteTheApplication()
        {
            valor = (Decimal)calculoHora.CalculaHoraExtraNormal(quantidade);
        }

        [Then(@"the result should be '(.*)' on the screen")]
        public void ThenTheResultShouldBeOnTheScreens(Decimal p0)
        {
            p0.ToString("N2").ShouldBe(valor.ToString("N2"));
        }
    }
}
