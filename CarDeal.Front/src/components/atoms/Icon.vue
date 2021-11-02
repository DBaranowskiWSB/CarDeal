<template>
    <img v-bind:src="link" v-bind:alt="altMsg">
</template>


<script>
export default {
    props: ['link','altMsg']
}
</script>

<style lang="scss" scoped>
    img {
        width:20px;
    }
</style>