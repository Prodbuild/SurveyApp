
$(document).ready(function () {

    $("#navTabs").on("click", "a", function (e) {
        e.preventDefault();
        $(this).tab("show");
    });

    $("#navTabs").on("click", "li a .tabClose", function () {
        removeWorkItemTab($(this).parents("li").children("a").attr("href"));
        $("#navTabs a:first").tab("show");
    });

    $("#navTabs").on("show.bs.tab", "li a", function (el) {
        
        var panelId = $(this).attr('href');
        if (panelId == "#workQueue" || panelId == "#workList" || panelId == "#activeWorkItemsList") {

            if ($(panelId).find("div[id ^= 'workItemGrid']").length == 0) {
                if ($(panelId + ".loading").length == 0) {
                    $(panelId).append($("#_preload").html());
                }
                var request = LoadWorkItemContainer(workItemCollection, panelId.substring(1));

                request.success(function (data) {
                    $(panelId).append(data);

                    $(panelId).find("div[id ^= 'workItemGrid']").each(function () {
                        var gridId = $(this).attr('id');
                        var grid = $("#" + gridId).data("kendoGrid");
                        grid.dataSource.read();
                    });

                    $(panelId).find(".loading").remove();
                    bindHandlersToGrid("div[id^='workItemGrid']");
                });

                request.fail(function (jqXHR, textStatus) {
                    $(panelId).find(".loading").remove();
                });
            }
            else {
                var selector = (panelId == "#workQueue") ? "#ddlRepNameQueue" : "#ddlRepNameList";
                var userDropDown = $(selector).data("kendoDropDownList");

                if (userDropDown != null && userDropDown != undefined)
                { userDropDown.value(selectedUser); }

                $(panelId).find("div[id ^= 'workItemGrid']").each(function () {
                    var gridId = $(this).attr('id');
                    var grid = $("#" + gridId).data("kendoGrid");
                    grid.dataSource.data([]);
                    grid.dataSource.read();
                });
            }
        }
        else {
            $(panelId).find("div[id ^= 'workItemGrid']").each(function () {
                var gridId = $(this).attr('id');
                var grid = $("#" + gridId).data("kendoGrid");
                grid.dataSource.data([]);
                grid.dataSource.read();
            });
            bindHandlersToGrid("div[id^='workItemGrid']");
        }
    });

});


function LoadWorkItemContainer(workItemCollection, tab) {
    return jQuery.ajax({
        type: "POST"
        , url: "/EnrollmentWorkflow/Home/LoadWorkItemsGridContainer"
        , data: "{ 'workItemCategories':" + workItemCollection + ", 'tabName':" + JSON.stringify(tab) + "}"
        , contentType: "application/json"
        , cache: false
        , async: true
    });
}



// Binds the handlers to a Kendo UI grid to open a work item when it loads items of type "WorkItemModel".
function bindHandlersToGrid(selector) {
    $(selector).on("dblclick", "tbody tr", function (e) {
        var row = $(this);
        openWorkItem(row);
    });

    $(selector).on("click", "tbody tr", function (e) {
        var row = $(this);

        $(selector).find("tr.k-state-selected").each(function (index, el) {
            $(el).removeClass("k-state-selected");
        });

        $(row).addClass("k-state-selected");
    });
}

function openWorkItem(row) {
    var gridId = $(row).closest(".k-grid").attr("id");
    var grid = $("#" + gridId).data("kendoGrid");
    var rowData = grid.dataItem(row);

    var newTabPane = addTab("workItem-" + rowData.Id, "Site " + rowData.SiteId);
    newTabPane.append("<img src='/EnrollmentWorkflow/Content/loading.gif' style='margin: 30px' />");

    $("#navTabs").find("a[href=\"#" + newTabPane.attr("id") + "\"]").tab("show");

    jQuery.ajax({
        type: "GET",
        url: '/EnrollmentWorkflow/WorkItem/Index',
        context: document.body,
        cache: false,
        data: { workItemId: rowData.Id },
        success: function (data) {
            newTabPane.empty();
            newTabPane.append(data);
            $("#navTabs").find("a[href=\"#" + newTabPane.attr("id") + "\"]").tab("show");
        }
    });
}

function openWorkItemFromSearch() {
    var combobox = $('#txtSearch').data("kendoComboBox");
    var dataItem = combobox.dataItem(0);

    if (typeof dataItem !== "undefined") {
        var workItemId = $('#txtSearch').data('kendoComboBox').value();
        if (workItemId !== "") {
            var siteId = $('#txtSearch').data('kendoComboBox').text();
            var newTabPane = addTab("workItem-" + workItemId, "Site " + siteId);
            newTabPane.append("<img src='/EnrollmentWorkflow/Content/loading.gif' style='margin: 30px' />");

            $("#navTabs").find("a[href=\"#" + newTabPane.attr("id") + "\"]").tab("show");

            jQuery.ajax({
                type: "GET",
                url: '/EnrollmentWorkflow/WorkItem/Index',
                context: document.body,
                cache: false,
                data: { workItemId: workItemId },
                success: function (data) {
                    newTabPane.empty();
                    newTabPane.append(data);
                    $("#navTabs").find("a[href=\"#" + newTabPane.attr("id") + "\"]").tab("show");
                }
            });
        }

        $('#txtSearch').data('kendoComboBox').value("");
    }

}

function openReport(reportId, reportName, queryString) {
    var newTabPane = addTab("report-" + reportId.replace("/", ""), reportName);
    newTabPane.append("<img src='/EnrollmentWorkflow/Content/loading.gif' style='margin: 30px' />");

    $("#navTabs").find("a[href=\"#" + newTabPane.attr("id") + "\"]").tab("show");

    $.get("/EnrollmentWorkflow/Reports/" + reportId + "?" + queryString, function (data) {
        newTabPane.empty();
        newTabPane.append(data);
        bindHandlersToGrid("#" + newTabPane.attr("id") + " div[id^='workItemGrid']");
    })
    .fail(function (jqXHR, textStatus, errorThrown) {
        newTabPane.empty();
        newTabPane.append("<p class='error'>There was a problem loading this report.</p><p class='error'>" + errorThrown + "</p>");
    });
}

function addTab(id, text) {
    if ($("#navTabs").find("a[href='#" + id + "']").length > 0) {
        $(".tab-pane[id=\"" + id + "\"]").empty();
        return $(".tab-pane[id=\"" + id + "\"]");
    }

    $("#navTabs").append("<li><a href=\"#" + id + "\">" + text + " <span class=\"tabClose\" >×</span>" + "</a></li>");
    $("#navTabContent").append("<div class=\"tab-pane\" id=\"" + id + "\"></div>");

    return $(".tab-pane[id=\"" + id + "\"]");
}

function removeWorkItemTab(tabId) {
    $("#navTabs").find("a[href='" + tabId + "']").parents("li").remove();
    $(tabId).remove();
}

