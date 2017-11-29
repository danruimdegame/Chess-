using System;
using CAMPO_DE_BATALHA;

namespace CHESS
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor) { }

        public override string ToString()
        {
            return "T";
        }
    }
}
