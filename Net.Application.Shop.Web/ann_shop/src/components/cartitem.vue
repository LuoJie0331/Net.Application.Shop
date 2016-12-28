<template>
    <div class="cart-item">
        <div class="cart-item-part">
            <Checkbox></Checkbox>
        </div>
        <div class="cart-item-part">
            <img src="" class="item-photo" />
        </div>
        <div class="cart-item-part" style="width: 240px;">
            <span class="item-title">{{data.ProductSell.SellTitle}}</span>
            <span class="item-option">单月（4束） 不加购毛毯，周六收货，顺丰快递，礼品卡包装</span>
            <div class="item-cost">
                <span class="item-cost-price">￥{{data.Price}}</span>
                <span class="item-cost-count">x{{data.Count}}</span>
            </div>
        </div>
    </div>
</template>

<style>
    .cart-item{
        overflow: hidden;
        vertical-align: middle;
        background-color: #fafafa;
        height: 100px;
        font-size: 12px;
        margin-bottom: 8px;
    }
    .cart-item-part{
        float: left;
        line-height: 100px;
    }
    .item-photo{
        margin: 5px;
        width: 90px;    
        height: 90px;
    }
    .item-title{
        word-break: break-all;
        line-height: 1.4em;
        overflow:hidden; 
        text-overflow:ellipsis;
        display:-webkit-box; 
        -webkit-box-orient:vertical;
        -webkit-line-clamp:2; 
        padding-top: 8px;
    }
    .item-option{
        word-break: break-all;
        line-height: 1.2em;
        overflow:hidden; 
        text-overflow:ellipsis;
        display:-webkit-box; 
        -webkit-box-orient:vertical;
        -webkit-line-clamp:1; 
        color: gray;
    }
    .item-cost{
        line-height: 40px;
        vertical-align: bottom;
    }
    .item-cost-price{
        color: orangered;
        font-size: 16px;
    }
    .item-cost-count{
        float: right;
        color: grey;
    }
</style>

<script>
    import Checkbox from '../components/checkbox.vue'
    export default {
        name: 'cartitem',
        components: {
            Checkbox,
        },
        props: {
            data: {
                type: Object,
                require: true
            }
        }
    }
</script>