$(".create").on("click", function () {
    $.ajax({
        url: document.location.origin + "/Product/Create",
        type: "post",
        success: function (result) {
            $.ajax({
                url: document.location.origin + "/Product/List",
                success: function (resp) {
                    $(".data-container").html(resp);
                }
            });
        }
    });
});

$(".list").on("click", function () {
    $.ajax({
        url: document.location.origin + "/Product/List",
        success: function (resp) {
            $(".data-container").html(resp);
            $(".delete").on("click", function () {
                $.ajax({
                    url: document.location.origin + "/Product/Delete/" + $(this).attr("data-id"),
                    success: function (resp) {
                        $(".list").trigger("click")
                    }
                });
            });

            $(".edit").on("click", function () {
                $.ajax({
                    url: document.location.origin + "/Product/Update/" + $(this).attr("data-id"),
                    type: "post",
                    success: function (resp) {
                        $(".list").trigger("click")
                    }
                });
            })
        }
    });
});