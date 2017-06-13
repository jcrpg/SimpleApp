
var sendEnquiry = function (item) {

    var firstName = item.firstName;
    var lastName = item.lastName;
    var email = item.email;
    alert(firstName + ' ' + lastName);
    if (isEmpty(firstName) || isEmpty(lastName) || isEmpty(email)){
        //a simple pop up box
        alert('Please fill in all the required fields marked *');
        setView("enquiry");

    } else {
        setView("thankyou");

    }


}