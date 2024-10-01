using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTarget
{
    public class Teste1
    {
        public int INDICE = 12;

        public int SOMA = 0;

        public int K = 1;

        const int resposta = 78;
        public void ExecuteTeste1()
        {
            while (K < INDICE) {
                K++;
                SOMA += K;
            }

            if (SOMA == resposta) {
                Console.WriteLine(SOMA);
            }

        }
    }
}
