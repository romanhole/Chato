<template>
  <div id="teste">
    <div class="todo">
      <div class="item article-00" :class="{ 'perfil-aberto': abaPerfil }">
        <div>
          <div>
            <button @click="trocar">
              <font-awesome-icon :icon="['fas', 'arrow-left']" />
            </button>
            <p>Perfil</p>
          </div>
        </div>
        <div>
          <div>
            <label for="select-file">
              <div :class="{ 'alterar-imagem': url == '' }">
                <p>ADICIONAR NOVA IMAGEM DE PERFIL</p>
              </div>
              <img :src="url" v-if="url != ''" />
            </label>
            <input
              type="file"
              id="select-file"
              @change="onFileChange"
              style="display : none"
            />
          </div>
        </div>
        <div>
          <p>Nome</p>
          <div>
            <input
              type="text"
              :disabled="alterarEstado"
              :class="{ 'alterar-nome': alterarNome }"
              v-model="nome"
            />
            <button @click="changeName">
              <font-awesome-icon
                :icon="['fas', 'edit']"
                v-if="alterarEstado"
              /><font-awesome-icon :icon="['fas', 'check']" v-else />
            </button>
          </div>
        </div>
        <div>
          <p>Seu ID:</p>
          <p>12312</p>
        </div>
        <div @click="logout">
          <p>Sair</p>
          <button>
            <font-awesome-icon :icon="['fas', 'sign-out-alt']" />
          </button>
        </div>
      </div>
      <div class="item article-002" :class="{ 'amigo-aberto': abaAmigo }">
        <div>
          <div>
            <button @click="addAmigo">
              <font-awesome-icon :icon="['fas', 'arrow-left']" />
            </button>
            <p>Perfil</p>
          </div>
        </div>
        <div>
          <p>Coloque o Id de seu novo amigo</p>
          <input type="text" />
          <button><font-awesome-icon :icon="['fas', 'check']" /></button>
        </div>
      </div>
      <div class="item article-003" :class="{ 'grupo-aberto': abaGrupo }">
        <div>
          <div>
            <button @click="criarGrupo">
              <font-awesome-icon :icon="['fas', 'arrow-left']" />
            </button>
            <p>Novo grupo</p>
          </div>
        </div>
        <div>
          <div>
            <label for="select-file2">
              <div :class="{ 'alterar-imagem2': url2 == '' }">
                <p>ADICIONAR IMAGEM DO GRUPO</p>
              </div>
              <img :src="url2" v-if="url2 != ''" />
            </label>
            <input
              type="file"
              id="select-file2"
              @change="onFileChange2"
              style="display : none"
            />
          </div>
        </div>
        <div>
          <input type="text" placeholder="Nome do grupo" />
        </div>
        <div>
          <button><font-awesome-icon :icon="['fas', 'check']" /></button>
        </div>
      </div>
      <div class="item article-01">
        <div class="left">
          <div class="left-01">
            <img src="../../assets/meuperfil.jpg" @click="trocar" />
            <div>
              <button @click="addAmigo">
                <font-awesome-icon :icon="['fas', 'user-plus']" />
              </button>
              <button @click="criarGrupo">
                <font-awesome-icon :icon="['fas', 'comment-alt']" />
              </button>
            </div>
          </div>
          <div class="left-02">
            <input
              type="text"
              id="procurar"
              placeholder="Procurar por conversas"
            />
          </div>
          <div class="left-03">
            <div
              class="amigos"
              @click="grupoSelecionado"
              :class="{ selecionado: selecionado }"
            >
              <img
                src="https://web.whatsapp.com/pp?e=https%3A%2F%2Fpps.whatsapp.net%2Fv%2Ft61.24694-24%2F75518813_135672844467532_4825498981546307180_n.jpg%3Foe%3D5EDEBAE7%26oh%3D7d719f1952dc7d8b1ecc1b71bea6c04c&t=l&u=5519987277158-1583320513%40g.us&i=1583320610&n=wKIscaInsu%2FhaxUDSCy%2FIX%2Fx7uoIm3SX6Pw0xlkvBkA%3D"
              />
              <div>
                <p>chat de pratica</p>
                <p>João: Ola, amigos tudo bem?</p>
                <hr />
              </div>
            </div>
            <div
              class="amigos"
              @click="grupoSelecionado"
              :class="{ selecionado: selecionado }"
            >
              <img src="../../assets/pp.jpg" />
              <div>
                <p>pdz9</p>
                <p>E faço aquela página de avaliação lá</p>
                <hr />
              </div>
            </div>
          </div>
        </div>
      </div>
      <div class="item article-02" :class="{ 'conversa-dados': abaDados }">
        <div class="right">
          <div class="right-01">
            <input type="text" id="msg" placeholder="Digite sua mensagem:" />
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
              <p>
                orem ipsum dolor sit amet, consectetur adipiscing elit. Mauris
                in condimentum nulla. Mauris convallis nisl sed pharetra
                suscipit. Vivamus euismod pulvinar leo quis gravida. Curabitur
                in magna sem.
              </p>
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
            <img :src="url3" />
            <div>
              <p>{{ nomeGrupo }}</p>
              <p>João, Marcelao, Pires, Você</p>
            </div>
          </div>
        </div>
      </div>
      <div class="item article-03" :class="{ dadosAberto: abaDados }">
        <div>
          <button @click="dadosGrupo">
            <font-awesome-icon :icon="['fas', 'times']" />
          </button>
          <p>Dados do grupo</p>
        </div>
        <div>
          <div>
            <div>
              <label for="select-file3">
                <div :class="{ 'alterar-imagem3': url3 == '' }">
                  <p>ADICIONAR NOVA IMAGEM AO GRUPO</p>
                </div>
                <img :src="url3" v-if="url3 != ''" />
              </label>
              <input
                type="file"
                id="select-file3"
                @change="onFileChange3"
                style="display : none"
              />
            </div>
          </div>
          <div>
            <input
              type="text"
              :disabled="alterarEstado2"
              :class="{ 'alterar-nome2': alterarNome2 }"
              v-model="nomeGrupo"
            />
            <button @click="changeName2">
              <font-awesome-icon
                :icon="['fas', 'edit']"
                v-if="alterarEstado2"
              /><font-awesome-icon :icon="['fas', 'check']" v-else />
            </button>
          </div>
          <div>
            <div>
              <p>4 participantes</p>
            </div>
            <div>
              <button>
                <font-awesome-icon :icon="['fas', 'user-plus']" />
              </button>
              <div>
                <hr />
                <p>Adicionar pessoas</p>
              </div>
            </div>
            <div
              class="participantes"
              :class="{ participantesAberto: abaDados }"
            >
              <img src="../../assets/meuperfil.jpg" />
              <div>
                <hr />
                <p>Você</p>
              </div>
            </div>
            <div
              class="participantes"
              :class="{ participantesAberto: abaDados }"
            >
              <img src="../../assets/meuperfil.jpg" />
              <div>
                <hr />
                <p>Pires</p>
              </div>
            </div>
            <div
              class="participantes"
              :class="{ participantesAberto: abaDados }"
            >
              <img src="../../assets/meuperfil.jpg" />
              <div>
                <hr />
                <p>João</p>
              </div>
            </div>
            <div
              class="participantes"
              :class="{ participantesAberto: abaDados }"
            >
              <img src="../../assets/meuperfil.jpg" />
              <div>
                <hr />
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
    </div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      messages: [],
      selecionado: false,
      abaPerfil: false,
      abaDados: false,
      abaGrupo: false,
      alterarNome: false,
      alterarNome2: false,
      alterarEstado: true,
      alterarEstado2: true,
      nome: "Rafael Romanhole",
      nomeGrupo: "chat de pratica",
      abaAmigo: false,
      url: "",
      url2: "",
      url3: ""
    };
  },
  methods: {
    trocar() {
      this.abaPerfil = !this.abaPerfil;
    },
    grupoSelecionado() {
      this.selecionado = !this.selecionado;
    },
    dadosGrupo() {
      this.abaDados = !this.abaDados;
    },
    criarGrupo() {
      this.abaGrupo = !this.abaGrupo;
    },
    changeName() {
      this.alterarNome = !this.alterarNome;
      this.alterarEstado = !this.alterarEstado;
    },
    changeName2() {
      this.alterarNome2 = !this.alterarNome2;
      this.alterarEstado2 = !this.alterarEstado2;
    },
    addAmigo() {
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
    onFileChange3(e) {
      const file3 = e.target.files[0];
      this.url3 = URL.createObjectURL(file3);
    },
    logout() {
      localStorage.removeItem("idUsuario");
      this.$router.go();
    }
  }
};
//localStorage.setItem("user", response.data.user);
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
#teste {
  width: 100%;
  height: 100vh;
  display: flex;
  justify-content: center;
  align-items: center;
}
.todo {
  height: 800px;
  width: 1400px;
  display: flex;
  flex-direction: row;
  flex-wrap: wrap;
  overflow: hidden;
  position: relative;
  border-radius: 15px;
}
.article-00 {
  position: absolute;
  display: flex;
  width: 0;
  height: 100%;
  background-color: #8b0000;
  flex-direction: column;
  z-index: 99;
  transition: all 0.4s;
  visibility: hidden;
}
.perfil-aberto {
  width: 25%;
  visibility: visible;
}

.article-00 > div:nth-child(1) {
  background-color: red;
  height: 130px;
  width: 100%;
  display: flex;
  align-items: flex-end;
  border-bottom: 1px solid black;
}
.perfil-aberto > div:nth-child(1) > div {
  padding: 20px;
  display: flex;
  align-items: flex-end;
}
.article-00 > div:nth-child(1) > div > button {
  opacity: 0;
  visibility: hidden;
  transition: opacity 0.4s;
}
.perfil-aberto > div:nth-child(1) > div > button {
  visibility: visible;
  opacity: 1;
  -webkit-animation: fade 0.4s;
  animation: fade 0.4s;
  background-color: transparent;
  border: none;
  color: white;
  font-size: 19px;
  margin-right: 20px;
  outline: none;
}
.article-00 > div:nth-child(1) > div > p {
  color: white;
  font-family: "Segoe UI";
  font-feature-settings: "kern";
  font-size: 19px;
  font-stretch: 100%;
  font-weight: 500;
  visibility: hidden;
  opacity: 0;
  transition: opacity 0.4s;
}
.perfil-aberto > div:nth-child(1) > div > p {
  visibility: visible;
  opacity: 1;
  -webkit-animation: fade 0.4s;
  animation: fade 0.4s;
}
.article-00 > div:nth-child(2) {
  height: 250px;
  border-bottom: 1px solid black;
  display: flex;
  align-items: center;
  justify-content: center;
  opacity: 0;
  visibility: hidden;
  transition: opacity 0.4s;
}
.perfil-aberto > div:nth-child(2) {
  visibility: visible;
  opacity: 1;
  -webkit-animation: fade 0.4s;
  animation: fade 0.4s;
}
.article-00 > div:nth-child(2) > div {
  width: 100%;
  height: 100%;
  display: flex;
  align-items: center;
  justify-content: center;
}
.article-00 > div:nth-child(2) > div > label {
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
.article-00 > div:nth-child(2) > div > label > div {
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
.article-00 > div:nth-child(2) > div > label:hover > div {
  visibility: visible;
}
.alterar-imagem {
  visibility: visible;
}
.article-00 > div:nth-child(2) > div > label > img {
  z-index: 9;
  width: 100%;
  height: 100%;
  max-width: 190px;
  max-height: 190px;
  border-radius: 50%;
}
.article-00 > div:nth-child(3) {
  height: 100px;
  background-color: lightgrey;
  display: flex;
  flex-direction: column;
  justify-content: space-between;
  border-bottom: 1px solid black;
}
.perfil-aberto > div:nth-child(3) {
  padding: 20px;
}
.article-00 > div:nth-child(3) > div {
  display: flex;
  justify-content: space-between;
  visibility: hidden;
  opacity: 0;
  transition: opacity 0.4s;
}
.perfil-aberto > div:nth-child(3) > div {
  visibility: visible;
  opacity: 1;
  -webkit-animation: fade 0.4s;
  animation: fade 0.4s;
}
.article-00 > div:nth-child(3) > div > button {
  background-color: transparent;
  border: none;
  font-size: 20px;
  outline: none;
}
.article-00 > div:nth-child(3) > div > input {
  border: none;
  background-color: transparent;
  outline: none;
  font-size: 15px;
  width: 100%;
}
.alterar-nome {
  border-bottom: 1px solid black !important;
}
.article-00 > div:nth-child(3) > p {
  visibility: hidden;
  opacity: 0;
  transition: opacity 0.4s;
}
.perfil-aberto > div:nth-child(3) > p {
  visibility: visible;
  opacity: 1;
  -webkit-animation: fade 0.4s;
  animation: fade 0.4s;
}
.article-00 > div:nth-child(3) > p {
  color: red;
  font-size: 15px;
}
.article-00 > div:nth-child(4) {
  height: 100px;
  background-color: lightgrey;
  display: flex;
  flex-direction: column;
  justify-content: space-between;
  border-bottom: 1px solid black;
  margin-top: 50px;
}
.perfil-aberto > div:nth-child(4) {
  padding: 20px;
}
.article-00 > div:nth-child(4) > p {
  visibility: hidden;
  opacity: 0;
  transition: opacity 0.4s;
}
.perfil-aberto > div:nth-child(4) > p {
  visibility: visible;
  opacity: 1;
  -webkit-animation: fade 0.4s;
  animation: fade 0.4s;
}
.article-00 > div:nth-child(4) > p:nth-child(1) {
  color: red;
  font-size: 15px;
}
.article-00 > div:nth-child(4) > p:nth-child(2) {
  font-size: 15px;
}
.article-00 > div:nth-child(5) {
  height: 100px;
  background-color: lightgrey;
  display: flex;
  justify-content: space-between;
  border-bottom: 1px solid black;
  align-items: center;
  margin-top: 50px;
  cursor: pointer;
}
.article-00 > div:nth-child(5):hover {
  background-color: rgb(148, 148, 148);
}
.perfil-aberto > div:nth-child(5) {
  padding: 20px;
}
.article-00 > div:nth-child(5) > p {
  visibility: hidden;
  opacity: 0;
  transition: opacity 0.4s;
}
.perfil-aberto > div:nth-child(5) > p {
  visibility: visible;
  opacity: 1;
  -webkit-animation: fade 0.4s;
  animation: fade 0.4s;
}
.article-00 > div:nth-child(5) > button {
  visibility: hidden;
  opacity: 0;
  transition: opacity 0.4s;
  background-color: transparent;
  outline: none;
  border: none;
  cursor: pointer;
  font-size: 20px;
}
.perfil-aberto > div:nth-child(5) > button {
  visibility: visible;
  opacity: 1;
  -webkit-animation: fade 0.4s;
  animation: fade 0.4s;
}
.article-002 {
  position: absolute;
  display: flex;
  width: 0;
  height: 100%;
  background-color: #8b0000;
  flex-direction: column;
  z-index: 99;
  transition: all 0.4s;
  visibility: hidden;
}
.amigo-aberto {
  visibility: visible;
  width: 25%;
}
.article-002 > div:nth-child(1) {
  background-color: red;
  height: 130px;
  width: 100%;
  display: flex;
  align-items: flex-end;
  border-bottom: 1px solid black;
  margin-bottom: 25px;
}
.article-002 > div:nth-child(1) > div {
  display: flex;
  align-items: flex-end;
  opacity: 0;
  visibility: hidden;
  transition: opacity 0.4s;
}
.amigo-aberto > div:nth-child(1) > div {
  padding: 20px;
  visibility: visible;
  opacity: 1;
  -webkit-animation: fade 0.4s;
  animation: fade 0.4s;
}
.article-002 > div:nth-child(1) > div > button {
  background-color: transparent;
  border: none;
  color: white;
  font-size: 19px;
  margin-right: 20px;
  outline: none;
  opacity: 0;
  visibility: hidden;
  transition: opacity 0.4s;
}
.amigo-aberto > div:nth-child(1) > div > button {
  visibility: visible;
  opacity: 1;
  -webkit-animation: fade 0.4s;
  animation: fade 0.4s;
}
.article-002 > div:nth-child(1) > div > p {
  opacity: 0;
  visibility: hidden;
  transition: opacity 0.4s;
  color: white;
  font-family: "Segoe UI";
  font-feature-settings: "kern";
  font-size: 19px;
  font-stretch: 100%;
  font-weight: 500;
}
.amigo-aberto > div:nth-child(1) > div > p {
  visibility: visible;
  opacity: 1;
  -webkit-animation: fade 0.4s;
  animation: fade 0.4s;
}
.article-002 > div:nth-child(2) {
  display: flex;
  flex-direction: column;
  justify-content: center;
  text-align: center;
  align-items: center;
  opacity: 0;
  visibility: hidden;
  transition: opacity 0.4s;
}
.amigo-aberto > div:nth-child(2) {
  visibility: visible;
  opacity: 1;
  -webkit-animation: fade 0.4s;
  animation: fade 0.4s;
}
.article-002 > div:nth-child(2) > input {
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
.article-002 > div:nth-child(2) > p {
  color: white;
  margin-bottom: 25px;
}
.article-002 > div:nth-child(2) > button {
  background-color: lightgray;
  border: none;
  outline: none;
  font-size: 25px;
  border-radius: 50%;
  height: 45px;
  width: 45px;
  cursor: pointer;
}
.article-003 {
  position: absolute;
  display: flex;
  width: 0;
  height: 100%;
  background-color: #8b0000;
  flex-direction: column;
  z-index: 99;
  transition: all 0.4s;
  visibility: hidden;
}
.grupo-aberto {
  width: 25%;
  visibility: visible;
}
.article-003 > div:nth-child(1) {
  background-color: red;
  height: 130px;
  width: 100%;
  display: flex;
  align-items: flex-end;
  border-bottom: 1px solid black;
}
.article-003 > div:nth-child(1) > div {
  padding: 20px;
  display: flex;
  align-items: flex-end;
  opacity: 0;
  visibility: hidden;
  transition: opacity 0.4s;
}
.grupo-aberto > div:nth-child(1) > div {
  visibility: visible;
  opacity: 1;
  -webkit-animation: fade 0.4s;
  animation: fade 0.4s;
}
.grupo-aberto > div:nth-child(1) > div > button {
  background-color: transparent;
  border: none;
  color: white;
  font-size: 19px;
  margin-right: 20px;
  outline: none;
}
.article-003 > div:nth-child(1) > div > p {
  color: white;
  font-family: "Segoe UI";
  font-feature-settings: "kern";
  font-size: 19px;
  font-stretch: 100%;
  font-weight: 500;
}
.article-003 > div:nth-child(2) {
  height: 250px;
  display: flex;
  align-items: center;
  justify-content: center;
  opacity: 0;
  visibility: hidden;
  transition: opacity 0.4s;
}
.grupo-aberto > div:nth-child(2) {
  visibility: visible;
  opacity: 1;
  -webkit-animation: fade 0.4s;
  animation: fade 0.4s;
}
.article-003 > div:nth-child(2) > div {
  width: 100%;
  height: 100%;
  display: flex;
  align-items: center;
  justify-content: center;
}
.article-003 > div:nth-child(2) > div > label {
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
.article-003 > div:nth-child(2) > div > label > div {
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
.article-003 > div:nth-child(2) > div > label:hover > div {
  visibility: visible;
}
.alterar-imagem2 {
  visibility: visible;
}
.article-003 > div:nth-child(2) > div > label > img {
  z-index: 9;
  width: 100%;
  height: 100%;
  max-width: 190px;
  max-height: 190px;
  border-radius: 50%;
}
.article-003 > div:nth-child(3) {
  display: flex;
  opacity: 0;
  visibility: hidden;
  transition: opacity 0.4s;
  justify-content: flex-end;
}
.grupo-aberto > div:nth-child(3) {
  visibility: visible;
  opacity: 1;
  -webkit-animation: fade 0.4s;
  animation: fade 0.4s;
}
.article-003 > div:nth-child(3) > input {
  background-color: transparent;
  border: none;
  border-bottom: 1px solid black;
  outline: none;
  width: 90%;
  color: white;
  font-size: 15px;
}
.article-003 > div:nth-child(3) > input::placeholder {
  /* Chrome, Firefox, Opera, Safari 10.1+ */
  color: rgba(255, 255, 255, 0.644);
  opacity: 1; /* Firefox */
}

.article-003 > div:nth-child(3) > input:-ms-input-placeholder {
  /* Internet Explorer 10-11 */
  color: rgba(255, 255, 255, 0.644);
}

.article-003 > div:nth-child(3) > input::-ms-input-placeholder {
  /* Microsoft Edge */
  color: rgba(255, 255, 255, 0.644);
}
.article-003 > div:nth-child(4) {
  display: flex;
  align-items: center;
  justify-content: center;
  height: 130px;
  opacity: 0;
  visibility: hidden;
  transition: opacity 0.4s;
}
.grupo-aberto > div:nth-child(4) {
  visibility: visible;
  opacity: 1;
  -webkit-animation: fade 0.4s;
  animation: fade 0.4s;
}
.article-003 > div:nth-child(4) > button {
  background-color: lightgray;
  border: none;
  outline: none;
  font-size: 25px;
  border-radius: 50%;
  height: 45px;
  width: 45px;
  cursor: pointer;
}
.article-01 {
  width: 25%;
  height: 100%;
  background-color: #8b0000;
  z-index: 9;
}
.article-02 {
  width: 75%;
  height: 100%;
  background-color: #f0f0f0;
  transition: all 0.4s;
}
.conversa-dados {
  width: 45%;
}
.article-03 {
  width: 0;
  height: 100%;
  background-color: #8b0000;
  transition: all 0.4s;
  visibility: hidden;
}
.dadosAberto {
  width: 30%;
  visibility: visible;
}
.article-03 > div:nth-child(1) {
  display: flex;
  background-color: rgb(100, 1, 1);
  height: 60px;
  align-items: center;
  padding: 25px;
  color: white;
}
.article-03 > div:nth-child(1) > button {
  margin-right: 25px;
  opacity: 0;
  visibility: hidden;
  transition: opacity 0.5s;
  background-color: transparent;
  border: none;
  outline: none;
  color: white;
  font-size: 20px;
}
.dadosAberto > div:nth-child(1) > button {
  visibility: visible;
  opacity: 1;
  -webkit-animation: fade 0.5s;
  animation: fade 0.5s;
}
.article-03 > div:nth-child(1) > p {
  opacity: 0;
  visibility: hidden;
  transition: opacity 0.5s;
}
.dadosAberto > div:nth-child(1) > p {
  visibility: visible;
  opacity: 1;
  -webkit-animation: fade 0.5s;
  animation: fade 0.5s;
}
.article-03 > div:nth-child(2) {
  width: 100%;
  overflow-x: hidden;
  overflow-y: scroll;
  display: flex;
  flex-direction: column;
  height: 680px;
}
.article-03 > div:nth-child(2) > div:nth-child(1) {
  height: 250px;
  background-color: rgb(158, 0, 0);
  display: flex;
  align-items: center;
}
.article-03 > div:nth-child(2) > div:nth-child(1) > div {
  width: 100%;
  height: 100%;
  display: flex;
  align-items: center;
  justify-content: center;
  justify-content: center;
  opacity: 0;
  visibility: hidden;
  transition: opacity 0.4s;
}
.dadosAberto > div:nth-child(2) > div:nth-child(1) > div {
  visibility: visible;
  opacity: 1;
  -webkit-animation: fade 0.4s;
  animation: fade 0.4s;
}
.article-03 > div:nth-child(2) > div:nth-child(1) > div > label {
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
.article-03 > div:nth-child(2) > div:nth-child(1) > div > label > div {
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
.article-03 > div:nth-child(2) > div:nth-child(1) > div > label:hover > div {
  visibility: visible;
}
.alterar-imagem3 {
  visibility: visible;
}
.article-03 > div:nth-child(2) > div:nth-child(1) > div > label > img {
  z-index: 9;
  width: 100%;
  height: 100%;
  max-width: 190px;
  max-height: 190px;
  border-radius: 50%;
}
.article-03 > div:nth-child(2) > div:nth-child(2) {
  display: flex;
  background-color: rgb(158, 0, 0);
  justify-content: space-between;
  padding: 20px;
  color: white;
  font-size: 20px;
  margin-bottom: 12px;
}
.article-03 > div:nth-child(2) > div:nth-child(2) > button {
  background-color: transparent;
  border: none;
  font-size: 20px;
  outline: none;
  color: white;
  opacity: 0;
  visibility: hidden;
  transition: opacity 0.5s;
}
.dadosAberto > div:nth-child(2) > div:nth-child(2) > button {
  visibility: visible;
  opacity: 1;
  -webkit-animation: fade 0.5s;
  animation: fade 0.5s;
}
.article-03 > div:nth-child(2) > div:nth-child(2) > input {
  border: none;
  background-color: transparent;
  outline: none;
  font-size: 15px;
  width: 100%;
  color: white;
  font-size: 20px;
  opacity: 0;
  visibility: hidden;
  transition: opacity 0.5s;
}
.dadosAberto > div:nth-child(2) > div:nth-child(2) > input {
  visibility: visible;
  opacity: 1;
  -webkit-animation: fade 0.5s;
  animation: fade 0.5s;
}
.alterar-nome2 {
  border-bottom: 1px solid black !important;
}
.article-03 > div:nth-child(2) > div:nth-child(3) {
  background-color: rgb(158, 0, 0);
  display: flex;
  flex-direction: column;
  margin-bottom: 12px;
}
.article-03 > div:nth-child(2) > div:nth-child(3) > div:nth-child(1) {
  color: lightskyblue;
  padding: 20px;
  align-items: center;
  font-size: 14px;
  position: relative;
  opacity: 0;
  visibility: hidden;
  transition: opacity 0.5s;
}
.dadosAberto > div:nth-child(2) > div:nth-child(3) > div:nth-child(1) {
  visibility: visible;
  opacity: 1;
  -webkit-animation: fade 0.5s;
  animation: fade 0.5s;
}
.article-03 > div:nth-child(2) > div:nth-child(3) > div:nth-child(2) {
  opacity: 0;
  visibility: hidden;
  transition: opacity 0.5s;
  position: relative;
  display: flex;
  align-items: center;
  cursor: pointer;
  padding: 20px;
  color: white;
}
.article-03 > div:nth-child(2) > div:nth-child(3) > div:nth-child(2):hover {
  background-color: rgb(100, 1, 1);
}
.dadosAberto > div:nth-child(2) > div:nth-child(3) > div:nth-child(2) {
  visibility: visible;
  opacity: 1;
  -webkit-animation: fade 0.5s;
  animation: fade 0.5s;
}
.article-03 > div:nth-child(2) > div:nth-child(3) > div:nth-child(2) > button {
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
.article-03 > div:nth-child(2) > div:nth-child(3) > div:nth-child(2) > div {
  height: 100%;
  color: white;
  font-size: 18px;
}
.article-03
  > div:nth-child(2)
  > div:nth-child(3)
  > div:nth-child(2)
  > div
  > hr {
  position: absolute;
  top: 0px;
  right: 0px;
  width: 80%;
  border: 0px;
  background-color: rgba(100, 1, 1, 0.5);
  height: 1px;
}
.participantes {
  display: flex;
  padding: 20px;
  align-items: center;
  position: relative;
  cursor: pointer;
  opacity: 0;
  visibility: hidden;
  transition: opacity 0.5s;
}
.participantesAberto {
  visibility: visible;
  opacity: 1;
  -webkit-animation: fade 0.5s;
  animation: fade 0.5s;
}
.participantes:hover {
  background-color: rgb(100, 1, 1);
}
.participantes > img {
  width: 50px;
  height: 50px;
  border-radius: 50%;
  margin-right: 15px;
}
.participantes > div {
  height: 100%;
  color: white;
  font-size: 18px;
}
.participantes > div > hr {
  position: absolute;
  top: 0px;
  right: 0px;
  width: 80%;
  border: 0px;
  background-color: rgba(100, 1, 1, 0.5);
  height: 1px;
}
.article-03 > div:nth-child(2) > div:nth-child(4) {
  display: flex;
  background-color: rgb(158, 0, 0);
  padding: 20px;
  color: rgb(255, 85, 55);
  cursor: pointer;
}
.article-03 > div:nth-child(2) > div:nth-child(4):hover {
  background-color: rgb(100, 1, 1);
}
.article-03 > div:nth-child(2) > div:nth-child(4) > button {
  margin-right: 40px;
  opacity: 0;
  visibility: hidden;
  transition: opacity 0.5s;
  background-color: transparent;
  border: none;
  outline: none;
  color: white;
  font-size: 20px;
  cursor: pointer;
}
.dadosAberto > div:nth-child(2) > div:nth-child(4) > button {
  visibility: visible;
  opacity: 1;
  -webkit-animation: fade 0.5s;
  animation: fade 0.5s;
}
.article-03 > div:nth-child(2) > div:nth-child(4) > p {
  opacity: 0;
  visibility: hidden;
  transition: opacity 0.5s;
}
.dadosAberto > div:nth-child(2) > div:nth-child(4) > p {
  visibility: visible;
  opacity: 1;
  -webkit-animation: fade 0.5s;
  animation: fade 0.5s;
}
.left {
  display: flex;
  flex-direction: column;
}
.left-01 {
  height: 60px;
  background-color: rgb(100, 1, 1);
  display: flex;
  align-items: center;
  padding: 15px;
  justify-content: space-between;
}
.left-01 > img {
  width: 40px;
  height: 40px;
  border-radius: 50%;
  margin-right: 15px;
  cursor: pointer;
}
.left-01 > div {
  display: flex;
  padding: 10px;
}
.left-01 > div > button {
  margin-left: 20px;
  background-color: transparent;
  outline: none;
  border: none;
  color: white;
  font-size: 20px;
  cursor: pointer;
}
.left-02 {
  height: 50px;
  display: flex;
  flex-direction: column;
  width: 100%;
  align-items: center;
  justify-content: center;
  border-bottom: 1px solid rgb(100, 1, 1);
}
.left-03 {
  height: 690px;
  width: 100%;
  overflow-x: hidden;
  overflow-y: scroll;
  display: flex;
  flex-direction: column;
}
.amigos {
  display: flex;
  padding: 12px;
  align-items: center;
  cursor: pointer;
  position: relative;
}
.amigos:hover {
  background-color: rgb(100, 1, 1);
}
.amigos > img {
  width: 50px;
  height: 50px;
  border-radius: 50%;
  margin-right: 15px;
}
.amigos > div {
  width: 100%;
  height: 100%;
  display: flex;
  flex-direction: column;
  justify-content: space-around;
}
.amigos > div > hr {
  position: absolute;
  bottom: 0px;
  right: 0px;
  width: 80%;
  border: 0px;
  background-color: rgb(100, 1, 1);
  height: 1px;
}
.amigos > div > p:nth-child(1) {
  font-size: 20px;
  color: white;
}
.amigos > div > p:nth-child(2) {
  font-size: 12px;
  color: rgba(255, 255, 255, 0.575);
}
.selecionado {
  background-color: rgb(73, 0, 0);
}
#procurar {
  border-radius: 7px;
  border-style: none;
  outline: none;
  width: 280px;
  height: 25px;
  padding: 10px;
}
.right {
  display: flex;
  flex-direction: column-reverse;
  justify-content: space-between;
  width: 100%;
  height: 100%;
}
#msg {
  /*width: 750px;*/
  width: 100%;
  height: 35px;
  border-radius: 7px;
  border-style: none;
  outline: none;
  font-size: 15px;
  padding: 10px;
}
.right-01 {
  display: flex;
  flex-direction: row;
  width: 100%;
  height: 60px;
  background-color: lightgrey;
  justify-content: center;
  align-items: center;
  padding: 0 45px;
}
.right-02 {
  height: 680px;
  width: 100%;
  display: flex;
  flex-direction: column;
  align-items: flex-start;
  justify-content: flex-start;
  padding: 15px;
  overflow-y: scroll;
}
.right-02 > div {
  display: flex;
  flex-direction: column;
  max-width: 40%;
  background-color: white;
  padding: 10px;
  border-radius: 10px;
  margin-bottom: 10px;
}
.right-02 > div h1 {
  font-size: 17px;
  color: blue;
  margin-bottom: 3px;
}
.right-02 > div p {
  text-align: justify;
}
.recebida {
  align-self: flex-start;
}
.enviada {
  align-self: flex-end;
}
.right-03 {
  height: 60px;
  background-color: lightgray;
  cursor: pointer;
  width: 100%;
  display: flex;
  align-items: center;
  padding: 15px;
}
.right-03 > div {
  display: flex;
  flex-direction: column;
  justify-content: space-between;
}
.right-03 > img {
  width: 40px;
  height: 40px;
  border-radius: 50%;
  margin-right: 15px;
}
.right-03 > div > p:nth-child(1) {
  font-size: 16px;
  color: black;
}
.right-03 > div > p:nth-child(2) {
  font-size: 13px;
  color: rgba(0, 0, 0, 0.493);
}

.right-02::-webkit-scrollbar {
  background-color: #f0f0f0;
  width: 16px;
}
.left-03::-webkit-scrollbar,
.article-03 > div:nth-child(2)::-webkit-scrollbar {
  background-color: #8b0000;
  width: 16px;
}

/* background of the scrollbar except button or resizer */
.right-02::-webkit-scrollbar-track {
  background-color: #f0f0f0;
}
.left-03::-webkit-scrollbar-track,
.article-03 > div:nth-child(2)::-webkit-scrollbar-track {
  background-color: #8b0000;
}
.right-02::-webkit-scrollbar-track:hover {
  background-color: #f0f0f0;
}
.left-03::-webkit-scrollbar-track:hover,
.article-03 > div:nth-child(2)::-webkit-scrollbar-track:hover {
  background-color: #8b0000;
}

/* scrollbar itself */
.right-02::-webkit-scrollbar-thumb {
  background-color: #babac0;
  border-radius: 16px;
  border: 5px solid #f0f0f0;
}
.left-03::-webkit-scrollbar-thumb,
.article-03 > div:nth-child(2)::-webkit-scrollbar-thumb {
  background-color: rgb(100, 1, 1);
  border-radius: 16px;
  border: 5px solid #8b0000;
}
.right-02::-webkit-scrollbar-thumb:hover {
  background-color: #babac0;
  border: 4px solid #f0f0f0;
}
.left-03::-webkit-scrollbar-thumb:hover,
.article-03 > div:nth-child(2)::-webkit-scrollbar-thumb:hover {
  background-color: rgb(100, 1, 1);
  border: 4px solid #8b0000;
}

/* set button(top and bottom of the scrollbar) */
.right-02::-webkit-scrollbar-button,
.left-03::-webkit-scrollbar-button,
.article-03 > div:nth-child(2)::-webkit-scrollbar-button {
  display: none;
}
</style>
