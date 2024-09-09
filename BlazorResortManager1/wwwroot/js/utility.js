function sizeHeightToBottom(elementId) {
    //get the element
    var targetElement = document.getElementById(elementId);

    var windowHeight = window.innerHeight;
    //console.log(windowHeight);
    var contHoffset = targetElement.offsetTop;
    //console.log(contHoffset);
    targetElement.style.height = (windowHeight - contHoffset - 88) + "px";
}

function getBottomOffsetReference(elementId) {
    var targetElement = document.getElementById(elementId);
    return targetElement.offsetTop + targetElement.offsetHeight;
}
function sizeHeightToBottomOfParent(elementId, bottomOffset) {
    //get the element
    var targetElement = document.getElementById(elementId);
    //console.log(windowHeight);
    var contHoffset = targetElement.offsetTop;
    //console.log(contHoffset);
    targetElement.style.height = (bottomOffset - contHoffset) + "px";
}

function alertThing() {
    alert("alerting test");
}