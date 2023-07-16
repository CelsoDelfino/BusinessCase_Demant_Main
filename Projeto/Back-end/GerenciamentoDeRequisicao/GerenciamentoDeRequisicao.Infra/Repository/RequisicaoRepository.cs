using GerenciamentoDeRequisicao.Domain.Interface;
using GerenciamentoDeRequisicao.Domain.Model;
using GerenciamentoDeRequisicao.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeRequisicao.Infra.Repository
{
    public class RequisicaoRepository : IRequisicaoRepository
    {
        private readonly RequisicaoContext _context;
        public RequisicaoRepository(RequisicaoContext context)
        {
            _context = context;
        }

        public Requisicao Create(Requisicao requisicao)
        {
            try
            {
                _context.Requisicaos.Add(requisicao);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }

            return requisicao;
        }

        public void Delete(int id)
        {
            var checkId = _context.Requisicaos.SingleOrDefault(_ => _.Id.Equals(id));

            if (checkId != null)
            {
                try
                {
                    _context.Requisicaos.Remove(checkId);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        public bool Exists(int id)
        {
            return _context.Requisicaos.Any(_=>_.Id == id); 
        }

        public List<Requisicao> FindAll()
        {
            return _context.Requisicaos.ToList();
        }

        public Requisicao FindById(int id)
        {
            return _context.Requisicaos.SingleOrDefault(_ => _.Id.Equals(id));
        }

        public Requisicao Update(Requisicao requisicao)
        {
            if (!Exists(requisicao.Id)) return null;

            var checkId = _context
                .Requisicaos
                .SingleOrDefault(_ => _.Id == requisicao.Id);

            if (checkId != null)
            {
                try
                {
                    _context.Entry(checkId).CurrentValues.SetValues(requisicao);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw;
                }
            }

            return requisicao;
        }
    }
}
