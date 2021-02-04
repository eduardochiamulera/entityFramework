using CpmPedidos.Domain;
using System.Collections.Generic;

namespace CpmPedidos.Interface
{
    public interface ICidadeRepository
    {
        dynamic Get();
        public int Criar(CidadeDTO model);
        public int Alterar(CidadeDTO model);
        public bool Excluir(int id);
    }
}
