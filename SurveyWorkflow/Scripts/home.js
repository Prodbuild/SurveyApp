jQuery(window).on("resize", function () {
    kendo.resize($(".chart-wrapper"));
    kendo.resize($(".k-dropdown-wrap"));

});
function currentDataQueue() {
    var userDropDown = $("#ddlRepNameQueue").data("kendoDropDownList");

    return {
        selectedUser: (userDropDown.value() != undefined) ? userDropDown.value() : 'none',
    };
}

function currentDataList() {
    var userDropDown = $("#ddlRepNameList").data("kendoDropDownList");

    return {
        selectedUser: (userDropDown.value() != undefined) ? userDropDown.value() : 'none',
        prioritized: true
    };
}

function areaClicked(e) {
    openReport('Chart/' + e.category.replace(/\s/g, ""), 'Chart - ' + e.category, "category=" + encodeURIComponent(e.category));
}

function gotoRepList(repName) {
    selectedUser = repName.toLowerCase();

    var tabVal = "workQueue";
    $('.nav-tabs a[href="#' + tabVal + '"]').tab('show');
}

function viewListFor() {
    $('#workQueue .k-grid').each(function (index, el) {
        var grid = $(el).data("kendoGrid");
        grid.dataSource.data([]);
        grid.dataSource.read();

    });
}

function viewListForList() {
    $('#workList .k-grid').each(function (index, el) {
        var grid = $(el).data("kendoGrid");
        grid.dataSource.data([]);
        grid.dataSource.read();
    });
}

function confirmAssignment(e) {
    var callingElement = $(this.element);
    var gridId = callingElement.closest('.k-grid').attr('id');
    var dropDownId = callingElement.attr("id");
    var dropdown = $('#' + dropDownId).data("kendoDropDownList");
    var grid = $('#' + gridId).data("kendoGrid");
    var row = callingElement.closest("tr");
    var rowData = grid.dataItem(row);

    if (dropdown.value() !== rowData.enrollmentRep && dropdown.text() !== "Reassign Work Item") {

        var modal = $('#confirm-assignment');
        modal.find('.siteId').text(rowData.SiteId);
        modal.find('.repName').text(dropdown.value());

        if (dropDownId == "EnrollmentRep") {
            modal.find('.repType').text("enrollment rep");
        }
        else if (dropDownId == "TestingRep") {
            modal.find('.repType').text("testing rep");
        }
        else {
            modal.find('.repType').text("rep");
        }

        modal.find('.modal-body input[name="repName"]').val(dropdown.value());
        modal.find('.modal-body input[name="workItemId"]').val(rowData.Id);
        modal.find('.modal-body input[name="gridId"]').val('#' + gridId);
        modal.find('.modal-body input[name="repType"]').val(dropDownId);




        modal.modal('show');
    }
}

function reassignWorkItem(workItemId, repName, gridId, repType) {
    var grid = $(gridId).data("kendoGrid");

    if (repType == "EnrollmentRep") {
        jQuery.ajax({
            type: "POST",
            url: '/EnrollmentWorkflow/WorkItem/AssignWorkItemToEnrollmentRep',
            context: document.body,
            data: { workItemId: workItemId, enrollmentRep: repName },
            success: function (result) {
                if (result !== undefined && result.success) {
                    grid.dataSource.read();
                }
            }
        });
    } else if (repType == "TestingRep") {
        jQuery.ajax({
            type: "POST",
            url: '/EnrollmentWorkflow/WorkItem/AssignWorkItemToTestingRep',
            context: document.body,
            data: { workItemId: workItemId, testingRep: repName },
            success: function (result) {
                if (result !== undefined && result.success) {
                    grid.dataSource.read();
                }
            }
        });
    }
}

$(document).on('click', 'button[name="saveAssignment"]', function (e) {

    var button = $(this);
    var gridId = button.closest('.modal-content').find('input[name="gridId"]').val();
    var workItemId = button.closest('.modal-content').find('input[name="workItemId"]').val();
    var repName = button.closest('.modal-content').find('input[name="repName"]').val();
    var repType = button.closest('.modal-content').find('input[name="repType"]').val();

    reassignWorkItem(workItemId, repName, gridId, repType);

});

$(document).on('click', 'button[name="discardAssignment"]', function (e) {
    var gridId = $(this).closest('.modal-content').find('input[name="gridId"]').val();
    var grid = $(gridId).data("kendoGrid");
    grid.dataSource.read();
});

$(document).on('change', "form[id^='workItemForm'] :input", function () {
    $(this).closest(".tab-pane").find("button[id^='btnSaveWorkItem']").removeClass('disabled');
    $(this).closest('.edit-container').addClass('panel-warning').removeClass('panel-primary');
});

$(document).on('click', '.panel-heading', function () {
    if (jQuery(this).find("div[name='indicator']").text() == "►")
        jQuery(this).find("div[name='indicator']").text("▼");
    else
        jQuery(this).find("div[name='indicator']").text("►");
});

$(document).on('click', '.editBtn', function (e) {
    var el = $(this);
    var heading = $(el).closest('.panel-heading');

    var inputs = $(el).closest('.panel').find('.form-control.editable').not('.note');
    var noteButtons = $(el).closest('.panel').find('button.noteBtn');
    var noteCancelButtons = $(el).closest('.panel').find('button.noteCancel');
    var datepickers = $(el).closest('.panel').find('.k-datepicker');
    var dropdowns = $(el).closest('.panel').find('.k-dropdown');

    if (datepickers.length > 0) {
        datepickers.each(function (index, el) {
            var id = $(el).find('input').attr('id');
            $('#' + id).data('kendoDatePicker').enable();
        });
    }

    if (dropdowns.length > 0) {
        dropdowns.each(function (index, el) {
            var id = $(el).find('input').attr('id');
            $('#' + id).data('kendoDropDownList').enable();
        });
    }

    noteButtons.each(function () {
        $(this).removeAttr('disabled');
    });

    noteCancelButtons.each(function () {
        $(this).removeAttr('disabled');
    });

    inputs.each(function (index, ele) {
        var currentInput = $(ele);
        currentInput.removeAttr('readonly');
        currentInput.closest('.row').find('input[name="currentValue"]').val(currentInput.val());
    });

    el.prop('disabled', 'disabled');
    heading.find('.saveBtn').removeProp('disabled');
    heading.find('.cancelBtn').removeProp('disabled');

    e.stopPropagation();
});

$(document).on('click', '.cancelBtn', function (e) {
    var el = $(this);
    var heading = $(el).closest('.panel-heading');
    el.prop('disabled', 'disabled');
    heading.find('.saveBtn').prop('disabled', 'disabled');
    heading.find('.editBtn').removeProp('disabled');

    var inputs = $(el).closest('.panel').find('.form-control.editable').not('.note');
    var noteButtons = $(el).closest('.panel').find('button.noteBtn');
    var noteCancelButtons = $(el).closest('.panel').find('button.noteCancel');
    var datepickers = $(el).closest('.panel').find('.k-datepicker');
    var dropdowns = $(el).closest('.panel').find('.k-dropdown');

    if (datepickers.length > 0) {
        datepickers.each(function (index, el) {
            var id = $(el).find('input').attr('id');
            $('#' + id).data('kendoDatePicker').enable(false);
        });
    }

    if (dropdowns.length > 0) {
        dropdowns.each(function (index, el) {
            var id = $(el).find('input').attr('id');
            $('#' + id).data('kendoDropDownList').enable(false);
        });
    }

    noteButtons.each(function () {
        $(this).attr('disabled', 'disabled');
    });

    noteCancelButtons.each(function () {
        $(this).attr('disabled', 'disabled');
    });

    inputs.each(function (index, ele) {
        var currentInput = $(ele);
        currentInput.attr('readonly', 'readonly');
        var currentValue = $(ele).closest('.row').find('input[name="currentValue"]').val();
        currentInput.val(currentValue);
        currentInput.attr('readonly', 'readonly');
    });

    $(el).closest('.edit-container').removeClass('panel-warning');
    $(el).closest('.edit-container').addClass('panel-primary');

    e.stopPropagation();
});

function saveGeneralInformation(ele) {
    var form = $(ele).closest('.panel').find('form');

    jQuery.ajax({
        type: "POST",
        url: '/EnrollmentWorkflow/WorkItem/UpdateGeneralInformation',
        context: document.body,
        data: form.serialize(),
        success: function (result) {
        }
    });

}

function saveDateInformation(ele) {
    var form = $(ele).closest('.panel').find('form');

    jQuery.ajax({
        type: "POST",
        url: '/EnrollmentWorkflow/WorkItem/UpdateDateInformation',
        context: document.body,
        data: form.serialize(),
        success: function (result) {
            var panelBody = $(ele).find('.panel-body');

            panelBody.html(result);

        }
    });

}

function saveAdditionalInformation(ele) {
    var form = $(ele).closest('.panel').find('form');

    jQuery.ajax({
        type: "POST",
        url: '/EnrollmentWorkflow/WorkItem/UpdateAdditionalInformation',
        context: document.body,
        data: form.serialize(),
        success: function (result) {
        }
    });
}

function savePracticeInformation(ele) {
    var form = $(ele).closest('form');

    jQuery.ajax({
        type: "POST",
        url: '/EnrollmentWorkflow/WorkItem/UpdatePracticeInformation',
        context: document.body,
        data: form.serialize(),
        success: function (result) {
        }
    });

}

$(document).on('click', '.saveBtn', function (e) {
    var el = $(this);
    var heading = $(el).closest('.panel-heading');


    el.prop('disabled', 'disabled');
    heading.find('.cancelBtn').prop('disabled', 'disabled');
    heading.find('.editBtn').removeProp('disabled');

    var inputs = $(el).closest('.panel').find('.form-control.editable').not('.note');
    var noteButtons = $(el).closest('.panel').find('button.noteBtn');
    var noteCancelButtons = $(el).closest('.panel').find('button.noteCancel');
    var datepickers = $(el).closest('.panel').find('.k-datepicker');
    var dropdowns = $(el).closest('.panel').find('.k-dropdown');

    if (datepickers.length > 0) {
        datepickers.each(function (index, el) {
            var id = $(el).find('input').attr('id');
            $('#' + id).data('kendoDatePicker').enable(false);
        });
    }

    if (dropdowns.length > 0) {
        dropdowns.each(function (index, el) {
            var id = $(el).find('input').attr('id');
            $('#' + id).data('kendoDropDownList').enable(false);
        });
    }

    noteButtons.each(function () {
        $(this).attr('disabled', 'disabled');
    });

    noteCancelButtons.each(function () {
        $(this).attr('disabled', 'disabled');
    });

    inputs.each(function (index, ele) {
        var currentInput = $(ele);
        currentInput.attr('readonly', 'readonly');
        currentInput.attr('readonly', 'readonly');
    });
    e.stopPropagation();
});

$(document).on('click', '.noteBtn', function () {
    var el = $(this);
    var row = $(el).closest('.row');
    var notes = row.find('div[name="notes"]');
    notes.show();
});

$(document).on('click', '.noteCancel', function () {
    var el = $(this);
    var row = $(el).closest('.row');
    var notes = row.find('div[name="notes"]');
    notes.hide();
    notes.find('input').val('');

});

$(document).on("click", "#workItemGridActiveList .chkActive", function () {
    var isActive = $(this).is(':checked');
    var grid = $('#workItemGridActiveList').data().kendoGrid;
    var dataItem = grid.dataItem($(this).closest('tr'));

    return jQuery.ajax({
        type: "POST"
        , url: "/EnrollmentWorkflow/WorkItem/UpdateWorkItem"
        , data: "{ 'workItemid':" + dataItem.Id + ", 'isActive':" + isActive + "}"
        , contentType: "application/json"
        , cache: false
        , async: true
        , success: function (response) {

            if (response.success) {
                // refreshing the work items grid
                var workItemGridElement = $("#activeWorkItemsList").find("div[id ^= 'workItemGrid']");
                var workItemgrid = workItemGridElement.data("kendoGrid");
                workItemgrid.dataSource.read();

                // refreshing the site combo box
                var siteComboBox = $("#txtSearch").data("kendoComboBox");
                siteComboBox.dataSource.read();

                // refreshing dashborad data
                refreshDashboardData();
            }
        }
    });
});

$(document).on('click', '#createActionItem', function (e) {

    if (validateForm()) {

        if ($("#showLoading.loading").length == 0) {
            $("#showLoading").append($("#_preload").html());
        }

        var form = $("#createNewWorkItem");
        $.ajax({
            type: "POST",
            url: '/EnrollmentWorkflow/WorkItem/CreateNewWorkItem',
            dataType: 'json',
            data: form.serialize(),
            success: function (response) {

                var messageSummary = '';
                if (response.messageList != null) {
                    $.each(response.messageList, function (i, message) {
                        messageSummary += '<li>' + message + '</li>';
                    });
                    $("#newWorkItemValidationSummary").html("<ul style='list-style-type: none' >" + messageSummary + "</ul>");
                    $("#newWorkItemValidationSummary").addClass(response.isSuccess ? "successMessageDisplay" : "errorFieldSummary");

                    if (response.isSuccess) {

                        $("#createNewWorkItem :text").each(function () {
                            $(this).val('');
                        });

                        // refreshing the  workitems grid
                        var workItemGridElement = $("#activeWorkItemsList").find("div[id ^= 'workItemGrid']");
                        var workItemgrid = workItemGridElement.data("kendoGrid");
                        workItemgrid.dataSource.read();

                        // refreshing the site combo box
                        var siteComboBox = $("#txtSearch").data("kendoComboBox");
                        siteComboBox.dataSource.read();

                        // refreshing dashborad data
                        refreshDashboardData();
                    }
                }
                $("#showLoading").find(".loading").remove();
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(jqXHR);
                console.log(textStatus);
                console.log(errorThrown);
                $("#showLoading").find(".loading").remove();
            }
        });
    }
});

function validateForm() {

    // clearing the contents of validation summary
    $("#newWorkItemValidationSummary").empty();
    $("#newWorkItemValidationSummary").addClass("nodisplay");

    var errorSummary = '';
    var isValid = true;

    $('input[data-val-required]').each(function () {

        // explicit checking for kenodo combo box
        if ($(this).attr("id").indexOf("Vendor") != -1) {
            var spanElement = $(this).parents("span[class*='k-combobox']");
            if (spanElement != null && spanElement.length != 0) {
                if ($.trim($(this).val()) == '') {
                    spanElement.addClass("errorField");
                    errorSummary += "<li>" + $(this).attr("data-val-required") + "</li>";
                    isValid = false;
                }
                else {
                    spanElement.removeClass("errorField");
                }
            }
            return;
        }

        if ($.trim($(this).val()) == '') {
            isValid = false;
            $(this).addClass("errorField");
            errorSummary += "<li>" + $(this).attr("data-val-required") + "</li>";
        }
        else {
            $(this).removeClass("errorField");
        }
    });

    if (!isValid) {
        $("#newWorkItemValidationSummary").html("<ul>" + errorSummary + "</ul>");
        $("#newWorkItemValidationSummary").attr('class', '');
        $("#newWorkItemValidationSummary").addClass("errorFieldSummary");
    }

    return isValid;
}

function refreshDashboardData() {

    var panelId = "#dashboard";

    $(panelId).empty();
    if ($(panelId + ".loading").length == 0) {
        $(panelId).append($("#_preload").html());
    }

    var request = LoadWorkItemContainer(workItemCollection, panelId.substring(1));

    request.success(function (data) {
        $(panelId).append(data);
        $(panelId).find(".loading").remove();
    });

    request.fail(function (jqXHR, textStatus, errorThrown) {
        console.log(jqXHR);
        console.log(textStatus);
        console.log(errorThrown);
        $(panelId).find(".loading").remove();
    });
}


function isActiveWorkItemsSelected() {
    var isActive = $("input:radio[name='workitemstatus']:checked").val();
    return { showActiveItems: (isActive == "active" ? true : false) };
}

function toggleActiveItem() {
    if ($("#workItemGridActiveList").length != 0) {
        var grid = $("#workItemGridActiveList").data("kendoGrid");
        grid.dataSource.page(1);
        grid.refresh();
    }
}