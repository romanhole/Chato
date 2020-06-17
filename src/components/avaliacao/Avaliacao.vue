<template>
    <div class="pagina">
        <div class="avaliacao">
            <input type="radio" id="star1" name="estrela" @click="darNota(5)"><label for="star1"></label>
            <input type="radio" id="star2" name="estrela" @click="darNota(4)"><label for="star2"></label>
            <input type="radio" id="star3" name="estrela" @click="darNota(3)"><label for="star3"></label>
            <input type="radio" id="star4" name="estrela" @click="darNota(2)"><label for="star4"></label>
            <input type="radio" id="star5" name="estrela"  @click="darNota(1)"><label for="star5"></label>

        </div>
        <div class="reclamacoes">
            <p id="mda">Media das avaliações: </p>
            <textarea rows="4" cols="37" name="comentario" v-model="coment">Comente sua avaliação do chat aqui!</textarea><br>
            <button class="botao avaliar" @click="avaliar">Avaliar</button>  
        </div> 
    </div>
</template>
<script>
export default{
    data(){
        return{
            coment: "",
            not: "0",
        };
    },

    methods : {
        darNota(estrela){
            this.not=estrela
        },
        async avaliar(){
            try{
                let url = "http://localhost:55707/api/home/avaliacao";
                console.log(this.not)
                console.log(parseInt(this.not))
                const response = await this.$http.post(url, {
                  nota: parseInt(this.not),
                  comentario: this.coment});
                alert("Obrigado por avaliar nosso site!")
              }catch (erro) {
              console.log(erro);
              alert(erro.body);
            }
        },
        async getAvaliacoes(){       
            try{
                let url = "http://localhost:55707/api/home/getAvaliacoes";
                const response = await this.$http.get(url);
                let elem = 0;
                let soma = 0;
                response.data.forEach(avaliacao => {
                    soma += avaliacao.nota;
                    elem++;
                });
                let media = soma/elem;
                document.getElementById("mda").innerHTML += media;
            }   
            catch(erro){console.log(erro)}
        },
    },
    mounted(){
        this.getAvaliacoes();
    }
}
</script>
<style>
@import url(https://use.fontawesome.com/releases/v5.5.0/css/all.css);
body{
    padding: 0;
    margin: 0;
    background: #1f9cf1;
}

.avaliacao{
    position: absolute;
    top: 45%;
    left: 50%;
    transform: translate(-50%, -50%) rotateY(180deg);
    display: flex;
}

.avaliacao label{
    display: block;
    cursor: pointer;
    width: 60px;
    padding-left: 10px;
}

.avaliacao label::before{
    content: '\f005';
    font-family: 'Font Awesome 5 Free';
    font-weight: 900;
    position: relative;
    display: block;
    font-size: 50px;
    color: #1d1c1d;
}
.avaliacao label::after{
    content: '\f005';
    font-family: 'Font Awesome 5 Free';
    font-weight: 900;
    font-size: 50px;
    position: absolute;
    top: 0;
    opacity: 0;
    display: block;
    color: goldenrod;
    transition: 0.5s;
    text-shadow: 0 2px 5px rgba(0, 0, 0, 0.5);
}
.avaliacao input{
    display: none;
}
.avaliacao label:hover::after, 
.avaliacao label:hover ~ label::after,
.avaliacao input:checked ~ label::after{
    opacity: 1;
}
.reclamacoes{
    font-family: 'Roboto', sans-serif;
    font-size: 15px;
}
#mda{
    position: absolute;
    margin-top: 465px;
    left: 795px;
    font-size: 23px;
}
.reclamacoes textarea{
    resize: none;
    position: absolute;
    margin-top: 500px;
    left: 795px;
}
.reclamacoes button{
    position: absolute;
    left: 1013px;
    margin-top: 555px;
    width: 60px;
    height: 30px;
    border-radius:5px;
    border: 1px solid black;
    background-color: #e3baba;
    cursor: pointer;
}
.reclamacoes button:hover{
    background-color: #f2ebeb;
}
</style>