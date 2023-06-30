$(document).ready(function () {
    $(document).on("click", ".image a", function (event) {
      
        event.preventDefault(); 

        let productImageId = $(this).attr("data-id");
        let removedElem = $(this).parent();
        let data = { id: productImageId };

        $.ajax({
            url: "/admin/product/DeleteProductImage",
            type: "Post",
            data: data,
            success: function (res) {
                $(removedElem).remove();
            }
        })
    })

    $(document).on("click", ".image .change-ismain", function (event) {
        event.preventDefault(); 
        
        let productImageId = $(this).attr("data-id");
        let changedElem = $(this);
        var changeBtns = document.querySelectorAll(".image .change-ismain");
        let data = { id: productImageId };

        $.ajax({
            url: "/admin/product/ChangeImageIsMain",
            type: "Post",
            data: data,
            success: function (res) {
                for (var i = 0; i < changeBtns.length; i++) {
                    var btn = changeBtns[i];

                    if ($(changedElem).contains("main-image")) {
                        $(changedElem).remove("main-image");
                    }
                }
                $(changedElem).addClass("main-image");
            }
        })
    })
});
