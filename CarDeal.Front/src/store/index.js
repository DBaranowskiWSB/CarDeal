import { createStore } from "vuex";

export default createStore({
  state: {
    USER_LOGGED: null,
    ALL_DEALERS_NUM: 178,
    ALL_OFFERS_NUM: 636,
    ALL_USERS_NUM: 1179,

    CAR_DETAILS: {
      BodyType: ['coupe','cabriolet','suv','sedan','compact','combi','other'],
      VehicleBrand: ['bmw','opel','audi','volkswagen','ford','mercedes benz','renault','toyota','skoda','other'],
      FuelType: ['diesel','electric','petrol','lpg']
    }
  },
  mutations: {

  },
  actions: {

  },
  modules: {

  },
});
