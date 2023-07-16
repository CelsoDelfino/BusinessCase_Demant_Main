using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeRequisicao.Domain.Model
{
    public class Requisicao
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public DateTime Data { get; set; }
        public string Cidade { get; set; }
        public string Descricao { get; set; }
        public RequisicaoStatusEnum RequisicaoStatus { get; set; }

        public enum RequisicaoStatusEnum
        {
            Recebida = 1,
            EmAndamento = 2,
            Concluida = 3
        }

    }
}
