$(document).ready(function () {

    $(document).on("click", "#delete", function (e) {
        e.preventDefault();
        let productId = $(this).attr("data-id");

        let removedElem = $(this).closest(".parent");

        let data = { id: productId };

        $.ajax({
            url: '/admin/Product/Delete',
            type: 'POST',
            data: data,
            success: function () {
                $(removedElem).remove();
            }
        });

    })
})