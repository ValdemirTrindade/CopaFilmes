import React from 'react';
import {Col, CardPanel, Row} from 'react-materialize';
import injectSheet from 'react-jss';
import { Redirect } from 'react-router-dom';

const styles = {
    pos: {
     textAlign: "center",
     fontSize: "32px !important",
     color: "black"
    }
  };


const Classificacao = (props) => (
    <Col s={12}>
        <CardPanel className="purple lighten-3 black-text">
        <Row>
          <Col s={3} ><label className={props.classes.pos}>{props.classificacao}</label></Col>
          <Col s={9}><label className={props.classes.pos}>{props.titulo}</label></Col>
          </Row>
        </CardPanel>
    </Col>
    
);

export default injectSheet(styles)(Classificacao);