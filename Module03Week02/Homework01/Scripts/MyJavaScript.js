
function checkTextLength(el) {

    var length = el.value.length;

    if (length > 4) {
        el.removeAttribute('style');
    }
    else {
        el.setAttribute('style', 'border:1px solid red;');
    }
}