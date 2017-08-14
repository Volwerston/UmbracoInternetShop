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
                
                $("#loadingModal").modal("show");
                
                var toPass = buildContext();
                
                $.ajax({
                    method: 'POST',
                    url: '/Umbraco/Surface/Basket/Purchase',
                    contentType: 'application/json; charset=utf-8',
                    data: JSON.stringify(toPass),
                    success: function(res){
                        $("#loadingModal").modal("hide");
                        displayMessage("Success", "Your order has been successfully processed. Please check your email");
                        setTimeout(function(){window.location = '/'}, 2000);
                    },
                    error: function(res){
                        $("#loadingModal").modal("hide");
                        displayMessage("Error", res.statusText);
                    }
                });
                return false;
            }
        });
    });
                