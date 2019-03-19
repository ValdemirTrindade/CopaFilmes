using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ViewModel
{
    public class ResultadoCampeonato
    {
        public long Id { get; set; }
        public string Titulo { get; set; }
        public long AnoLancamento { get; set; }
        public float Nota { get; set; }
    }
}
