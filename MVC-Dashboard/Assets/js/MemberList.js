﻿var MemberListVue = new Vue({
    el: '#Member-list-area',
    data: {
        MemberList: [],
    },
    created: function () {
        $.ajax({
            url: '/api/Member/GetAllMemberData',
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
            this.MemberListVue.MemberList = input;
        }
    }

})