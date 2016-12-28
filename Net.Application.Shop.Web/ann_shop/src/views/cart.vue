<template>
    <div class="cart">
        <div class="horizontal cart-header">
            <div>
                <Checkbox></Checkbox>
            </div>
            <div>全选</div>
        </div>
        <div class="cart-body">
            <CartItem v-for="item in list" :data="item"></CartItem>
        </div>
        <!--<table class="cart-body">
            <tr class="cart-item" v-for="n in 10">
                <td><Checkbox></Checkbox></td>
                <td><img src="" class="item-photo" /></td>
                <td>
                    <span>祖师闻言，咄的一声，跳下高台，手持戒尺，指定悟空道：“你这猢狲，这般不学，那般不学，却待怎么？”</span>
                </td>
            </tr>
            <tr>
                <td colspan="3" class="item-split-line"></td>
            </tr>
        </table>-->
        <mt-tabbar class="cart-bar" style="position:fixed;">
            <div class="cart-bar-d1">
                <Checkbox></Checkbox>全选
            </div>
            <div class="cart-bar-d2">
                <div class="cart-bar-total">合计：￥606.14</div>
                <div class="cart-bar-total-sub">不含运费</div>
            </div>
            <div class="cart-bar-d3">
                <div @click="popupVisible4 = true">
                    <router-link to="/order">结算(4)</router-link>
                </div>
            </div>
        </mt-tabbar>
    </div>
</template>

<style>
    .cart-bar{
        height: 50px;
        line-height: 50px;
    }
    .cart-bar-d1, .cart-bar-d2{
        background-color: white;
    }
    .cart-bar-d1{
        width: 20%;
        font-size: 14px;
    }
    .cart-bar-d2{
        width: 55%;
        font-size: 10px;
        text-align: right;
        padding-right: 10px;
    }
    .cart-bar-d3{
        width: 25%;
        background-color: red;
    }
    .cart-bar-d3 a{
        color: white;
        text-decoration: none; 
    }
    .cart-bar-total{
        margin-top: 10px;
        color: orangered;
    }      
    .cart-bar-total, .cart-bar-total-sub {
        line-height: 1.8em;
    }
    table, tr, td {
        padding: 0px;
    }
    .item-split-line{
        height: 8px;
        background-color: white;
    }
    .cart{
        background-color: #f4f4f4;
        padding: 10px 0px;
    }
    .cart-header{
        line-height: 40px;
        background-color: white;
        font-size: 14px;
    }
    .cart-header div {
        height: 100%;
        vertical-align: middle;
    }
    .cart-body{
        background-color: white;
    }
</style>

<script>
    import Checkbox from '../components/checkbox.vue'
    import CartItem from '../components/cartitem.vue'
    export default {
        name: 'cart',
        components: {
            Checkbox,
            CartItem,
        },
        data(){
            return {
                list: [],
            }
        },
        created: function(){
            this.fetchData()
        },
        methods: {
            fetchData(){
                this.$http({
                    url: '/api/cart'
                }).then((resp)=>{
                    this.list = resp
                }).catch((err)=>{
                    console.log(err)
                })
            }
        }
    }
</script>