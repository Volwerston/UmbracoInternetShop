        function displayMessage(aTitle, aText) {
            if (aTitle == "Success") {
                $.growl.notice({ title: aTitle, message: aText });
            }
            else if (aTitle == "Warning") {
                $.growl.warning({ title: aTitle, message: aText });
            }
            else if (aTitle == "Error") {
                $.growl.error({ title: aTitle, message: aText });
            }
            else {
                $.growl({ title: aTitle, message: aText });
            }
        }