@ModelType Technical.TBL_EMPL

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Details</title>
</head>
<body>
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
    </div>
    <p>
        @Html.ActionLink("Edit", "Edit", New With { .id = Model.EMPLOYEE_ID }) |
        @Html.ActionLink("Back to List", "Index")
    </p>
</body>
</html>
