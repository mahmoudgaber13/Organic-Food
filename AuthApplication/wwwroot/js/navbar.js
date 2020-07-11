var idliH = 1;
setInterval(function () {
    document.getElementById("liH" + idliH).style.display = "none";
    idliH = idliH + 1;
    if (idliH == 9) {
        idliH = 1;
    }
    document.getElementById("liH" + idliH).style.opacity = 1;
    document.getElementById("liH" + idliH).style.display = "inline";
}, 3000);
var isdisplayed = false;
function displaysearch() {
    if (isdisplayed == false) {
        document.getElementById("SearchDiv").style.display = "block";
        isdisplayed = true;
    }
    else {
        document.getElementById("SearchDiv").style.display = "none";
        isdisplayed = false;
    }
}