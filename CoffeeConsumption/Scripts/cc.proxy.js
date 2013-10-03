cc.proxy = {
    sendRequest: function (url, requestParams, onSuccess, onFailure) {
        $.ajax({
            url: url,
            type: "POST",
            dataType: "json",
            contentType: "application/json",
            data: JSON.stringify(requestParams),
            success: onSuccess,
            error: function (response) {
                //showError("Error: " + response.message);
            }
        });
    },
    
    getBeverage: function (requestParams, onSuccess, onFailure) {
        cc.proxy.sendRequest(cc.urls.getBeverageUrl, requestParams, onSuccess, onFailure);
    }
}