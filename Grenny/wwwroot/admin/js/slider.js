$(document).ready(function () {
    $(document).on("click", ".status-slider", function () {    
        
        let sliderId = $(this).attr("data-id");

        let status = $(this)

        let image = $(".sliderImage")


        let data = { id: sliderId };

        $.ajax({
            url: "Slider/ChangeStatus",
            type: "Post",
            data: data,
            success: function (res) {
                if (res)
                {
                    $(status).removeClass("status-false")
                    $(status).addClass("status-true")
                    
                }
                else
                {
                    $(status).removeClass("status-true")
                    $(status).addClass("status-false") 
                }
            }
        })
    })
})