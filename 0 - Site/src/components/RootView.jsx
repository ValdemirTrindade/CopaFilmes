import React from 'react';
import {Row, Col, Button} from 'react-materialize';
import Header from '../ui/Header';
import ItemFilme from '../ui/ItemFilme';
import FilmeLista from './../components/FilmeLista/FilmeLista';
import { Redirect } from 'react-router-dom';

const RootView = (props) =>
{
    if(props.redirect == true) return <Redirect to='/resultado' />
    return (
   <Row>
        <Col  offset="s1" s={10}>
            <Row>
             <Header subtitulo="CAMPEONATO DE FILMES" titulo="Fase de Seleção" descricao="Selecione 8 filmes que você deseja que entrem na competição e depois pressione o botão Gerar Meu Campeonato para prosseguir"></Header>
             <Col s={12}>
                <Col s={3}><p>Selecionados {props.filmes.length} de 8 filmes</p> </Col>
                <Col s={4} className="right"> <Button disabled={props.filmes.length != 8} onClick={() => props.handerSubmit()}>GERAR MEU CAMPEONATO</Button> </Col>
             </Col>
             <FilmeLista filmesSelecionados={props.filmes} handerPush={props.handerPush}/>
            </Row>
       </Col>
   </Row>
    );
}

export default RootView;