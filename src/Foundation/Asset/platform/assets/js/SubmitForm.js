$(document).on("click", "#feedbackSubmit", function (e) {

    e.preventDefault();
    $('#srcErr').attr("style", "display:none");
    
    if ($('#feedbackForm').valid()) {

        $('#btnLoader').attr("style", "display:block");
        $("#flexCheckDefault").attr("style", "border-color:black");
        $('#agreeCheck').attr("style", "display:none");
        $('#feedbackSubmit').attr("style", "display:none");



        if ($("#flexCheckDefault").is(':checked')) {

            var FormData = JSON.stringify({               
             
                'Name': $("#fullName").val(),
                'Email': $("#emailId").val(),
                'Description': $("#description").val(),
                'MobileNumber': $("#mobileNo").val()
            })



            $.ajax({
                url: '/api/sitecore/FeebackForm/SubmitForm',
                type: "POST",
                data: FormData,
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (result) {

                    if (result != null && result.Status) {
                        $('#btnLoader').attr("style", "display:none");
                        $('#feedbackSubmit').attr("style", "display:block");
                        var incNumber = result.Data.IncidentDetail.IncidentId;
                        $('#feedbackModal').addClass('show');
                        $("#feedbackModal").attr("style", "display:block");
                        $('#feedbackForm')[0].reset();
                                            
                    }
                    else {
                        $('#srcErr').attr("style", "display:block");
                        $('#btnLoader').attr("style", "display:none");
                        $('#feedbackSubmit').attr("style", "display:block");

                    }

                },
                error: function (data) {
                    console.log(data);
                    $('#srcErr').attr("style", "display:block");
                    $('#btnLoader').attr("style", "display:none");
                    $('#feedbackSubmit').attr("style", "display:block");
                }
            });

        }
        else {
            $("#flexCheckDefault").attr("style", "border-color:red");
            $('#btnLoader').attr("style", "display:none");
            $('#agreeCheck').attr("style", "display:block;color:red");
            $('#feedbackSubmit').attr("style", "display:block");
        }
    }


    return false;
})



$(document).on("click", "#btnClose", function (e) {

    $('#feedbackModal').addClass('hide');
    $("#feedbackModal").attr("style", "display:none");
})