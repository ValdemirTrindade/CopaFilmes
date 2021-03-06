﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    class Fase
    {
        private Partida[] partidas;
        private Juiz juiz;
        private Filme ganhador;
       

        public Fase(params Filme[] filmes)
        {
            juiz = new Juiz();
            Filme[] filmeOrdenado = juiz.ordenar(filmes);

            montarPartidas(filmeOrdenado);
           
        }

        public Partida[] getPartidas()
        {
            return (Partida[]) this.partidas.Clone();
        }

        private void montarPartidas(Filme[] filmes)
        {
            this.partidas = new Partida[filmes.Length / 2];

            for (int x = 0, y = filmes.Length - 1; x < partidas.Length; x++, y--)
            {
                int rodada = x + 1;
                this.partidas[x] = new Partida(juiz, filmes[x], filmes[y], rodada);
            }
        }

        public Filme[] comecar()
        {
            Filme[] vencedores = new Filme[this.partidas.Length];

            int contador = 0;
            foreach(Partida p in this.partidas)
            {
               vencedores[contador] = p.comecarPartida();
               contador++;
            }

            return vencedores;
        }

        private void montarPartidaParaProximaFase(Filme[] filmes)
        {
            this.partidas = null;
            this.partidas = new Partida[filmes.Length / 2];

            for (int x = 0, rodada = 1; x < filmes.Length; x += 2, rodada++)
            {
                this.partidas[rodada-1] = new Partida(juiz, filmes[x], filmes[x+1], rodada);
            }
        }

        public bool proximaFase(Filme[] filmes)
        {
            if (filmes.Length == 1)
            {
                this.ganhador = filmes[0];
              
                return false;
            }
            montarPartidaParaProximaFase(filmes);

            return true;
        }

        public Filme getGanhador()
        {
            return this.ganhador;
        }

       
    }
}
