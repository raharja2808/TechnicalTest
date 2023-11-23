@ModelType Technical.TBL_EMPL

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Delete</title>
</head>
<body>
    <h3>Are you sure you want to delete this?</h3>
    <div>
        <h4>TBL_EMPL</h4>
        <hr />
        <dl class="dl-horizontal">
            <dt>
                @Html.DisplayNameFor(Function(model) model.EMPLOYEE_NAME)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.EMPLOYEE_NAME)
            </dd>
    
            <dt>
                @Html.DisplayNameFor(Function(model) model.AGE)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.AGE)
            </dd>
    
        </dl>
        @Using (Html.BeginForm())
            @Html.AntiForgeryToken()
    
            @<div class="form-actions no-color">
                <input type="submit" value="Delete" class="btn btn-default" /> |
                @Html.ActionLink("Back to List", "Index")
            </div>
        End Using
    </div>
</body>
</html>
