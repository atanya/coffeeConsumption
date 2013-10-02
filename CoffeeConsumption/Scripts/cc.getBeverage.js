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
    
    getBeverage: function() {
        
    }
};
$(cc.getBeverage.init);