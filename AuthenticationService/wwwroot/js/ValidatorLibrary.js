
function ShowToast(text) {
    var x = document.getElementById("snackbar");
    x.className = "show";
    x.innerHTML = text;
    setTimeout(function () { x.className = x.className.replace("show", ""); }, 3000);
}


function checkCodeMeli(code) {
    var L = code.length;
    if (L < 8 || parseInt(code, 10) == 0)
        return false;
    code = ('0000' + code).substr(L + 4 - 10);
    if (parseInt(code.substr(3, 6), 10) == 0)
        return false;
    var c = parseInt(code.substr(9, 1), 10), s = 0;
    for (var i = 0; i < 9; i++)
        s += parseInt(code.substr(i, 1), 10) * (10 - i);
    s = s % 11;
    return (s < 2 && c == s) || (s >= 2 && c == (11 - s));
}


function checkName(name) {
    if (name == null)
        return false;
    var L = name.length;

    if (L < 3 || L > 40)
        return false;

    return true;
}

function checkMobile(mobile) {
    if (mobile == null)
        return false;

    if (mobile.substr(0, 2) != "09")
        return false;

    var L = mobile.length;
    if (L != 11)
        return false;

    return true;
}


function checkPassword(password) {
    if (password == null)
        return false;

    var L = password.length;
    if (L < 6 || L > 16)
        return false;

    return true;
}

function checkConfirmPassword(password,confirmPassword) {
    if (confirmPassword == null)
        return false;

    var L = confirmPassword.length;
    if (L < 6 || L > 16)
        return false;

    if (password != confirmPassword)
        return false;

    return true;
}

function checkSmsCode(code) {
    if (code == null)
        return false;

    var L = code.length;
    if (L != 4)
        return false;
    
    return true;
}