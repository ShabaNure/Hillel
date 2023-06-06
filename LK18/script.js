function validateForm() {
    let name = document.forms["myForm"]["name"].value;
    let email = document.forms["myForm"]["email"].value;
    let number = document.forms["myForm"]["number"].value;
    let message = document.forms["myForm"]["message"].value;
    alert("Name: " + name + "\nEmail: " + email + "\nPhone number: " + number + "\nMessage: " + message);
}