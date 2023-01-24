//using Microsoft.AspNetCore.Http;
using Domain.Entidades;
using Domain.Infraestrutura.RepositorioProjetoGestran;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Web.Http;

namespace ApiTesteGestran.Controllers
{
    [RoutePrefix("Gestran")]
    [ApiController]
    public class GestranController : ApiController
    {
        string stringConnection = "";

        [Microsoft.AspNetCore.Mvc.Route("CadastrarFornecedores"), Microsoft.AspNetCore.Mvc.HttpPost]   
        public HttpResponseMessage CadastrarFornecedores(DadosCadastro dados) 
        {
            var retorno = new ServicoDeDominioProjetoGestran(stringConnection).CadastrarFornecedores(dados);
            return Request.CreateResponse(HttpStatusCode.OK,retorno);
        }

        [Microsoft.AspNetCore.Mvc.Route("CadastrarEnderecoFornecedores"), Microsoft.AspNetCore.Mvc.HttpPost]
        public HttpResponseMessage CadastrarEnderecoFornecedores(DadosCadastroEndereco dados)
        {
            var retorno = new ServicoDeDominioProjetoGestran(stringConnection).CadastrarEnderecoFornecedores(dados);
            return Request.CreateResponse(HttpStatusCode.OK, retorno);
        }

        [Microsoft.AspNetCore.Mvc.Route("RecuperarFornecedores"), Microsoft.AspNetCore.Mvc.HttpPost]
        public HttpResponseMessage RecuperarFornecedores(int idFornecedor = 0, string cnpj = "", string cidade = "")
        {
            var retorno = new ServicoDeDominioProjetoGestran(stringConnection).RecuperarFornecedores(idFornecedor,cnpj,cidade);
            return Request.CreateResponse(HttpStatusCode.OK, retorno);
        }
    }
}
