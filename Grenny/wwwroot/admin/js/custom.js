DoWithoutRefresh(".product-delete", "/admin/Product/Delete",".parent");
DoWithoutRefresh(".brand-delete", "/admin/Brand/Delete",".parent");
DoWithoutRefresh(".category-delete", "/admin/Category/Delete", ".parent");
DoWithoutRefresh(".subcategory-delete", "/admin/SubCategory/Delete", ".parent");
DoWithoutRefresh(".discount-delete", "/admin/Discount/Delete", ".parent");
DoWithoutRefresh(".tag-delete", "/admin/Tag/Delete", ".parent");
DoWithoutRefresh(".rating-delete", "/admin/Rating/Delete", ".parent");

//DoWithoutRefresh(".restore-item", "Restore");

$('.reload-page').click(function () {
    location.reload();
});
$(".delete-from-card").click(function () {
    $('.reload-page').removeClass("d-none")
});

function DoWithoutRefresh(btn, url,closest) {
    $(document).on("click", btn, function (e) {
        e.preventDefault()
        let parent = $(this).closest(closest);
        let id = $(this).attr("data-id");
        let data = { id: id };

        $.ajax({
            url: url,
            type: "Post",
            data: data,
            success: function () {
                parent.addClass("d-none");


            }
        })
    })
}

//$(document).on("click", ".load-more", function () {

//    let parent = $(".parent-products-elem");

//    let skip = $(parent).children().length;

//    let datas = $(parent).attr("data-count");
//    console.log(parent);
//    console.log(datas);

//    $.ajax({
//        url: `course/loadmore?skip=${skip}`,
//        type: "Get",
//        success: function (res) {


//            $(parent).append(res);
//            console.log(res);

//            skip = $(parent).children().length;

//            if (skip >= datas) {
//                $(".load-more").addClass("d-none");

//            }
//        }

//    })
//});


//$(document).on("click", ".add-card", function (e) {
//    e.preventDefault()
//    let id = $(this).attr("data-id");
//    let data = { id: id };
//    console.log(id)
//    $.ajax({
//        url: "Course/AddBasket",
//        type: "Post",
//        data: data,
//        success: function () {
//            console.log("ok")

//        }
//    })
//})
