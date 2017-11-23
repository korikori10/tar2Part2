

function Details(element, pos) {
    var h2 = document.getElementsByTagName("H2");
    var h3 = document.getElementsByTagName("H3");
    var h5 = document.getElementsByTagName("H5");
    var pic = document.getElementById("img" + pos).src;
    
    document.getElementById("demo").innerHTML = "<img class=imges src='" + pic + "'/>" + "<br/>" + h2[pos - 1].innerHTML + "<br/>" + h3[pos - 1].innerHTML + "<br/>" + h5[pos - 1].innerHTML + "<br/>";

}
