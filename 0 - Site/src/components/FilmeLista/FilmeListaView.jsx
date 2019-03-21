import React from 'react';
import {Row, Col} from 'react-materialize';
import ItemFilme from '../../ui/ItemFilme';


const FilmeListaView = (props) => (
   <Row>
       {props.filmes.map((e,i) => <ItemFilme key={i} filme={e} value={props.filmesSelecionados.filter(fs => fs.id == e.id).length == 1} disabled={props.filmesSelecionados.length >= 8} handerPush={props.handerPush} />) }
   </Row>
);

export default FilmeListaView;