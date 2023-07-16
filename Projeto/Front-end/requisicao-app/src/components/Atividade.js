import React from "react";

export default function Atividade(props) {
 
  function converteStatus(selectStatus) {
    switch (selectStatus) {
      case "Recebida":
      case "EmAndamento":
      case "Concluida":
        return selectStatus;
      default:
        return "nao definido";
    }
  }

  return (
    <div className="card mb-2 shadow-sm">
      <div className="card-body">
        <div className="d-flex justify-content-between">
          <h5 className="card-tittle">
            <span className="badge text-bg-secondary me-2">{props.x.id}</span>
            Cliente: {props.x.nomeCompleto}
          </h5>
          <h6 className="">
            Status: <i className="ms-1">{converteStatus(props.x.requisicaoStatus)}</i>
          </h6>
        </div>
        <h5 className="card-title">{props.x.cidade}</h5>
        <p className="card-text">{props.x.descricao}</p>

        <div className="d-flex justify-content-end border-top">
          <button
            className="btn btn-outline-primary"
            onClick={() => props.pegarAtividade(props.x.id)}
          >
            Editar
          </button>
          <button
            className="btn btn-outline-danger ms-2"
            onClick={() => props.deletRequisicao(props.x.id)}
          >
            Excluir
          </button>
        </div>
      </div>
    </div>
  );
}
