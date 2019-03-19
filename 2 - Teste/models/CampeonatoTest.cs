using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using API.Models;
using API.Input;

namespace Teste.models
{
    public class CampeonatoTest
    {
        [Fact]
        public void testeTorneioCom8Filmes()
        {
            FilmeInput filme1 = new  FilmeInput { Titulo = " Filme 1", Nota = 9 };
             FilmeInput  filme2 = new  FilmeInput { Titulo = " Filme 2", Nota = 4 };
             FilmeInput  filme3 = new  FilmeInput { Titulo = " Filme 3", Nota = 3 };
             FilmeInput  filme4 = new  FilmeInput { Titulo = " Filme 4", Nota = 2 };
             FilmeInput ganhador = new  FilmeInput { Titulo = " Filme 5", Nota = 10 };
             FilmeInput  filme6 = new  FilmeInput { Titulo = " Filme 6", Nota = 4 };
             FilmeInput  filme7 = new  FilmeInput { Titulo = " Filme 7", Nota = 6 };
             FilmeInput  filme8 = new  FilmeInput { Titulo = " Filme 8", Nota = 1 };

             FilmeInput[] filmes = { filme1, filme2, filme3, filme4, ganhador, filme6, filme7, filme8 };

            Campeonato camp = new Campeonato(filmes);

            var resultado = camp.Iniciar();

            Assert.Equal(ganhador.Titulo, resultado.Titulo);
        }
    }
}
