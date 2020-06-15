import Home from "./components/home/Home.vue";
import Cadastro from "./components/cadastro/Cadastro.vue";
import Chat from "./components/chat/Chat.vue";
import Login from "./components/login/Login.vue";
import Avaliacao from "./components/avaliacao/Avaliacao.vue"
import axios from "axios";

export const routes = [
  {
    path: "/",
    component: Home
  },
  {
    path: "/cadastro",
    name: "cadastro",
    component: Cadastro,
    meta: {
      guest: true
    }
  },
  {
    path: "/login",
    name: "login",
    component: Login,
    meta: {
      guest: true
    }
  },
  {
    path: "/chat",
    name: "chat",
    component: Chat,
    meta: {
      requiresAuth: true
    }
  },
  {
    path: "/avaliacao",
    name: "avaliacao",
    component: Avaliacao,
    meta:{
      guest: true
    }
  },
  { path: "*", redirect: "/" }
];
