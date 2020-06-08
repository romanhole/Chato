import Vue from 'vue'
import App from './App.vue'
import VueResource from 'vue-resource'
import VueRouter from 'vue-router'
import { routes } from './router'
import './assets/style.css'
import Axios from "axios";
import { library } from '@fortawesome/fontawesome-svg-core';
import { fas} from '@fortawesome/free-solid-svg-icons';
import { FontAwesomeIcon } from '@fortawesome/vue-fontawesome';

library.add(fas);
Vue.component('font-awesome-icon', FontAwesomeIcon);
Vue.prototype.$http = Axios;
Vue.use(VueResource);
Vue.use(VueRouter);

const router = new VueRouter({
  routes : routes
});

new Vue({
  el: '#app',
  router,
  render: h => h(App)
})
