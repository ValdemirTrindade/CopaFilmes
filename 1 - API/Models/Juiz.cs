using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("Teste")]
namespace API.Models
{
    /*
     Classe responsável por manter todas as regras do campeonato    
     */
    class Juiz
    {
        public Filme quemGanhou(Filme filmeA, Filme filmeB)
        {
            if (filmeA.Nota > filmeB.Nota) return filmeA;
            else if(filmeA.Nota == filmeB.Nota) return ordenar(filmeA, filmeB).ElementAt(0);
            else return filmeB;
        }

        public Filme[] ordenar(params Filme[] filmes)
        {
            List<Filme> listaFilmes = new List<Filme>();

            listaFilmes.AddRange(filmes);

            return listaFilmes.OrderBy(f => f.Titulo).ToArray();
            
        }
    }
}
