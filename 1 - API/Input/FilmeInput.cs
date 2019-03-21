using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Input
{
    public class FilmeInput
    {
        public String Id { get; set; }
        public string Titulo { get; set; }
        public long AnoLancamento { get; set; }
        public float Nota { get; set; }
    }
}
