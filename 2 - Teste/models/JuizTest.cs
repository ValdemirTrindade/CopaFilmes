using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using API.Models;

namespace Teste.models
{
    

    public class JuizTest
    {
        [Fact]
        public void testePartidaGanhar()
        {
            Juiz juiz = new Juiz();
            Filme vencedor = new Filme { Titulo = "Vencedor", Nota = 10.0f };
            Filme perdedor = new Filme { Titulo = "perdedor", Nota = 7.0f };
            Filme quemVenceu = juiz.quemGanhou(vencedor, perdedor);


            Assert.Equal(vencedor, quemVenceu);
        }

        [Fact]
        public void testePartidaEmpate()
        {
            Juiz juiz = new Juiz();
            Filme vencedor = new Filme { Titulo = "Vencedor 1", Nota = 5.0f };
            Filme perdedor = new Filme { Titulo = "Vencedor 2", Nota = 5.0f };
            Filme quemVenceu = juiz.quemGanhou(vencedor, perdedor);


            Assert.Equal(vencedor, quemVenceu);
        }

        [Fact]
        public void testePartidaEmpate2()
        {
            Juiz juiz = new Juiz();
            Filme vencedor = new Filme { Titulo = "B", Nota = 5.0f };
            Filme perdedor = new Filme { Titulo = "C", Nota = 5.0f };
            Filme quemVenceu = juiz.quemGanhou(perdedor, vencedor);


            Assert.Equal(vencedor, quemVenceu);
        }
    }
}
