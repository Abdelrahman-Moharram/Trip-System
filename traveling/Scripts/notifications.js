function hideNotifications(){
    var notifications = document.getElementsByClassName("all-notifications")[0];   

    if (notifications.style.transform !== "scaleY(0)")
    {
        notifications.style.transform = "scaleY(0)";

        document.getElementsByClassName("notification-controller")[0].style.transform = "rotateZ(0deg)";
    }
   else
   {
    notifications.style.transform = "scaleY(1)";
    document.getElementsByClassName("notification-controller")[0].style.transform = "rotateZ(45deg)";
   }
}    
function hidenotification(id) {
    document.getElementById(id).style.display = "none";
}   