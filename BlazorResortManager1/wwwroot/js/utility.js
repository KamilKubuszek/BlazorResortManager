function sizeHeightToBottom(elementId) {
    //get the element
    var targetElement = document.getElementById(elementId);

    var windowHeight = window.innerHeight;
    //console.log(windowHeight);
    var contHoffset = targetElement.offsetTop;
    //console.log(contHoffset);
    targetElement.style.height = (windowHeight - contHoffset - 16) + "px";
}
function setMaxHeightToBottom(elementId, margin, marginMultiplier) {

    //get the element
    var targetElement = document.getElementById(elementId);

    var windowHeight = window.innerHeight;

    var contHoffset = targetElement.offsetTop;

    targetElement.style.maxHeight = (windowHeight - contHoffset - margin * marginMultiplier) + "px";
    
}
function alertThing() {
    alert("alerting test");
}