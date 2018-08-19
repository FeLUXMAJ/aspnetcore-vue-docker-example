<template>
  <div id="app">
    <img src="./assets/logo.png">
    <h1>{{ msg }}</h1>
    <p>There are some data from backend:</p>
    <ul>
      <li
        v-for="(value, index) in values"
        :key="index"
      >
        <b>{{ value }}</b>
      </li>
    </ul>
  </div>
</template>

<script>
export default {
  name: 'app',
  data () {
    return {
      msg: 'Vue SPA',
      apiUri: 'http://localhost:5000/api/values',
      values: ['Loading ...']
    }
  },
  created: function () {
    // for quick starting, import axios from cdn
    axios
      .get(this.apiUri)
      .then(res => {
        console.log(res)
        if (res.status === 200) {
          this.values = res.data
        }
      })
      .catch(console.error)
  }
}
</script>

<style>
#app {
  font-family: 'Montserrat', 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}

h1, h2 {
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
</style>
