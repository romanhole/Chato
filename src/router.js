import Home from './components/home/Home.vue';
import Cadastro from './components/cadastro/Cadastro.vue';
import Chat from './components/chat/Chat.vue';
import Login from './components/login/Login.vue';

export const routes = [

    { path: '', component: Home},
    { path: '/cadastro', component: Cadastro},
    { path: '/login', component: Login},
    { path: '/chat', component: Chat}

]
