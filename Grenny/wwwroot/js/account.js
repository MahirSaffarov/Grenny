$(document).ready(function () {
    $('#checkbox1').change(function () {
        if ($(this).is(':checked')) {
            $('#password1').attr('type', 'text');
        } else {
            $('#password1').attr('type', 'password');
        }
    });

    $('#checkbox2').change(function () {
        if ($(this).is(':checked')) {
            $('#password2').attr('type', 'text');
        } else {
            $('#password2').attr('type', 'password');
        }
    });
});
