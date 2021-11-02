<template>
  <div class="app-wrapper">
     <div class="app">
        <Navigation/>
        <router-view />
     </div>

  </div>

</template>

<script>
import Navigation from '../src/components/molecules/Navigation.vue';
export default {
  name: 'app',
  components: {
    Navigation,
  }
}
</script>

<style lang="scss">
@import url('https://fonts.googleapis.com/css2?family=Roboto:ital,wght@0,100;0,400;0,700;1,300&display=swap');
@import "./assets/styles/variables.scss"; //wymagne w kazdym komponencie 

* {
  margin:0;
  padding: 0;
}

#app {
  font-family: Roboto, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: $primaryTextColor;
}

.app {
  display: flex;
  flex-direction: column;
  min-height: 100vh;
}

a {
  font-weight: bold;
  color: $primaryTextColor;
  text-decoration: none;

  &.router-link-exact-active {
      color: $secondaryTextColor;
  }
}

.container {
  display: flex;
}

</style>
