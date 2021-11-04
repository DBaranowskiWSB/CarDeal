<template>
   <section>
    <h2><span>B</span>rowse Our Offers</h2>
    <p>Filter among houndred of offers</p>
    <div class="wrapper">

        <form action="">
            <h3>What are you looking for?</h3>
  
            <div class="carType type">
                <div>
                   <label for="BodyType">Type of car body</label>
                   <select name="BodyType" id="BodyType">
                     <option v-for="type of CAR_DETAILS.BodyType" :key="type" :value="type">{{type.toUpperCase()}}</option>
                   </select>
                </div>

                <div>
                    <label for="VehicleBrand">Car brand</label>
                    <select name="VehicleBrand" id="VehicleBrand">
                      <option v-for="brand of CAR_DETAILS.VehicleBrand" :value="brand" :key="brand">{{brand.toUpperCase()}}</option>
                   </select>
                </div>
            </div>
            <div class="carNameAndFuel type">
                <div>
                    <label for="Model">Car model</label>
                   <input type="text" id="Model" placeholder="Type car model">
                </div>
                <div>
                  <label for="FuelType">Type of fuel</label>
                  <select name="FuelType" id="FuelType">
                    <option v-for="fuel of CAR_DETAILS.FuelType" :value="fuel" :key="fuel">{{fuel.toUpperCase()}}</option>
                  </select>
                </div>

            </div>

            <div class="carPrice type">
                <div>
                   <label for="MinPrice">Minimum Price</label>
                   <input type="number" id="MinPrice" placeholder="from">
                </div>
                <div>
                   <label for="MaxPrice">Maximum Price</label>
                   <input type="number" id="MaxPrice" placeholder="to">
                </div>

            </div>
            <div class="carMilleage type">
                <div>
                   <label for="MinMilleage">Minimum Milleage</label>
                   <input type="number" id="MinMilleage" placeholder="from">
                </div>
                <div>
                   <label for="MaxMilleage">Maximum Milleage</label>
                   <input type="number" id="MaxMilleage" placeholder="to">
                </div>

            </div>
            <div class="carYearOfProd type">
                <div>
                   <label for="MinYearOfProd">Minimum Year</label>
                   <input type="number" id="MinYearOfProd" placeholder="from">
                </div>
                <div>
                   <label for="MaxYearOfProd">Maximum Year</label>
                   <input type="number" id="MaxYearOfProd" placeholder="to">
                </div>

            </div>

            <button>Search</button>

        </form>
      </div>
    </section>
</template>

<script>
import { mapState } from 'vuex'
export default {

    computed: {
        ...mapState(['CAR_DETAILS']),
    }
}
</script>

<style lang="scss" scoped>
@import "@/assets/styles/_variables.scss";
    section {     
       background-image: url('../../assets/images/bannerImg3.jpg');
       background-repeat: no-repeat;
       background-position: center;
       position: relative;
       padding: 100px 50px;
       margin: 60px 0;

       h2 {
           color:$primaryTextColor;
           text-align:left;
           font-size:48px;

           span {
               color:#fff;
               background: $secondaryColor;
           }
       }
       p {
           text-align: left;
           margin-bottom: 40px;
           margin-top: 5px;
           font-weight: 600;
       }
   }
   .wrapper {
       display: flex;
       flex-direction: column;
       align-items: flex-start;
       background-color:#efefef;
       box-shadow: 0px 5px 10px 1px rgba(126, 126, 126, 0.295);
       width:40%;
       min-width: 300px;
       text-align: left;
       form {
           margin: 0 auto;
           padding: 25px;
           .type {
               display: flex;
               text-align: left;
               flex-wrap: wrap;

               div {
                   display: flex;
                   flex-direction: column;
                   margin-right: 25px;
                   margin-top: 10px;

                   label {
                       margin-bottom: 5px;
                   }
               }

           }
       }
   }
</style>