function closeCard(id){
    var card = document.getElementsByClassName("cards");
    card[id].style.display = "none";

}

function showPopup(id){
    if(id === "user-profile-full-cont" || id === "login-form" || id === "register-form"){
        document.getElementById("profile-pic-options").style.transform = "scaleX(0)";
    }
    document.getElementById(id).style.transform = "scaleX(1)";
}


function hidePopup(id){
    document.getElementById(id).style.transform = "scaleX(0)";
}



function hidePost(id){
    var post = document.getElementById(id);
    post.style.display = "none";
    }

function switchPass(id) {
    var pass = document.getElementById(id);
    if (pass.type == "password") {
        pass.type = "text";
    }
    else {
        pass.type = "password";
    }
}