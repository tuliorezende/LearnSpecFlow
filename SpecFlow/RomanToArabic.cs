using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesDeExemploParaBDD
{
    public class RomanToArabic
    {
        private Dictionary<char, int> romanValue = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        public int Convert(string romanNumber)
        {
            int accumulatedValue = 0;
            int lastAnalyzedNumber = 0;

            for (int count = romanNumber.Length - 1; count >= 0; count--)
            {
                // pega o inteiro referente ao simbolo atual
                int actual = romanValue[romanNumber[count]];

                int multiplicator = 1;

                // se o da direita for menor, o multiplicaremos
                // por -1 para torná-lo negativo
                if (actual < lastAnalyzedNumber)
                {
                    multiplicator = -1;
                }

                accumulatedValue += romanValue[romanNumber[count]] * multiplicator;

                // atualiza o vizinho da direita
                lastAnalyzedNumber = actual;
            }
            return accumulatedValue;
        }
    }
}
