﻿var TestListProductVue = new Vue({
    el: '#producttest-list-area',
    data: {
        isBusy: true,
        ProductList: [],
    },
    created: function () {
        $.ajax({
            url: '/api/Product/GetAll',
            type: 'GET',
            data: '',
            async: true,
            success: function (response) {
                console.log(response);
                if (response.StatusCode == '1') {
                    GetResponse(response.Result);
                    BusyChange();
                }
                else {
                    //跳出警告視窗
                }
            }
        });

        function GetResponse(input) {
            this.TestListProductVue.ProductList = input;
        }

        function BusyChange() {
            this.TestListProductVue.isBusy = !this.TestListProductVue.isBusy;
        }
    },
});