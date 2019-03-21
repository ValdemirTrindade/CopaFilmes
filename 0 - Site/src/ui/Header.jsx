import React from 'react';
import {Col, CardPanel} from 'react-materialize';
import injectSheet from 'react-jss'

const styles = {
    titulo: {
     textAlign: "center"
    }
  };


const Header = (props) => (
    <Col s={12}>
        <CardPanel className="teal lighten-4 black-text">
           <p className={props.classes.titulo}>{props.subtitulo}</p>
           <h5 className={props.classes.titulo}>{props.titulo}</h5>
           <p className={props.classes.titulo}>{props.descricao}</p>
        </CardPanel>
    </Col>
    
);

export default injectSheet(styles)(Header);