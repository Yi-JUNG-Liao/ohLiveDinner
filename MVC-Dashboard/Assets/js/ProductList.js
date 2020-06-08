var ProductListVue = new Vue({
    el: '#Product-list-area',
    data: {
        ProductList: [],
    },
    created: function () {
        $.ajax({
            url: '/api/Product/GetAllProduct',
            type: 'GET',
            data: '',
            async: true,
            success: function (response) {
                console.log(response);
                if (response.StatusCode == '1') {
                    GetResponse(response.Result);
                    //BusyChange();
                }
                else {
                    //跳出警告視窗
                }
            }
        });

        function GetResponse(input) {
            this.ProductListVue.ProductList = input;
        }
    }

})