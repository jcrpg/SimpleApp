var enquiryModel = {
    currentView: ko.observable('enquiry'),
    car: ko.observableArray([])
};


var initialData = [
    {
        firstName: "", lastName: "", email: ""
    }
];


var contactsModel = function (contacts) {
    var self = this;
    self.contacts = ko.observableArray(ko.utils.arrayMap(contacts, function (contact) {
        return {
            firstName: contact.firstName, lastName: contact.lastName,email: contact.email
        };
    }));

};

var viewModels = {
    contactsModel: contactsModel(initialData),
    enquiryModel: enquiryModel
}

ko.applyBindings(contactsModel(initialData), document.getElementById("contactsList")); 
