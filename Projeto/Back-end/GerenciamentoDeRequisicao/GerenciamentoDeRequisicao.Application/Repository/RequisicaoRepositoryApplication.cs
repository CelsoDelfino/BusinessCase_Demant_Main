using GerenciamentoDeRequisicao.Application.Repository.Interface;
using GerenciamentoDeRequisicao.Domain.Interface;
using GerenciamentoDeRequisicao.Domain.Model;

namespace GerenciamentoDeRequisicao.Application.Repository
{
    public class RequisicaoRepositoryApplication : IRequisicaoRepositoryApplication
    {
        private readonly IRequisicaoRepository _repository;
        public RequisicaoRepositoryApplication(IRequisicaoRepository repository)
        {
            _repository = repository;
        }

        public Requisicao Create(Requisicao requisicao)
        {
            return _repository.Create(requisicao);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<Requisicao> FindAll()
        {
            return _repository.FindAll();
        }

        public Requisicao FindById(int id)
        {
            return _repository.FindById(id);
        }

        public Requisicao Update(Requisicao requisicao)
        {
            return _repository.Update(requisicao);
        }
    }
}
