function switchProfileSetting(settid,conid) {
    var settings = document.getElementsByClassName("single-setting-cont");
    var profilecons = document.getElementsByClassName("user-info-container");
    var i,j;
    for(i = 0; i < 4; i++){
        settings[i].classList.remove("active-profile-settings");
        profilecons[i].style.display = "none";
    }
    document.getElementById(settid).className += " active-profile-settings";
    document.getElementById(conid).style.display = "block";

}


function showPopup(id){
    if(id == "user-profile-full-cont"){
        document.getElementById("profile-pic-options").style.transform = "scaleX(0)";
    }
    document.getElementById(id).style.transform = "scaleX(1)";
}
function hidePopup(id){
    document.getElementById(id).style.transform = "scaleX(0)";
}