import Vue from 'vue'
import App from './App.vue'
import VueResource from 'vue-resource'
import VueRouter from 'vue-router'
import { routes } from './routes'
import PubNubVue from 'pubnub-vue'

Vue.config.productionTip = false;
    
const publish_Key = 'YOUR_PUBLISH_KEY_HERE';
const subscribe_Key = 'YOUR_SUBSCRIBE_KEY_HERE';

// Make a unique uuid for each client
const myUuid = fourCharID();
const me = {
    uuid: myUuid,
};

try{
    if(!publish_Key || !subscribe_Key){
        throw 'PubNub Keys are missing.';
    }
}
catch(err){
    console.log(err);
}

Vue.use(PubNubVue, {
  subscribeKey: subscribe_Key,
  publishKey: publish_Key,
  ssl: true
}, store);
Vue.use(VueResource);
Vue.use(VueRouter);

const router = new VueRouter({
  routes : routes
});

new Vue({
  el: '#app',
  router,
  store,
  components: { App },
  //render: h => h(App),
  template: '&lt;App/&gt;',
  created
})
