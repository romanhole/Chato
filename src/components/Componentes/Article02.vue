<template>
<div id="todo">
  <div class="item article-02" :class="{ 'conversa-dados': abaDados}">
          <div class="right">
              <div class="right-01">
                  <input type="text" id="msg" placeholder="Digite sua mensagem:">
              </div>
              <div class="right-02">
                <!--<div v-for="message in messages" :key="message.Id" v-bind="message" :class="{['recebida']: message.recieved, ['enviada']: message.sended}">
                    <h1 v-if="message.grupo">{{ message.Nome }}</h1>
                    <p>{{ message.Text }}</p>
                </div>-->
                <div class="recebida">
                    <h1>João</h1>
                    <p>Ola, amigos tudo bem?</p>
                </div>
                <div class="mensagem enviada">
                    <h1></h1>
                    <p>orem ipsum dolor sit amet, consectetur adipiscing elit. Mauris in condimentum nulla. Mauris convallis nisl sed pharetra suscipit. Vivamus euismod pulvinar leo quis gravida. Curabitur in magna sem.</p>
                </div>
                <div class="enviada">
                    <h1></h1>
                    <p>Horas trabalhadas: 11h00</p>
                </div>
                <div class="enviada">
                    <h1></h1>
                    <p>Eai pessoal, tranquilos?</p>
                </div>
                <div class="recebida">
                    <h1>Marcelao</h1>
                    <p>Oba, pc quebro</p>
                </div>
                <div class="recebida">
                    <h1>Pires</h1>
                    <p>eai João? Você poderia me ajudar num negócio?</p>
                </div>
              </div>
              <div class="right-03" @click="dadosGrupo">
                    <img :src= "url3"/>
                    <div>
                        <p>{{nomeGrupo}}</p>
                        <p>João, Marcelao, Pires, Você</p>
                    </div>
              </div>
          </div>
      </div>
      <div class="item article-03" :class="{ 'dadosAberto': abaDados}" v-if="grupo">
          <div>
              <button @click="dadosGrupo"><font-awesome-icon :icon="['fas', 'times']" /></button>
              <p>Dados do grupo</p>
          </div>
          <div>
            <div>
                <div>
                <label for="select-file3">
                    <div :class="{'alterar-imagem3' : url3 == ''}">
                        <p>ADICIONAR NOVA IMAGEM AO GRUPO</p>
                    </div>
                    <img :src="url3" v-if="url3 != ''"/>
                </label>
                <input type="file" id="select-file3" @change="onFileChange3" style="display : none" />
            </div>
            </div>
            <div>
                <input type="text" :disabled = alterarEstado2 :class="{'alterar-nome2' : alterarNome2}" v-model="nomeGrupo">
                <button @click="changeName2"><font-awesome-icon :icon="['fas', 'edit']" v-if="alterarEstado2"/><font-awesome-icon :icon="['fas', 'check']" v-else/></button>
            </div>
            <div>
                <div>
                    <p>4 participantes</p>
                </div>
                <div>
                    <button><font-awesome-icon :icon="['fas', 'user-plus']"/></button>
                    <div>
                        <hr>
                        <p>Adicionar pessoas</p>
                    </div>
                </div>
                <div class="participantes" :class="{ 'participantesAberto': abaDados}">
                    <img src="../../assets/imgs/meuperfil.jpg"/>
                    <div>
                        <hr>
                        <p>Você</p>
                    </div>
                </div>
                <div class="participantes" :class="{ 'participantesAberto': abaDados}">
                    <img src="../../assets/imgs/meuperfil.jpg"/>
                    <div>
                        <hr>
                        <p>Pires</p>
                    </div>
                </div>
                <div class="participantes" :class="{ 'participantesAberto': abaDados}">
                    <img src="../../assets/imgs/meuperfil.jpg"/>
                    <div>
                        <hr>
                        <p>João</p>
                    </div>
                </div>
                <div class="participantes" :class="{ 'participantesAberto': abaDados}">
                    <img src="../../assets/imgs/meuperfil.jpg"/>
                    <div>
                        <hr>
                        <p>Marcelao</p>
                    </div>
                </div>
            </div>
            <div>
                <button><font-awesome-icon :icon="['fas', 'door-open']" /></button>
                <p>Sair do grupo</p>
            </div>
          </div>
      </div>
      <div class="item article-04" :class="{ 'dadosAbertoAmigo': abaDados}" v-else>
            <div>
              <button @click="dadosGrupo"><font-awesome-icon :icon="['fas', 'times']" /></button>
              <p>Dados do amigo</p>
            </div>
            <div>
                <img :src= "urlAmigo"/>
            </div>
            <div>
                <p>Juan</p>
                <p>ID: 13123</p>
            </div>
            <div>
                <button><font-awesome-icon :icon="['fas', 'user-times']" /></button>
                <p>Desfazer amizade</p>
            </div>
      </div>
</div>
</template>

<script>
export default {
    data(){
        return{
            messages:[],
            abaDados: false,
            nomeGrupo: "",
            url3:"",
            alterarEstado2: true,
            alterarNome2: false,
            grupo: true,
            urlAmigo: "../../assets/imgs/meuperfil.jpg"
        }
    },
    methods:{
        dadosGrupo(){
            this.abaDados = !this.abaDados;
        },
        dadosGrupo(){
            this.abaDados = !this.abaDados;
        },
        onFileChange3(e) {
            const file3 = e.target.files[0];
            this.url3 = URL.createObjectURL(file3);
        },
        changeName2(){
            this.alterarNome2 = !this.alterarNome2;
            this.alterarEstado2 = !this.alterarEstado2;
        },
    },
    name: 'Article02'
}
</script>

<style scoped>
 @-webkit-keyframes fade {
    0% {
        opacity: 0;
    }
    75% {
        opacity: 0;
    }
    100% {
        opacity: 1;
    }
}

@keyframes fade {
    0% {
        opacity: 0;
    }
    75% {
        opacity: 0;
    }
    100% {
        opacity: 1;
    }
}
.article-02{
    width: 100%;
    height: 100%;
    background-color: #f0f0f0;
    transition: all .4s;
    z-index: 9;
}
.conversa-dados{
    width: 60%;
}
.right{
    display: flex;
    flex-direction: column-reverse;
    justify-content: space-between;
    width: 100%;
    height: 100%;
}
#msg{
    /*width: 750px;*/
    width: 100%;
    height: 35px;
    border-radius: 7px;
    border-style: none;
    outline: none;
    font-size: 15px;
    padding: 10px;
}
.right-01{
    display: flex;
    flex-direction: row;
    width: 100%;
    height: 60px;
    background-color: lightgrey;
    justify-content: center;
    align-items: center;
    padding: 0 45px;
}
.right-02{
    height: 680px;
    width: 100%;
    display: flex;
    flex-direction: column;
    align-items: flex-start;
    justify-content: flex-start;
    padding: 15px;
    overflow-y: scroll;
}
.right-02>div{
    display: flex;
    flex-direction: column;
    max-width: 40%;
    background-color: white;
    padding: 10px;
    border-radius: 10px;
    margin-bottom: 10px;
}
.right-02>div h1{
    font-size: 17px;
    color: blue;
    margin-bottom: 3px;
}
.right-02>div p{
    text-align: justify;
}
.recebida{
    align-self: flex-start;
}
.enviada{
    align-self: flex-end;
}
.right-03{
    height: 60px;
    background-color: lightgray;
    cursor: pointer;
    width: 100%;
    display: flex;
    align-items: center;
    padding: 15px;
}
.right-03>div{
    display: flex;
    flex-direction: column;
    justify-content:space-between;
}
.right-03>img{
    width: 40px;
    height: 40px;
    border-radius: 50%;
    margin-right: 15px;
}
.right-03>div>p:nth-child(1){
    font-size: 16px;
    color: black;
}
.right-03>div>p:nth-child(2){
    font-size: 13px;
    color: rgba(0, 0, 0, 0.493);
}





.right-02::-webkit-scrollbar{
    background-color:#f0f0f0;
    width:16px

}
.left-03::-webkit-scrollbar, .article-03>div:nth-child(2)::-webkit-scrollbar{
    background-color:#8B0000;
    width:16px
}

/* background of the scrollbar except button or resizer */
.right-02::-webkit-scrollbar-track {
    background-color:#f0f0f0;
}
.left-03::-webkit-scrollbar-track, .article-03>div:nth-child(2)::-webkit-scrollbar-track {
    background-color:#8B0000;
}
.right-02::-webkit-scrollbar-track:hover {
    background-color:#f0f0f0;
}
.left-03::-webkit-scrollbar-track:hover, .article-03>div:nth-child(2)::-webkit-scrollbar-track:hover {
    background-color:#8B0000;
}

/* scrollbar itself */
.right-02::-webkit-scrollbar-thumb{
    background-color:#babac0;
    border-radius:16px;
    border:5px solid #f0f0f0;
}
.left-03::-webkit-scrollbar-thumb, .article-03>div:nth-child(2)::-webkit-scrollbar-thumb {
    background-color:rgb(100, 1, 1);
    border-radius:16px;
    border:5px solid #8B0000;
}
.right-02::-webkit-scrollbar-thumb:hover {
    background-color:#babac0;
    border:4px solid #f0f0f0;
}
.left-03::-webkit-scrollbar-thumb:hover, .article-03>div:nth-child(2)::-webkit-scrollbar-thumb:hover {
    background-color:rgb(100, 1, 1);
    border:4px solid #8B0000;
}
.article-03{
    width: 0;
    height: 100%;
    background-color: #8B0000;
    transition: all .4s;
    visibility: hidden;
    display: flex;
    flex-direction: column;
    z-index: 99;
}
.dadosAberto{
    width: 40%;
    visibility: visible;
}
.article-03>div:nth-child(1){
    display: flex;
    background-color: rgb(100, 1, 1);
    height: 60px;
    align-items: center;
    padding: 25px;
    color: white;
}
.article-03>div:nth-child(1)>button{
    margin-right: 25px;
    opacity: 0;
    visibility: hidden;
    transition: opacity .5s;
    background-color: transparent;
    border: none;
    outline: none;
    color: white;
    font-size: 20px;
    cursor: pointer;
}
.dadosAberto>div:nth-child(1)>button{
    visibility: visible;
    opacity: 1;
    -webkit-animation: fade .5s;
    animation: fade .5s;
}
.article-03>div:nth-child(1)>p{
    opacity: 0;
    visibility: hidden;
    transition: opacity .5s;
}
.dadosAberto>div:nth-child(1)>p{
    visibility: visible;
    opacity: 1;
    -webkit-animation: fade .5s;
    animation: fade .5s;
}
.article-03>div:nth-child(2){
    width: 100%;
    overflow-x: hidden;
    overflow-y: scroll;
    display: flex;
    flex-direction: column;
    height: 680px;
}
.article-03>div:nth-child(2)>div:nth-child(1){
    height: 250px;
    background-color: rgb(158, 0, 0);
    display: flex;
    align-items: center;
}
.article-03>div:nth-child(2)>div:nth-child(1)>div{
    width: 100%;
    height: 100%;
    display: flex;
    align-items: center;
    justify-content: center;
    justify-content: center;
    opacity: 0;
    visibility: hidden;
    transition: opacity .4s;
}
.dadosAberto>div:nth-child(2)>div:nth-child(1)>div{
    visibility: visible;
    opacity: 1;
    -webkit-animation: fade .4s;
    animation: fade .4s;
}
.article-03>div:nth-child(2)>div:nth-child(1)>div>label{
    width: 100%;
    height: 100%;
    max-width: 190px;
    max-height: 190px;
    border-radius: 50%;
    cursor: pointer;
    background: lightgray;
    display: flex;
    align-items: center;
    justify-content: center;
    position: relative;
}
.article-03>div:nth-child(2)>div:nth-child(1)>div>label>div{
    visibility: hidden;
    width: 100%;
    height: 100%;
    font-size: 13px;
    text-align: center;
    position: absolute;
    z-index: 99;
    background-color: rgba(173, 173, 173, 0.603);
    border-radius: 50%;
    display: flex;
    justify-content: center;
    align-items: center;
}
.article-03>div:nth-child(2)>div:nth-child(1)>div>label:hover>div{
    visibility: visible;
}
.alterar-imagem3{
    visibility: visible;
}
.article-03>div:nth-child(2)>div:nth-child(1)>div>label>img{
    z-index: 9;
    width: 100%;
    height: 100%;
    max-width: 190px;
    max-height: 190px;
    border-radius: 50%;
}
.article-03>div:nth-child(2)>div:nth-child(2){
    display: flex;
    background-color: rgb(158, 0, 0);
    justify-content: space-between;
    padding: 20px;
    color: white;
    font-size: 20px;
    margin-bottom: 12px;
}
.article-03>div:nth-child(2)>div:nth-child(2)>button{
    background-color: transparent;
    border: none;
    font-size: 20px;
    outline: none;
    color: white;
    opacity: 0;
    visibility: hidden;
    transition: opacity .5s;
}
.dadosAberto>div:nth-child(2)>div:nth-child(2)>button{
    visibility: visible;
    opacity: 1;
    -webkit-animation: fade .5s;
    animation: fade .5s;
}
.article-03>div:nth-child(2)>div:nth-child(2)>input{
    border: none;
    background-color: transparent;
    outline: none;
    font-size: 15px;
    width: 100%;
    color: white;
    font-size: 20px;
    opacity: 0;
    visibility: hidden;
    transition: opacity .5s;
}
.dadosAberto>div:nth-child(2)>div:nth-child(2)>input{
    visibility: visible;
    opacity: 1;
    -webkit-animation: fade .5s;
    animation: fade .5s;
}
.alterar-nome2{
    border-bottom: 1px solid black !important;
}
.article-03>div:nth-child(2)>div:nth-child(3){
    background-color: rgb(158, 0, 0);
    display: flex;
    flex-direction: column;
    margin-bottom: 12px;
}
.article-03>div:nth-child(2)>div:nth-child(3)>div:nth-child(1){
    color: lightskyblue;
    padding: 20px;
    align-items: center;
    font-size: 14px;
    position: relative;
    opacity: 0;
    visibility: hidden;
    transition: opacity .5s;
}
.dadosAberto>div:nth-child(2)>div:nth-child(3)>div:nth-child(1){
    visibility: visible;
    opacity: 1;
    -webkit-animation: fade .5s;
    animation: fade .5s;
}
.article-03>div:nth-child(2)>div:nth-child(3)>div:nth-child(2){
    opacity: 0;
    visibility: hidden;
    transition: opacity .5s;
    position: relative;
    display: flex;
    align-items: center;
    cursor: pointer;
    padding: 20px;
    color: white;
}
.article-03>div:nth-child(2)>div:nth-child(3)>div:nth-child(2):hover{
    background-color: rgb(100, 1, 1);
}
.dadosAberto>div:nth-child(2)>div:nth-child(3)>div:nth-child(2){
    visibility: visible;
    opacity: 1;
    -webkit-animation: fade .5s;
    animation: fade .5s
}
.article-03>div:nth-child(2)>div:nth-child(3)>div:nth-child(2)>button{
    color: white;
    background-color: transparent;
    border: none;
    user-select: none;
    outline: none;
    cursor: pointer;
    margin-right: 10px;
    width: 50px;
    height: 50px;
    border-radius: 50%;
    margin-right: 15px;
    font-size: 20px;
}
.article-03>div:nth-child(2)>div:nth-child(3)>div:nth-child(2)>div{
    height: 100%;
    color: white;
    font-size: 18px;
}
.article-03>div:nth-child(2)>div:nth-child(3)>div:nth-child(2)>div>hr{
    position: absolute;
    top: 0px;
    right: 0px;
    width: 80%;
    border: 0px;
    background-color: rgba(100, 1, 1, 0.5);
    height: 1px;
}
.participantes{
    display: flex;
    padding: 20px;
    align-items: center;
    position: relative;
    cursor: pointer;
    opacity: 0;
    visibility: hidden;
    transition: opacity .5s;
}
.participantesAberto{
    visibility: visible;
    opacity: 1;
    -webkit-animation: fade .5s;
    animation: fade .5s;
}
.participantes:hover{
    background-color: rgb(100, 1, 1);
}
.participantes>img{
    width: 50px;
    height: 50px;
    border-radius: 50%;
    margin-right: 15px;
}
.participantes>div{
    height: 100%;
    color: white;
    font-size: 18px;
}
.participantes>div>hr{
    position: absolute;
    top: 0px;
    right: 0px;
    width: 80%;
    border: 0px;
    background-color: rgba(100, 1, 1, 0.5);
    height: 1px;
}
.article-03>div:nth-child(2)>div:nth-child(4){
    display: flex;
    background-color: rgb(158, 0, 0);
    padding: 20px;
    color: rgb(255, 85, 55);
    cursor: pointer;
}
.article-03>div:nth-child(2)>div:nth-child(4):hover{
    background-color: rgb(100, 1, 1);
}
.article-03>div:nth-child(2)>div:nth-child(4)>button{
    margin-right: 40px;
    opacity: 0;
    visibility: hidden;
    transition: opacity .5s;
    background-color: transparent;
    border: none;
    outline: none;
    color: white;
    font-size: 20px;
    cursor: pointer;
}
.dadosAberto>div:nth-child(2)>div:nth-child(4)>button{
    visibility: visible;
    opacity: 1;
    -webkit-animation: fade .5s;
    animation: fade .5s;
}
.article-03>div:nth-child(2)>div:nth-child(4)>p{
    opacity: 0;
    visibility: hidden;
    transition: opacity .5s;
}
.dadosAberto>div:nth-child(2)>div:nth-child(4)>p{
    visibility: visible;
    opacity: 1;
    -webkit-animation: fade .5s;
    animation: fade .5s;
}
.article-04{
    width: 0;
    height: 100%;
    background-color: #8B0000;
    transition: all .4s;
    visibility: hidden;
    display: flex;
    flex-direction: column;
    z-index: 99;
}
.dadosAbertoAmigo{
    width: 40%;
    visibility: visible;
}
.article-04>div:nth-child(1){
    display: flex;
    background-color: rgb(100, 1, 1);
    height: 60px;
    align-items: center;
    padding: 25px;
    color: white;
}
.article-04>div:nth-child(1)>button{
    margin-right: 25px;
    opacity: 0;
    visibility: hidden;
    transition: opacity .5s;
    background-color: transparent;
    border: none;
    outline: none;
    color: white;
    font-size: 20px;
    cursor: pointer;
}
.dadosAbertoAmigo>div:nth-child(1)>button{
    visibility: visible;
    opacity: 1;
    -webkit-animation: fade .5s;
    animation: fade .5s;
}
.article-04>div:nth-child(1)>p{
    opacity: 0;
    visibility: hidden;
    transition: opacity .5s;
}
.dadosAbertoAmigo>div:nth-child(1)>p{
    visibility: visible;
    opacity: 1;
    -webkit-animation: fade .5s;
    animation: fade .5s;
}
.article-04>div:nth-child(2){
    height: 250px;
    background-color: rgb(158, 0, 0);
    display: flex;
    align-items: center;
    justify-content: center;
}
.article-04>div:nth-child(2)>img{
    width: 100%;
    height: 100%;
    max-width: 190px;
    max-height: 190px;
    border-radius: 50%;
    opacity: 0;
    visibility: hidden;
    transition: opacity .5s;
}
.dadosAbertoAmigo>div:nth-child(2)>img{
    visibility: visible;
    opacity: 1;
    -webkit-animation: fade .5s;
    animation: fade .5s;
}
.article-04>div:nth-child(3){
    display: flex;
    background-color: rgb(158, 0, 0);
    justify-content: space-between;
    padding: 20px;
    color: white;
    font-size: 20px;
    margin-bottom: 12px;
}
.article-04>div:nth-child(3)>p{
    opacity: 0;
    visibility: hidden;
    transition: opacity .5s;
}
.dadosAbertoAmigo>div:nth-child(3)>p{
    visibility: visible;
    opacity: 1;
    -webkit-animation: fade .5s;
    animation: fade .5s;
}
.article-04>div:nth-child(4){
    display: flex;
    background-color: rgb(158, 0, 0);
    padding: 20px;
    color: rgb(255, 85, 55);
    cursor: pointer;
}
.article-04>div:nth-child(4):hover{
    background-color: rgb(100, 1, 1);
}
.article-04>div:nth-child(4)>button{
    margin-right: 40px;
    opacity: 0;
    visibility: hidden;
    transition: opacity .5s;
    background-color: transparent;
    border: none;
    outline: none;
    color: white;
    font-size: 20px;
    cursor: pointer;
}
.dadosAbertoAmigo>div:nth-child(4)>button{
    visibility: visible;
    opacity: 1;
    -webkit-animation: fade .5s;
    animation: fade .5s;
}
.article-04>div:nth-child(4)>p{
    opacity: 0;
    visibility: hidden;
    transition: opacity .5s;
}
.dadosAbertoAmigo>div:nth-child(4)>p{
    visibility: visible;
    opacity: 1;
    -webkit-animation: fade .5s;
    animation: fade .5s;
}
/* set button(top and bottom of the scrollbar) */
.right-02::-webkit-scrollbar-button, .left-03::-webkit-scrollbar-button, .article-03>div:nth-child(2)::-webkit-scrollbar-button {display:none}
</style>
