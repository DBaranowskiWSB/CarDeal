<template>
    <div class="wrapper">
        <div class="card">
            <Icon :link="require('../../assets/icons/user-crown-light.svg')"/>
            <p>{{ALL_DEALERS_NUM}} <span>Dealers</span> </p>

        </div>
        <div class="card">
            <Icon :link="require('../../assets/icons/envelope-regular.svg')"/>
            <p>{{ALL_OFFERS_NUM}} <span>Offers</span> </p>
        </div>
        <div class="card">
            <Icon :link="require('../../assets/icons/user-alt-light.svg')"/>
            <p>{{ALL_USERS_NUM}} <span>Users</span> </p>
        </div>

    </div>
</template>

<script>
import Icon from '../atoms/Icon.vue'
import { mapState } from 'vuex';
export default {
    components: {
        Icon
    },
    props: {
        link: String,
        num: Number,
        text: String
    },
    computed: {
        ...mapState(['ALL_DEALERS_NUM','ALL_OFFERS_NUM','ALL_USERS_NUM']),  
    }
}
</script>

<style lang="scss" scoped>
@import "@/assets/styles/_variables.scss";
   .wrapper {
       display: flex;
       flex-direction: column;
       align-items: center;
       justify-content: center;
       color:#fff;

       .card {
           display: flex;
           padding:25px;
           box-shadow: 0px 5px 10px 1px rgba(0, 0, 0, 0.295);
           margin: 10px;
           justify-content: space-evenly;
           width:200px;
           text-align: left;
           transition: box-shadow .4s;
           cursor:pointer;

           img {
               width:25px;
           }
           p:first-of-type {
               color:$secondaryTextColor;
               font-weight: 600;
               span {
                   color:#fff;
               }
           }

           &:hover {
                box-shadow: 0px 5px 10px 1px rgba(0, 0, 0, 0.634);
           }
       }
   }
    
</style>