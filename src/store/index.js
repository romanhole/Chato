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
   },
   open: false,
 },
 getters: {
    getOpen(state){
      return state.open;
    }
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
   },
   alterarModal(state){
     state.open = !state.open;
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
  }
 }
});
