<template>
  <div>
      <div class="container" :class="{'open': open}">
          <div>
              <div>
                  <p>Ola</p>
              </div>
          </div>
      </div>
  </div>
</template>

<script>
export default {
    data(){
        return{
            open: false
        }
    },
    methods:{

    },
    name: 'Modal'
}
</script>

<style>
    .container{
        position: fixed;
        display: none;
    }
    .container>div{
        position: fixed;
        top: 0;
        right: 0;
        left: 0;
        bottom: 0
    }
    .container>div>div{
        width: 100%;
        position: absolute;
        top: 50%;
        left: 50%;
    }
</style>