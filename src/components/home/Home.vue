<template>
  <div id="app">
    <nav class="navbar navbar-expand-lg navbar-light fixed-top" id="mainNav">
      <div class="container">
        
        <div class="collapse navbar-collapse" id="navbarResponsive">
          <ul class="navbar-nav ml-auto">
            
            <li class="nav-item">
              <a class="nav-link js-scroll-trigger" href="#sobre">sobre</a>
            </li>
          </ul>
        </div>
      </div>
    </nav>
    <h2>Chato</h2>
    <div >
      <p id="animacao">
      </p>
    </div>
    <button>clique aqui para cadastrar</button>
    <!-- <img> -->
    <section class="contact-section bg-black" id="sobre">
      <div>
        <p>Chato é um chat online gratuito perfeito para você e seus amigos conversarem virtualmente!</p>
      </div>
    </section>
    <div id="contato">
      
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

</style>