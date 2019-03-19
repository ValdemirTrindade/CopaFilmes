using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using API.Models;


namespace Teste.models
{
    public class FaseTest
    {     
        [Fact]
        public void testeQuantidadePartidas4()
        {
            Filme filme1 = new Filme { Titulo = "filme 1", Nota = 10 };
            Filme filme2 = new Filme { Titulo = "filme 2", Nota = 10 };
            Filme filme3 = new Filme { Titulo = "filme 3", Nota = 10 };
            Filme filme4 = new Filme { Titulo = "filme 4", Nota = 10 };
            Filme filme5 = new Filme { Titulo = "filme 5", Nota = 10 };
            Filme filme6 = new Filme { Titulo = "filme 6", Nota = 10 };
            Filme filme7 = new Filme { Titulo = "filme 7", Nota = 10 };
            Filme filme8 = new Filme { Titulo = "filme 8", Nota = 10 };


            Filme[] filmes = { filme1, filme2, filme3, filme4, filme5, filme6, filme7, filme8 };

            Fase fase = new Fase(filmes);
            
            Assert.Equal(4, fase.getPartidas().Length);
        }

        [Fact]
        public void testePosicoesPartidas4()
        {
            Filme filme1 = new Filme { Titulo = "filme 1", Nota = 10 };
            Filme filme2 = new Filme { Titulo = "filme 2", Nota = 10 };
            Filme filme3 = new Filme { Titulo = "filme 3", Nota = 10 };
            Filme filme4 = new Filme { Titulo = "filme 4", Nota = 10 };
            Filme filme5 = new Filme { Titulo = "filme 5", Nota = 10 };
            Filme filme6 = new Filme { Titulo = "filme 6", Nota = 10 };
            Filme filme7 = new Filme { Titulo = "filme 7", Nota = 10 };
            Filme filme8 = new Filme { Titulo = "filme 8", Nota = 10 };


            Filme[] filmes = { filme1, filme2, filme3, filme4, filme5, filme6, filme7, filme8 };

            Fase fase = new Fase(filmes);

           

            Partida[] p = fase.getPartidas();


            Assert.Equal("Rodada 1 filme 1 vs filme 8", p[0].toString());
            Assert.Equal("Rodada 2 filme 2 vs filme 7", p[1].toString());
            Assert.Equal("Rodada 3 filme 3 vs filme 6", p[2].toString());
            Assert.Equal("Rodada 4 filme 4 vs filme 5", p[3].toString());

        }

        [Fact]
        public void testePosicoesPartidas2()
        {
            Filme filme1 = new Filme { Titulo = "filme 1", Nota = 10 };
            Filme filme2 = new Filme { Titulo = "filme 2", Nota = 10 };
            Filme filme3 = new Filme { Titulo = "filme 3", Nota = 10 };
            Filme filme4 = new Filme { Titulo = "filme 4", Nota = 10 };



            Filme[] filmes = { filme1, filme2, filme3, filme4};

            Fase fase = new Fase(filmes);



            Partida[] p = fase.getPartidas();


            Assert.Equal("Rodada 1 filme 1 vs filme 4", p[0].toString());
            Assert.Equal("Rodada 2 filme 2 vs filme 3", p[1].toString());
  

        }

        [Fact]
        public void testeQuantidadePartidas2()
        {
            Filme filme1 = new Filme { Titulo = "filme 1", Nota = 10 };
            Filme filme2 = new Filme { Titulo = "filme 2", Nota = 10 };
            Filme filme3 = new Filme { Titulo = "filme 3", Nota = 10 };
            Filme filme4 = new Filme { Titulo = "filme 4", Nota = 10 };



            Filme[] filmes = { filme1, filme2, filme3, filme4 };

            Fase fase = new Fase(filmes);

            Assert.Equal(2, fase.getPartidas().Length);
        }

        [Fact]
        public void testeQuantidadePartida()
        {
            Filme filme1 = new Filme { Titulo = "filme 1", Nota = 10 };
            Filme filme2 = new Filme { Titulo = "filme 2", Nota = 10 };




            Filme[] filmes = { filme1, filme2 };

            Fase fase = new Fase(filmes);

            Assert.Single(fase.getPartidas());
        }


        [Fact]
        public void testeComecarFase()
        {
            Filme filme1 = new Filme { Titulo = "filme 1", Nota = 10 };
            Filme filme2 = new Filme { Titulo = "filme 2", Nota = 10 };
            Filme filme3 = new Filme { Titulo = "filme 3", Nota = 10 };
            Filme filme4 = new Filme { Titulo = "filme 4", Nota = 10 };
            Filme filme5 = new Filme { Titulo = "filme 5", Nota = 10 };
            Filme filme6 = new Filme { Titulo = "filme 6", Nota = 10 };
            Filme filme7 = new Filme { Titulo = "filme 7", Nota = 10 };
            Filme filme8 = new Filme { Titulo = "filme 8", Nota = 10 };


            Filme[] filmes = { filme1, filme2, filme3, filme4, filme5, filme6, filme7, filme8 };

            Fase fase = new Fase(filmes);

            Filme[] filmesVencedores = fase.comecar();

            Assert.Equal(4, filmesVencedores.Length);
        }
    }
}
