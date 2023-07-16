import React, { useEffect, useState } from "react";
import "./App.css";

import AtividadeForm from "./components/AtividadeForm";
import AtividadeLista from "./components/AtividadeLista";

import api from './api/requisicao';


function App() {
  const [atividades, setAtividades] = useState([]);
  const [requisicao, setRequisicao] = useState({id:0});

  const pegaTodasRequisicoes = async () =>{
    const response = await api.get('Requisicao');
    console.log(response.data);
    return response.data;
  }

  useEffect(()=>{
    const getAtividades = async() =>{
      const get =await pegaTodasRequisicoes();
      if(get) setAtividades(get);
    }
    getAtividades();
  },[])

  const addRequisicao = async (ativ) => {
    const response = await api.post('Requisicao', ativ);

    setAtividades([
      ...atividades,
      response.data
    ]);
  }

  const deletRequisicao = async (id) => {
    if (await api.delete(`Requisicao/${id}`)){
      const requisicoeFilter = atividades.filter((x) => x.id !== id);
      setAtividades([...requisicoeFilter]);
    }
  }

  function pegarAtividade(id) {
    const requisicoeFilter = atividades.filter((x) => x.id === id);
    setRequisicao(requisicoeFilter[0]);
  }

  function cancelarAtividade() {
    setRequisicao({ id: 0 });
  }

  const atualizarAtividade = async (ativ) => {
    const response = await api.put(`Requisicao`, ativ)

    setAtividades(
      atividades.map((item) => (item.id === ativ.id ? response.data : item))
    );
    setRequisicao({ id: 0 });
  }

  return (
    <>
      <AtividadeForm
        addRequisicao={addRequisicao}
        atualizarAtividade={atualizarAtividade}
        cancelarAtividade={cancelarAtividade}
        requisicaoSelecionada={requisicao}
        atividades={atividades}
      />
      <AtividadeLista
        atividades={atividades}
        deletRequisicao={deletRequisicao}
        pegarAtividade={pegarAtividade}
      />
    </>
  );
}

export default App;
