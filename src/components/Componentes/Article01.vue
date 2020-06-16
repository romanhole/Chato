<template>
<div id="todo">
  <div class="item article-00" :class="{'perfil-aberto': abaPerfil}">
          <div>
              <div>
                <button @click="trocar"><font-awesome-icon :icon="['fas', 'arrow-left']" /></button>
                <p>Perfil</p>
              </div>
          </div>
          <div>
            <div>
                <label for="select-file">
                    <div :class="{'alterar-imagem' : fotoPerfil == ''}">
                        <p>ADICIONAR NOVA IMAGEM DE PERFIL</p>
                    </div>
                    <img v-bind:src="require('../../assets/imgs/'+fotoPerfil)"/>
                </label>
                <input type="file" id="select-file" @change="onFileChange" style="display : none" />
            </div>
           </div>
          <div>
              <p>Nome</p>
              <div>
                <input type="text" :disabled = alterarEstado :class="{'alterar-nome' : alterarNome}" v-model="nome" id="inputNome">
                <button @click="changeName"><font-awesome-icon :icon="['fas', 'edit']" v-if="alterarEstado"/><font-awesome-icon :icon="['fas', 'check']" v-else/></button>
               </div>
          </div>
          <div>
              <p>Seu ID:</p>
              <p>{{this.$store.state.user.id}}</p>
          </div>
          <div @click="logout">
              <p>Sair</p>
              <button><font-awesome-icon :icon="['fas', 'sign-out-alt']" /></button>
          </div>
      </div>
      <div class="item article-002" :class="{'amigo-aberto' : abaAmigo}">
          <div>
              <div>
                <button @click="addAmigo"><font-awesome-icon :icon="['fas', 'arrow-left']" /></button>
                <p>Perfil</p>
              </div>
          </div>
          <div>
                <p>Coloque o ID de seu novo amigo</p>
                <input type="text" id="idAmigo"/>
                <button @click="adicionarAmigo"><font-awesome-icon :icon="['fas', 'check']" /></button>
          </div>
      </div>
      <div class="item article-003" :class="{'grupo-aberto' : abaGrupo}">
          <div>
              <div>
                <button @click="criarGrupo"><font-awesome-icon :icon="['fas', 'arrow-left']" /></button>
                <p>Novo grupo</p>
              </div>
          </div>
          <div>
              <div>
                <label for="select-file2">
                    <div :class="{'alterar-imagem2' : url2 == ''}">
                        <p>ADICIONAR IMAGEM DO GRUPO</p>
                    </div>
                    <img :src="url2" v-if="url2 != ''"/>
                </label>
                <input type="file" id="select-file2" @change="onFileChange2" style="display : none" />
            </div>
          </div>
          <div>
              <input type="text" placeholder="Nome do grupo">
          </div>
          <div>
              <button><font-awesome-icon :icon="['fas', 'check']" /></button>
          </div>
      </div>
      <div class="item article-01">
          <div class="left">
              <div class="left-01">
                  <img v-bind:src="require('../../assets/imgs/'+fotoPerfil)" @click="trocar"/>
                  <div>
                    <button @click="addAmigo"><font-awesome-icon :icon="['fas', 'user-plus']"/></button>
                    <button @click="criarGrupo"><font-awesome-icon :icon="['fas', 'comment-alt']" /></button>
                  </div>
              </div>
              <div class="left-02">
                  <input type="text" id="procurar" placeholder="Procurar por conversas">
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
                      <img src="../../assets/imgs/pp.jpg"/>
                      <div>
                          <p>pdz9</p>
                          <p>E faço aquela página de avaliação lá</p>
                          <hr>
                      </div>
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
            selecionado: false,
            abaPerfil: false,
            abaGrupo: false,
            alterarNome: false,
            alterarEstado: true,
            abaAmigo: false,
            url: "",
            url2: "",
        }
    },
    computed: {
      nome: {
        get(){
          return this.$store.state.user.nome;
        },
        set(value){
          this.$store.commit("alterarNome", value)
        }
      },
      fotoPerfil: {
          get(){
             return this.$store.state.user.fotoPerfil;
          },
          set(value){
          this.$store.commit("alterarImagem", value)
          }
      }
    },
    methods : {
        trocar(){
            this.abaPerfil = !this.abaPerfil;
        },
        grupoSelecionado(){
            this.selecionado = !this.selecionado;
        },
        criarGrupo(){
            this.abaGrupo = !this.abaGrupo;
        },
        async changeName(){
          if(!this.alterarNome){
            this.alterarNome = !this.alterarNome;
            this.alterarEstado = !this.alterarEstado;
          }
          else{
            this.alterarNome = !this.alterarNome
            this.alterarEstado = !this.alterarEstado
            let self = this;
            try{
              let url = "http://localhost:55707/api/home/putNome"
              const response = await this.$http.put(url, {
                idUsuario: self.$store.state.user.id,
                nome: self.$store.state.user.nome});
            }catch(erro){
              console.log(erro);
              alert(erro.body);
            }
          }
        },
        addAmigo(){
            this.abaAmigo = !this.abaAmigo;
        },
        onFileChange(e) {
            const file = e.target.files[0];
            this.url = URL.createObjectURL(file);
        },
        onFileChange2(e) {
            const file2 = e.target.files[0];
            this.url2 = URL.createObjectURL(file2);
        },
        logout() {
            localStorage.removeItem("idUsuario");
            this.$router.go();
        },
        async adicionarAmigo(){
            let idAmigo = parseInt(document.getElementById('idAmigo').value);
            if(idAmigo != ''){
              try{
                let self = this;
                let url = "http://localhost:55707/api/home/adicionarAmigo";
                const response = await this.$http.post(url, {
                  idUsuario: self.$store.state.user.id,
                  idAmigo: idAmigo});
                alert("Amigo adicionado com sucesso!")
              }catch (erro) {
              console.log(erro);
              alert(erro.body);
            }
          }else{alert("ID vazio!")}
        }
    },
    name: 'Article01'
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
.article-00{
    position: absolute;
    display: flex;
    width: 0;
    height: 100%;
    background-color: #8B0000;
    flex-direction: column;
    z-index: 99;
    transition: all .4s;
    visibility: hidden;
}
.perfil-aberto{
    width: 25%;
    visibility: visible;
}

.article-00>div:nth-child(1){
    background-color: red;
    height: 130px;
    width: 100%;
    display: flex;
    align-items: flex-end;
    border-bottom: 1px solid black;
}
.perfil-aberto>div:nth-child(1)>div{
    padding: 20px;
    display: flex;
    align-items: flex-end;
}
.article-00>div:nth-child(1)>div>button{
    opacity: 0;
    visibility: hidden;
    transition: opacity .4s;
}
.perfil-aberto>div:nth-child(1)>div>button{
    visibility: visible;
    opacity: 1;
    -webkit-animation: fade .4s;
    animation: fade .4s;
    background-color: transparent;
    border: none;
    color: white;
    font-size: 19px;
    margin-right: 20px;
    outline: none;
    cursor: pointer;
}
.article-00>div:nth-child(1)>div>p{
    color: white;
    font-family:"Segoe UI";
    font-feature-settings: "kern";
    font-size: 19px;
    font-stretch: 100%;
    font-weight: 500;
    visibility: hidden;
    opacity: 0;
    transition: opacity .4s;
}
.perfil-aberto>div:nth-child(1)>div>p{
    visibility: visible;
    opacity: 1;
    -webkit-animation: fade .4s;
    animation: fade .4s;
}
.article-00>div:nth-child(2){
    height: 250px;
    border-bottom: 1px solid black;
    display: flex;
    align-items: center;
    justify-content: center;
    opacity: 0;
    visibility: hidden;
    transition: opacity .4s;
}
.perfil-aberto>div:nth-child(2){
    visibility: visible;
    opacity: 1;
    -webkit-animation: fade .4s;
    animation: fade .4s;
}
.article-00>div:nth-child(2)>div{
    width: 100%;
    height: 100%;
    display: flex;
    align-items: center;
    justify-content: center;
}
.article-00>div:nth-child(2)>div>label{
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
.article-00>div:nth-child(2)>div>label>div{
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
.article-00>div:nth-child(2)>div>label:hover>div{
    visibility: visible;
}
.alterar-imagem{
    visibility: visible;
}
.article-00>div:nth-child(2)>div>label>img{
    z-index: 9;
    width: 100%;
    height: 100%;
    max-width: 190px;
    max-height: 190px;
    border-radius: 50%;
}
.article-00>div:nth-child(3){
    height: 100px;
    background-color: lightgrey;
    display: flex;
    flex-direction: column;
    justify-content: space-between;
    border-bottom: 1px solid black;
}
.perfil-aberto>div:nth-child(3){
    padding: 20px;
}
.article-00>div:nth-child(3)>div{
    display: flex;
    justify-content: space-between;
    visibility: hidden;
    opacity: 0;
    transition: opacity .4s;
}
.perfil-aberto>div:nth-child(3)>div{
    visibility: visible;
    opacity: 1;
    -webkit-animation: fade .4s;
    animation: fade .4s;
}
.article-00>div:nth-child(3)>div>button{
    background-color: transparent;
    border: none;
    font-size: 20px;
    outline: none;
}
.article-00>div:nth-child(3)>div>input{
    border: none;
    background-color: transparent;
    outline: none;
    font-size: 15px;
    width: 100%;
}
.alterar-nome{
    border-bottom: 1px solid black !important;
}
.article-00>div:nth-child(3)>p{
    visibility: hidden;
    opacity: 0;
    transition: opacity .4s;
}
.perfil-aberto>div:nth-child(3)>p{
    visibility: visible;
    opacity: 1;
    -webkit-animation: fade .4s;
    animation: fade .4s;
}
.article-00>div:nth-child(3)>p{
    color: red;
    font-size: 15px;
}
.article-00>div:nth-child(4){
    height: 100px;
    background-color: lightgrey;
    display: flex;
    flex-direction: column;
    justify-content: space-between;
    border-bottom: 1px solid black;
    margin-top: 50px;
}
.perfil-aberto>div:nth-child(4){
    padding: 20px;
}
.article-00>div:nth-child(4)>p{
    visibility: hidden;
    opacity: 0;
    transition: opacity .4s;
}
.perfil-aberto>div:nth-child(4)>p{
    visibility: visible;
    opacity: 1;
    -webkit-animation: fade .4s;
    animation: fade .4s;
}
.article-00>div:nth-child(4)>p:nth-child(1){
    color: red;
    font-size: 15px;
}
.article-00>div:nth-child(4)>p:nth-child(2){
    font-size: 15px;
}
.article-00>div:nth-child(5){
    height: 100px;
    background-color: lightgrey;
    display: flex;
    justify-content: space-between;
    border-bottom: 1px solid black;
    align-items: center;
    margin-top: 50px;
    cursor: pointer;
}
.article-00>div:nth-child(5):hover{
    background-color: rgb(148, 148, 148);
}
.perfil-aberto>div:nth-child(5){
    padding: 20px;
}
.article-00>div:nth-child(5)>p{
    visibility: hidden;
    opacity: 0;
    transition: opacity .4s;
}
.perfil-aberto>div:nth-child(5)>p{
    visibility: visible;
    opacity: 1;
    -webkit-animation: fade .4s;
    animation: fade .4s;
}
.article-00>div:nth-child(5)>button{
    visibility: hidden;
    opacity: 0;
    transition: opacity .4s;
    background-color: transparent;
    outline: none;
    border: none;
    cursor: pointer;
    font-size: 20px;
}
.perfil-aberto>div:nth-child(5)>button{
    visibility: visible;
    opacity: 1;
    -webkit-animation: fade .4s;
    animation: fade .4s;
}
.article-002{
    position: absolute;
    display: flex;
    width: 0;
    height: 100%;
    background-color: #8B0000;
    flex-direction: column;
    z-index: 99;
    transition: all .4s;
    visibility: hidden;
}
.amigo-aberto{
    visibility: visible;
    width: 25%;
}
.article-002>div:nth-child(1){
    background-color: red;
    height: 130px;
    width: 100%;
    display: flex;
    align-items: flex-end;
    border-bottom: 1px solid black;
    margin-bottom: 25px;
}
.article-002>div:nth-child(1)>div{
    display: flex;
    align-items: flex-end;
    opacity: 0;
    visibility: hidden;
    transition: opacity .4s;
}
.amigo-aberto>div:nth-child(1)>div{
    padding: 20px;
    visibility: visible;
    opacity: 1;
    -webkit-animation: fade .4s;
    animation: fade .4s;
}
.article-002>div:nth-child(1)>div>button{
    background-color: transparent;
    border: none;
    color: white;
    font-size: 19px;
    margin-right: 20px;
    outline: none;
    opacity: 0;
    visibility: hidden;
    transition: opacity .4s;
    cursor: pointer;
}
.amigo-aberto>div:nth-child(1)>div>button{
    visibility: visible;
    opacity: 1;
    -webkit-animation: fade .4s;
    animation: fade .4s;
}
.article-002>div:nth-child(1)>div>p{
    opacity: 0;
    visibility: hidden;
    transition: opacity .4s;
    color: white;
    font-family:"Segoe UI";
    font-feature-settings: "kern";
    font-size: 19px;
    font-stretch: 100%;
    font-weight: 500;
}
.amigo-aberto>div:nth-child(1)>div>p{
    visibility: visible;
    opacity: 1;
    -webkit-animation: fade .4s;
    animation: fade .4s;
}
.article-002>div:nth-child(2){
    display: flex;
    flex-direction: column;
    justify-content: center;
    text-align: center;
    align-items: center;
    opacity: 0;
    visibility: hidden;
    transition: opacity .4s;
}
.amigo-aberto>div:nth-child(2){
    visibility: visible;
    opacity: 1;
    -webkit-animation: fade .4s;
    animation: fade .4s;
}
.article-002>div:nth-child(2)>input{
    border: none;
    border-bottom: 1px solid black;
    background-color: transparent;
    outline: transparent;
    width: 80%;
    color: white;
    margin-bottom: 25px;
    text-align: center;
    font-size: 15px;
}
.article-002>div:nth-child(2)>p{
    color: white;
    margin-bottom: 25px;
}
.article-002>div:nth-child(2)>button{
    background-color: lightgray;
    border: none;
    outline: none;
    font-size: 25px;
    border-radius: 50%;
    height: 45px;
    width: 45px;
    cursor: pointer;
}
.article-003{
    position: absolute;
    display: flex;
    width: 0;
    height: 100%;
    background-color: #8B0000;
    flex-direction: column;
    z-index: 99;
    transition: all .4s;
    visibility: hidden;
}
.grupo-aberto{
    width: 25%;
    visibility: visible;
}
.article-003>div:nth-child(1){
    background-color: red;
    height: 130px;
    width: 100%;
    display: flex;
    align-items: flex-end;
    border-bottom: 1px solid black;
}
.article-003>div:nth-child(1)>div{
    padding: 20px;
    display: flex;
    align-items: flex-end;
    opacity: 0;
    visibility: hidden;
    transition: opacity .4s;
}
.grupo-aberto>div:nth-child(1)>div{
    visibility: visible;
    opacity: 1;
    -webkit-animation: fade .4s;
    animation: fade .4s;
}
.grupo-aberto>div:nth-child(1)>div>button{
    background-color: transparent;
    border: none;
    color: white;
    font-size: 19px;
    margin-right: 20px;
    outline: none;
    cursor: pointer;
}
.article-003>div:nth-child(1)>div>p{
    color: white;
    font-family:"Segoe UI";
    font-feature-settings: "kern";
    font-size: 19px;
    font-stretch: 100%;
    font-weight: 500;
}
.article-003>div:nth-child(2){
    height: 250px;
    display: flex;
    align-items: center;
    justify-content: center;
    opacity: 0;
    visibility: hidden;
    transition: opacity .4s;
}
.grupo-aberto>div:nth-child(2){
    visibility: visible;
    opacity: 1;
    -webkit-animation: fade .4s;
    animation: fade .4s;
}
.article-003>div:nth-child(2)>div{
    width: 100%;
    height: 100%;
    display: flex;
    align-items: center;
    justify-content: center;
}
.article-003>div:nth-child(2)>div>label{
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
.article-003>div:nth-child(2)>div>label>div{
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
.article-003>div:nth-child(2)>div>label:hover>div{
    visibility: visible;
}
.alterar-imagem2{
    visibility: visible;
}
.article-003>div:nth-child(2)>div>label>img{
    z-index: 9;
    width: 100%;
    height: 100%;
    max-width: 190px;
    max-height: 190px;
    border-radius: 50%;
}
.article-003>div:nth-child(3){
    display: flex;
    opacity: 0;
    visibility: hidden;
    transition: opacity .4s;
    justify-content: flex-end;
}
.grupo-aberto>div:nth-child(3){
    visibility: visible;
    opacity: 1;
    -webkit-animation: fade .4s;
    animation: fade .4s;
}
.article-003>div:nth-child(3)>input{
    background-color: transparent;
    border: none;
    border-bottom: 1px solid black;
    outline: none;
    width: 90%;
    color: white;
    font-size: 15px;
}
.article-003>div:nth-child(3)>input::placeholder { /* Chrome, Firefox, Opera, Safari 10.1+ */
  color: rgba(255, 255, 255, 0.644);
  opacity: 1; /* Firefox */
}

.article-003>div:nth-child(3)>input:-ms-input-placeholder { /* Internet Explorer 10-11 */
  color: rgba(255, 255, 255, 0.644);
}

.article-003>div:nth-child(3)>input::-ms-input-placeholder { /* Microsoft Edge */
  color: rgba(255, 255, 255, 0.644);
}
.article-003>div:nth-child(4){
    display: flex;
    align-items: center;
    justify-content: center;
    height: 130px;
    opacity: 0;
    visibility: hidden;
    transition: opacity .4s;
}
.grupo-aberto>div:nth-child(4){
    visibility: visible;
    opacity: 1;
    -webkit-animation: fade .4s;
    animation: fade .4s;
}
.article-003>div:nth-child(4)>button{
    background-color: lightgray;
    border: none;
    outline: none;
    font-size: 25px;
    border-radius: 50%;
    height: 45px;
    width: 45px;
    cursor: pointer;
}
.article-01{
    width: 100%;
    height: 100%;
    background-color: #8B0000;
    z-index: 9;
}
.left{
    display: flex;
    flex-direction: column;
}
.left-01{
    height: 60px;
    background-color: rgb(100, 1, 1);
    display: flex;
    align-items: center;
    padding: 15px;
    justify-content: space-between;
}
.left-01>img{
    width: 40px;
    height: 40px;
    border-radius: 50%;
    margin-right: 15px;
    cursor: pointer;
}
.left-01>div{
    display: flex;
    padding: 10px;
}
.left-01>div>button{
    margin-left: 20px;
    background-color: transparent;
    outline: none;
    border: none;
    color: white;
    font-size: 20px;
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



.left-03::-webkit-scrollbar, .article-03>div:nth-child(2)::-webkit-scrollbar{
    background-color:#8B0000;
    width:16px
}

/* background of the scrollbar except button or resizer */
.left-03::-webkit-scrollbar-track, .article-03>div:nth-child(2)::-webkit-scrollbar-track {
    background-color:#8B0000;
}
.left-03::-webkit-scrollbar-track:hover, .article-03>div:nth-child(2)::-webkit-scrollbar-track:hover {
    background-color:#8B0000;
}

/* scrollbar itself */
.left-03::-webkit-scrollbar-thumb, .article-03>div:nth-child(2)::-webkit-scrollbar-thumb {
    background-color:rgb(100, 1, 1);
    border-radius:16px;
    border:5px solid #8B0000;
}
.left-03::-webkit-scrollbar-thumb:hover, .article-03>div:nth-child(2)::-webkit-scrollbar-thumb:hover {
    background-color:rgb(100, 1, 1);
    border:4px solid #8B0000;
}

/* set button(top and bottom of the scrollbar) */
.right-02::-webkit-scrollbar-button, .left-03::-webkit-scrollbar-button, .article-03>div:nth-child(2)::-webkit-scrollbar-button {display:none}
</style>
