using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circus_Trein
{
    public interface IEdible
    {
        bool EetAnderen(IEnumerable<Dier> anderDier);
        bool WordGegeten(IEnumerable<Dier> anderDier);
    }
}
