<template>
    <div>
        <mt-button type="default" @click.native="handleClick">default</mt-button>
        <mt-button type="primary">primary</mt-button>
        <mt-button type="danger">danger</mt-button>
        <mt-button plain>plain</mt-button>
    </div>
</template>

<script>
    import { Toast } from 'mint-ui';
    export default {
        name: 'helloMint',
        data(){
            return {
                pager: {
                    page: 1,
                    size: 10
                }
            }
        },
        methods: {
            handleClick(){
                Toast({
                message: '提示',
                position: 'bottom',
                duration: 5000
                });
            },
        }
    }
</script>

<style>

</style>