
var sendEnquiry = function (item) {
    var firstName = document.getElementById("firstname").value;
    var lastName = document.getElementById("lastname").value;
    var email = document.getElementById("email").value;

    if (isEmpty(firstName) || isEmpty(lastName) || isEmpty(email)) {
        //a simple pop up box
        alert('Please fill in all the required fields marked *');
        setView("enquiry");

    } else {
        $.ajax({
            url: '/car/SaveEnquiry',
            cache: false,
            type: 'GET',
            datatype: 'json',
            contentType: "application/json; charset=utf-8",
            data: {
                firstname: firstName,
                lastname: lastName,
                email: email,
                Make: item.car.Make,
                model: item.car.model,
                carid: item.car.carid
            },
            success: function (data) {

                if (data.Status) {
                    thankYouModel.car.removeAll();
                    thankYouModel.car.push({ count: 1, car: item.car });

                    setView("thankyou");

                } else {
                    alert('Error: Please contact IT support')
                }
            },
            error: function (xhr) {
                alert('Error: ' + xhr.statusText + ', please try again later');

            }
        });
        


    }


}