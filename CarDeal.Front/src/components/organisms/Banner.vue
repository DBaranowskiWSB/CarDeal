<template>
    <div class="wrapper">
        <!-- <img src="../../assets/images/bannerImg.jpg" alt="" class="bannerImage"> -->
        <div class="bannerImage"></div>
        <div class="bannerText">
            <h1>Car<span>Deal</span> in numbers</h1>
            <p v-if="!USER_LOGGED">Become part of our community and browse through hundreds of offers,
             Sell, buy and get orders. <br> <router-link :to="{name:'Login'}">JOIN NOW</router-link></p>
            <p v-else>Don't waste your time! Check the latest offers,
                <br>
                 Sell, buy and get orders.
            </p>
             <div class="cardsWrapper">
                 <NumberCards/>
             </div>
 
        </div>
        <svg class="shapeBlob" viewBox="0 0 200 200" xmlns="http://www.w3.org/2000/svg">
             <path fill="#383d42" d="M41.1,-43.7C56.7,-36,75.1,-26.2,76.3,-14.3C77.4,-2.3,61.2,11.8,49.9,26.2C38.5,40.6,32,55.2,19.3,65.1C6.6,74.9,-12.2,80,-29.5,75.9C-46.8,71.9,-62.6,58.6,-67.5,42.6C-72.4,26.7,-66.3,8,-61.2,-9.1C-56.2,-26.2,-52.1,-41.8,-42.1,-50.4C-32.1,-59.1,-16,-60.9,-1.6,-59C12.8,-57,25.6,-51.4,41.1,-43.7Z" transform="translate(100 100)" />
       </svg>
    </div>
</template>

<script>
import {mapState} from 'vuex';
import NumberCards from '../molecules/NumberCards.vue';
export default {
    components: {
       NumberCards
    },
    computed: {
         ...mapState(['USER_LOGGED','ALL_DEALERS_NUM']),  
    }
}
</script>

<style lang="scss" scoped>
@import "@/assets/styles/_variables.scss";

    .wrapper {
        display: flex;
        position: relative;
        background-color: $primaryColor;

        .bannerImage {
            position: relative;
            width:100%;
            flex:2;
            background-image: url('../../assets/images/bannerImg2.jpg');
            background-repeat: no-repeat;
            clip-path: polygon(0 0, 100% 0, 88% 100%, 0% 100%);
            background-position: center;
            z-index:1;
            min-height:600px;
            background-size: cover;
            &::before {
                width:100%;
                height:100%;
                position:absolute;
                content:"";
                top:0;
                lefT:0;
                background-color: $secondaryColor;    
                animation: fade 2s 1 forwards alternate;

                @keyframes fade {
                   0% {
                       opacity:0;
                   } 
                   100% {
                       opacity:49%;
                   }
                }
            }
            @media(max-width:768px) {
               min-height: 100vh;
               clip-path: initial;
            }
        }
        .bannerText {
            display: flex;
            z-index:1;
            flex-direction: column;
            justify-content: center;
            align-items: center;
            flex:1;
            @media(max-width:768px) {
               position:absolute;
               top:50%;
               left:50%;
               transform: translate(-50%,-50%);
               background-color: $primaryColorOpacity;
               padding:25px;
               width:55%;
               min-width: 300px;
            }
            .cardsWrapper {
                align-self: flex-start;
                @media(max-width:768px) {
                   align-self: center;
                }
            }

            h1 {
             font-size: 36px;
             font-weight: 600;
             color: #fff;

             span {
                 color: $secondaryTextColor;
             }
            }
            p {
                margin-top: 15px;
                font-weight: 300;
                color:#fff;

                a {
                    display: block;
                    margin-top: 12px;
                    color: $secondaryTextColor;
                }
            }
        }

        @media(max-width:768px) {
            flex-direction: column;
            background-color: transparent !important;
        }
        .shapeBlob {
            width:350px;
            position: absolute;
            bottom:0;
            right:0%;
            z-index:0;
        }
    }
</style>