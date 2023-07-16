using GerenciamentoDeRequisicao.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeRequisicao.Infra.Data
{
    public class RequisicaoContext : DbContext
    {
        public RequisicaoContext(DbContextOptions<RequisicaoContext> options):base(options) { } 
        
        public DbSet<Requisicao> Requisicaos { get; set; }
    }
}
