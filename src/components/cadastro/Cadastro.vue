<template>
  <div class="container">
        <div class="conteudo">
                <div class="primeira-coluna">
                    <h2 class="title title-primario">Bem-vindo!</h2>
                    <p class="descricao">Logue no Chato com suas informações pessoais</p>
                    <p class="descricao">e se divirta virtualmente!</p>
                    <button class="btn btn-primario">Login</button>
                </div>
                <div class="segunda-coluna">
                    <h2 class="title title-secundario">Criar conta</h2>
                    <form class="form">
                        <label class="label-input" for="">
                            <i class="fas fa-user icon-modify"></i>
                            <input type="text" placeholder="Nome">
                        </label>
                        <label class="label-input" for="">
                            <i class="fas fa-envelope icon-modify"></i>
                            <input type="email" placeholder="Email">
                        </label>
                        <label class="label-input" for="">
                            <i class="fas fa-lock icon-modify"></i>
                            <input type="password" placeholder="Senha">
                        </label>
                        <br>
                        <button class="btn btn-secundario">Cadastrar</button>
                    </form>
                </div>
        </div>
    </div>
</template>

<script>
export default {

    src="https://kit.fontawesome.com/9f8b65618e.js", crossorigin="anonymous"

}
</script>

<style>
    @import url('https://fonts.googleapis.com/css2?family=Open+Sans:wght@300;400;700&display=swap');
*{
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}
body{
    font-family: 'Open Sans', sans-serif;
}
.conteudo{
    border-radius: 15px;
    background-color: white;
    width: 960px;
    height: 50%;
    display: flex;
    justify-content: space-between;
    align-items: center;
    position: relative;
}
.conteudo::before{
    content: "";
    position: absolute;
    background-color: #8B0000;
    width: 40%;
    height: 100%;
    border-top-left-radius: 15px;
    border-bottom-left-radius: 15px;
}
.container{
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100vh;
    background-color: #f0f0f0;
}
.title{
    font-size: 30px;
    font-weight: bold;
}
.title-primario{
    color: white;
}
.title-secundario{
    color:#8B0000;
    height: 80px;
}
.descricao{
    font-size: 14px;
    font-weight: 300;
    color: white;
    line-height: 30px;
}
.btn{
    border-radius: 15px;
    text-transform: uppercase;
    color: white;
    font-size: 12px;
    cursor: pointer;
    font-weight: bold;
    width: 150px;
    align-self: center;
    border: none;
    height: 35px;
}
.btn-primario{
    background-color: transparent;
    border: 1px solid white;
}
.btn-primario:hover{
    background-color: white;
    color: #8B0000;
}
.btn-secundario{
    background-color: #8B0000;
}
.btn-secundario:hover{
    background-color: white;
    color: #8B0000;
    border: 1px solid #8B0000;
}
.primeira-coluna{
    text-align: center;
    flex: 0.5 0 auto;
    z-index: 10;
}
.segunda-coluna{
    flex: 2 0 auto;
    display: flex;
    flex-direction: column;
    align-items: center;
}
.form{
    display: flex;
    flex-direction: column;
    width: 55%;
}
.form input{
    height: 45px;
    width: 100%;
    border: none;
    background-color: #ecf0f1;
}
.label-input{
    background-color: #ecf0f1;
    display: flex;
    align-items: center;
    margin: 8px;
}
.icon-modify{
    color: #7f8c8d;
    padding: 0 5px;
}
</style>