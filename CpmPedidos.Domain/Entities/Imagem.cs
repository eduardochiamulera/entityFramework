using System;

namespace CpmPedidos.Domain
{
    //entidade "FRACA", precisa de produto para existir
    public class Imagem : BaseDomain
    {
        public string Nome { get; set; }
        public string NomeArquivo { get; set; }
        public bool Principal { get; set; }
    }
}
