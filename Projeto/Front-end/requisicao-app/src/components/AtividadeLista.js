import React from 'react'
import Atividade from './Atividade';

export default function AtividadeLista(props) {
  return (
    <div className="mt-3">
          {props.atividades.map((x) => (
            <Atividade
              key={x.id}
              x={x}
              deletRequisicao={props.deletRequisicao}
              pegarAtividade={props.pegarAtividade}
            />
          ))}
      </div>
  )
}
