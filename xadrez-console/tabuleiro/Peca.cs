using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro {
    class Peca {

        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qdtMovimentos { get; protected set; }
        public Tabuleiro tab { get; set; }

        public Peca(Tabuleiro tab, Cor cor) {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qdtMovimentos = 0;
        }
    }
}
