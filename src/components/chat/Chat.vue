<template>
  <div id="teste">
    <div class="todo">
      <Modal/>
      <Article01 id="A1" />
      <Article02 id="A2" />
    </div>
  </div>
</template>

<script>
import Article01 from "../Componentes/Article01";
import Article02 from "../Componentes/Article02";
import Modal from "../Componentes/Modal";
export default {
  async mounted(){ // conexao com a API
    let self = this;
      try{
        let url = "http://localhost:55707/api/home/usuario";
        const response = await this.$http.post(url, {idUsuario: JSON.parse(localStorage.getItem("idUsuario"))});
        self.$store.commit("alterarUsuario", {
            id: response.data.idUsuario,
            nome: response.data.nome,
            email: response.data.email,
            senha: response.data.senha
          });
      }catch (erro) {
          console.log(erro);
          alert(erro.body);
      }
  },
  data() {},
  components: {
    Article01,
    Article02,
    Modal
  }
}
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
#A1 {
  width: 25%;
  height: 100%;
}
#A2 {
  width: 75%;
  height: 100%;
  display: flex;
  flex-direction: row;
}
</style>
