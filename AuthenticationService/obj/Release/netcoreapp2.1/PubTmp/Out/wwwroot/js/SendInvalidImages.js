
window.onload = function () {
}
function validateForms(NationalCard,Person,Booklet) {

    var nationalCard = document.getElementById(NationalCard);
    var person = document.getElementById(Person);
    var booklet = document.getElementById(Booklet);

    var i1 = checkHasValue(person, "لطفا تصویر صفحه اول دفترچه را انتخاب کنید");
    var i2 = checkHasValue(booklet, "لطفا تصویر پرسنلی را انتخاب کنید");
    var i3 = checkHasValue(nationalCard, "لطفا تصویر کارت ملی را انتخاب کنید");


    return (i1 && i2 && i3);
}

function checkHasValue(val,text) {
    if (val != null) {
        if (val.value.length == 0 || val.value == null) {
            ShowToast(text);
            return false;
        }
    }
    return true;
}
