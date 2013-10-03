cc.getBeverage = {
    init: function() {
        $("[id$='SelectButton']").on('click', cc.getBeverage.selectBeverage);
        $("[id$='SelectButton']").first().children('img').addClass('selectedBeverage');

        $("#getButton").on('click', cc.getBeverage.getBeverage);
    },
    
    selectBeverage: function () {
        $("[id$='SelectButton']").children('img').removeClass('selectedBeverage');
        $(this).children('img').addClass('selectedBeverage');
    },
    
    getBeverage: function () {
        var selectedCup = $(".selectedBeverage").first();
        if (selectedCup) {
            var cupId = selectedCup.data('cupid');
            cc.proxy.getBeverage({ cup: { Id: cupId } }, cc.getBeverage.getBeverageOnSuccess, {});
        }
    },
    
    getBeverageOnSuccess: function() {
        
    }
};
$(cc.getBeverage.init);