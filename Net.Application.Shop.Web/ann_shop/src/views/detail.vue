<template>
    <div class="detail">
        <div class="head">
            <span class="head-left">花点时间的店</span>
            <span class="head-right">关注 | 我的记录</span>
        </div>
        <div class="swipe-wrapper">
            <mt-swipe :auto="4000">
                <mt-swipe-item class="slide1">1</mt-swipe-item>
                <mt-swipe-item class="slide2">2</mt-swipe-item>
                <mt-swipe-item class="slide3">3</mt-swipe-item>
            </mt-swipe>
        </div>
        <div class="info">
            <div class="info-title">
                {{sell.SellTitle}}
            </div>
            <div class="info-price">
                <span>￥{{sell.Price}}</span>
            </div>
        </div>

        <mt-cell class="select-cell" title="请选择：" to="#" is-link value="尺码 颜色"></mt-cell>

        <div id="goods-detail" v-html="sell.Product.Introduce">
        </div>

        <mt-tabbar class="buy-bar" style="position:fixed;">
            <div class="buy-bar-d1">
                <router-link to="/user">购物车</router-link>
            </div>
            <div class="buy-bar-d2">加入购物车</div>
            <div class="buy-bar-d3">
                <div @click="popupVisible4 = true">立即购买</div>
            </div>
        </mt-tabbar>
        <mt-popup v-model="popupVisible4" position="bottom" class="mint-popup-4">
            <mt-cell
            title="标题文字"
            to="//github.com"
            is-link
            value="带链接">
            </mt-cell>
            <mt-cell title="标题" label="描述信息" is-link></mt-cell>
            <mt-cell title="标题" label="描述信息" is-link></mt-cell>
            <mt-cell title="标题" label="描述信息" is-link></mt-cell>
            <mt-cell title="标题" label="描述信息" is-link></mt-cell>
        </mt-popup>
    </div>
</template>

<style scoped>
    .mint-popup-4 {
    width: 100%;
    }
    .buy-bar-d1, .buy-bar-d2, .buy-bar-d3{
        padding-top: 15px;
    }
    .buy-bar-d1{
        width: 20%;
    }
    .buy-bar-d2{
        width: 40%;
        color: white;
        background-color: orangered;
    }
    .buy-bar-d3{
        width: 40%;
        color: white;
        background-color: red;
    }
    .buy-bar{
        height: 50px;
    }
    .select-cell{
        margin-top: 20px;
        margin-bottom: 20px;
        border-top: solid 1px #e0e0e0;
        border-bottom: solid 1px #e0e0e0;
    }
    .info{
        padding: 0.6em 0 0.6em 6px;
        height: 100%;
        background-color: #ffffff;
        border-bottom: solid 1px #e0e0e0;
        text-align: left;        
    }
    .info-title{
        padding-bottom: 0.5em;
        border-bottom: solid 1px #e0e0e0;
        word-break: break-all;
        line-height: 1.6em;
        overflow:hidden; 
        text-overflow:ellipsis;
        display:-webkit-box; 
        -webkit-box-orient:vertical;
        -webkit-line-clamp:2; 
    }
    .info-price{
        padding-top: 0.4em;
        color: orangered;
    }
    .detail{
        background-color: #f4f4f4;
        height: 100%;
        min-height: 800px;
    }
    .head {
        height: 26px;
        background-color: #454545;
        color: #dcdcdc;
        text-align: left;
        padding-top: 8px;
        font-size: 16px;
        overflow: hidden;
    }
    .head-left{
        float: left;
        margin-left: 10px;
    }
    .head-right{
        float: right;
        margin-right: 10px;
    }
    .swipe-wrapper{
        height: 300px;
    }
    .mint-swipe {
        color: #fff;
        font-size: 30px;
        text-align: center;
        margin-bottom: 20px;
    }

    .mint-swipe-item {
        line-height: 300px;
    }
    .slide1 {
        background-color: #0089dc;
        color: #fff;
    }

    .slide2 {
        background-color: #ffd705;
        color: #000;
    }

    .slide3 {
        background-color: #ff2d4b;
        color: #fff;
    }
</style>

<script>
    import { Swipe, SwipeItem } from 'mint-ui';
    // Vue.component(Swipe.name, Swipe);
    // Vue.component(SwipeItem.name, SwipeItem);
    export default{
        name: 'detail',
        data(){
            return {
                popupVisible4: false,
                sell: {
                    Product: {
                        Introduce: ""
                    }
                }
            }
        },
        computed: {
            sell_id(){
                return this.$route.params.id
            }
        },
        created(){
            this.fetchData()
        },
        methods: {
            fetchData(){
                let params = {
                    id: this.sell_id
                }
                this.$http({
                    url: '/api/productsell',
                    params: params
                }).then((resp)=>{
                    this.sell = resp
                }).catch((err)=>{
                    console.log(err)
                })
            }
        },
        components: {

        }
    }
</script>