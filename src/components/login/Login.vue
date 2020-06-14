<template>
  <div class="container2">
    <div class="conteudo2">
      <div class="primeiracoluna">
        <h2 class="titulo titulo-primario">Olá, Amigo</h2>
        <p class="description">Insira seus dados pessoais</p>
        <p class="description">e cadastre-se no Chato!</p>
        <button class="botao botao-primario" @click="redirectCadastro">
          Cadastre-se
        </button>
      </div>
      <div class="segundacoluna">
        <h2 class="titulo titulo-secundario">Faça login no Chato!</h2>
        <form class="form">
          <label class="labelinput" for="">
            <i class="fas fa-envelope icon-modify"></i>
            <input
              type="email"
              placeholder="Email"
              v-model="email"
              required
              autofocus
            />
          </label>
          <label class="labelinput" for="">
            <i class="fas fa-lock icon-modify"></i>
            <input
              type="password"
              placeholder="Senha"
              v-model="senha"
              required
            />
          </label>
          <a href="#">Esqueceu sua senha?</a>
          <br /><button
            class="botao botao-secundario"
            type="submit"
            @click="handleSubmit"
          >
            Login
          </button>
        </form>
      </div>
    </div>
  </div>
</template>

<script>
//src="https://kit.fontawesome.com/9f8b65618e.js", crossorigin="anonymous"
export default {
  data() {
    return {
      email: "",
      senha: ""
    };
  },
  methods: {
    async handleSubmit(e) {
      let self = this;
      e.preventDefault();
      if (this.senha.length > 0) {
        try {
          let url = "http://localhost:55707/api/home/login";
          const response = await this.$http.post(url, {
            email: this.email,
            senha: this.senha
          })
          if (response == null)
            self.$router.go();
          localStorage.setItem("idUsuario", JSON.stringify(response.data.idUsuario));
          self.$router.push("/chat");

        } catch (erro) {
          console.log(erro);
          alert(erro.body);
        }
      } else {
        return alert("Insira uma senha!");
      }
    },
    redirectCadastro() {
      this.$router.push("/cadastro");
    }
  }
};
</script>

<style scoped>
@import url("https://fonts.googleapis.com/css2?family=Open+Sans:wght@300;400;700&display=swap");
* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}
.conteudo2 {
  border-radius: 15px;
  background-color: white;
  width: 960px;
  height: 50%;
  display: flex;
  justify-content: space-between;
  align-items: center;
  position: relative;
}
.conteudo2::before {
  content: "";
  position: absolute;
  background-color: #8b0000;
  width: 40%;
  height: 100%;
  border-top-right-radius: 15px;
  border-bottom-right-radius: 15px;
  left: 60%;
}
.container2 {
  display: flex;
  justify-content: center;
  align-items: center;
  height: 100vh;
  background-color: #f0f0f0;
  font-family: "Open Sans", sans-serif;
}
.titulo {
  font-size: 30px;
  font-weight: bold;
}
.titulo-primario {
  color: white;
}
.titulo-secundario {
  color: #8b0000;
  height: 80px;
}
.description {
  font-size: 14px;
  font-weight: 300;
  color: white;
  line-height: 30px;
}
.botao {
  border-radius: 15px;
  text-transform: uppercase;
  color: white;
  font-size: 12px;
  cursor: pointer;
  font-weight: bold;
  width: 150px;
  align-self: center;
  border: none;
  height: 35px;
}
.botao-primario {
  background-color: transparent;
  border: 1px solid white;
}
.botao-primario:hover {
  background-color: white;
  color: #8b0000;
}
.botao-secundario {
  background-color: #8b0000;
}
.botao-secundario:hover {
  background-color: white;
  color: #8b0000;
  border: 1px solid #8b0000;
}
.primeiracoluna {
  text-align: center;
  flex: 1.5 0 auto;
  z-index: 10;
  order: 2;
}
.segundacoluna {
  flex: 2 0 auto;
  display: flex;
  flex-direction: column;
  align-items: center;
  order: 1;
}
.form {
  display: flex;
  flex-direction: column;
  width: 55%;
}
.form input {
  height: 45px;
  width: 100%;
  border: none;
  background-color: #ecf0f1;
}
.labelinput {
  background-color: #ecf0f1;
  display: flex;
  align-items: center;
  margin: 8px;
}
.icon-modify {
  color: #7f8c8d;
  padding: 0 5px;
}
a {
  text-align: center;
  font-size: 15px;
  color: #8b0000;
  text-decoration: none;
}
</style>
