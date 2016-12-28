<template>
    <div class="page">
        <div class="head">
            <span class="head-left">花点时间的店</span>
            <span class="head-right">关注 | 我的记录</span>
        </div>
        <div>
            <img src="static/images/header.jpg" />
        </div>
        <Goods v-for="item in list" :data="item"></Goods>
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