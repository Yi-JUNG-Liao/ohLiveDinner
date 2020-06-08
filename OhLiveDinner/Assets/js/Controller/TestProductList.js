var TestListProductVue = new Vue({
    el: '#producttest-list-area',
    data: {
        isBusy: true,
        Apper: [],
        main: [],
        dessert: [],
        drink: [],
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
            input.forEach(element => {
                if (element.ProductKindName == Appetizers) {
                    this.TestListProductVue.Apper = element;
                    debugger;
                }

           });
            
            
        }

        function BusyChange() {
            this.TestListProductVue.isBusy = !this.TestListProductVue.isBusy;
        }
    },
});