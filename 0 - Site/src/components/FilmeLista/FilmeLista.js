import React, { Component } from 'react';
import FilmeListaView  from './FilmeListaView';
import Service from './../../service/Service';

class FilmeLista extends Component {
    constructor(props){
        super(props);
        this.state = {filmes: []};
    }

    async componentWillMount(){
        try{
            let service = new Service();
           let filmes = await service.get();
           this.setState({filmes});
        }catch(error){
            console.log(error);
        }
    }

    render() {
        return <FilmeListaView {...this.state} filmesSelecionados={this.props.filmesSelecionados} handerPush={this.props.handerPush} />
    }
}

export default FilmeLista;