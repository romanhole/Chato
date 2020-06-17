<template>
    <div class="container" :class="{'open': getOpen}">
        <div>
            <div>
                <button @click="abrirModal"><font-awesome-icon :icon="['fas', 'times']" /></button>
                <p>Adicionar amigo</p>
            </div>
            <div>
                <input type="text" placeholder="Procurar amigos:">
            </div>
            <div>
                <p>CONTATOS:</p>
            </div>
            <div>
                <div class="amigos">
                    <input type="checkbox" name="amigoSelecionado" id="amigoSelecionado">
                    <img src="../../assets/imgs/meuperfil.jpg"/>
                    <div>
                        <hr>
                        <p>Você</p>
                    </div>
                </div>
                <div class="amigos">
                    <input type="checkbox" name="amigoSelecionado" id="amigoSelecionado">
                    <img src="../../assets/imgs/meuperfil.jpg"/>
                    <div>
                        <hr>
                        <p>Pires</p>
                    </div>
                </div>
                <div class="amigos">
                    <input type="checkbox" name="amigoSelecionado" id="amigoSelecionado">
                    <img src="../../assets/imgs/meuperfil.jpg"/>
                    <div>
                        <hr>
                        <p>João</p>
                    </div>
                </div>
                <div class="amigos">
                    <input type="checkbox" name="amigoSelecionado" id="amigoSelecionado" checked>
                    <img src="../../assets/imgs/meuperfil.jpg"/>
                    <div>
                        <hr>
                        <p>Marcelao</p>
                    </div>
                </div>
                <div class="amigos">
                    <input type="checkbox" name="amigoSelecionado" id="amigoSelecionado" checked>
                    <img src="../../assets/imgs/meuperfil.jpg"/>
                    <div>
                        <hr>
                        <p>Marcelao</p>
                    </div>
                </div>
                <div class="amigos">
                    <input type="checkbox" name="amigoSelecionado" id="amigoSelecionado" checked>
                    <img src="../../assets/imgs/meuperfil.jpg"/>
                    <div>
                        <hr>
                        <p>Marcelao</p>
                    </div>
                </div>
                <div class="amigos">
                    <input type="checkbox" name="amigoSelecionado" id="amigoSelecionado" checked>
                    <img src="../../assets/imgs/meuperfil.jpg"/>
                    <div>
                        <hr>
                        <p>Marcelao</p>
                    </div>
                </div>
            </div>
            <div>
                <button><font-awesome-icon :icon="['fas', 'check']" /></button>
            </div>
        </div>
    </div>
</template>

<script>
import store from '../../store'
export default {
    data(){
        return{

        }
    },
    methods:{
        abrirModal(){
            store.dispatch("alterarModal");
        }
    },
    name: 'Modal',
    computed:{
        getOpen(){
            return store.getters["getOpen"];
        },
    }
}
</script>

<style>
    .container{
        position: fixed;
        visibility: hidden;
        opacity: 0;
        width: 100%;
        height: 100%;
        top: 0;
        right: 0;
        left: 0;
        bottom: 0;
        background-color: rgba(255, 255, 255, 0.808);
        z-index: 999;
        border: 1px solid red;
    }
    .open{
        visibility: visible;
        opacity: 1;
    }
    .container>div{
        width: 100%;
        height: 100%;
        max-height: 700px;
        max-width: 400px;
        position: absolute;
        top: 50%;
        left: 50%;
        transform: translate(-50%, -50%);
        background-color: #f0f0f0;
        border-radius: 5px;
        display: flex;
        flex-direction: column;
    }
    .container>div>div:nth-child(1){
        padding: 20px;
        display: flex;
        background-color: #8B0000;
        align-items: center;
    }
    .container>div>div:nth-child(1)>button{
        background-color: transparent;
        border: none;
        color: white;
        font-size: 20px;
        margin-right: 20px;
        outline: none;
        cursor: pointer;
    }
    .container>div>div:nth-child(1)>p{
        color: white;
    }
    .container>div>div:nth-child(2){
        background-color: rgb(228, 228, 228);
        padding: 10px;
        display: flex;
        justify-content: center;
        align-items: center;
    }
    .container>div>div:nth-child(2)>input{
        border-radius: 7px;
        border-style: none;
        outline: none;
        width: 280px;
        height: 25px;
        padding: 10px;
    }
    .container>div>div:nth-child(3){
        padding-top: 50px;
        padding-left: 20px;
        color: #8B0000;
        padding-bottom: 20px;
    }
    .container>div>div:nth-child(4){
        height: 100%;
        overflow-x: hidden;
        overflow-y: scroll;
    }

    .amigos{
        display: flex;
        padding: 13px;
        padding-left: 20px;
        align-items: center;
        position: relative;
        cursor: pointer;
    }
    .amigos:hover{
        background-color: lightgrey;
    }
    .amigos>img{
        width: 50px;
        height: 50px;
        border-radius: 50%;
        margin-right: 15px;
    }
    .amigos>div{
        height: 100%;
        font-size: 18px;
    }
    .amigos>div>hr{
        position: absolute;
        top: 0px;
        right: 0px;
        width: 80%;
        border: 0px;
        background-color: lightgrey;
        height: 1px;
    }
    .amigos>input{
        margin-right: 20px;
        background-color: transparent;
        border: 0px;
        outline: none;
        -webkit-box-shadow: none;
        -moz-box-shadow: none;
        box-shadow: none;
        color:transparent;
        width: 18px;
        height: 18px;
        cursor:default;
    }

    .container>div>div:nth-child(4)::-webkit-scrollbar{
        background-color:#f0f0f0;
        width:15px
    }
    .container>div>div:nth-child(5){
        display: flex;
        align-items: flex-end;
        justify-content: flex-end;
        padding: 20px;
        z-index: 9999;
    }
    .container>div>div:nth-child(5)>button{
        background-color: #8B0000;
        border-radius: 50%;
        border: none;
        outline: none;
        cursor: pointer;
        width: 40px;
        height: 40px;
        font-size: 20px;
    }

    /* background of the scrollbar except button or resizer */
    .container>div>div:nth-child(4)::-webkit-scrollbar-track {
        background-color:#f0f0f0;
    }
    .container>div>div:nth-child(4)::-webkit-scrollbar-track:hover {
        background-color:#f0f0f0;
    }

    /* scrollbar itself */
    .container>div>div:nth-child(4)::-webkit-scrollbar-thumb {
        background-color:#babac0;
        border-radius:16px;
        border:5px solid #f0f0f0;
    }
    .container>div>div:nth-child(4)::-webkit-scrollbar-thumb:hover {
        background-color:#babac0;
        border:4px solid #f0f0f0;
    }

    /* set button(top and bottom of the scrollbar) */
    .container>div>div:nth-child(4)::-webkit-scrollbar-button {display:none}
</style>