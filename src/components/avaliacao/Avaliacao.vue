<template>
    <div class="pagina">
        <div class="avaliacao">
            <input type="radio" id="star1" name="estrela" value="1" v-model="nota"><label for="star1"></label>
            <input type="radio" id="star2" name="estrela"><label for="star2"></label>
            <input type="radio" id="star3" name="estrela"><label for="star3"></label>
            <input type="radio" id="star4" name="estrela"><label for="star4"></label>
            <input type="radio" id="star5" name="estrela"><label for="star5"></label>

        </div>
        <div class="reclamacoes">
                <textarea rows="4" cols="37" name="comentario" v-model="coment">Comente sua avaliação do chat aqui!</textarea><br>
                <button class="botao avaliar" @click="avaliar">Avaliar</button>  
        </div> 
    </div>
</template>
<script>
export default{
  /*  data(){
        return{
            coment: "",
            nota: 1,
        },
    },
    methods :  {
        async avaliar(){
            try{
                let url = "http://localhost:55707/api/home/avaliacao";
                const response = await this.$http.post(url, {
                  nota: this.nomeGp,
                  comentario: this.coment});
                alert("Amigo adicionado com sucesso!")
              }catch (erro) {
              console.log(erro);
              alert(erro.body);
            }
        }
    }*/
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
.reclamacoes textarea{
    resize: none;
    position: absolute;
    margin-top: 480px;
    left: 810px;
}
.reclamacoes button{
    position: absolute;
    left: 1028px;
    margin-top: 535px;
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