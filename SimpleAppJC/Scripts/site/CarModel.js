var carModel = {
    carCategories: ko.observableArray([]),
    filteredCars: ko.observableArray([]),
    selectedCategory: ko.observable(null),
    car: ko.observableArray([]),
    currentView: ko.observable('list')
}