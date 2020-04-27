var itemName = document.getElementById("txtItemName");
var itemDesc = document.getElementById("txtDescription");
var condition = document.getElementById("ddCondition");
var startBid = document.getElementById("txtStartBid");
var file = document.getElementById("fileUpload");

const btn = document.getElementById("btnSubmit");

btn.addEventListener('click', () => {
    if (itemName.value === '' || itemDesc.value === '' || startBid.value === '') {
        showAlert("Please make sure all fields are filled in", "alertNewItem", null);
    } else if (!isNumeric(startBid.value)) {
        showAlert("Please make sure that starting price is a number", "alertNewItem", null);
    } else {
        __doPostBack("btnSubmit", "Click");
    }


})

function isNumeric(num) {
    return !isNaN(num)
}

function showAlert(message, id, className) {
    if (id === 'alertNewItem') {
        const div = document.createElement('div');
        div.className = 'alert alert-danger';
        div.id = id;
        div.appendChild(document.createTextNode(message));
        const container = document.querySelector('#container1');
        const fg = document.querySelector('#form-group1');
        container.insertBefore(div, fg);

        //Vanish in 5 seconds
        setTimeout(() => document.querySelector('#alertNewItem').remove(), 5000);
    }
}