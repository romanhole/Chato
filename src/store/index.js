
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
   mudarId(state, payload){
     state.user.id = payload;
   },
   mudarNome(state, payload){
     state.user.nome = payload;
   },
   mudarEmail(state, payload){
     state.user.email = payload;
   },
   mudarSenha(state, payload){
     state.user.senha = payload;
   }
   //this.$store.commit("changeName", "New Name");
 },
 actions: {}
});
