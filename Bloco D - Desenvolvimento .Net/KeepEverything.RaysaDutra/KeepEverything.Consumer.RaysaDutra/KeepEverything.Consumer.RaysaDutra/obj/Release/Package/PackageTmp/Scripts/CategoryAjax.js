var ViewModel = function () {
    var self = this;
    self.tasks = ko.observableArray();
    self.tags = ko.observableArray();
    self.tagSeleted = {
        Category: ko.observable()
    }
    self.error = ko.observable();

    var baseUri = 'https://keepeverythingraysadutrawebapi.azurewebsites.net:443';
    var tasksByCategoryUri = baseUri + '/api/TasksByCategory/';
    var tagsUri = baseUri + '/api/Categories/';

    function ajaxHelper(uri, method, data) {
        self.error(''); // Clear error message
        return $.ajax({
            type: method,
            url: uri,
            dataType: 'json',
            contentType: 'application/json',
            data: data ? JSON.stringify(data) : null
        }).fail(function (jqXHR, textStatus, errorThrown) {
            self.error(errorThrown);
        });
    }
    function getAllCategories() {
        console.log("chamando");
        console.log(tagsUri);
        ajaxHelper(tagsUri, 'GET').done(function (data) {
            self.tags(data);
        });
    }

    getAllCategories();

    self.getTasksByCategory = function (formElement) {
        var id = self.tagSeleted.Category().IdCategory;
        ajaxHelper(tasksByCategoryUri + id, 'GET').done(function (data) {
            self.tasks(data);
        });
    }
};

ko.applyBindings(new ViewModel());
