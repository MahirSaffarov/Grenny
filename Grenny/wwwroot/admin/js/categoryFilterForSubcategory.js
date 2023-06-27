$(document).ready(function () {
    getSubCategoryByCategoryId();
})
$("#categoryId").change(function () {
    getSubCategoryByCategoryId();
})

var getSubCategoryByCategoryId = function () {
    $.ajax({
        url: "/admin/Product/GetSubCategoryByCategoryId",
        type: 'Get',
        data: {
            categoryId: $('#categoryId').val(),
        },
        success: function (data) {
            $('#subCatogId').find('option').remove()
            $(data).each(
                function (index, item) {
                    $('#subCatogId').append(`<option value="${item.id}">${item.name}</option>`)
                    console.log("dshbvk");
                }
            );
        }
    })
}