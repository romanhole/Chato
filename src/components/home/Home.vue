<template>
  <div id="app">
    <ul class="topnav">
      <li> <a href="#">Entrar</a> </li>
      <li> <a href="#">Cadastrar</a> </li>
      <li> <a href="#sobre">Sobre</a> </li>
      <li id="logo"> <!-- <img id="imgLogo"> --></li>
    </ul>
    <div id="corpo">
      <h2>Chato</h2>
      <div >
        <p id="animacao">
        </p>
      </div>
      <button>clique aqui para cadastrar</button><br><br>
      <img src="Imagens/Img1.png"> 
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

<style>
  body {
    margin: 0;
  }

  /* CSS do menu */

  ul.topnav {
    list-style-type: none;
    margin: 0;
    padding: 0;
    overflow: hidden;
    background-color: #333;
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
    background-color: #111;
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
    border-color: black;
    background-color: white;
  }
  #animacao{
    font-size: 40px;
  }
  h2{
    font-size: 45px;
    padding-top: 30px;
  }
</style>