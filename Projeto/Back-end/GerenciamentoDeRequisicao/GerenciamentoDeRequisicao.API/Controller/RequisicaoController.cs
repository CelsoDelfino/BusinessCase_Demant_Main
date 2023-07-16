using GerenciamentoDeRequisicao.API.DTO;
using GerenciamentoDeRequisicao.Application.Repository.Interface;
using GerenciamentoDeRequisicao.Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace GerenciamentoDeRequisicao.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequisicaoController : ControllerBase
    {
        private readonly IRequisicaoRepositoryApplication _repository;

        public RequisicaoController(IRequisicaoRepositoryApplication repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_repository.FindAll());   
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            //faco a consulta no domain
            var checkId = _repository.FindById(id);

            if (checkId == null) 
                return NotFound();

            //exponho no DTO
            var idConvertido = RequisicaoModel.converteParaModel(checkId);

            return Ok(idConvertido); 
        }

        [HttpPost]
        public IActionResult Post([FromBody] RequisicaoModel requisicaoModel)
        {
            if (requisicaoModel == null)
                return BadRequest();

            return Ok(_repository.Create(requisicaoModel.ConverterParaEntidade()));
        }

        [HttpPut]
        public IActionResult Put([FromBody] RequisicaoModel requisicaoModel)
        {
            if (requisicaoModel == null)
                return BadRequest();

            return Ok(_repository.Update(requisicaoModel.ConverterParaEntidade()));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return NoContent(); 
        }

    }
}
