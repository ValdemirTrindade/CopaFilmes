using API.Input;
using API.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Campeonato
    {
        private Filme[] filmes;
        private Fase fase;

        public Campeonato(params FilmeInput[] filmesInput)
        {
            this.filmes = this.FilmeInputToModel(filmesInput);

            fase = new Fase(filmes);
        }

        private Filme[] FilmeInputToModel(FilmeInput[] FilmeInput)
        {
            Filme[] filmes = new Filme[FilmeInput.Length];

            int contador = 0;
            foreach(var input in FilmeInput)
            {
                Filme filme = new Filme()
                {
                    Titulo = input.Titulo,
                    AnoLancamento = input.AnoLancamento,
                    Id = input.Id,
                    Nota = input.Nota
     
                };

                filmes[contador] = filme;
                contador++;
            }

            return filmes;
        }

        public ResultadoCampeonato Iniciar()
        {


            do
            {
                this.filmes = fase.comecar();
            } while (!fase.proximaFase(this.filmes));

            ResultadoCampeonato resultado = new ResultadoCampeonato();

            Filme vencedor = fase.getGanhador();

            if (vencedor == null) return null;

            resultado.Titulo = vencedor.Titulo;

            return resultado;
        }
    }
}
