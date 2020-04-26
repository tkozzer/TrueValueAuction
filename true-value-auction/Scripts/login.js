var alert = document.getElementById('alert');
console.log(alert);
if (document.getElementById('alert') !== null) {
    console.log("alertLiteral not empty");
    setTimeout(() => document.querySelector('.alert').remove(), 5000)
};

var regFirstName = document.getElementById('txtRegisterFirstName');
var regEmail = document.getElementById('txtRegisterEmail');
var regPassword = document.getElementById('txtRegisterPassword');
var regConfirmPassword = document.getElementById('txtRegisterConfirmPassword');

var loginEmail = document.getElementById('txtEmail');
var loginPassword = document.getElementById('txtPassword');

document.getElementById('btnLogin').addEventListener("click", () => {
    if (loginEmail.value === '' || loginPassword.value === '') {
        showAlert("Please make sure all fields are filled in", "alertBody", null);
    } else if (loginPassword.value.length < 9) {
        showAlert("Please make sure your password is atleast 9 characters", 'alertBody', null);
    } else if (!loginEmail.value.includes("@")) {
        showAlert("Please make sure you enter a valid email address", 'alertBody', null);
    } else {
        __doPostBack('btnLogin', 'Click');
    }
})

document.getElementById('btnRegister').addEventListener("click", () => {
    if (regFirstName.value === "" || regEmail.value === "" || regPassword.value === "" || regConfirmPassword.value === "") {
        showAlert('Please make sure all fields are filled in', 'alertModal', null);
    } else if (regPassword.value != regConfirmPassword.value) {
        showAlert("Please make sure your passwords match", 'alertModal', null);
    } else if (regPassword.value.length < 9) {
        showAlert("Please make sure you password is atleast 9 characters", 'alertModal', null);
    } else if (!regEmail.value.includes("@")) {
        showAlert("Please make sure you enter a valid email address", 'alertModal', null);
    } else {
        __doPostBack('btnRegister', 'Click');
    }
})



function showAlert(message, id, className) {
    if (id === 'alertModal') {
        const div = document.createElement('div');
        div.className = 'alert alert-danger';
        div.id = id;
        div.appendChild(document.createTextNode(message));
        const modalBody = document.querySelector('.modal-body');
        const h3 = document.querySelector('#fn');
        modalBody.insertBefore(div, h3);

        //Vanish in 5 seconds
        setTimeout(() => document.querySelector('#alertModal').remove(), 5000);
    } else {
        const div = document.createElement('div');
        div.className = 'alert alert-danger';
        div.id = id;
        div.appendChild(document.createTextNode(message));
        const container = document.querySelector('#container1');
        const fg = document.querySelector('#form-group1');
        container.insertBefore(div, fg);

        //Vanish in 5 seconds
        setTimeout(() => document.querySelector('#alertBody').remove(), 5000);
    }
}