
import Vue from "vue";
import Vuex from "vuex";

Vue.use(Vuex);

export default new Vuex.Store({
 state: {
   user: {
     id: null,
     nome: '',
     email: '',
     senha: ''
   }
 },
 getters: {},
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
   }
   //this.$store.commit("changeName", "New Name");
 },
 actions: {
    alterarId(context, payload){
      context.commit("alterarId", payload)
    },
    alterarNome(context, payload){
      context.commit("alterarNome", payload)
    },
    alterarEmail(context, payload){
      context.commit("alterarEmail", payload)
    },
    alterarSenha(context, payload){
      context.commit("alterarSenha", payload)
    },
    alterarUsuario(context, payload){
      context.commit("alterarUsuario", payload)
    },

 }
});
