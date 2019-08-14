using ClassesDeExemploParaBDD;
using Shouldly;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowTests.Step.CalculoHoras
{
    [Binding]
    public class CalculoHoraSteps
    {
        private CalculoHora calculoHora;
        private double quantidade;
        private Decimal valor;

        [Given(@"que estou consumindo o método CalculaHoraExtraNormal")]
        public void DadoQueEstouConsumindoOMetodoCalculaHoraExtraNormal()
        {
            calculoHora = new CalculoHora();
        }

        [Given(@"preencho o campo quantidade com o valor (.*)")]
        public void DadoPreenchoOCampoQuantidadeComOValor(int p0)
        {
            quantidade = p0;
        }

        [When(@"executo a aplicação")]
        public void QuandoExecutoAAplicacao()
        {
            valor = (Decimal)calculoHora.CalculaHoraExtraNormal(quantidade);
        }

        [Then(@"vejo '(.*)'")]
        public void EntaoVejo(Decimal p0)
        {
            p0.ToString("N2").ShouldBe(valor.ToString("N2"));
        }
    }
}
