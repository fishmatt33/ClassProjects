$().ready(function() {
    // on button click, show modal
    $('#btnShowAddContact').click(function() {
        $('#addContactModal').modal('show');
    });

    $('#btnSaveContact').click(function() {
        var contact = {}; // new object

        //get the values from the inputs
        contact.Name = $('#name').val();
        contact.PhoneNumber = $('#phonenumber').val();

        // post it to the WebAPI, passing the JavaScript object
        $.post(uri, contact)
            .done(function () {
                $('#name').val(' ');
                $('#phonenumber').val(' ');

                loadContacts();
                $('#addContactModal').modal('hide');
            })
            .fail(function(jqXhr, status, err) {
                alert(status + ' - ' + err);
            });
    });
});