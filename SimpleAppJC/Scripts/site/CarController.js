//setting for POA, DAP and EGC
var setCategory = function (category) {

    carModel.selectedCategory(category);
    filterCarsByCategory();
}

var setView = function (view) {
    if (view == 'list') {
        enquiryModel.car.removeAll();
    }
    if (view == 'thankyou') {
        enquiryModel.car.removeAll();
    }
    carModel.currentView(view);
}


model.cars.subscribe(function (newProducts) {

    filterCarsByCategory();

    carModel.carCategories.removeAll();
    carModel.carCategories.push.apply(carModel.carCategories,
        model.cars().map(function (p) {
            return p.PriceType;
        })
            .filter(function (value, index, self) {
                return self.indexOf(value) === index;
            }).sort(function (a, b) {
                return a - b;
            }));
});


//By default it will return the full list
var filterCarsByCategory = function () {
    var category = carModel.selectedCategory();
    
    carModel.filteredCars.removeAll();
    carModel.filteredCars.push.apply(carModel.filteredCars,
        model.cars().filter(function (p) {
            return category == null || p.PriceType == category;
        }));
}

$(document).ready(function () {
    getCars();
});

var url = "/car/GetAllCars";
var getCars = function () {
    sendRequest(url, "GET", null, function (data) {
        model.cars.removeAll();
        model.cars.push.apply(model.cars, data);
    });
}

var addToEnquiry = function (item) {

    enquiryModel.car.removeAll();
    enquiryModel.car.push({ count: 1, car: item });


    setView("enquiry")
}