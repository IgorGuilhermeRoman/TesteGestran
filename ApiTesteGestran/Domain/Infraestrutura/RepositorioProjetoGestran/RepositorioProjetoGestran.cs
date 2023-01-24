using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Infraestrutura.RepositorioProjetoGestran
{
    public class RepositorioProjetoGestran
    {
        public DadosCadastro GravarFornecedores(DadosCadastro dados)
        { return new DadosCadastro(); }

        public DadosCadastro UpdateFornecedores(DadosCadastro dados)
        { return new DadosCadastro(); }

        public DadosCadastroEndereco GravarEnderecoFornecedores(DadosCadastroEndereco dados)
        { return new DadosCadastroEndereco(); }

        public DadosCadastroEndereco UpdateEnderecoFornecedores(DadosCadastroEndereco dados)
        { return new DadosCadastroEndereco(); }

        public List<DadosCadastro> RecuperarFonecedor(int idFornecedor, string cnpj, string cidade)
        { return new List<DadosCadastro>(); }

        public List<DadosCadastro> RecuperarTodosFornecedores()
        { return new List<DadosCadastro>(); }

    }
}
