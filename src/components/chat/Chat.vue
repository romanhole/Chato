<template>
<div id="teste">
  <div class="todo">
      <div class="item article-00">
          <div>
              <button> &#60-- </button>
              <p>Perfil</p>
          </div>
          <div>
              <img src="../../assets/meuperfil.jpg"/>
          </div>
          <div>
              <p>Nome</p>
              <p>Rafael Romanhole</p>
          </div>
      </div>
      <div class="item article-01">
          <div class="left">
              <div class="left-01">
                  <img src="../../assets/meuperfil.jpg"/>
              </div>
              <div class="left-02">
                  <input type="text" id="procurar">
              </div>
              <div class="left-03">
                  <div class="amigos" @click="grupoSelecionado" :class="{ 'selecionado': selecionado }">
                      <img src="https://web.whatsapp.com/pp?e=https%3A%2F%2Fpps.whatsapp.net%2Fv%2Ft61.24694-24%2F75518813_135672844467532_4825498981546307180_n.jpg%3Foe%3D5EDEBAE7%26oh%3D7d719f1952dc7d8b1ecc1b71bea6c04c&t=l&u=5519987277158-1583320513%40g.us&i=1583320610&n=wKIscaInsu%2FhaxUDSCy%2FIX%2Fx7uoIm3SX6Pw0xlkvBkA%3D"/>
                      <div>
                          <p>chat de pratica</p>
                          <p>João: Ola, amigos tudo bem?</p>
                          <hr>
                      </div>
                  </div>
                  <div class="amigos" @click="grupoSelecionado" :class="{ 'selecionado': selecionado }">
                      <img src="../../assets/pp.jpg"/>
                      <div>
                          <p>pdz9</p>
                          <p>E faço aquela página de avaliação lá</p>
                          <hr>
                      </div>
                  </div>
              </div>
          </div>
      </div>
      <div class="item article-02">
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
              <div class="right-03" @click="teste">
                    <img src="https://web.whatsapp.com/pp?e=https%3A%2F%2Fpps.whatsapp.net%2Fv%2Ft61.24694-24%2F75518813_135672844467532_4825498981546307180_n.jpg%3Foe%3D5EDEBAE7%26oh%3D7d719f1952dc7d8b1ecc1b71bea6c04c&t=l&u=5519987277158-1583320513%40g.us&i=1583320610&n=wKIscaInsu%2FhaxUDSCy%2FIX%2Fx7uoIm3SX6Pw0xlkvBkA%3D"/>
                    <div>
                        <p>chat de pratica</p>
                        <p>João, Marcelao, Pires, Você</p>
                    </div>
              </div>
          </div>
      </div>
      <div class="item article-03">
          <div>
              <button>X</button>
              <p>Dados do grupo</p>
          </div>
          <div>
            <div>
                <img src="https://web.whatsapp.com/pp?e=https%3A%2F%2Fpps.whatsapp.net%2Fv%2Ft61.24694-24%2F75518813_135672844467532_4825498981546307180_n.jpg%3Foe%3D5EDEBAE7%26oh%3D7d719f1952dc7d8b1ecc1b71bea6c04c&t=l&u=5519987277158-1583320513%40g.us&i=1583320610&n=wKIscaInsu%2FhaxUDSCy%2FIX%2Fx7uoIm3SX6Pw0xlkvBkA%3D"/>
            </div>
            <div>
                <p>chat pratica</p>
                <button>lapis</button>
            </div>
            <div>
                <div>
                    <p>4 participantes</p>
                </div>
                <div class="participantes">
                    <img src="../../assets/meuperfil.jpg"/>
                    <div>
                        <hr>
                        <p>Você</p>
                    </div>
                </div>
                <div class="participantes">
                    <img src="../../assets/meuperfil.jpg"/>
                    <div>
                        <hr>
                        <p>Pires</p>
                    </div>
                </div>
                <div class="participantes">
                    <img src="../../assets/meuperfil.jpg"/>
                    <div>
                        <hr>
                        <p>João</p>
                    </div>
                </div>
                <div class="participantes">
                    <img src="../../assets/meuperfil.jpg"/>
                    <div>
                        <hr>
                        <p>Marcelao</p>
                    </div>
                </div>
            </div>
            <div>
                <button>sair</button>
                <p>Sair do grupo</p>
            </div>
          </div>
      </div>
  </div>
</div>
</template>

<script>
export default {
    data(){
        return{
            messages:[],
            selecionado: false,
            abaPerfil: false
        }
    },
    methods:{
        trocar(){
            abaPerfil = !abaPerfil;
        },
        grupoSelecionado(){
            this.selecionado = !this.selecionado;
        }
    }
}
/*window.onload = function(){
    var conectado = false;
    if(!conectado)
        HttpResponse.RedirectToRoute('/login');
    window.setInterval(1000,atualizar());
}
function atualizar(){
    //atualizar o chat a cada 1 seg pra ver se tem mensagem nova.
}*/
</script>

<style scoped>
#teste{
    width: 100%;
    height: 100vh;
    display: flex;
    justify-content: center;
    align-items: center;
}
.todo{
    height: 800px;
    width: 1400px;
    display: flex;
    flex-direction: row;
    flex-wrap: wrap;
    overflow: hidden;
}
.article-00{
    display: none;
    width: 25%;
    height: 100%;
    border-top-left-radius: 15px;
    border-bottom-left-radius: 15px;
    background-color: #8B0000;
    flex-direction: column;
}
.article-00>div:nth-child(1){
    background-color: red;
    height: 130px;
    border-top-left-radius: 15px;
    width: 100%;
    display: flex;
    align-items: flex-end;
    padding: 20px;
    border-bottom: 1px solid black;
}
.article-00>div:nth-child(1)>button{
    margin-right: 10px;
}
.article-00>div:nth-child(1)>p{
    color: white;
    font-family:"Segoe UI";
    font-feature-settings: "kern";
    font-size: 19px;
    font-stretch: 100%;
    font-weight: 500;
}
.article-00>div:nth-child(2){
    height: 250px;
    border-bottom: 1px solid black;
    display: flex;
    align-items: center;
    justify-content: center;
}
.article-00>div:nth-child(2)>img{
    width: 190px;
    height: 190px;
    border-radius: 50%;
    cursor: pointer;
}
.article-00>div:nth-child(3){
    height: 100px;
    background-color: lightgrey;
    display: flex;
    flex-direction: column;
    justify-content: space-between;
    padding: 20px;
    border-bottom: 1px solid black;
}
.article-00>div:nth-child(3)>p:nth-child(1){
    color: red;
    font-size: 15px;
}
.article-01{
    width: 25%;
    height: 100%;
    background-color: #8B0000;
    border-top-left-radius: 15px;
    border-bottom-left-radius: 15px;
}
.article-02{
    width: 75%;
    height: 100%;
    background-color: #f0f0f0;
    border-top-right-radius: 15px;
    border-bottom-right-radius: 15px;
}
.article-03{
    display: none;
    width: 30%;
    height: 100%;
    background-color: #8B0000;
    border-top-right-radius: 15px;
    border-bottom-right-radius: 15px;
}
.article-03>div:nth-child(1){
    display: flex;
    background-color: rgb(100, 1, 1);
    border-top-right-radius: 15px;
    height: 60px;
    align-items: center;
    padding: 25px;
    color: white;
}
.article-03>div:nth-child(1)>button{
    margin-right: 25px;
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
    display: flex;
    flex-direction: column;
    background-color: rgb(158, 0, 0);
    align-items: center;
    padding: 20px;
}
.article-03>div:nth-child(2)>div:nth-child(1)>img{
    width: 190px;
    height: 190px;
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
}
.participantes{
    display: flex;
    padding: 20px;
    align-items: center;
    position: relative;
    cursor: pointer;
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
    color: tomato;
}
.article-03>div:nth-child(2)>div:nth-child(4):hover{
    background-color: rgb(100, 1, 1);
}
.article-03>div:nth-child(2)>div:nth-child(4)>button{
    margin-right: 40px;
}
.left{
    display: flex;
    flex-direction: column;
}
.left-01{
    height: 60px;
    background-color: rgb(100, 1, 1);
    border-top-left-radius: 15px;
    display: flex;
    align-items: center;
    padding: 15px;
}
.left-01>img{
    width: 40px;
    height: 40px;
    border-radius: 50%;
    margin-right: 15px;
    cursor: pointer;
}
.left-02{
    height: 50px;
    display: flex;
    flex-direction: column;
    width: 100%;
    align-items: center;
    justify-content: center;
    border-bottom: 1px solid rgb(100, 1, 1);
}
.left-03{
    height: 690px;
    width: 100%;
    overflow-x: hidden;
    overflow-y: scroll;
    display: flex;
    flex-direction: column;
}
.amigos{
    display: flex;
    padding: 12px;
    align-items: center;
    cursor: pointer;
    position: relative;
}
.amigos:hover{
    background-color: rgb(100, 1, 1);
}
.amigos>img{
    width: 50px;
    height: 50px;
    border-radius: 50%;
    margin-right: 15px;
}
.amigos>div{
    width: 100%;
    height: 100%;
    display: flex;
    flex-direction: column;
    justify-content: space-around;
}
.amigos>div>hr{
    position: absolute;
    bottom: 0px;
    right: 0px;
    width: 80%;
    border: 0px;
    background-color: rgb(100, 1, 1);
    height: 1px;
}
.amigos>div>p:nth-child(1){
    font-size: 20px;
    color: white;
}
.amigos>div>p:nth-child(2){
    font-size: 12px;
    color: rgba(255, 255, 255, 0.575);
}
.selecionado{
    background-color: rgb(73, 0, 0);
}
#procurar{
    border-radius: 7px;
    border-style: none;
    outline: none;
    width: 280px;
    height: 25px;
    padding: 10px;
}
.right{
    display: flex;
    flex-direction: column-reverse;
    justify-content: space-between;
    width: 100%;
    height: 100%;
}
#msg{
    width: 750px;
    /*width: 525px;*/
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
    border-bottom-right-radius: 15px;
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
    border-top-right-radius: 15px;
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

/* set button(top and bottom of the scrollbar) */
.right-02::-webkit-scrollbar-button, .left-03::-webkit-scrollbar-button, .article-03>div:nth-child(2)::-webkit-scrollbar-button {display:none}

</style>