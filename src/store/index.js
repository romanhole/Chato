import Vue from "vue";
import Vuex from "vuex";
import Axios from "axios";


Vue.use(Vuex);

export default new Vuex.Store({
 state: {
   user: {
     id: null,
     nome: null,
     email: null,
     senha: null,
     fotoPerfil: null,
     amigos: [],
     idConversa: null
   },
   open: false,
   nomeGp: null,
 },
 getters: {
    getOpen(state){
      return state.open;
    }, 
 },
 mutations: {
   alterarId(state, payload){
     state.user.id = payload;
   },
   alterarNome(state, payload){
     state.user.nome = payload;
   },
   alterarEmail(state, payload){
     state.user.email = payload;
   },
   alterarSenha(state, payload){
     state.user.senha = payload;
   },
   alterarUsuario(state, payload){
     state.user.id = payload.id;
     state.user.nome = payload.nome;
     state.user.email = payload.email;
     state.user.senha = payload.senha;
     state.user.fotoPerfil = payload.fotoPerfil;
   },
   alterarModal(state){
     state.open = !state.open;
   },
   alterarImagem(state, payload){
     state.user.fotoPerfil = payload;
   },
   alterarIdConversa(state, payload){
     state.user.idConversa = payload;
   }
   //this.$store.commit("changeName", "New Name");
 },
 actions: {
  alterarNome(context, payload){
    let self = this;
    try{
      context.commit("alterarNome", payload)
      let url = "http://localhost:55707/api/home/putNome"
      const response = Axios.put(url, {
        idUsuario: self.state.user.id,
        nome: payload});
    }catch(erro){
      alert(erro);
    }
  },
  alterarModal({commit}){
    commit("alterarModal");
  },
  alterarImagem(context, payload){
    let self = this;
  },
 }
});
