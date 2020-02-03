function validateSignUp() {
    if (document.getElementById("FullName").value.length < 5) {
        document.getElementById("errorSignUp").innerHTML = "FullName should be atleast 5 letter";
        document.SignUpForm.Name.focus();
        return false;
    }

    if (document.getElementById("SignUpFullName").value.length < 4) {
        document.getElementById("errorSignUp").innerHTML = "Fullname should be atleast 5 letter";
        document.SignUpForm.SignUpUserName.focus();
        return false;
    }

    if (document.getElementById("Age").value.length < 2) {
        document.getElementById("errorSignUp").innerHTML = "Type correct Age";
        document.SignUpForm.Email.focus();
        return false;
    }

    if (document.getElementById("EmailId").value.length < 4) {
        document.getElementById("errorSignUp").innerHTML = "Type correct Email ID";
        document.SignUpForm.Email.focus();
        return false;
    }

    if (document.getElementById("WorkExperience").value.length=1) {
        document.getElementById("errorSignUp").innerHTML = "Incorrect WorkExperience";
        document.SignUpForm.Mobile.focus();
        return false;
    }

    console.log($('#FullName').val());

    $.ajax({
        url: '/Add',
        type: 'POST',
        contentType: 'application/json;charset=utf-8',
        dataType: 'json',
        data: "{'FullName': '" + $('#FullName').val() + "','UserName': '" + $('#SignUpUserName').val() + "','Pass': '" + $('#SignUpPass').val() + "','Age': '" + $('#Age').val() +"','EmailId': '" + $('#EmailId').val() + "','WorkExperience': '" + $('#WorkExperience').val() + "'}",
        success: function () {
            alert("Data Inserted successfully!!!");
        },
        error: function () {
            alert("Insert Error!!!");
        }
    });

    $(".signup-form").hide();
    $(".login-form").show();
    event.preventDefault();
    return true;
}

function validateLogin() {
    if (document.getElementById("LoginId").value.length < 4 || document.getElementById("LoginPass").value.length < 4) {
        document.getElementById("errorLogin").innerHTML = "Username or Password is incorrect";
        document.LoginForm.LoginPass.focus();
        return false;
    }
    return true;
}

$(document).ready(function () {
    $(".login-form").hide();


    $(".login").click(function () {
        $(".signup-form").hide();
        $(".login-form").show();
        $("#errorSignUp").hide();
    });

    $(".signup").click(function () {
        $(".login-form").hide();
        $(".signup-form").show();
    });

    $(".notmember").click(function () {
        $(".login-form").hide();
        $(".signup-form").show();
    });

});
