
var ids = [0];
var likes = [10];
var dislikes = [3];

for (var i = 0; i < ids.length; i++){

    var id = ids[i];
    var likesFactor = (likes[i]/(likes[i] + dislikes[i]) )*100;
    if(likesFactor < 0){
        likesFactor += 1;
    }
    console.log(likesFactor);


    const likesBar = document.getElementsByClassName("gaven-likes-counter");
    const dislikesBar = document.getElementsByClassName("gaven-dislikes-counter");

    likesBar[id].style.width = (likesFactor) + "%";
    dislikesBar[id].style.width = (100 - likesFactor) + "%";
}






function like(id,likes, dislikes){
var like = document.getElementsByClassName("post-like-icon");
    var dislike = document.getElementsByClassName("post-dislike-icon");
    var likeNums = document.getElementsByClassName("likes-number");
    var dislikeNums = document.getElementsByClassName("dislikes-number");
    
if(dislike[id].style.color === "#1a8cff"){
    dislikes--;
}
    likes++;
    likeNums.innerHtml +=  1;
    dislikeNums.innerHtml -=1 ;

var likesFactor = (likes/(likes + dislikes) )*100;
if(likesFactor < 0){
    likesFactor += 1;
}
console.log(likesFactor);


var likesBar = document.getElementsByClassName("gaven-likes-counter");
var dislikesBar = document.getElementsByClassName("gaven-dislikes-counter");

likesBar[id].style.width = (likesFactor) + "%";
dislikesBar[id].style.width = (100 - likesFactor) + "%";





like[id].style.color = "#0d6efd";
like[id].style.transform = "scale(1.3,1.3)";
dislike[id].style.color = "#1a1a1a";
dislike[id].style.transform = "scale(1.0,1.0)";

}

function dislike(id,likes,dislikes){
var dislike =document.getElementsByClassName("post-dislike-icon"); 
    var like = document.getElementsByClassName("post-like-icon");
    var likeNums = document.getElementsByClassName("likes-number");
    var dislikeNums = document.getElementsByClassName("dislikes-number");
    dislikes++;
    likeNums.innerHtml -= 1;
    dislikeNums.innerHtml += 1;
    console.log(likeNums);

if(dislike[id].style.color === "#1a8cff"){
    likes--;
}
var likesFactor = (likes/(likes + dislikes) )*100;
if(likesFactor < 0){
    likesFactor += 1;
}



var likesBar = document.getElementsByClassName("gaven-likes-counter");
var dislikesBar = document.getElementsByClassName("gaven-dislikes-counter");

likesBar[id].style.width = (likesFactor) + "%";
dislikesBar[id].style.width = (100 - likesFactor) + "%";


dislike[id].style.color = "#f00";
dislike[id].style.transform = "scale(1.3,1.3)";

like[id].style.color = "#1a1a1a";
like[id].style.transform = "scale(1.0,1.0)";

}

function comment_show(id){
var comment = document.getElementsByClassName("post-comments");
var comm_icon = document.getElementsByClassName("post-comment-icon");
console.log(comment[id].style.display);
if(comment[id].style.display !== "none")
{
    

    comment[id].style.display = "none";
    comm_icon[id].style.color = "#1a1a1a";
    comm_icon[id].style.transform = "scale(1.0,1.0)";
}
else{
    comment[id].style.display = "inline-block";
    comm_icon[id].style.color = "#009900";
    comm_icon[id].style.transform = "scale(1.3,1.3)";
}
}

