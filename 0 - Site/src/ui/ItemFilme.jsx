import React from 'react';
import {Col, Input, Row} from 'react-materialize';
import injectSheet from 'react-jss';



const styles = {
   titulo: {
       marginTop:"-15px",
       color: "black",
       fontSize: "13px"
   }
  };


const ItemFilme = (props) => (
    <div id="col-item-Filme" class="col s3" >
         <Input  type='checkbox' checked={props.value}  onChange={() => props.handerPush(props.filme)} disabled={props.disabled && !props.value} label={<div className={props.classes.titulo}>{props.filme.titulo}<div><label>{props.filme.ano}</label></div></div>}  />
    </div>
);


export default injectSheet(styles)(ItemFilme);