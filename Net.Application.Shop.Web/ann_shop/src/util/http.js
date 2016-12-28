import Vue from 'vue'
/**
 * 用fetch封装的http方法
auther : Geoff
使用方法:
this.$http({
  url: '/op/admin/login',
  type: 'POST',  //如果不传type，默认GET
  params: {
   'name': that.username,
   'password': that.password
  }
}).then(function (resp) {})
 */
const Http = {
  install () {
    Vue.prototype.$http = function (options) {
      var url = options.url,
      fetchOption = {
        method: options.type || 'GET',
        credentials: 'same-origin'
      }

      if(fetchOption.method === 'GET'){
        let params = "?"
        for(let key in options.params){
          params += key + '=' + options.params[key] + '&'
        }
        url = url + params
        url = url.substring(0, url.length-1)
      }else if(options.type === 'POST'){
        fetchOption.body = JSON.stringify(options.params)
      }

      return window.fetch(url, fetchOption)
      .then(function (rawResponse) {
        return rawResponse.json()
      })
    }

    window.$http = Vue.prototype.$http;
  }
}

export default Http
