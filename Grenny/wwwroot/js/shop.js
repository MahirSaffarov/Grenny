$(document).ready(function () {
    $(document).on("click", ".show-more-btn", function () {
        let parent = $("#parent-elem")

        let skipCount = $(parent).children().length;

        let productsCount = $("#products").attr("data-count")

        $.ajax({
            url: `shop/ShowMoreOrLess?skip=${skipCount}`,
            type: "Get",
            success: function (res) {
                $(parent).append(res)
                let skipCount = $(parent).children().lenght;
                if (skipCount >= productsCount) {
                    $(".show-more-btn").addClass("d-none")
                    $(".show-less-btn").removeClass("d-none")
                }
            }
        })

    })

    $(document).on("click", ".show-less-btn", function () {
        let parent = $("#parent-elem")

        let skipCount = 0;

        $.ajax({
            url: `shop/ShowMoreOrLess?skip=${skipCount}`,
            type: "Get",
            success: function (res) {
                $(parent).empty()
                $(parent).append(res)
                $(".show-more-btn").removeClass("d-none")
                $(".show-less-btn").addClass("d-none")
            }
        })

    })
})