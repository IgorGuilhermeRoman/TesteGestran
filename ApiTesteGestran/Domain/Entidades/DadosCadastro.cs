using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades
{
    public class DadosCadastro
    {
        public int Id { get; set; }
        public int IdEndereco { get; set; }
        public string NomeFornecedor { get; set; }
        public string CnpjFornecedor { get; set; }
        public string TelefoneFornecedor { get; set; }
        public string EmailFornecedor { get; set; }
        //public List<DadosCadastroEndereco> Enderecos { get; set; }

    }


}
