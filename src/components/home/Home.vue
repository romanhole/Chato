<template>
  <div id="topo">
    <ul class="topnav">
      <li> <router-link to="/Login">Entrar</router-link></li>
      <li> <router-link to="/cadastro">Cadastro</router-link><li>
      <li> <router-link to="/avaliacao">Avaliação</router-link><li>
      <li> <a href="#sobre">Sobre</a> </li>
      <li id="logo"> <!-- <img id="imgLogo"> --></li>
    </ul>
    <div id="corpo">
      <h2>CHATO</h2>
      <div >
        <p id="animacao">
        </p>
      </div>
      <button>Clique aqui para cadastrar</button><br><br>
      <img src="./Imagens/Img1.png"> 
      <section class="contact-section bg-black" id="sobre">
        <div>
          <p>Chato é um chat online gratuito perfeito para você e seus amigos conversarem virtualmente!</p>
        </div>
      </section>
      <div id="contato">
        
      </div>
    </div>
  </div>
</template>

<script>
import typeWriter from './writer'
window.onload = typeWriter;
export default {

}
</script>

<style scoped>
  #topo {
    align-content: center;
    color: #8B0000;
    background-color: #f0f0f0	;
    height: 100%;
    width: 100%;
  }

  /* CSS do menu */

  ul.topnav {
    list-style-type: none;
    margin: 0;
    padding: 0;
    overflow: hidden;
    color: #f0f0f0;
    /*background-color: #333;*/
    background-color: #000000;
    top: 0;
    position: fixed;
    width: 100%;
  }

  ul.topnav li {
    float: right;
  }

  #logo {
    float: left;
  }
  #imgLogo{
    width: 46px;
  }

  ul.topnav li a {
    display: block;
    color: white;
    text-align: center;
    padding: 14px 16px;
    text-decoration: none;
  }

  ul.topnav li a:hover:not(.active) {
    background-color: #f0f0f0;
    color: #000000;
  }

  ul.topnav li a.active {
    background-color: #4CAF50;
  }

  /*@media screen and (max-width: 600px) {
    ul.topnav li {float: none;}
  }*/

  /* Fim do CSS do menu */
  button{
    border-width: 3px;
    color: #8B0000;
    border-color: #000000;
    background-color: #f0f0f0;
    border-radius:4px;
    cursor:pointer;
    height: 70px;
    width: 500px;
    font-size: 25px;
  }
  button:hover{
    background-color: lightgray;
    color: #8B0000;
  }
  #animacao{
    padding-bottom: 50px;
    font-size: 40px;
  }
  h2{
    font-size: 65px;
    padding-top: 50px;
  }
  #corpo{
    text-align: center;
  }
  p{
    padding-top: 40px;
    font-size: 25px;
  }
</style>