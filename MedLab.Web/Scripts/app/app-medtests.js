var app = app || {};

app.medTests = app.medTests || {};

(function (vm) {
    vm.init = function () {
        $('a#add-medtest-btn, a.edit-medtest-btn').click(displaySaveTestModal);
        $('a.delete-medtest-btn').click(deleteTest);
    };

    function displaySaveTestModal(e) {
        e.preventDefault();

        var dataset = e.currentTarget.dataset;
        var testId = 0;

        if (dataset && dataset.id) {
            testId = dataset.id;
        }

        $.get('/medTests/saveTest', { id: testId }).done(function (responseText) {
            var div = '<div class="med-test-modal-container">' + responseText + '</div>';

            $('.med-test-modal-container').remove();
            $('body').append(div);

            $('#med-test-save-modal').modal('show');
        })
    }

    function deleteTest(e) {
        e.preventDefault();

        var dataset = e.currentTarget.dataset;
        var testId = dataset.id;

        if (!testId) {
            console.error('Test Id needs to be available to delete');
            return;
        }

        $.post('/medTests/deleteTest', { id: testId })
            .done(function () {
                location.reload();
            });
    }

    vm.init();
})(app.medTests);