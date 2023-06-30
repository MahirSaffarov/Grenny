$("#categoryId").change(function () {
    getSubCategoryByCategoryId();
})

var getSubCategoryByCategoryId = function () {
    $.ajax({
        url: "/Admin/Product/GetSubCategoryByCategoryId",
        type: 'Get',
        data: {
            categoryId: $('#categoryId').val(),
        },
        success: function (data) {
            console.log(data);
            console.log("Salam");
            $('#subCatogId').find('option').remove()
            $(data).each(
                function (index, item) {
                    $('#subCatogId').append(`<option value="${item.id}">${item.name}</option>`)
                }
            );
        }
    })
}