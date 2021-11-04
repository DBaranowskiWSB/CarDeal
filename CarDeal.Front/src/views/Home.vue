<template>
  <div class="home">
    <Banner/>
    <Filters/>
  </div>
</template>

<script>
import Banner from '../components/organisms/Banner.vue'
import Filters from '../components/organisms/Filters.vue';
export default {
  name: "Home",
  components: {
    Banner,
    Filters
  }
};
</script>
