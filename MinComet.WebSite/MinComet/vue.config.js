module.exports = {
    devServer: {
      proxy: {
        '/api': {
          target: 'https://localhost:5001/api',
          ws: true,
          secure:false,
          changeOrigin: true,
          pathRewrite:{
              '^/api':''
          }
        },
        '/foo': {
          target: '<other_url>'
        }
      }
    }
  }
  
  
//   module.exports = {
//     devServer: {
//       proxy: 'http://localhost:4000'
//     }
//   }