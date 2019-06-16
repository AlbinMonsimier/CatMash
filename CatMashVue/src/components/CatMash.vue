<template>
<html>
  <head></head>
  <body>
    <div>
      <h1>Who's cutest ? Click to Choose</h1>
      <center>
        <div class="images">
          <img :src="selectedCat1.url" v-on:click="Vote(selectedCat1.id)" class="catImage" ALIGN="top" >
          <p> OR</p>
          <img :src="selectedCat2.url" v-on:click="Vote(selectedCat2.id)" class="catImage" ALIGN="top" >
          </div>
      </center>
    </div>
  </body>
</html>
</template>
<script>
import { GetCat } from "../services/ApiService";
import { GetCatsJSON } from "../services/ApiService";
import { VoteCat } from "../services/ApiService";

export default {
  data() {
    return {
      myCats: {},
      selectedCat1: {},
      selectedCat2: {}
    };
  },

  async mounted() {
    this.myCats = await GetCatsJSON();
    console.log("myCats");
    this.selectedCat1 = this.DrawCat();
    this.selectedCat2 = this.DrawCat();
  },

  methods: {
    // Incrémente le score du chat passé en argument et pioche 2 autres chats
    async Vote(catId) {
      await VoteCat(catId);
      this.selectedCat1 = this.DrawCat();
      this.selectedCat2 = this.DrawCat();
      if (this.myCats.images.length <= 1) {
        // Quand la pile de chat est a 0, recupère une nouvelle pile
        this.myCats = await GetCatsJSON();
      }
    },

    // Pioche aléatoirement un chat dans le JSON et supprime son index pour ne pas retomber dessus
    DrawCat() {
      let random = Math.floor(Math.random() * (this.myCats.images.length - 1));
      let drawed = this.myCats.images[random];
      this.myCats.images.splice(random, 1);
      return drawed;
    }
  }
};
</script>



<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h1,
h2 {
  font-size: 50px;
  font-weight: normal;
}

 p {
  font-size: 40px;
  margin-bottom: 10%;
  display: inline-block;
}

.images {
  width: 1300px;
}

.images p {
  margin-top: 20%;
  padding: 1%;
}

.catImage {
  width: 400px;
  height: 600px;
  display: inline-block;
  margin: auto;
}
</style>
