<template>
    <div class="avaliacao">
        <input type="radio" id="star1"><label for="star1"></label>
        <input type="radio" id="star2"><label for="star2"></label>
        <input type="radio" id="star3"><label for="star3"></label>
        <input type="radio" id="star4"><label for="star4"></label>
        <input type="radio" id="star5"><label for="star5"></label>
    </div>
</template>
<script>
export default{

}
</script>
<style>
@import url(https://use.fontawesome.com/releases/v5.5.0/css/all.css);
body{
    padding: 0;
    margin: 0;
    background: #34495e;
}

.avaliacao{
    position: absolute;
    top: 50%;
    left: 50%;
    transform: translate(-50%, -50%) rotateY(180deg);
    display: flex;
}

.avaliacao label{
    display: block;
    cursor: pointer;
    width: 60px;
    padding-left: 10px;
}

.avaliacao label::before{
    content: '\f005';
    font-family: 'Font Awesome 5 Free';
    font-weight: 900;
    position: relative;
    display: block;
    font-size: 50px;
    color: #1d1c1d;
}
.avaliacao label::after{
    content: '\f005';
    font-family: 'Font Awesome 5 Free';
    font-weight: 900;
    font-size: 50px;
    position: absolute;
    top: 0;
    opacity: 0;
    display: block;
    color: #1f9cff;
    transition: 0.5s;
    text-shadow: 0 2px 5px rgba(0, 0, 0, 0.5);
}
.avaliacao input{
    display: none;
}

.avaliacao label:hover::after, 
.avaliacao label:hover ~ label::after,
.avaliacao input:checked ~ label::after{
    opacity: 1;
}
</style>