<template>
  <div id="app">
    <header>
      <div class="navbar">
        <router-link class="nav-link" to="/" id="home">
          <h1>CatMash</h1>
        </router-link>
        <router-link class="nav-link" to="/leaderboard" id="leaderboard">
          <h1>LeaderBoard</h1>
        </router-link>
      </div>
    </header>
    <router-view/>
  </div>
</template>

<script>
export default {
  name: "App"
};
</script>

<style>
#app {
  font-family: "Avenir", Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}
.navbar {
  align: top;
  height: 70px;
  weight: 50px;
  background-color: #c41414;
}

.navbar h1 {
  margin-top: 0;
  margin-left: 3%;
  vertical-align: text-bottom;
  color: white;
  display: inline-block;
  text-align: right;
  font-size: 59px;
  
}

.navbar h1:hover {
  color: black;
}


a {
  text-decoration: none;
}

body {
  margin: 0;
  padding: 0;
}
</style>
