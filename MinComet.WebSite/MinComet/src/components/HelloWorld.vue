<template>
  <div class="hello">
    <h1>{{ msg }}</h1>
    <div @click="jump('www.baidu.com','tab')">test1</div>
    <router-link to="/home">新的标签页打开首页</router-link>
    <router-link target="_blank" to="/home">新的标签页打开首页</router-link>
    <div @click="jump('www.baidu.com')">test2</div>
    <div @click="$router.go(1)">前进</div>
    <div @click="$router.go(-1)">后退</div>
    <div @click="$router.back()">后退2</div>
  </div>
</template>

<script>
export default {
  name: "HelloWorld", //'HelloWorld',
  data() {
    return {
      msg: "Welcome to Your Vue.js App",
    };
  },
   methods: {
    jump(url,type) {
      if(type=='tab'){
     const newsUrl = this.$router.resolve(url);
     window.open(newsUrl.href);
      }
      else{
this.$router.push({path:`${url}?a=1`});
      }
    },
  } 
};
</script>

<!Add "scoped" attribute to limit CSS to this component only -->
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
</style>
