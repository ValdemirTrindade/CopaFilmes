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
            Filme[] paraSaberOSegundoLugar = new Filme[2];

            if (this.filmes.Length == 0) return null;
            do
            {
                this.filmes = fase.comecar();
                if(this.filmes.Length == 2)
                {
                    paraSaberOSegundoLugar = this.filmes;
                }
            } while (fase.proximaFase(this.filmes));

            ResultadoCampeonato resultado = new ResultadoCampeonato();

            Filme vencedor = fase.getGanhador();
            Filme segundoFilme = null;
            if (vencedor == null) return null;

            if (paraSaberOSegundoLugar[0].Equals(vencedor)) segundoFilme = paraSaberOSegundoLugar[1];
            else segundoFilme = paraSaberOSegundoLugar[0];

            if (vencedor == null) return null;

            resultado.primeiroLugar = vencedor.Titulo;
            resultado.segundoLugar = segundoFilme.Titulo;

            
     

            return resultado;
        }
    }
}
