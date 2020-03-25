let i = 0;
let txt = 'Tá achando o mundo real muito chato? \n Venha se divertir com seus amigos virtualmente!';
let speed = 50; 

function typeWriter() {
    if (i < txt.length) {
        if (txt.charAt(i) == '\n')
        document.getElementById("animacao").innerHTML += "<br>";
        else
        document.getElementById("animacao").innerHTML += txt.charAt(i);
        i++;
        setTimeout(typeWriter, speed);
    }
}

export default typeWriter;