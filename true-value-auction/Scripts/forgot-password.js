
var forgotEmail = document.getElementById('txtForgotEmail');
document.getElementById('btnSubmit').addEventListener("click", () => {
    if (forgotEmail.value === '') {
        showAlert("Please fill in the email field", 'alertForgotEmail', null);
    } else if (!forgotEmail.value.includes("@")) {
        showAlert("Please make sure you enter a valid email address", 'alertForgotEmail', null);
    } else {
        __doPostBack('btnSubmit', 'Click');
    }
})


function showAlert(message, id, className) {

    const div = document.createElement('div');
    div.className = 'alert alert-danger';
    div.id = id;
    div.appendChild(document.createTextNode(message));
    const container = document.querySelector('#container1');
    const div1 = document.querySelector('#div1');
    container.insertBefore(div, div1);

    //Vanish in 5 seconds
    setTimeout(() => document.querySelector('#alertForgotEmail').remove(), 5000);

}