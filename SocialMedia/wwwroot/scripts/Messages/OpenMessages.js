var response = document.getElementsByClassName('formForResponse')[0];
var buttonElement = document.getElementById('buttonResponse').addEventListener('click', function (e) {

    e.currentTarget.remove();
    var elementTextArea = document.createElement('textarea');
    elementTextArea.setAttribute('id', 'Content');
    elementTextArea.setAttribute('name', 'Content');
    elementTextArea.style = "height: 100px; width: 600px ; resize: none";

    response.appendChild(elementTextArea);

    console.log(response.style= "padding-top:10px")

    var newButttonElement = document.createElement('button');
    newButttonElement.setAttribute('type', 'submit');
    newButttonElement.classList.add('btn-primary');
    newButttonElement.innerHTML = 'изпрати'

    response.appendChild(newButttonElement);


})