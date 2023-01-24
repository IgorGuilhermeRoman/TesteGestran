using Domain.Entidades;
using Domain.Infraestrutura.RepositorioProjetoGestran;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dominio
{
    public class ServicoDeDominioProjetoGestran
    {
        string stringConnection = "";

        public ServicoDeDominioProjetoGestran(string stringConnection)
            => this.stringConnection = stringConnection;

        public DadosCadastro CadastrarFornecedores(DadosCadastro dados)
        {
            DadosCadastro retorno = new DadosCadastro();

            if (dados.Id != 0)
                retorno = new RepositorioProjetoGestran().UpdateFornecedores(dados);
            else
                retorno = new RepositorioProjetoGestran().GravarFornecedores(dados);

            return retorno;
        }

        public DadosCadastroEndereco CadastrarEnderecoFornecedores(DadosCadastroEndereco dados)
        {
            DadosCadastroEndereco retorno = new DadosCadastroEndereco();

            if (dados.Id != 0)
                retorno = new RepositorioProjetoGestran().UpdateEnderecoFornecedores(dados);
            else
                retorno = new RepositorioProjetoGestran().GravarEnderecoFornecedores(dados);

            return retorno;
        }

        public List<DadosCadastro> RecuperarFornecedores(int idFornecedor, string cnpj, string cidade)
        {
            List<DadosCadastro> retorno = new List<DadosCadastro>();

            if (idFornecedor != 0)
                retorno = new RepositorioProjetoGestran().RecuperarFonecedor(idFornecedor, cnpj, cidade);
            else
                retorno = new RepositorioProjetoGestran().RecuperarTodosFornecedores();

            return retorno;
        }
    }
}
