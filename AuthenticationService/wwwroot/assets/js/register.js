
window.onload = function () {

    var divUserInfo = document.getElementById('divUserInfo');
    var divSmsCode = document.getElementById('divSmsCode');
    var divImages = document.getElementById('divImages');

    divSmsCode.style.display = 'none';
    divImages.style.display = 'none';

    document.getElementById("RegisterLevelOne").addEventListener("click", RegisterLevelOne);
    document.getElementById("RegisterLevelTwo").addEventListener("click", RegisterLevelTwo);
    document.getElementById("RegisterLevelThree").addEventListener("click", RegisterLevelThree);

}
function RegisterLevelOne() {

    if (validateForm(false)) {
        var divUserInfo = document.getElementById('divUserInfo');
        var divSmsCode = document.getElementById('divSmsCode');

        var nationalCode = document.getElementById('NationalCode');
        var phoneNumber = document.getElementById('PhoneNumber');

        var sendData = {
            NationalCode: nationalCode.value,
            PhoneNumber: phoneNumber.value
        };

        AJX.post("/Account/RegisterListLevelOne", sendData, function (result) {
            if (result.status == "ok") {
                divUserInfo.style.display = 'none';
                divSmsCode.style.display = 'block';
            } else if (result.status == "Nok") {
                ShowToast(result.message);
            }
        });
    }

}

function RegisterLevelTwo() {

    if (validateForm(true)) {
        var divSmsCode = document.getElementById('divSmsCode');
        var divImages = document.getElementById('divImages');


        var name = document.getElementById('Name');
        var familyName = document.getElementById('FamilyName');
        var nationalCode = document.getElementById('NationalCode');
        var phoneNumber = document.getElementById('PhoneNumber');
        var password = document.getElementById('Password');
        var code = document.getElementById('Code');
        var inputPi = document.getElementById('inputPi');

        var sendData = {
            Name: name.value,
            FamilyName: familyName.value,
            NationalCode: nationalCode.value,
            PhoneNumber: phoneNumber.value,
            Password: password.value,
            Code: code.value
        };

        AJX.post("/Account/RegisterListLevelTwo", sendData, function (result) {
            if (result.status == "ok") {
                inputPi.value = result.message;
                divSmsCode.style.display = 'none';
                divImages.style.display = 'block';
            } else if (result.status == "Nok") {
                ShowToast(result.message);
            }
        });
    }
}




function RegisterLevelThree() {


    var imgCartMelli = document.getElementById('ImgCartMelli');
    var imgPersonally = document.getElementById('ImgPersonally');
    var imgSafheAvvaleDaftarche = document.getElementById('ImgSafheAvvaleDaftarche');
    var inputPi = document.getElementById('inputPi');

    var sendData = {
        ImgCartMelli: imgCartMelli.value,
        ImgPersonally: imgPersonally.value,
        ImgSafheAvvaleDaftarche: imgSafheAvvaleDaftarche.value,
        PersonId: inputPi.value
    };

    AJX.post("/Account/RegisterListLevelThree", sendData, function (result) {
        if (result.status == "ok") {
            alert("" + document.getElementById('returnUrl').value);
            window.location = "" + document.getElementById('returnUrl').value;

        } else if (result.status == "Nok") {
            ShowToast(result.message);
        }
    });
}



function validateForm(validateCode) {

    var error = 0;
    var name = document.getElementById('Name').value;
    var familyName = document.getElementById('FamilyName').value;
    var nationalCode = document.getElementById('NationalCode').value;
    var phoneNumber = document.getElementById('PhoneNumber').value;
    var password = document.getElementById('Password').value;
    var confirmPassword = document.getElementById('ConfirmPassword').value;
    var code = document.getElementById('Code').value;

    var spnName = document.getElementById('spnName');
    var spnFamilyName = document.getElementById('spnFamilyName');
    var spnNationalCode = document.getElementById('spnNationalCode');
    var spnPhoneNumber = document.getElementById('spnPhoneNumber');
    var spnPassword = document.getElementById('spnPassword');
    var spnConfirmPassword = document.getElementById('spnConfirmPassword');
    var spnCode = document.getElementById('spnCode');

    var spans = document.getElementsByTagName("span");
    for (var i = 0; i < spans.length; i++) {
        spans[i].innerHTML = "";
    }

    var isNameValid = checkName(name);
    if (!isNameValid) {
        spnName.innerHTML = "نام صحیح نیست";
        error++;
    }

    var isFamilyNameValid = checkName(familyName);
    if (!isFamilyNameValid) {
        spnFamilyName.innerHTML = "نام خانوادگی صحیح نیست";
        error++;
    }

    var isNationalCodeValid = checkCodeMeli(nationalCode);
    if (!isNationalCodeValid) {
        spnNationalCode.innerHTML = "کد ملی صحیح نیست";
        error++;
    }
    
    var isPhoneNumberValid = checkMobile(phoneNumber);
    if (!isPhoneNumberValid) {
        spnPhoneNumber.innerHTML = "شماره موبایل صحیح نیست";
        error++;
    }

    var isPasswordValid = checkPassword(password);
    if (!isPasswordValid) {
        spnPassword.innerHTML = "رمز عبور صحیح نیست";
        error++;
    }

    var isConfirmPassworddValid = checkPassword(confirmPassword);
    if (!isConfirmPassworddValid) {
        spnConfirmPassword.innerHTML = "رمز عبور و تکرار آن یکسان نیست";
        error++;
    }

    if (validateCode) {
        var isCodeValid = checkSmsCode(code);
        if (!isCodeValid) {
            spnCode.innerHTML = "کد نادرست است";
            error++;
        }
    }

    return (!error > 0);

}


