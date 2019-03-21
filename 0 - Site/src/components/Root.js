import React, { Component } from 'react';
import  RootView  from './RootView';
import Service from './../service/Service';


class Root extends Component {

  

    constructor(props){
        super(props);
        this.state = { filmes:[], redirect: false }
        this.handerSubmit = this.handerSubmit.bind(this);
        this.handerPush = this.handerPush.bind(this);
    }

    render() {
        return <RootView {...this.state} handerSubmit={this.handerSubmit} handerPush={this.handerPush}/>
    }

    async handerSubmit() {
        try {
            let service = new Service();
           let result = await service.post(this.state.filmes)
           localStorage.setItem('resultado', JSON.stringify(result));
           this.setState({redirect:true});
        } catch(error){

            window.Materialize.toast(error, 10000)
        
        }
        
      
    }

    async handerPush(filme) {
     

        let filmes = this.state.filmes;

        if(filmes.includes(filme)){
         let filme2 =  filmes.filter(e => e.id != filme.id);
         
         this.setState({filmes: filme2});
        }
        else if(this.state.filmes.length >= 8) {
            this.forceUpdate();
            return;
        }
        else{
             filmes.push(filme);
             this.setState({filmes});

        }
  
    }
    
}

export default Root;