var TestListProductVue = new Vue({
    el: '#producttest-list-area',
    data: {
        isBusy: true,
        productList:[],
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
                    BusyChange();
                }
                else {
                    //跳出警告視窗
                }
            }
        });

        function GetResponse(input) {
            

            this.TestListProductVue.productList = input;
                   
                

           
            
            
        }

        function BusyChange() {
            this.TestListProductVue.isBusy = !this.TestListProductVue.isBusy;
        }
    },
});