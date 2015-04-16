$(document).ready(function () {
    
});


function LoginStatus(result)
{
    if (result) {
        alert("Authentication succesful. Redirecting to main intranet page.");
        window.location = "/intranet";
    }
    else {
        alert("Authentication failed. Please check your username and password.");
    }
}