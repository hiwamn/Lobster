
window.onload = function () {

    var divSmsCode = document.getElementById('divSmsCode');
    var divMobileChanged = document.getElementById('divMobileChanged');

    divSmsCode.style.display = 'none';
    divMobileChanged.style.display = 'none';

    document.getElementById("RestorePasswordLevelOne").addEventListener("click", RestorePasswordLevelOne);
    document.getElementById("RestorePasswordLevelTwo").addEventListener("click", RestorePasswordLevelTwo);

}
function RestorePasswordLevelOne() {

    if (validateForm(false)) {
        var divUserInfo = document.getElementById('divUserInfo');
        var divSmsCode = document.getElementById('divSmsCode');

        var PhoneNumber = document.getElementById('PhoneNumber').value;
        var NationalCode = document.getElementById('NationalCode').value;


        var sendData = {
            nationalCode: NationalCode,
            phoneNumber: PhoneNumber
        };

        AJX.post("/Account/RestorePasswordLevelOne", sendData, function (result) {
            if (result.status == "ok") {
                divUserInfo.style.display = 'none';
                divSmsCode.style.display = 'block';
            } else if (result.status == "Nok") {
                ShowToast(result.message);
            }
        });
    }

}

function RestorePasswordLevelTwo() {

    if (validateForm(true)) {

        var divUserInfo = document.getElementById('divUserInfo');
        var divSmsCode = document.getElementById('divSmsCode');

        var PhoneNumber = document.getElementById('PhoneNumber').value;
        var NationalCode = document.getElementById('NationalCode').value;
        var Password = document.getElementById('Password').value;
        var ConfirmPassword = document.getElementById('ConfirmPassword').value;
        var code = document.getElementById('Code');

        var sendData = {
            Password: Password,
            ConfirmPassword: ConfirmPassword,
            nationalCode: NationalCode,
            phoneNumber: PhoneNumber,
            Code: code.value
        };

        AJX.post("/Account/RestorePasswordLevelTwo", sendData, function (result) {
            if (result.status == "ok") {
                divSmsCode.style.display = 'none';
                divMobileChanged.style.display = 'block';
            } else if (result.status == "Nok") {
                ShowToast(result.message);
            }
        });
    }
}

function validateForm(validateCode) {

    var error = 0;

    var PhoneNumber = document.getElementById('PhoneNumber').value;
    var NationalCode = document.getElementById('NationalCode').value;
    var code = document.getElementById('Code').value;
    var Password = document.getElementById('Password').value;
    var ConfirmPassword = document.getElementById('ConfirmPassword').value;

    var spnPhoneNumber = document.getElementById('spnPhoneNumber');
    var spnNationalCode = document.getElementById('spnNationalCode');
    var spnCode = document.getElementById('spnCode');
    var spnPassword = document.getElementById('spnPassword');
    var spnConfirmPassword = document.getElementById('spnConfirmPassword');
    

    spnPhoneNumber.innerHTML = "";
    spnNationalCode.innerHTML = "";
    spnCode.innerHTML = "";
    spnPassword.innerHTML = "";
    spnConfirmPassword.innerHTML = "";

    var isPhoneNumberValid = checkMobile(PhoneNumber);
    if (!isPhoneNumberValid) {
        spnPhoneNumber.innerHTML = "شماره موبایل صحیح نیست";
        error++;
    }

    var isNationalCodeValid = checkCodeMeli(NationalCode);
    if (!isNationalCodeValid) {
        spnNationalCode.innerHTML = "کد ملی صحیح نیست";
        error++;
    }


    if (validateCode) {
        var isCodeValid = checkSmsCode(code);
        if (!isCodeValid) {
            spnCode.innerHTML = "کد نادرست است";
            error++;
        }

        var isPasswordValid = checkPassword(Password);
        if (!isPasswordValid) {
            spnPassword.innerHTML = "رمز عبور وارد شده صحیح نیست";
            error++;
        }

        var isConfirmPasswordValid = checkConfirmPassword(Password,ConfirmPassword);
        if (!isConfirmPasswordValid) {
            spnConfirmPassword.innerHTML = "رمز عبور و تکرار آن یکسان نیست";
            error++;
        }
    }

    return (!error > 0);

}


