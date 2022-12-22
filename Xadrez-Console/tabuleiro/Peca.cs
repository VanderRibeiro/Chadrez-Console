﻿namespace tabuleiro
{
    abstract class Peca{

        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qteMovimentos = 0;
        }

        public void incrementarQteMovimentos()
        {
            this.qteMovimentos++;
        }

        public abstract bool[,] movimentosPossiveis();//vai ser abstract pq não tem a peça específica, eventualmente a classe também vai ser abstract

    }
}
