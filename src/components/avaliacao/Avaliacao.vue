<template>
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
</template>
<script>
function Avaliar(estrela) {
 var url = window.location;
 url = url.toString()
 url = url.split("index.html");
 url = url[0];

 var s1 = document.getElementById("s1").src;
 var s2 = document.getElementById("s2").src;
 var s3 = document.getElementById("s3").src;
 var s4 = document.getElementById("s4").src;
 var s5 = document.getElementById("s5").src;
 var avaliacao = 0;

if (estrela == 5){ 
 if (s5 == url + "img/star0.png") {
 document.getElementById("s1").src = "img/star1.png";
 document.getElementById("s2").src = "img/star1.png";
 document.getElementById("s3").src = "img/star1.png";
 document.getElementById("s4").src = "img/star1.png";
 document.getElementById("s5").src = "img/star1.png";
 avaliacao = 5;
 } else {
 document.getElementById("s1").src = "img/star1.png";
 document.getElementById("s2").src = "img/star1.png";
 document.getElementById("s3").src = "img/star1.png";
 document.getElementById("s4").src = "img/star1.png";
 document.getElementById("s5").src = "img/star0.png";
 avaliacao = 4;
}}
 
 //ESTRELA 4
if (estrela == 4){ 
 if (s4 == url + "img/star0.png") {
 document.getElementById("s1").src = "img/star1.png";
 document.getElementById("s2").src = "img/star1.png";
 document.getElementById("s3").src = "img/star1.png";
 document.getElementById("s4").src = "img/star1.png";
 document.getElementById("s5").src = "img/star0.png";
 avaliacao = 4;
 } else {
 document.getElementById("s1").src = "img/star1.png";
 document.getElementById("s2").src = "img/star1.png";
 document.getElementById("s3").src = "img/star1.png";
 document.getElementById("s4").src = "img/star0.png";
 document.getElementById("s5").src = "img/star0.png";
 avaliacao = 3;
}}

//ESTRELA 3
if (estrela == 3){ 
 if (s3 == url + "img/star0.png") {
 document.getElementById("s1").src = "img/star1.png";
 document.getElementById("s2").src = "img/star1.png";
 document.getElementById("s3").src = "img/star1.png";
 document.getElementById("s4").src = "img/star0.png";
 document.getElementById("s5").src = "img/star0.png";
 avaliacao = 3;
 } else {
 document.getElementById("s1").src = "img/star1.png";
 document.getElementById("s2").src = "img/star1.png";
 document.getElementById("s3").src = "img/star0.png";
 document.getElementById("s4").src = "img/star0.png";
 document.getElementById("s5").src = "img/star0.png";
 avaliacao = 2;
}}
 
//ESTRELA 2
if (estrela == 2){ 
 if (s2 == url + "img/star0.png") {
 document.getElementById("s1").src = "img/star1.png";
 document.getElementById("s2").src = "img/star1.png";
 document.getElementById("s3").src = "img/star0.png";
 document.getElementById("s4").src = "img/star0.png";
 document.getElementById("s5").src = "img/star0.png";
 avaliacao = 2;
 } else {
 document.getElementById("s1").src = "img/star1.png";
 document.getElementById("s2").src = "img/star0.png";
 document.getElementById("s3").src = "img/star0.png";
 document.getElementById("s4").src = "img/star0.png";
 document.getElementById("s5").src = "img/star0.png";
 avaliacao = 1;
}}
 
 //ESTRELA 1
if (estrela == 1){ 
 if (s1 == url + "img/star0.png") {
 document.getElementById("s1").src = "img/star1.png";
 document.getElementById("s2").src = "img/star0.png";
 document.getElementById("s3").src = "img/star0.png";
 document.getElementById("s4").src = "img/star0.png";
 document.getElementById("s5").src = "img/star0.png";
 avaliacao = 1;
 } else {
 document.getElementById("s1").src = "img/star0.png";
 document.getElementById("s2").src = "img/star0.png";
 document.getElementById("s3").src = "img/star0.png";
 document.getElementById("s4").src = "img/star0.png";
 document.getElementById("s5").src = "img/star0.png";
 avaliacao = 0;
}}
 
 document.getElementById('rating').innerHTML = avaliacao;
 
}
</script>
<style>
</style>