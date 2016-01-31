/// <reference path="jquery-2.2.0.js" />
(function () {
    $("#EmployeesUpdatePanel").on("click", ".selectButton a", function () {
        $("#OrdersGridView").remove("#OrdersGridView");

    });
})();