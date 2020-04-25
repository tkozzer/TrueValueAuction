var alert = document.getElementById('alert');
console.log(alert);
if (document.getElementById('alert') !== null) {
    console.log("alertLiteral not empty");
    setTimeout(() => document.querySelector('.alert').remove(), 5000)
};

var firstName = document.getElementById('txtRegisterFirstName');
var email = document.getElementById('txtRegisterEmail');
var password = document.getElementById('txtRegisterPassword');
var confirmPassword = document.getElementById('txtRegisterConfirmPassword');

var loginEmail = document.getElementById('txtEmail');
var loginPassword = document.getElementById('txtPassword');

document.getElementById('btnLogin').addEventListener("click", () => {
    if (loginEmail.value === '' || loginPassword.value === '') {
        showAlert("Please enter make sure all fields are filled in", "alertBody");
    } else {
        __doPostBack('btnLogin', 'Click');
    }
})

document.getElementById('btnRegister').addEventListener("click", () => {
    if (firstName.value === "" || email.value === "" || password.value === "" || confirmPassword.value === "") {
        showAlert('Please make sure all fields are filled in', 'alertModal');
    } else if (password.value != confirmPassword.value) {
        showAlert("Please make sure your passwords match", 'alertModal');
    } else {
        __doPostBack('btnRegister', 'Click');
    }
})


function showAlert(message, id) {
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