using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTarget
{
    public class Teste3
    {
        public void CalcularContabilidadeAnual(decimal[] arrayFaturamentoDiario)
        {
            IEnumerable<decimal> decimals = arrayFaturamentoDiario.AsEnumerable().Where(a => a > 0);

            decimal media = decimals.Sum() / decimals.Count();

            Console.WriteLine(decimals.Min().ToString() + "-" + decimals.Max().ToString() + "-" + decimals.Where(a => a < media).Count());
        }
    }
}
