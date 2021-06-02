function switchProfileSetting(settid,conid) {
    var settings = document.getElementsByClassName("single-setting-cont");
    var profilecons = document.getElementsByClassName("user-info-container");
    var i;
    for (i = 0; i < profilecons.length; i++){
        settings[i].classList.remove("active-profile-settings");
        profilecons[i].style.display = "none";
    }
    document.getElementById(settid).className += " active-profile-settings";
    document.getElementById(conid).style.display ="block";

}


