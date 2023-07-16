import React, { useEffect, useState } from "react";

const requisicaoInicial = {
  id: 0,
  nomeCompleto: "",
  cidade: "",
  descricao: "",
  status: 0,
};

export default function AtividadeForm(props) {
  const [atividade, setAtividade] = useState(requisicaoAtual());

  function inputTextHandler(e) {
    const { name, value } = e.target;

    setAtividade({ ...atividade, [name]: value });
  }

  function requisicaoAtual() {
    if (props.requisicaoSelecionada.id !== 0) {
      return props.requisicaoSelecionada;
    } else {
      return requisicaoInicial;
    }
  }

  const handleSalvar = (e) => {};

  const handleCancelar = (e) => {
    e.preventDefault();

    props.cancelarAtividade();
    setAtividade(requisicaoInicial);   
  };

  const handleSubmit = (e) => {
    e.preventDefault();

    if (props.requisicaoSelecionada.id !== 0) {
      props.atualizarAtividade(atividade);
    } else {
      props.addRequisicao(atividade);
    }

    setAtividade(requisicaoInicial);
  };

  useEffect(() => {
    if (props.requisicaoSelecionada.id !== 0) {
      setAtividade(props.requisicaoSelecionada);
    }
  }, [props.requisicaoSelecionada]);

  return (
    <>
      <h1>Requisição {atividade.id !== 0 ? atividade.id : ""} </h1>
      <div>
        <form className="row g-3" onSubmit={handleSubmit}>
          <div className="col-md-4">
            <label className="form-label">Nome</label>
            <input
              className="form-control"
              name="nomeCompleto"
              id="nomeCompleto"
              onChange={inputTextHandler}
              type="text"
              placeholder="seu nome"
              value={atividade.nomeCompleto}
            />
          </div>

          <div className="col-md-2">
            <label className="form-label">Status</label>
            <select
              id="status"
              name="requisicaoStatus"
              value={atividade.requisicaoStatus}
              onChange={inputTextHandler}
              className="form-select"
            >
              <option defaultValue="0">Selecione</option>
              <option value="1">Recebida</option>
              <option value="2">Em andamento</option>
              <option value="3">Concluida</option>
            </select>
          </div>

          <div className="col-md-4">
            <label className="form-label">Cidade</label>
            <input
              className="form-control"
              id="cidade"
              name="cidade"
              onChange={inputTextHandler}
              value={atividade.cidade}
              type="text"
              placeholder="cidade"
            />
          </div>

          <div className="col-md-10">
            <label className="form-label">Descricao</label>
            <textarea
              className="form-control"
              id="descricao"
              typeof="text"
              name="descricao"
              value={atividade.descricao}
              onChange={inputTextHandler}
            />
          </div>

          <div className="col-12">
            {atividade.id === 0 ? (
              <button type="submit" className="btn btn-primary">
                adicionar requisicao
              </button>
            ) : (
              <>
                <button
                  type="submit"
                  className="btn btn-success me-2"
                  onClick={handleSalvar}
                >
                  Salvar
                </button>
                <button className="btn btn-warning" onClick={handleCancelar}>
                  Cancelar
                </button>
              </>
            )}
          </div>
        </form>
      </div>
    </>
  );
}
