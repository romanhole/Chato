<template>
<div id="container">
    <div class="conteudo">
        <div id="primeiraColuna">
            <p>Teste</p>
        </div>
        <div id="segundaColuna">
            <input type="text">
        </div>
    </div>
</div>
</template>

<script>
export default {

}
</script>

<style>
    .conteudo{
    border-radius: 15px;
    background-color: white;
    width: 1400px;
    height: 75%;
    display: flex;
    justify-content: space-between;
    align-items: center;
    position: relative;
    }
    .conteudo::before{
    content: "";
    position: absolute;
    background-color: #8B0000;
    width: 20%;
    height: 100%;
    border-top-left-radius: 15px;
    border-bottom-left-radius: 15px;
    }
    #container{
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100vh;
    background-color: #f0f0f0;
    }
    input{
    }
    #segundaColuna{
        align-items: center;
    }
</style>