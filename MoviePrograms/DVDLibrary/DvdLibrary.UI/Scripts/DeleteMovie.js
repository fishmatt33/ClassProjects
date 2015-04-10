$(function () {
   //$('[data-toggle="confirmation"]').click(function() {
   //     var MovieDelete = window.confirm("Are you sure you want to delete this movie?");
    // });
    $(".DeleteForm").submit(function() {
        return window.confirm("Are you sure you want to delete this movie?");
    });
});