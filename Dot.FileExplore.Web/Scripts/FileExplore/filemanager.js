$(document).ready(function () {
    $('#imgBack').hide();
    $.ajaxSetup({
        error: function (jqXHR, exception) {
            if (jqXHR.status === 401) {
                ShowError('HTTP Error 401 Unauthorized.');
            } else {
                ShowError('Uncaught Error.\n' + jqXHR.responseText);
            }
        }
    });
    Refresh();
    $("#FolderTree").find(".jstree-no-dots").attr('style', 'width: 300px;height: 573px; overflow-y: scroll;overflow-x: hidden');

    $('#FolderTree').bind('select_node.jstree', function (e, data) {
        RightPaneRefresh(data.node.id);
        //RightPaneRefresh();
    });
    var current = '', rootPath = '';
    $('#imgBack').off().on('click', function () {
        $('.error').hide();
        var index = 0, path = $('#divPath').html(), rootPath = $('#hdnPath').val();
        index = path.lastIndexOf('\\');
        path = path.substr(0, path.lastIndexOf('\\'));
        current = $('#divPath').text();
        rootPath = $('#hdnPath').val();
        

        if (rootPath.length <= path.length) {
            RightPaneRefresh(path);
        } else if (current == rootPath) {
            Refresh();
        }
        else {
            ShowError('Not able to view folder.');
            return false;
        }
    });
    current = $('#divPath').text();
    rootPath = $('#hdnPath').val();
    if (current != rootPath) {
        RightPaneRefresh(current);
    }
});

function Refresh() {
    $('.error').hide();
    $('#FolderTree').jstree({
        'core': {
            "check_callback": true,
            "plugins": ["core", "themes", "json_data", "grid", "types", "ui", "cookies"],
            "data": {
                "url": function (node) {
                    if (node.id === '#') {
                        return "/FileExplore/FolderInfo?id=" + $('#divPath').text();
                    } else {
                        return "/FileExplore/SubFolderInfo?id=" + node.id;
                    }
                },
                "data": function (node) {
                    return { 'id': node.id };
                }
            },
            "load_open": true
        }
    }).bind("select_node.jstree", function (event, data) {
        return data.instance.toggle_node(data.node);
    });
}

function RightPaneRefresh(id) {
    $('#imgBack').show();
    $('.error').hide();
    // gather ids of selected nodes
    $.post("/FileExplore/RightSide",
        {
            "path": id,
        },
        function (r) {
            $('#ViewFolder').empty();
            $('#RootPath').val('');
            $('#divPath').html(r.id);
            var tableChild = '<div class="inner">', children = r.children, file = '', type = '', id = '';
            if (children != null && children.length > 0) {
                $('#RootPath').val(r.id);
                tableChild += '<div  class="inner">';
                tableChild += '<table class="tbl"><tr class="thead"><td class="tname">Name</td><td></td><td class="tright">Modified Date</td><td class="tright">Size</td></tr>';
                for (i = 0; i < children.length; i++) {
                    file = r.children[i].text;
                    type = r.children[i].type
                    id = r.children[i].id;
                    size = bytesToSize(r.children[i].size);
                    date = r.children[i].date;
                    if (file != undefined) {
                        if (type == 'file') {
                            tableChild += '<tr class="' + type + '" data="' + id + '"><td><img src="/Content/images/'
                                + type + '.png" /></td><td class="ftext">' + file + '</td><td class="fdate"><span>' + date + '</span></td><td class="fsize"><span>' + size + '</span></td></tr>';
                        } else {
                            tableChild += '<tr class="' + type + '" data="' + id + '"><td><img src="/Content/images/'
                                + type + '.png" /></td><td class="ftext">' + file + '</td><td class="fdate"><span>' + date + '</span></td><td class="fsize"><span> </span></td></tr>';
                        }

                    }
                }
                tableChild += "</table></div>";
                $('#ViewFolder').append(tableChild);
                $('.file').off().on('click', function () {
                    var id = $(this).attr('data');
                    DownloadFile(id);
                });
                $('.folder').off().on('click', function () {
                    var id = $(this).attr('data');
                    RightPaneRefresh(id);
                });
            }
            else {
                ShowError('Not able to find any file / folder!!!');
            }
        });

}

function bytesToSize(bytes) {
    var sizes = ['Bytes', 'KB', 'MB', 'GB', 'TB'];
    if (bytes == 0) return 'n/a';
    var i = parseInt(Math.floor(Math.log(bytes) / Math.log(1024)));
    if (i == 0) return bytes + ' ' + sizes[i];
    return (bytes / Math.pow(1024, i)).toFixed(1) + ' ' + sizes[i];
};

function DownloadFile(id) {
    var param = { path: id };
    $.ajax({
        async: true,
        type: "POST",
        url: "/FileExplore/DownloadFile",
        dataType: "json",
        data: JSON.stringify(param),
        contentType: "application/json charset=utf-8",
        success: function (json) {
            json = JSON.parse(json);
            window.location = '/FileExplore/Download?name=' + json.path;
        }
    });
}

function validateUrl() {
    var txt = $('#txtHttpUrl').val();
    if (txt != null && txt != '') {
        if (txt.indexOf('http://') == -1) {
            ShowError('Invalid url.');
            return false;
        }
    }
    else {
        ShowError('Please enter url.');
        return false;
    }
    return true;
}

function ShowError(msg) {
    $('.error').show().html(msg);
    setTimeout(function () { $('.error').fadeOut("slow"); }, 3000);
}