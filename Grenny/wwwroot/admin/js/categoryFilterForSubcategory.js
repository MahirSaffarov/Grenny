$(document).ready(function () {
    // Kategori verilerini almak için AJAX isteği
    $.ajax({
        url: 'get_categories.php',
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            populateCategories(data);
        },
        error: function () {
            alert('Kategori verileri alınamadı.');
        }
    });

    // Alt kategori verilerini almak için AJAX isteği
    $(document).on('change', '#categories', function () {
        var selectedCategory = $(this).val();
        $.ajax({
            url: 'get_subcategories.php',
            type: 'GET',
            dataType: 'json',
            data: {
                category: selectedCategory
            },
            success: function (data) {
                populateSubcategories(data);
            },
            error: function () {
                alert('Alt kategori verileri alınamadı.');
            }
        });
    });

    // Kategorileri dropdown listesine ekleyen fonksiyon
    function populateCategories(data) {
        var dropdown = $('#categories');
        dropdown.empty();
        $.each(data, function (index, category) {
            dropdown.append($('<option></option>').attr('value', category.id).text(category.name));
        });
    }

    // Alt kategorileri dropdown listesine ekleyen fonksiyon
    function populateSubcategories(data) {
        var checkboxes = $('#subcategories');
        checkboxes.empty();
        $.each(data, function (index, subcategory) {
            checkboxes.append($('<label></label>').append($('<input>').attr('type', 'checkbox').attr('name', 'subcategories[]').val(subcategory.id)).append(subcategory.name));
        });
    }
});