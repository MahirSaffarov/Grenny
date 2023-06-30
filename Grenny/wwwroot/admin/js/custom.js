DoWithoutRefresh(".product-delete", "/admin/Product/Delete",".parent");
DoWithoutRefresh(".brand-delete", "/admin/Brand/Delete",".parent");
DoWithoutRefresh(".category-delete", "/admin/Category/Delete", ".parent");
DoWithoutRefresh(".subcategory-delete", "/admin/SubCategory/Delete", ".parent");
DoWithoutRefresh(".discount-delete", "/admin/Discount/Delete", ".parent");
DoWithoutRefresh(".tag-delete", "/admin/Tag/Delete", ".parent");
DoWithoutRefresh(".rating-delete", "/admin/Rating/Delete", ".parent");
DoWithoutRefresh(".user-delete", "/admin/User/Delete", ".parent");
DoWithoutRefresh(".slider-delete", "/admin/Slider/Delete", ".parent");
DoWithoutRefresh(".sliderInfo-delete", "/admin/SliderInfo/Delete", ".parent");
DoWithoutRefresh(".setting-delete", "/admin/Setting/Delete", ".parent");
DoWithoutRefresh(".ads-delete", "/admin/Adversitment/Delete", ".parent");
DoWithoutRefresh(".blog-delete", "/admin/Blog/Delete", ".parent");
DoWithoutRefresh(".team-delete", "/admin/Team/Delete", ".parent");
DoWithoutRefresh(".social-delete", "/admin/Social/Delete", ".parent");
DoWithoutRefresh(".service-delete", "/admin/Service/Delete", ".parent");
DoWithoutRefresh(".contact-delete", "/admin/Contact/Delete", ".parent");
DoWithoutRefresh(".city-delete", "/admin/City/Delete", ".parent");

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

