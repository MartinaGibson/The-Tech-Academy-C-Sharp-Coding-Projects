var urlPath = window.location.pathname;

$(function () {
    ko.applyBindings(indexVM);
    indexVM.loadDoctors();
});
var indexVM = {
    Doctors: ko.observableArray([]),
    loadDoctors: function () {
        var self = this;
        //Ajax Call Get All Drs.
        $.ajax({
            type: "GET",
            url: urlPath + '/FillIndex',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                self.Doctors(data); //Put the response in ObservableArray
            },
            error: function (err) {
                alert(err.status + " : " + err.statusText);
            }
        });
    }
};

function Doctors(Doctors) {

    this.FirstName = ko.observable(Doctors.FirstName);
    this.LastName = ko.observable(Doctors.LastName);
    this.Speciality = ko.observable(Doctors.Speciality);
    this.PhoneNumber = ko.observable(Doctors.PhoneNumber);
}