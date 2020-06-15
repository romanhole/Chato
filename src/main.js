import Vue from "vue";
import App from "./App.vue";
import VueResource from "vue-resource";
import VueRouter from "vue-router";
import { routes } from "./router";
import "./assets/style.css";
import Axios from "axios";
import VueAxios from "vue-axios";
import store from "./store";
import { library } from "@fortawesome/fontawesome-svg-core";
import { fas } from "@fortawesome/free-solid-svg-icons";
import { FontAwesomeIcon } from "@fortawesome/vue-fontawesome";

library.add(fas);
Vue.component("font-awesome-icon", FontAwesomeIcon);
Vue.prototype.$http = Axios;
Vue.use(VueResource);
Vue.use(VueRouter);

const router = new VueRouter({
  routes: routes
});

router.beforeEach((to, from, next) => {
  // redireciona à pàgina de login se não estiver logado e tentar entrar em página restrita.
  const publicPages = ["/", "/login", "/cadastro", "/avaliacao"];
  const authRequired = !publicPages.includes(to.path);
  const loggedIn = localStorage.getItem("idUsuario");

  if (authRequired && !loggedIn) {
    return next("/login");
  }

  next();
});

new Vue({
  store,
  el: "#app",
  router,
  render: h => h(App)
});
