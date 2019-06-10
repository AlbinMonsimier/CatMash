<template>
<html>
  <head></head>
  <body>
    <div>
      <router-link class="nav-link" to="/leaderboard" id="leaderboard" style="letter-spacing: 2px;">       
        <h1>LeaderBoard</h1>
      </router-link>

      <h1>Who is the cutest ?</h1>
      <img :src="selectedCat1.url" v-on:click="Vote(selectedCat1.id)" class="catImage">
      <img :src="selectedCat2.url" v-on:click="Vote(selectedCat2.id)" class="catImage">
    </div>
  </body>
</html>
</template>
<script>
import { GetCat } from "../services/ApiService";
import { VoteCat } from "../services/ApiService";
import myCatsJson from "../ressource/mycats.json";

export default {
  data() {
    return {
      myCats: myCatsJson,
      selectedCat1: {},
      selectedCat2: {}
    };
  },

  async mounted() {
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
        console.log(this.myCatsJson.images.length + "catsDeck");
        this.myCats = this.myCatsJson;
      }
    },

    // Pioche aléatoirement un chat dans le JSON et supprime son index pour ne pas retomber dessus 
    DrawCat() {
      let random = Math.floor(Math.random() * (this.myCats.images.length - 1));
      var drawed = this.myCats.images[random];
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
  font-weight: normal;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}

.catImage {
  width: 400px;
  height: 400px;
  display: inline-block;
  margin: auto;
}
</style>
