using GerenciamentoDeRequisicao.Domain.Model;
using System.Runtime.CompilerServices;
using static GerenciamentoDeRequisicao.Domain.Model.Requisicao;

namespace GerenciamentoDeRequisicao.API.DTO
{
    public class RequisicaoModel
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public DateTime Data { get; set; }
        public string Cidade { get; set; }
        public string Descricao { get; set; }
        public RequisicaoStatusEnum requisicaoStatus { get; set; }

        public static RequisicaoModel converteParaModel(Requisicao requisicao)
        {
            return new RequisicaoModel
            {
                Id = requisicao.Id,
                NomeCompleto = requisicao.NomeCompleto,
                Data = requisicao.Data,
                Cidade = requisicao.Cidade,
                Descricao = requisicao.Descricao,
                requisicaoStatus = requisicao.RequisicaoStatus
            };
        }

        public Requisicao ConverterParaEntidade()
        {
            return new Requisicao
            {
                Id = this.Id,
                NomeCompleto = this.NomeCompleto,
                Data = DateTime.Now,
                Cidade = this.Cidade,
                Descricao = this.Descricao,
                RequisicaoStatus = this.requisicaoStatus
            };
        }
     
    }
}
