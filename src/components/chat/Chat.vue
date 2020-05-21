<template>
<div id="caixa">
    <div class="cont">
        <div id="Coluna1">
            <p>Teste</p>
        </div>
        <div id="Coluna2">
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
    .cont{
    border-radius: 15px;
    background-color: white;
    width: 1400px;
    height: 75%;
    display: flex;
    justify-content: space-between;
    align-items: center;
    position: relative;
    }
    .cont::before{
    content: "";
    position: absolute;
    background-color: #8B0000;
    width: 30%;
    height: 100%;
    border-top-left-radius: 15px;
    border-bottom-left-radius: 15px;
    }
    #caixa{
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100vh;
    background-color: #f0f0f0;
    }
    input{
        float: bottom;
    }
    #Coluna1{
        flex: 2 0 auto;
        display: flex;
        flex-direction: column;
        align-items: center;
        order: 1;
    }
    #Coluna2{
        text-align: center;
        flex: 1.5 0 auto;
        z-index: 10;
        order: 2;
    }
</style>