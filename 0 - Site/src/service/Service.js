class Service {
    async post(input) {
        return await fetch("http://localhost:5000/api/campeonato", {
                method:'POST',
                headers: new Headers({
                    'Accept': 'application/json',
                    'Content-Type': "application/json"
                }),
                body: JSON.stringify(input)
            }).then((res) => res.json())
            .catch((e) => { throw "erro no servidor"});
    }

    async get() {
        return await fetch("https://copadosfilmes.azurewebsites.net/api/filmes").then((res) => res.json())
        .catch((e) => {throw "erro no servidor"});
    }
}

export default Service;