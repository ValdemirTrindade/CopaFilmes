import React from 'react';
import {Row, Col, Footer} from 'react-materialize';
import Header from './../../ui/Header';
import Classificacao from '../../ui/Classificacao';
import { Link } from "react-router-dom";


const Resultado = (props) =>{

    let resultado = JSON.parse(localStorage.getItem('resultado'));
    console.log("resultado", resultado);
 return    (
   <Row>
        <Col  offset="s1" s={10}>
            <Row>
             <Header subtitulo="CAMPEONATO DE FILMES" titulo="Resultado Final" descricao="Veja o resultado final do Campeonato de filmes de forma simples e rápida"></Header>
             <Classificacao classificacao="1" titulo={resultado.primeiroLugar}/>
             <Classificacao classificacao="2" titulo={resultado.segundoLugar}/>
            </Row>

            <Footer className="white"><Link to="/">Voltar para o inicio</Link></Footer>
       </Col>
   </Row>
);

}
export default Resultado;