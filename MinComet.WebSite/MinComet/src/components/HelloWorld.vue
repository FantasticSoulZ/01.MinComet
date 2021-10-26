
<template>
  <div class="hello">
    <h1>{{ msg }}</h1>
    <div @click="jump('www.baidu.com', 'tab')">test1</div>
    <router-link to="/home">新的标签页打开首页</router-link>
    <router-link target="_blank" to="/home">新的标签页打开首页</router-link>
    <div @click="jump('www.baidu.com')">test2</div>
    <div @click="$router.go(1)">前进</div>
    <div @click="$router.go(-1)">后退</div>
    <div @click="$router.back()">后退2</div>
    <div @click="send()">tesGet</div>
    <div @click="sendGet()">testGet2</div>
    <div @click="sendPost()">testPost2</div>
  </div>
</template>

<script>
/* eslint-disable */
const axios = require('axios');
export default {
  name: "HelloWorld", //'HelloWorld',
  data() {
    return {
      msg: "Welcome to Your Vue.js App",
    };
  },
  methods: {
    jump(url, type) {
      if (type == "tab") {
        const newsUrl = this.$router.resolve(url);
        window.open(newsUrl.href);
      } else {
        this.$router.push({ path: `${url}?a=1` });
      }
    },
    send() {
      axios({
        //格式a
        method: "get",
        url: "/api/Login",
      })
        .then(function (resp) {
          console.log(resp.data);
        })
        .catch((resp) => {
          console.log("请求失败：" + resp.status + "," + resp.statusText);
        });
    },
    sendGet() {
      axios
        .get("/api/Login/getId", {})
        .then((resp) => {
          console.log(resp.data);
        })
        .catch((err) => {
          //
          console.log("请求失败：" + err.status + "," + err.statusText);
        });
    },
    sendPost() {
      axios
        .post(
          "/api/Login?Account=123&Password=123",
          null,
          // {
          //   //方式2通过transformRequest方法发送数据，本质还是将数据拼接成字符串
          //   transformRequest: [
          //     function (data) {
          //       let params = "";
          //       for (let index in data) {
          //         params += index + "=" + data[index] + "&";
          //       }
          //       return params;
          //     },
          //   ],
          // }
          {
            transformRequest: [
              function () {
                return "";
              },
            ],
          }
        )
        .then((resp) => {
          console.log(resp.data);
        })
        .catch((err) => {
          console.log("请求失败：" + err.status + "," + err.statusText);
        });
    },
  },
};
/* eslint-enable */
</script>

<!--Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
/* eslint-disable */
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
/* eslint-enable */
</style>
