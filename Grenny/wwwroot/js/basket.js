$(document).ready(function () {

    //add method

    $(document).on("submit", "#basket-form", function (e) {
        e.preventDefault();

        let productId = $(this).attr("data-id");

        let data = { id: productId };

        $.ajax({
            url: "cart/AddBasket",
            type: "Post",
            data: data,
            success: function (res) {
                $("sup.rounded-circle").text(res)
            }
        })
    })

    //delete product
    $(document).on("submit", "#basket-delete-form", function (e) {
        e.preventDefault();

        let productId = $(this).attr("data-id");

        $(this).parent().parent().remove();

        let data = { id: productId };

        $.ajax({
            url: "cart/delete",
            type: "Post",
            data: data,
            success: function (res) {
                $("sup.rounded-circle").text(res.count);
                if (res.count > 0) {
                    $("#total-price").text("Total : " + res.total + " $");
                } else {
                    $("#total-price").addClass("d-none");
                }
            }
        })
    })
})