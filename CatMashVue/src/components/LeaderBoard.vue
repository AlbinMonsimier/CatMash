<template>
<html>
  <head></head>
  <body>
    <center>
      <table style="margin-top:100px;">
        <thead>
          <tr>
            <th><h1>Rank</h1></th>
            <th><h1>Cat</h1></th>
            <th><h1>Like</h1></th>
          </tr>
        </thead>
        <tr v-for="(data, index) in leaderBoard">
          <td><h1>{{index+1}}</h1></td>
          <td>
            <img :src="catsJson.images[index].url" class="catImageLeaderBoard">
          </td>
          <td><h1>{{data.catScore}}</h1></td>
        </tr>
      </table>
    </center>
  </body>
</html>
</template>
<script>
import { GetLeaderBoard } from "../services/ApiService";
import { GetCatsJSON } from "../services/ApiService";

export default {
  data() {
    return {
      leaderBoard: {},
      catsJson: {}
    };
  },

  async mounted() {
    this.leaderBoard = this.GetLeaderBoard();
    this.catsJson = await GetCatsJSON();
  },

  methods: {
    async GetLeaderBoard() {
      this.leaderBoard = await GetLeaderBoard();
    },
    Increment(index) {
      return index + 1;
    }
  }
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
table,
td {
  text-align: center;
  border: 2px solid #333;
}

th {
  background-color: #c41414;
    padding-right: 50px;
    padding-left: 50px;
}

h1 {
  font-size: 50px;
}

.catImageLeaderBoard {
  width: 600px;
  height: 400px;
  display: inline-block;
  align-self: center;
}

thead,
tfoot {
  background-color: #333;
  color: #fff;
}
</style>
