
        function createPost(){
            var newpost = document.getElementsByClassName("new-post-window");
            var icon = document.getElementById("create-post-icon");
            newpost[0].style.transform = "scaleY(1)";
            newpost[0].style.position = "fixed";
            icon.style.transform = "rotateZ(-45deg)";

        }

        function closePost(){
            var newpost = document.getElementsByClassName("new-post-window");
            var icon = document.getElementById("create-post-icon");
            newpost[0].style.transform = "scaleY(0)";
            icon.style.transform = "rotateZ(0)";
        }

        


        function closeNotify(id){
            var card = document.getElementsByClassName("cards");
            card[id].style.display = "none";

        }

        var notNum =  document.getElementById("notify-num");
        if (notNum.innerHTML == 0){
            notNum.style.visibility = "hidden";
        }
        else if(notNum.innerHTML > 99){
            notNum.innerHTML = "+99";
        }


        function openNav() {
        var sidebar = document.getElementById("mySidenav");
        var openbtn = document.getElementsByClassName("open-nav");
        var closebtn = document.getElementsByClassName("closebtn");
        var item = document.getElementsByClassName("link-item");
        var text = document.getElementsByClassName("nav-text");
        

        for(var i = 0; i < 4; i++){
            
            text[i].style.transitionDelay = "0.3s";
            text[i].style.fontSize = "large";
            item[i].style.borderRadius = "17px";
        }

        sidebar.style.width = "250px";
        openbtn[0].style.display = "none";

        closebtn[0].style.display = "inline-block";



}

function closeNav() {
    var sidebar = document.getElementById("mySidenav");
    var openbtn = document.getElementsByClassName("open-nav");
    var closebtn = document.getElementsByClassName("closebtn");
    var item = document.getElementsByClassName("link-item");
    var text = document.getElementsByClassName("nav-text");
        


    for(var i = 0; i < 4; i++){
        text[i].style.fontSize = "0px";
        text[i].style.transitionDelay = "0s";
        item[i].style.borderRadius = "17px";
    }


    sidebar.style.width = "0px";
    sidebar.style.transitionDelay = "0s";
    openbtn[0].style.display = "inline-block";

    closebtn[0].style.display = "none";

    var notifisMenu = document.getElementById("notification-menu");
    var notifis = document.getElementById("notifis");
    if(notifisMenu.style.display === "inline-block"){
        notifisMenu.style.display = "none";
        notifis.classList.remove("active-sideNav")
    }

    

}



function closeNotifi(id){
    var notifi = document.getElementById(id);
    notifi.style.marginLeft = "200%";
    notifi.style.display = "none";

}

function showNotifi(){
    
    var notifiMenu = document.getElementById("notification-menu");
    
    if(notifiMenu.style.display === "inline-block"){
        

        closeNav();
        notifiMenu.style.display = "none";   
        document.getElementById("notifis").classList.remove("active-sideNav");
    }
    else{
        openNav();
        notifiMenu.style.display = "inline-block";
        // notifiMenu.style.opacity = "1";
        document.getElementById("notifis").className += " active-sideNav";
         
    }

}

        function showLine(id){
            var postHeader = document.getElementsByClassName(id)[0];
            line = postHeader.getElementsByClassName("form-input-divider")[0].getElementsByClassName("form-input-insider")[0];
            line.style.width = "100%";
            line.style.marginLeft = "0";
        }
