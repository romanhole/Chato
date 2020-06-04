<template>
<div id="teste">
  <div class="todo">
      <div class="item article-01">
          <div class="left">
              <div class="left-01">
              </div>
              <div class="left-02">
                  <input type="text" id="procurar">
              </div>
              <div class="left-03">
              </div>
          </div>
      </div>
      <div class="item article-02">
          <div class="right">
              <div class="right-01">
                  <input type="text" id="msg">
              </div>
              <div class="right-02">
                <!--<div v-for="message in messages" :key="message.Id" v-bind="message" :class="{['recebida']: message.recieved, ['enviada']: message.sended}">
                    <h1 v-if="message.grupo">{{ message.Nome }}</h1>
                    <p>{{ message.Text }}</p>
                </div>-->
                <div class="recebida">
                    <h1>João</h1>
                    <p>Ola, amigos tudo bem?</p>
                </div>                          
                <div class="mensagem enviada">
                    <h1>Eu</h1>
                    <p>orem ipsum dolor sit amet, consectetur adipiscing elit. Mauris in condimentum nulla. Mauris convallis nisl sed pharetra suscipit. Vivamus euismod pulvinar leo quis gravida. Curabitur in magna sem.</p>
                </div>                                              
              </div>
              <div class="right-03">
              </div>
          </div>
      </div>
  </div>
</div>
</template>

<script>
export default {
    data(){
        return{
            messages:[]
        }
    }
}
/*window.onload = function(){
    var conectado = false;
    if(!conectado)
        HttpResponse.RedirectToRoute('/login');
    window.setInterval(1000,atualizar());
}
function atualizar(){
    //atualizar o chat a cada 1 seg pra ver se tem mensagem nova.
}*/
</script>

<style scoped>
#teste{
    width: 100%;
    height: 100vh;
    display: flex;
    justify-content: center;
    align-items: center;
}
.todo{
    height: 800px;
    width: 1400px;
    display: flex;
    flex-direction: row;
    flex-wrap: wrap;
}
.article-01{
    width: 25%;
    background-color: #8B0000;
    border-top-left-radius: 15px;
    border-bottom-left-radius: 15px;
}
.article-02{
    width: 75%;
    background-color: #f0f0f0;
    border-top-right-radius: 15px;
    border-bottom-right-radius: 15px;
}

.left{
    display: flex;
    flex-direction: column;
}
.left-01{
    height: 60px;
    background-color: rgb(100, 1, 1);
    border-top-left-radius: 15px;
}
.left-02{
    height: 50px;
    display: flex;
    flex-direction: column;
    width: 100%;
    align-items: center;
    justify-content: center;
    border-bottom: 1px solid rgb(100, 1, 1);
}
.left-03{
    height: 690px;
}
#procurar{
    border-radius: 7px;
    border-style: none;
    outline: none;
    width: 280px;
    height: 20px;
}
.right{
    display: flex;
    flex-direction: column-reverse;
    justify-content: space-between;
    width: 100%;
    height: 100%;
}
#msg{
    width: 750px;
    height: 35px;
    border-radius: 7px;
    border-style: none;
    outline: none;
    font-size: 15px;
}
.right-01{
    display: flex;
    flex-direction: row;
    width: 100%;
    height: 60px;
    background-color: lightgrey;
    justify-content: center;
    align-items: center;
    border-bottom-right-radius: 15px;
}
.right-02{
    height: 680px;
    width: 100%;
    display: flex;
    flex-direction: column;
    align-items: flex-start;
    justify-content: flex-start;
    padding: 15px;
}
.right-02>div{
    display: flex;
    flex-direction: column;
    max-width: 40%;
    background-color: white;
    padding: 10px;
    border-radius: 10px;
    margin-bottom: 10px;
}
.right-02>div h1{
    font-size: 17px;
    color: blue;
    margin-bottom: 3px;
}
.right-02>div p{
    text-align: justify;
}
.recebida{
    align-self: flex-start;
}
.enviada{
    align-self: flex-end;
}
.right-03{
    height: 60px;
    background-color: lightgray;
    border-top-right-radius: 15px;
}
</style>