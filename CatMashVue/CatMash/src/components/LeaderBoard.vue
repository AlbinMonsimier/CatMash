<template>
<html>
  <head></head>
  <body>
    <div>
        {{leaderBoard}}
    </div>
  </body>
</html>
</template>
<script>

import { GetLeaderBoard } from "../services/ApiService";


export default {
  data() {
    return {
        leaderBoard: {}
    };
  },

  async mounted() {
    this.leaderBoard = this.GetLeaderBoard();
  },

  methods: {
    async GetLeaderBoard() {
      this.leaderBoard = await GetLeaderBoard();
    }
  }
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>
