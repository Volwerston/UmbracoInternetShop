function buildContext(){
    var toReturn = {};
    
    toReturn.Name = $('input[name="name"]').val();
    toReturn.Surname = $('input[name="surname"]').val();
    toReturn.Email = $('input[name="email"]').val();
    toReturn.Country = $('input[name="country"]').val();
    toReturn.Town = $('input[name="town"]').val();
    
    return toReturn;
}   
   
   
   $(document).ready(function(){
        $("#purchaseForm").validator().submit(function(e){
            if(!e.isDefaultPrevented()){
                var toPass = buildContext();
                
                $.ajax({
                    method: 'POST',
                    url: '/Umbraco/Surface/Basket/Purchase',
                    contentType: 'application/json; charset=utf-8',
                    data: JSON.stringify(toPass),
                    success: function(res){
                        displayMessage("Success", "Your order has been successfully processed");
                        setTimeout(function(){window.location = '/'}, 2000);
                    },
                    error: function(res){
                        displayMessage("Error", res.statusText);
                    }
                });
                return false;
            }
        });
    });
                