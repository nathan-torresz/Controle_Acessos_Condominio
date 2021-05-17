using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_Condominio
{
    public enum TipoAcesso
    {
        Negado, Permitido, Desativado,
    }
    class Acesso
    {
        private static int _numeroAcessos = 0;
        public static int NumeroAcessos { get => _numeroAcessos; private set => _numeroAcessos = value; }
        private Pessoa pessoa;
        private TipoAcesso _tipoAcesso;
        public Pessoa Pessoa { get => pessoa; private set => pessoa = value; }
        public TipoAcesso TipoAcesso { get => _tipoAcesso; private set => _tipoAcesso = value; }

        public Acesso(Pessoa pessoa, TipoAcesso tipoAcesso)
        {
            Pessoa = pessoa;
            TipoAcesso = tipoAcesso;
            if (this.TipoAcesso == TipoAcesso.Permitido) NumeroAcessos++;
        }
    }
}
