

        function buildQuestion() {
            var toReturn = {};

            toReturn.ProductId = window.pageId;
            toReturn.MessageText = $('textarea[name="question_messageText"]').val();
            toReturn.SenderName = $('input[name="question_senderName"]').val();
            toReturn.SenderEmail = $('input[name="question_senderEmail"]').val();

            return toReturn;
        }

        function buildEstimate() {
            var toReturn = {};

            toReturn.ProductId = window.pageId;
            toReturn.MessageText = $('textarea[name="estimate_messageText"]').val();
            toReturn.SenderName = $('input[name="estimate_senderName"]').val();
            toReturn.SenderEmail = $('input[name="estimate_senderEmail"]').val();
            toReturn.Estimate = $('input[name="estimate"]').val();
            toReturn.Advantages = $('input[name="advantages"]').val();
            toReturn.Disadvantages = $('input[name="disadvantages"]').val();

            return toReturn;
        }

        function sendComment(toPass) {
            $.ajax({
                method: 'POST',
                url: '/Umbraco/Surface/Comment/Add',
                contentType: 'application/json; charset=utf-8',
                data: JSON.stringify(toPass),
                success: function (res) {
                    $("#loadingModal").modal("hide");
                    displayMessage("Success", "Your comment was successfully added");
                    setTimeout(function(){location.reload();}, 2000);
                },
                error: function (res) {
                    $("#loadingModal").modal("hide");
                    window.displayMessage("Error", res.statusText);
                }
            });
        }

        $(document).ready(function () {
            $('form[id^="send_form"]').validator().submit(function (e) {
                if (!e.isDefaultPrevented()) {
                    $("#loadingModal").modal("show");
                    var type = $(this).attr('id').split('_')[2];
                    var toPass = null;
                    if (type == "question") {
                        toPass = buildQuestion();
                    }
                    else {
                        toPass = buildEstimate();
                    }

                    sendComment(toPass);
                    $("#commentModal").modal("hide");
                    return false;
                }
            });
        });