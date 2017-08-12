
        function searchForProducts() {
            $("#product_container").empty();
            $.ajax({
                method: 'POST',
                url: '/Umbraco/Surface/Product/Search',
                contentType: 'application/json; charset=utf-8',
                data: JSON.stringify(selectedItems),
                async: false,
                success: function (res) {
                    $("#product_container").append(res);
                },
                error: function (res) {
                    alert(res);
                }
            });
        }

        $(document).ready(function () {

            $('input[name="product_name"]').change(function () {
                selectedItems.Name = $(this).val();
                searchForProducts();
            });

            $('input[id^="property"]').change(function () {

                var propertyName = $(this).attr('id').split('_')[1];
                var propertyValue = $(this).attr('id').split('_')[2];
                var isChecked = $(this).is(":checked");

                if (isChecked) {
                    var found = false;

                    for (var i = 0; i < selectedItems.Properties.length; ++i) {
                        if (selectedItems.Properties[i].Name == propertyName) {
                            found = true;
                            selectedItems.Properties[i].Values.push(propertyValue);
                            break;
                        }
                    }

                    if (!found) {
                        var toAdd = {
                            Name: propertyName,
                            Values: [propertyValue]
                        };

                        selectedItems.Properties.push(toAdd);
                    }
                }
                else {
                    for (var i = 0; i < selectedItems.Properties.length; ++i) {
                        if (selectedItems.Properties[i].Name == propertyName) {
                            if (selectedItems.Properties[i].Values.length == 1) {
                                selectedItems.Properties.splice(i, 1);
                            }
                            else {
                                for (var j = 0; j < selectedItems.Properties[i].Values.length; ++j) {
                                    if (selectedItems.Properties[i].Values[j] == propertyValue) {
                                        selectedItems.Properties[i].Values.splice(j, 1);
                                        break;
                                    }
                                }
                            }

                            break;
                        }
                    }
                }

                searchForProducts();
            });
        });