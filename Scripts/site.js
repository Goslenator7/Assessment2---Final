// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Validate Log in form with jQuery validate plugin
//
$("document").ready(function () {
    $("#logInForm").validate({
        rules: {
            logInUsername: {
                required: true
            },
            logInPassword: {
                required: true,
                minlength: 5
            }
        }
    });

});

// Validate Sign Up Form with jQuery validate plugin
//
$("document").ready(function () {
    $("#signUpForm").validate({
        rules: {
            signUpEmail: {
                required: true,
                email: true
            },
            signUpUsername: {
                required: true,
                minlength: 5
            },
            signUpPassword: {
                required: true,
                minlength: 5
            },
            signUpPassword2: {
                required: true,
                equalTo: "#signUpPassword",
                minlength: 5
            }
        }
    });

});

// Validate Start a petition form with jQuery validate plugin
$("document").ready(function () {
    $("#createPetition").validate({
        rules: {
            petitionName: {
                required: true,
            },
            petitionType: {
                required: true,
            },
            petitionDescription: {
                required: true
            }
        }
    });
});

// Function to insert above values into waiting div (User generated cause)
$("#createPetition").submit(function (e) {
    e.preventDefault();
    let petitionName = $("#petitionName").val();
    let petitionType = $("#petitionType").val();
    let petitionDescription = $("#petitionDescription").val();
    $("#userCauseText").append("<h1>" + petitionName + "</h1><p>" + petitionType + "</p><p>" + petitionDescription + "</p>");
    $("#userCause").show(2000);
});

