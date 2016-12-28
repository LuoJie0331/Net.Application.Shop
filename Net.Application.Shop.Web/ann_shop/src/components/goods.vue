<template>
    <div class="goods page">
        <mt-swipe :auto="4000">
            <mt-swipe-item class="goods-photo">
                <img src="static/images/1.jpg"/>
            </mt-swipe-item>
            <mt-swipe-item class="goods-photo">
                <img src="static/images/2.jpg"/>
            </mt-swipe-item>
            <mt-swipe-item class="goods-photo">
                <img src="static/images/3.jpg"/>
            </mt-swipe-item>
        </mt-swipe>
        <div class="info">
            <div class="title">{{data.SellTitle}}</div>
            <div class="resume">
                {{data.ShortIntro}}
            </div>
            <div>
                <div class="price">
                    <span style="color:orangered;">{{data.Price}}元</span>
                    <router-link :to="'/detail/' + data.ID">
                        <mt-button class="buy-button" type="danger">
                            查看详情 
                        </mt-button>
                    </router-link>
                </div>
            </div>
        </div>
    </div>
</template>

<style scoped>
    .buy-button{
        float: right;
    }
    .price{
        line-height: 2.6em;
    }
    .price a{
        color: white;
        text-decoration: none;
    }
    .info{
        background-color: white;
        padding: 10px 15px;
    }

    .title{
        font-weight: bold;
        line-height: 2em;
    }

    .resume{
        font-size: 12px;
        line-height: 1.6em;
    }

    .mint-swipe {
        height: 300px;
    }

    .mint-swipe-item {
        line-height: 300px;
    }
    .goods{
        margin-bottom: 15px;
    }
</style>

<script>
    export default{
        name: 'goods',
        data(){
            return {

            }
        },
        components: {

        },
        props: {
            data: {
                type: Object,
                require: true
            }
        }
    }
</script>