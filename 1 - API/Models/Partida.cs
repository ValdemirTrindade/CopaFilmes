using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    class Partida
    {
        private Juiz juiz;
        private Filme filmeA;
        private Filme filmeB;
        private int rodada;

        public Partida(Juiz juiz,Filme filmeA, Filme filmeB, int rodada)
        {
            this.juiz = juiz;
            this.filmeA = filmeA;
            this.filmeB = filmeB;
            this.rodada = rodada;
        }

        public Filme comecarPartida()
        {
            return juiz.quemGanhou(filmeA, filmeB);
        }

        public String toString()
        {
            return String.Format("Rodada {0} {1} vs {2}", this.rodada, this.filmeA.Titulo, this.filmeB.Titulo);
        }
    }
}
