using GerenciamentoDeRequisicao.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeRequisicao.Application.Repository.Interface
{
    public interface IRequisicaoRepositoryApplication
    {
        Requisicao Create(Requisicao requisicao);

        Requisicao FindById(int id);
        Requisicao Update(Requisicao requisicao);
        void Delete(int id);

        List<Requisicao> FindAll();
    }
}
