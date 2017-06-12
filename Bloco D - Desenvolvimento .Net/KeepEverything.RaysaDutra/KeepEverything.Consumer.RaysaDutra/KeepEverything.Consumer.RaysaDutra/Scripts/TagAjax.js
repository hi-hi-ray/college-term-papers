var ViewModel = function () {
    var self = this;
    self.tasks = ko.observableArray();
    self.tags = ko.observableArray();
    self.tagSeleted = {
        Tag: ko.observable()
    }
    self.error = ko.observable();

    var baseUri = 'https://keepeverythingraysadutrawebapi.azurewebsites.net:443';
    var tasksByTagUri = baseUri + '/api/TasksByTag/';
    var tagsUri = baseUri + '/api/Tags/';

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
    function getAllTags() {
        console.log("chamando");
        console.log(tagsUri);
        ajaxHelper(tagsUri, 'GET').done(function (data) {
            self.tags(data);
        });
    }

    getAllTags();

    self.getTasksByTag = function (formElement) {
        var id = self.tagSeleted.Tag().IdTag;
        ajaxHelper(tasksByTagUri + id, 'GET').done(function (data) {
            self.tasks(data);
        });
    }
};

ko.applyBindings(new ViewModel());
