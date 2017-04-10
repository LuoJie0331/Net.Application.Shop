<template>
    <div class="page">
        <div class="head">
            <span class="head-left">一庵 · YIAN</span>
            <span class="head-right">关注 | 我的记录</span>
        </div>
        <div>
            <img src="static/images/header.jpg" />
        </div>
        <Goods v-for="item in list" :data="item"></Goods>
        <div class="foot">
            <div class="foot-logo">这里放logo</div>
            <span>客服电话 010-1234-5678</span>
            <span>工作时间 工作日 9:00-20:00</span>
            <span>客服邮箱 service@yian.com</span>
        </div>
    </div>
</template>

<style>
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
    .foot{
        padding-bottom: 20px;
    }
    .foot span{
        display: block;
        text-align: center;
        margin-top: 6px;
    }
    .foot-logo{
        text-align: center;
        font-weight: blod;
        font-size:24px;
        color:#ed9208;
        margin: 0 0 10px 0;
    }
</style>

<script>
    import Goods from '../components/goods.vue'
    export default{
        name: 'index',
        data(){
            return {
                list: [],
            }
        },
        components: {
            Goods,
        },
        created () {
            this.fetchData(1, 10)
        },
        methods: {
            fetchData(page, size){
                let params = {
                    page: page,
                    size: size
                }
                this.$http({
                    url: '/api/productsell',
                    params: params
                }).then((resp)=>{
                    this.list = resp.List
                }).catch((err)=>{
                    console.log(err)
                })
            }
        }
    }
</script>