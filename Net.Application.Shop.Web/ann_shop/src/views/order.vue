<template>
    <div class="page">
        <div class="order-addrress">
            <div class="horizontal">
                <div>收货人：{{order.PostReceiver}}</div>
                <div style="float:right">{{order.PostTel}}</div>
            </div>
            <div class="order-address-detail">收货地址：{{order.PostAddress}}</div>
        </div>
        <div class="order-items">
            <CartItem v-for="item in order.Items" :data="item"></CartItem>
        </div>
        <div class="order-form">
            <mt-cell title="配送方式" is-link>
                <span>{{order.PostCompany}}</span>
            </mt-cell>
            <mt-field label="买家留言" placeholder="点击给商家留言"></mt-field>
            <mt-cell title="合计">
                <span style="color: orangered;">￥{{order.TotalPrice}}</span>
            </mt-cell>
        </div>
        <div class="order-coupon">
            <mt-cell title="优惠" is-link>
                <span>使用优惠券</span>
            </mt-cell>
        </div>
        <div class="order-all">
            <div class="horizontal">
                <div>商品金额</div>
                <div style="float:right;">￥{{order.TotalPrice}}</div>
            </div>
            <div class="horizontal">
                <div>运费</div>
                <div style="float:right;">+￥{{order.PostFee}}</div>
            </div>
        </div>
        <mt-tabbar class="order-bar" style="position:fixed;">
            <div class="order-bar-d1">
                <div class="order-bar-total">合计：￥{{order.TotalCost}}</div>
            </div>
            <div class="order-bar-d2">
                <div @click="popupVisible4 = true">
                    <router-link to="#" @click.native="submitData">提交订单</router-link>
                </div>
            </div>
        </mt-tabbar>
    </div>
</template>

<style scoped>
    .order-bar{
        line-height: 50px;
    }
    .order-bar-d1{
        width: 65%;
        background-color: white;
    }
    .order-bar-d2{
        width: 35%;
        background-color: red;
    }
    .order-bar-d2 a{
        color: white;
        text-decoration: none;
    }
    .order-bar-total{
        color: red;
    }
    .page{
        padding-bottom: 100px;
    }
    .order-all{
        background-color: white;
        margin-bottom: 10px;
        padding: 10px 10px;
        line-height: 1.8em;
    }
    .order-coupon{
        margin: 10px 0 10px 0;
    }
    .order-form{
        margin-bottom: 10px;
    }
    .order-items{
        background-color: white;
        margin-top: 10px;
        padding: 10px 0 10px 0;
    }
    .order-addrress{
        background-color: white;
        height: 60px;
        padding: 10px;
        border-bottom: 3px green solid;
    }
    .order-address-detail{
        margin-top: 2px;
        line-height: 1.4em;
        font-size: 12px;
        color: grey;
    }
</style>

<script>
    import CartItem from '../components/cartitem.vue'
    export default {
        name: 'order',
        components: {
            CartItem,
        },
        data(){
            return {
                order: {

                }
            }
        },
        methods: {
            fetchData(){
                let params = {

                }
                this.$http({
                    url: '/api/order',
                    params: params
                }).then((resp)=>{
                    this.order = resp
                    this.order.PostReceiver = '许蕾蕾';
                    this.order.PostAddress = '北京市海淀区西土城路中国政法大学研究生院1号楼6层6012';
                    this.order.PostCompany = '顺丰';
                    this.order.PostTel = '13910704723';
                }).catch((err)=>{
                    console.log(err)
                })
            },
            submitData(){
                let params = {
                    poster: this.order.PostCompany,
                    address: this.order.PostAddress,
                    tel: this.order.PostTel,
                    receiver: this.order.PostReceiver,
                }
                this.$http({
                    url: '/api/order',
                    params: params,
                    type: 'PUT',
                }).then((resp) => {
                    alter(resp)
                }).catch((err)=>{
                    console.log(err)
                })
            }
        },
        created(){
            this.fetchData()
        }
    }
</script>