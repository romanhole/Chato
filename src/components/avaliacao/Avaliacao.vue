<template>
    <div>
        <a href="javascript:void(0)" onclick="Avaliar(1)">
        <img src="img/star0.png" id="s1"></a>

        <a href="javascript:void(0)" onclick="Avaliar(2)">
        <img src="img/star0.png" id="s2"></a>

        <a href="javascript:void(0)" onclick="Avaliar(3)">
        <img src="img/star0.png" id="s3"></a>

        <a href="javascript:void(0)" onclick="Avaliar(4)">
        <img src="img/star0.png" id="s4"></a>

        <a href="javascript:void(0)" onclick="Avaliar(5)">
        <img src="img/star0.png" id="s5"></a>
        <p id="rating">0</p>
        <input type="text" placeholder="Deixe nos um comentario!">
    </div>
</template>
<script>
export default {

}
/*function Avaliar(estrela) {
 var url = window.location;
 url = url.toString()
 url = url.split("index.html");
 url = url[0];

 var s1 = document.getElementById("s1").src;
 var s2 = document.getElementById("s2").src;
 var s3 = document.getElementById("s3").src;
 var s4 = document.getElementById("s4").src;
 var s5 = document.getElementById("s5").src;

if(estrela >= 1){
    document.getElementById("s1").src = "img/star1.png";
    if(estrela >= 2){
        document.getElementById("s2").src = "img/star1.png";
        if(estrela >= 3){
            document.getElementById("s3").src = "img/star1.png";
            if(estrela >= 4){
                document.getElementById("s4").src = "img/star1.png";
                if(estrela == 5){
                    document.getElementById("s5").src = "img/star1.png";
                }
            }
        }
    }
}
 
 document.getElementById('rating').innerHTML = estrela;
 
}*/
</script>
<style scoped>
</style>