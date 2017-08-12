var basketEntries = null;
var overallPrice = 0;
var itemToRemoveIndex = -1;

function removeItem(counter){
    itemToRemoveIndex = counter;
    $("#removeCheckModal").modal("show");
}

function getBasketTableRow(product, counter){
    var toReturn = "<tr style='border: 1px solid black'><td class=\"col-xs-3\" style=\"padding: 10px\">"
    + "<img class=\"img-responsive\" src=\"" + product.Item1 + "\" alt=\"Product photo\"/>"
    + "</td>"
    + "<td class=\"col-xs-8\">"
    + "<span onclick=\"removeItem(" + counter + ")\" class='glyphicon glyphicon-remove pull-right' style='cursor: pointer;'></span>"
    + "<h3 style=\"text-align: center;\">" + product.Item2.Name + "</h3>";
    toReturn += "<br/>";
    for(var i = 0; i < product.Item2.Properties.length; ++i){
        toReturn += "<p style=\"text-align: center\"><b>" + product.Item2.Properties[i].Name + ":</b>       " + product.Item2.Properties[i].Values[0] + "</p>";
    }
    toReturn += "<p style=\"text-align: center\"><b>Price (1 item)</b>       " + product.Item2.Price + " $</p>";
    toReturn += "<p style=\"text-align: center\"><b>Discount:</b>       " + product.Item2.DiscountPercents + " %</p>";
    toReturn += "<div class='form-horizontal'><div class='form-group' style='display:table; margin: auto'>";
    toReturn += "<label for=\"items_" + counter + "\">Items:</label>";
    toReturn += "<input type=\"number\" id=\"items_" + counter + "\" placeholder=\"Items\" value=\"" + product.Item2.Items + "\" />";
    toReturn += "<button type='button' class='btn btn-success btn-sm' id='change_items_" + counter + "'>OK</button>";
    toReturn += "</div></div><br/>";
    toReturn += "<p style=\"text-align: center\"><b>Price (all items):</b>       <span id='all_price_" + counter + "'>" + product.Item2.Price*product.Item2.Items*(1 - (product.Item2.DiscountPercents/100)) +  "</span> $</p>";
    toReturn += "</td></tr>";
    return toReturn;
}



function postChangesToServer(){
    
    var toPost = [];
    for(var i = 0; i < basketEntries.length; ++i){
        toPost.push(basketEntries[i].Item2);
    }
    
    $.ajax({
        method: 'POST',
        url: '/Umbraco/Surface/Basket/PostToServer',
        contentType: 'application/json; charset=utf-8',
        dataType: "json",
        data: JSON.stringify(toPost)
    });
}

function bindEvents(){
    $('button[id^="change_items"]').click(function(){
        var pos = $(this).attr('id').split('_')[2];
        var entry = basketEntries[pos];
        
        var newVal = $("#items_" + pos).val();
        
        if(newVal <= 0){
            window.displayMessage("Warning", "You cannot specified a non-positive number of products");
            $("#items_" + pos).val(entry.Item2.Items);
            return;
        }
        
        if(newVal != entry.Item2.Items){
            var shift = entry.Item2.Price*(newVal - entry.Item2.Items)*(1 - entry.Item2.DiscountPercents/100);
            overallPrice += shift;
            $("#overall_price").html(overallPrice);
            var itemsPrice = newVal*entry.Item2.Price*(1 - entry.Item2.DiscountPercents/100);
            $("#all_price_" + pos).html(itemsPrice);
            entry.Item2.Items = newVal;
            postChangesToServer();
        }
    });
    
    $("#remove_product_confirm").click(function(){
        basketEntries.splice(itemToRemoveIndex,1);
        postChangesToServer();
        location.reload();
    });
}

$(document).ready(function(){

$.ajax({
    method: 'GET',
    url: '/Umbraco/Surface/Basket/GetBasketEntries',
    contentType: 'application/json; charset=utf-8',
    dataType: "json",
    success: function(res){
        basketEntries = res;
        if(res.length == 0){
            $("#basket_tbl").append('<tr><td>No items in basket yet.</td></tr>');
        }
        else{
            for(var i = 0; i < res.length; ++i){
                $("#basket_tbl").append(getBasketTableRow(res[i], i));
                overallPrice += res[i].Item2.Price*res[i].Item2.Items*(1 - res[i].Item2.DiscountPercents/100);
            }
            
            $("#basket_container").append("<h3 style='text-align: center'>Overall price: <span id='overall_price'>" + overallPrice + "</span> $</h3>");
            
            bindEvents();
        }
    },
    error: function(res){
        alert(JSON.stringify(res));
    }
});

});