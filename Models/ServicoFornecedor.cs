using SolicitaCompra.Models;

namespace SolicitaCompra
{
    public class ServicoFornecedor
    {
        public Fornecedores oFornecedores { get; set; }

        public List<Fornecedores> oListFornecedores { get; set; }

        public List<Servicos> oListServicos { get; set; }

        public Servicos oServicos { get; set; }


        public DateTime DataPrazo { get; set; }
      
        



    }
}
